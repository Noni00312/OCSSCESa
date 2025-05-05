using Microsoft.Reporting.WinForms;
using OCSSCESa.Helper;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;

namespace OCSSCESa
{
    public partial class FrmGenerateCode : Form
    {
        CRUD crud = new CRUD();
        private DataTable _votersData;

        public FrmGenerateCode()
        {
            InitializeComponent();
            this.Load += FrmGenerateCode_Load;
        }

        private  void FrmGenerateCode_Load(object sender, EventArgs e)
        {
            PopulateCourses();
        }

        public void PopulateCourses()
        {
            CRUD crud = new CRUD();

            course.Items.Clear();
            try
            {
                string query = "SELECT * FROM coursesTbl;";

                DataTable result = crud.ReadData(query, true);

                if (result.Rows.Count > 0)
                {
                    foreach (DataRow row in result.Rows)
                    {
                        course.Items.Add(row["courseName"]);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error reading courses: ", ex.Message);
            }

        }


        public async Task RefreshDataSource()
        {
            reportViewer1.Visible = false;
            loadingIndicator.Visible = true;

            await Task.Run(() => GenerateCode());

            this.Invoke((MethodInvoker)delegate
            {
                loadingIndicator.Visible = false;
                reportViewer1.Visible = true;
            });
        }

        private async void GenerateCode()
        {
            CRUD crud = new CRUD();

            crud.AddParameters("p_table_name", "codeTbl");
            crud.CallStoredProcedure("SP_TRUNCATE_TABLE", true);

            string selectQuery = "SELECT studentId, CONCAT_WS(' ', fName, mName, lName, suffix) AS fullName, yearLevel, course FROM studentInfoTbl ";

            bool hasCondition = false;



            this.Invoke((MethodInvoker)delegate
            {
                if (yearLevel.SelectedIndex != -1)
                {
                    selectQuery += "WHERE yearLevel = @yearLevel ";
                    crud.AddParameters("@yearLevel", yearLevel.SelectedItem.ToString());
                    hasCondition = true;
                }

                if (course.SelectedIndex != -1)
                {
                    if (hasCondition)
                    {
                        selectQuery += "AND course = @course ";
                    }
                    else
                    {
                        selectQuery += "WHERE course = @course ";
                    }
                    crud.AddParameters("@course", course.SelectedItem.ToString());
                }
            });
            DataTable students = crud.ReadData(selectQuery, true);

            if (students == null || students.Rows.Count == 0)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("No data found in the database.", "NO DATA FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string checkQuery = "SELECT uniqueCode FROM codeTbl";

            DataTable existingCodesTable = crud.ReadData(checkQuery, false);

            if (existingCodesTable == null)
            {
                existingCodesTable = new DataTable();
                existingCodesTable.Columns.Add("uniqueCode");
            }

            HashSet<string> existingCodes = new HashSet<string>(existingCodesTable.Rows.Cast<DataRow>().Select(r => r["uniqueCode"].ToString()));

            foreach (DataRow row in students.Rows)
            {
                string studentId = row["studentId"].ToString();
                string fullName = row["fullName"].ToString();
                string yearLevel = row["yearLevel"].ToString();
                string course = row["course"].ToString();

                string uniqueCode;
                do
                {
                    uniqueCode = GenerateRandomCode(5);
                } while (existingCodes.Contains(uniqueCode));

                existingCodes.Add(uniqueCode); 


                string insertQuery = "INSERT INTO codeTbl(studentId, fullName, yearLevel, course, uniqueCode, codeStatus) " +
                                     "VALUES (@studentId, @fullName, @yearLevel, @course, @code, @codeStatus)";

                crud.ClearSqlParameters();
                crud.AddParameters("@studentId", studentId, DbType.String);
                crud.AddParameters("@fullName", fullName, DbType.String);
                crud.AddParameters("@yearLevel", yearLevel, DbType.String);
                crud.AddParameters("@course", course, DbType.String);
                crud.AddParameters("@code", uniqueCode, DbType.String);
                crud.AddParameters("@codeStatus", "unuse", DbType.String);

                bool success = crud.ExecuteNonQuery(insertQuery, true);

                if (!success)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show($"Failed to insert for student {fullName}", "INSERT FAILED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            await DisplayReports();
            SystemSounds.Asterisk.Play();
            MessageBox.Show("Codes generated and saved successfully.", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }

        private string GenerateRandomCode(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ1234567";
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }



        private async Task DisplayReports()
        {
            try
            {
                string query = @"
                    SELECT studentId, fullName, yearLevel, course, uniqueCode 
                    FROM codeTbl";

                DataTable code = await Task.Run(() => crud.ReadData(query, false));

                if (code != null && code.Rows.Count > 0)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        _votersData = code;


                        reportViewer1.LocalReport.DataSources.Clear();


                        ReportDataSource rds = new ReportDataSource("StudentCodeInfo", _votersData);


                        reportViewer1.LocalReport.ReportPath = System.IO.Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Reports", "RPTStudentList.rdlc");


                        reportViewer1.LocalReport.DataSources.Add(rds);
                        reportViewer1.RefreshReport();
                    });

                
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("No data found in the database.", "NO DATA FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private async void generateCodeBtn_Click(object sender, EventArgs e)
        {
            generateCodeBtn.Enabled = false;
            await RefreshDataSource(); 
            generateCodeBtn.Enabled = true;
        }

        private bool IsReportReady()
        {
            return reportViewer1.LocalReport != null &&
                   reportViewer1.LocalReport.DataSources.Count > 0 &&
                   (!string.IsNullOrEmpty(reportViewer1.LocalReport.ReportPath) || !string.IsNullOrEmpty(reportViewer1.LocalReport.ReportEmbeddedResource));
        }



        private void excelBtn_Click(object sender, EventArgs e)
        {
            if (!IsReportReady())
            {
                MessageBox.Show("Please generate the report first before exporting.", "No Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Excel files (*.xls)|*.xls";
                saveFileDialog.FileName = "VotingCodeReport.xls";

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Warning[] warnings;
                    string[] streamids;
                    string mimeType;
                    string encoding;
                    string extension;

                    byte[] bytes = reportViewer1.LocalReport.Render(
                         "EXCELOPENXML", null, out mimeType, out encoding,
                        out extension, out streamids, out warnings);

                    File.WriteAllBytes(saveFileDialog.FileName, bytes);
                    MessageBox.Show("Excel file exported successfully.", "Export", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Excel: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void printBtn_Click(object sender, EventArgs e)
        {
            if (!IsReportReady())
            {
                MessageBox.Show("Please generate the report first before printing.", "No Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                reportViewer1.PrinterSettings = new System.Drawing.Printing.PrinterSettings();
                reportViewer1.PrintDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Print: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void clearParams_Click(object sender, EventArgs e)
        {
            yearLevel.SelectedIndex = -1;
            course.SelectedIndex = -1;
        }
    }
}
