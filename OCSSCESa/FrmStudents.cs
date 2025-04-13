using OCSSCESa.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Runtime.Remoting.Metadata;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCSSCESa
{
    public partial class FrmStudents : Form
    {


        private CRUD crud = new CRUD();
        private DataTable _votersData = new DataTable();

        List<String> columnNames = new List<String>()
        {
            "Student ID", "First name", "Middle name", "Last name", "Suffix",
            "Birthday",  "Age", "Gender", "Status", "Address", "Contact number",
            "Year level"
        };

        public FrmStudents()

        {
            InitializeComponent();          
        }
       
        private async Task DisplayStudentData()
        {
            try
            {  
           

                string query = "SELECT studentId, fName, mName, lName, suffix, birthdate, age, gender, " +
                                "civilStatus, address, contactNumber, yearLevel FROM studentinfotbl";

                DataTable students = await Task.Run(()=> crud.ReadData(query, false));

                if (students != null)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        _votersData = students;
                        UpdateDataGrid();

                    });
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        _votersData = students;
                        votersDatagrid.DataSource = _votersData;


                        SystemSounds.Hand.Play();
                        MessageBox.Show("No data found in the database.", "NO DATA FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    });
                }

               
             }
            catch (Exception ex)
            {
                Console.WriteLine("Error during database operation: " + ex.Message);
            }
        }

        public async Task RefreshDataSource()
        {
            loadingIndicator.Visible = true;

            await Task.Run(() => DisplayStudentData());

            this.Invoke((MethodInvoker)delegate
            {
                loadingIndicator.Visible = false ;
                UpdateDataGrid();
            });
        }

        private void UpdateDataGrid()
        {
            //Styling.DataGridViewStyle(votersDatagrid);
            this.Invoke((MethodInvoker)delegate
            {
                loadingIndicator.Visible = false;
            });
            PublicHelper.DisplayData(votersDatagrid, _votersData, columnNames);
           
        }

        private async void Students_Load(object sender, EventArgs e)
        {
            await RefreshDataSource();

        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FrmManualOrImport frmManualOrImport = new FrmManualOrImport(this);
            frmManualOrImport.ShowDialog(this);
        }

        private void archiveButton_Click(object sender, EventArgs e)
        {
            FrmArchive frmArchive = new FrmArchive(this);

            frmArchive.ShowDialog();
        }

        private void votersDatagrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // 
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = votersDatagrid.Rows[e.RowIndex];
                    DataGridViewColumn selectedColumn = votersDatagrid.Columns[e.ColumnIndex];

                    ContextMenuStrip contextMenu = new ContextMenuStrip();

                    ToolStripMenuItem editStudentData = new ToolStripMenuItem("Edit");
                    ToolStripMenuItem archiveItem = new ToolStripMenuItem("Archive");
                    editStudentData.Font = new Font("Segeo UI", 12, FontStyle.Regular);
                    archiveItem.Font = new Font("Segeo UI", 12, FontStyle.Regular);
                    editStudentData.Image = Properties.Resources.icons8_edit_96px;
                    archiveItem.Image = Properties.Resources.icons8_archive_96px;

                    editStudentData.Tag = e.RowIndex;
                    editStudentData.Click += editStudentData_Click;
                    archiveItem.Click += archive_Click;

                    contextMenu.Items.Add(editStudentData);
                    contextMenu.Items.Add(archiveItem);

                    contextMenu.Show(votersDatagrid, votersDatagrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location);
                }
            }
        }


        private async void archive_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to ARCHIVE this data?", "ARCHIVE DATA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string studentId = votersDatagrid.CurrentRow.Cells[0].Value?.ToString();

                crud.AddParameters("p_studentId", studentId);

                bool isDataArchived = crud.CallStoredProcedure("SP_ARCHIVE_DATA", true);

                if (isDataArchived)
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show(this, "Data successfully ARCHIVE.", "ARCHIVE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update data source

                    await RefreshDataSource();
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show(this, "Data failed to ARCHIVE.", "ARCHIVE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        
        private void editStudentData_Click(object sender, EventArgs e)
        {
            if(sender is ToolStripMenuItem menuItem && menuItem.Tag is int rowIndex)
            {
                if (rowIndex >= 0 && rowIndex < votersDatagrid.Rows.Count)
                {
                    DataGridViewRow selectedRow = votersDatagrid.Rows[rowIndex];

                    string studentId = selectedRow.Cells[0].Value?.ToString();
                    string fName = selectedRow.Cells[1].Value?.ToString();
                    string mName = selectedRow.Cells[2].Value?.ToString();
                    string lName = selectedRow.Cells[3].Value?.ToString();
                    string suffix = selectedRow.Cells[4].Value?.ToString();


                    string birthday = "";
                    if (selectedRow.Cells[5].Value != null)
                    {
                        if (selectedRow.Cells[5].Value is DateTime dateValue)
                        {
                            birthday = dateValue.ToString("yyyy-MM-dd");
                        }
                        else
                        {
                            // Handle if it's already a string
                            DateTime parsedDate;
                            if (DateTime.TryParse(selectedRow.Cells[5].Value.ToString(), out parsedDate))
                            {
                                birthday = parsedDate.ToString("yyyy-MM-dd");
                            }
                            else
                            {
                                birthday = selectedRow.Cells[5].Value?.ToString();
                            }
                        }
                    }

                    string age = selectedRow.Cells[6].Value?.ToString();
                    string gender = selectedRow.Cells[7].Value?.ToString();
                    string civilStatus = selectedRow.Cells[8].Value?.ToString();
                    string yearLevel = selectedRow.Cells[9].Value?.ToString();
                    string contactNumber = selectedRow.Cells[10].Value?.ToString();
                    string address = selectedRow.Cells[11].Value?.ToString();

                    FrmEditStudentData editStudentData = new FrmEditStudentData(
                        studentId, fName, mName, lName, suffix, birthday,
                        age, gender, civilStatus, yearLevel, contactNumber, address, this);
                    editStudentData.ShowDialog(this);
                }
            }
        }


        private void SearchAndDisplay()
        {
            loadingIndicator.Visible = true;
            votersDatagrid.Visible = false;
            Application.DoEvents(); 

            try
            {
                if (String.IsNullOrWhiteSpace(guna2TextBox1.Text))
                {
                    DisplayAllData();
                }
                else
                {
                    SearchData();
                }
            }
            finally
            {
                loadingIndicator.Visible = false;
                votersDatagrid.Visible = true;
            }
        }

        private void DisplayAllData()
        {
            Styling.DataGridViewStyle(votersDatagrid);
            PublicHelper.DisplayData(votersDatagrid, _votersData, columnNames);
        }

        private void SearchData()
        {
            if (_votersData == null || _votersData.Rows.Count == 0)
            {
                ShowNotFoundError();
                return;
            }

            var searchTerm = guna2TextBox1.Text.ToUpper();
            var filteredRows = _votersData.AsEnumerable()
                .Where(row => row.Field<string>("studentId")?.ToUpper().Contains(searchTerm) == true ||
                             row.Field<string>("fName")?.ToUpper().Contains(searchTerm) == true ||
                             row.Field<string>("lName")?.ToUpper().Contains(searchTerm) == true)
                .ToList();

            if (filteredRows.Any())
            {
                DataTable filteredData = filteredRows.CopyToDataTable();
                Styling.DataGridViewStyle(votersDatagrid);
                PublicHelper.DisplayData(votersDatagrid, filteredData, columnNames);
            }
            else
            {
                ShowNotFoundError();
            }
        }

        private void ShowNotFoundError()
        {
            SystemSounds.Hand.Play();
            MessageBox.Show(this, "No data found in the database.",
                "NO DATA FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchAndDisplay();
        }
    }
}
