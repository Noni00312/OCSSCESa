using MathNet.Numerics.Distributions;
using MySql.Data.MySqlClient;
using NPOI.HSSF.UserModel;
using NPOI.SS.UserModel;
using NPOI.XSSF.UserModel;
using OCSSCESa.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCSSCESa
{
    public partial class FrmImportExcel : Form
    {
        private DataTable _excelDataTable = new DataTable();
        private CRUD _crud = new CRUD();

        public FrmImportExcel()
        {
            InitializeComponent();
        }

        private void LoadExcelFile(string filePath, bool hasHeaders)
        {
            try
            {
                DataTable dt = new DataTable();

                using (FileStream stream = new FileStream(filePath, FileMode.Open, FileAccess.Read))
                {
                    IWorkbook workbook;

                    if (Path.GetExtension(filePath).ToLower() == ".xlsx")
                    {
                        workbook = new XSSFWorkbook(stream);
                    }
                    else
                    {
                        workbook = new HSSFWorkbook(stream);
                    }

                    ISheet sheet = workbook.GetSheetAt(0);
                    if (sheet == null)
                    {
                        throw new Exception("The Excel file does not contain any sheets.");
                    }

                    IRow firstRow = sheet.GetRow(0);

                    if (firstRow == null)
                    {
                        throw new Exception("The first sheet is empty.");
                    }

                    if (hasHeaders)
                    {

                        foreach (ICell cell in firstRow)
                        {
                            string columnName = cell?.ToString() ?? $"Column{dt.Columns.Count + 1}";
                            dt.Columns.Add(columnName);
                        }
                    }
                    else
                    {

                        for (int col = 0; col < firstRow.LastCellNum; col++)
                        {
                            dt.Columns.Add($"Column{col + 1}");
                        }


                        DataRow dr = dt.NewRow();

                        for (int col = 0; col < firstRow.LastCellNum; col++)
                        {
                            ICell cell = firstRow.GetCell(col);
                            dr[col] = cell?.ToString() ?? string.Empty;
                        }
                        dt.Rows.Add(dr);
                    }


                    int startRowIndex = hasHeaders ? 1 : 1;

                    for (int row = startRowIndex; row <= sheet.LastRowNum; row++)
                    {
                        IRow currentRow = sheet.GetRow(row);
                        if (currentRow != null)
                        {
                            DataRow dr = dt.NewRow();
                            for (int col = 0; col < currentRow.LastCellNum; col++)
                            {
                                ICell cell = currentRow.GetCell(col);
                                dr[col] = cell?.ToString() ?? string.Empty;
                            }
                            dt.Rows.Add(dr);
                        }
                    }
                }

                _excelDataTable = dt;

               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private async void browseButton_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
                openFileDialog.Title = "Select an Excel File";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string filePath = openFileDialog.FileName;

                    DialogResult headerDialogResult = MessageBox.Show(
                        "Does the Excel file have headers?",
                        "Headers",
                        MessageBoxButtons.YesNo,
                        MessageBoxIcon.Question
                    );

                    bool hasHeaders = (headerDialogResult == DialogResult.Yes);

                    loadingIndicator.Visible = true;
                    browseButton.Enabled = false;
                    excelDataGrid.Visible = false;

                    try
                    {
                        await Task.Run(() =>
                        {
                            LoadExcelFile(filePath, hasHeaders);

                            this.Invoke((MethodInvoker)delegate
                            {
                                excelDataGrid.SuspendLayout();
                                excelDataGrid.DataSource = _excelDataTable;
                                Styling.DataGridViewStyle(excelDataGrid);
                            });

                        }).ConfigureAwait(false);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        this.Invoke((MethodInvoker)delegate
                        {
                            excelDataGrid.ResumeLayout();
                            loadingIndicator.Visible = false;
                            browseButton.Enabled = true;
                            excelDataGrid.Visible = true;
                        });
                    }
                }
            }
        }

        private bool CheckStudentId()
        {
            //for (int row = 0; row <= excelDataGrid.Rows.Count - 1; row++)
            //{
            //    string currenntId = excelDataGrid.Rows[row].Cells[0].Value.ToString();

            //    try
            //    {
            //        excelDataGrid.Rows.Contains(currenntId);
            //    }
            //    catch (Exception ex)
            //    {
            //        Console.WriteLine($"Check Row Duplication Error: {ex.Message}");
            //    }
            //}

            for (int i = 0; i <= excelDataGrid.Rows.Count - 1; i++)
            {
                string currentId = excelDataGrid.Rows[i].Cells[0].Value.ToString();

                try
                {
                    string searchQuery = "SELECT studentId FROM studentInfoTbl WHERE studentId = @studentId " +
                                         "UNION " +
                                         "SELECT studentId FROM archiveTbl WHERE studentId = @studentId;";


                    _crud.AddParameters("@studentId", currentId);


                    DataTable searchResult = _crud.ReadData(searchQuery, true);

                    if (searchResult != null)
                    {
                        return false;
                    }
                    else
                    {
                        continue;
                    }
                    
                }
                catch (Exception searchException)
                {
                    Console.WriteLine($"Search Data Error: {searchException.Message}");
                    return false;
                }
            }

            return true;
        }

        private bool ImportDataToDatabase()
        {
            if (excelDataGrid.Columns.Count != 13)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Column count doesn't match the required count.",
                              "COLUMN COUNT MISMATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (excelDataGrid.Rows.Count == 0)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("No data found in this file.", "NO DATA FOUND",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }


            using (MySqlConnection connection = DatabaseHelper.DatabaseConnection())
            {
                if (connection == null)
                {
                    MessageBox.Show("Database connection failed.", "ERROR",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }

                try
                {
                    using (MySqlTransaction transaction = connection.BeginTransaction())
                    {
                        try
                        {
                            string insertQuery = @"INSERT INTO tempTbl(studentId, fName, mName, lName, suffix, birthdate, age, gender, civilStatus, address, contactNumber, yearLevel, course) VALUES (@studentId, @fName, @mName, @lName, @suffix, @birthdate, @age, @gender, @civilStatus, @address, @contactNumber, @yearLevel, @course)";

                            for (int rowNumber = 0; rowNumber < excelDataGrid.Rows.Count; rowNumber++)
                            {
                                if (excelDataGrid.Rows[rowNumber].IsNewRow) continue;

                                using (MySqlCommand command = new MySqlCommand(insertQuery, connection, transaction))
                                {
                                    command.Parameters.AddWithValue("@studentId", excelDataGrid.Rows[rowNumber].Cells[0]?.Value?.ToString() ?? "");
                                    command.Parameters.AddWithValue("@fName", excelDataGrid.Rows[rowNumber].Cells[1]?.Value?.ToString() ?? "");
                                    command.Parameters.AddWithValue("@mName", excelDataGrid.Rows[rowNumber].Cells[2]?.Value?.ToString() ?? "");
                                    command.Parameters.AddWithValue("@lName", excelDataGrid.Rows[rowNumber].Cells[3]?.Value?.ToString() ?? "");
                                    command.Parameters.AddWithValue("@suffix", excelDataGrid.Rows[rowNumber].Cells[4]?.Value?.ToString() ?? "");
                                    command.Parameters.AddWithValue("@birthdate", excelDataGrid.Rows[rowNumber].Cells[5]?.Value ?? "");
                                    command.Parameters.AddWithValue("@age", excelDataGrid.Rows[rowNumber].Cells[6]?.Value?.ToString() ?? "");
                                    command.Parameters.AddWithValue("@gender", excelDataGrid.Rows[rowNumber].Cells[7]?.Value?.ToString() ?? "");
                                    command.Parameters.AddWithValue("@civilStatus", excelDataGrid.Rows[rowNumber].Cells[8]?.Value?.ToString() ?? "");
                                    command.Parameters.AddWithValue("@address", excelDataGrid.Rows[rowNumber].Cells[9]?.Value?.ToString() ?? "");
                                    command.Parameters.AddWithValue("@contactNumber", excelDataGrid.Rows[rowNumber].Cells[10]?.Value?.ToString() ?? "");
                                    command.Parameters.AddWithValue("@yearLevel", excelDataGrid.Rows[rowNumber].Cells[11]?.Value?.ToString() ?? "");
                                    command.Parameters.AddWithValue("@course", excelDataGrid.Rows[rowNumber].Cells[12]?.Value?.ToString() ?? "");


                                    command.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                            return true;
                        }
                        catch (Exception ex)
                        {
                            transaction.Rollback();
                            MessageBox.Show($"Error importing row: {ex.ToString()}", "IMPORT ERROR",
                                          MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return false;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Database error: {ex.Message}", "DATABASE ERROR",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
        }

        private void importButton_Click(object sender, EventArgs e)
        {
            if (!CheckStudentId())
            {
                MessageBox.Show("Duplicate student ID detected. Please check your data.", "DUPLICATE STUDENT ID", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!ImportDataToDatabase())
            {
                MessageBox.Show("Data failed to save to the database. Please try again or check your files before saving.", "IMPORT FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_crud.CallStoredProcedure("SP_INSERT_TEMP", false))
            {
                MessageBox.Show("Data successfully added into the database", "IMPORT SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);


                _crud.AddParameters("p_table_name", "tempTbl");
                _crud.CallStoredProcedure("SP_TRUNCATE_TABLE", true);
            }


        }

        private void FrmImportExcel_Load(object sender, EventArgs e)
        {

        }
    }
}

