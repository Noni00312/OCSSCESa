using OCSSCESa.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCSSCESa
{
    public partial class FrmAddCandidates : Form
    {
        private readonly CRUD _crud = new CRUD();
        private DataTable _studentData;
        private string _studentName;
        private FrmCandidate frmCandi; 
        public bool addedNew = false;
        private readonly List<string> _columnNames = new List<string>
        {
            "Student ID", "First name", "Middle name", "Last name", "Suffix",
            "Birthday", "Age", "Gender", "Status", "Address", "Contact number",
            "Year level"
        };

        public FrmAddCandidates( FrmCandidate frmCandidate)
        {
            InitializeComponent();
            frmCandi = frmCandidate;
        }

        private async Task DisplayStudentData()
        {
            try
            {
                const string query = @"SELECT studentId, fName, mName, lName, suffix, birthdate, 
                                       age, gender, civilStatus, address, contactNumber, yearLevel 
                                       FROM studentinfotbl";

                var students = await Task.Run(() => _crud.ReadData(query, false)).ConfigureAwait(false);

                this.Invoke((MethodInvoker)delegate
                {
                    _studentData = students;
                    if (_studentData?.Rows.Count > 0)
                    {
                        UpdateDataGrid();
                    }
                    else
                    {
                        studentListDatagrid.DataSource = _studentData;
                        SystemSounds.Hand.Play();
                        MessageBox.Show("No data found in the database.",
                                      "NO DATA FOUND",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Error);
                    }
                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error during database operation: {ex.Message}");
            }
        }

        public async Task RefreshDataSource()
        {
            loadingIndicator.Visible = true;
            studentListDatagrid.Visible = false;

            try
            {
                await DisplayStudentData().ConfigureAwait(false);
            }
            finally
            {
                this.Invoke((MethodInvoker)delegate
                {
                    loadingIndicator.Visible = false;
                    
                });
            }
        }

        private void UpdateDataGrid()
        {
            PublicHelper.DisplayData(studentListDatagrid, _studentData, _columnNames);
        }


        private void studentListDatagrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right && e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                var contextMenu = new ContextMenuStrip();
                var cellRectangle = studentListDatagrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false);

                

                var addCandidate = new ToolStripMenuItem("Add candidate")
                {
                    Font = new Font("Segoe UI", 12),
                    Image = Properties.Resources.icons8_add_48px
                };

              

                addCandidate.Click += addCandidate_Click;

                contextMenu.Items.Add(addCandidate);

                contextMenu.Show(studentListDatagrid, cellRectangle.Location);
            }
        }

        private  void addCandidate_Click(object sender, EventArgs e)
        {

            string studentName = studentListDatagrid.CurrentRow.Cells[1].Value?.ToString() + " " + studentListDatagrid.CurrentRow.Cells[2].Value?.ToString() + " " + studentListDatagrid.CurrentRow.Cells[3].Value?.ToString() + " " + studentListDatagrid.CurrentRow.Cells[4].Value?.ToString();
            string studentId = studentListDatagrid.CurrentRow.Cells[0].Value?.ToString();


            string checkQuery = "SELECT studentId FROM candidateTbl WHERE studentId = @studentId LIMIT 1;";

            _crud.AddParameters("@studentId", studentId);

            DataTable checkResult = _crud.ReadData(checkQuery, true);

            if (checkResult != null)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Student is already a candidate.", "CANDIDATE ALREADT EXIST", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            FrmSelectPosition frmSelectPosition = new FrmSelectPosition(studentName, studentId, this, true, "Select position");

            frmSelectPosition.ShowDialog(this);
        }

        private void SearchAndDisplay()
        {
            loadingIndicator.Visible = true;
            studentListDatagrid.Visible = false;
            Application.DoEvents();

            try
            {
                if (string.IsNullOrWhiteSpace(searchText.Text))
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
                studentListDatagrid.Visible = true;
            }
        }

        private void DisplayAllData()
        {
            Styling.DataGridViewStyle(studentListDatagrid);
            PublicHelper.DisplayData(studentListDatagrid, _studentData, _columnNames);
        }

        private async  void SearchData()
        {
            await RefreshDataSource().ConfigureAwait(false);

            if (_studentData?.Rows.Count == 0)
            {
                ShowNotFoundError();
                return;
            }

            var searchTerm = searchText.Text.ToUpperInvariant();
            var filteredRows = _studentData.AsEnumerable()
                .Where(row => row.Field<string>("studentId")?.ToUpperInvariant().Contains(searchTerm) == true ||
                             row.Field<string>("fName")?.ToUpperInvariant().Contains(searchTerm) == true ||
                             row.Field<string>("lName")?.ToUpperInvariant().Contains(searchTerm) == true)
                .ToList();

            if (filteredRows.Count > 0)
            {

                var filteredData = filteredRows.CopyToDataTable();
                this.Invoke((MethodInvoker)delegate
                {
                    PublicHelper.DisplayData(studentListDatagrid, filteredData, _columnNames);
                    studentListDatagrid.Visible = true;
                });
               
               
            }
            else
            {
                ShowNotFoundError();
            }
        }

        private void ShowNotFoundError()
        {
            SystemSounds.Hand.Play();
            this.Invoke((MethodInvoker)delegate
            {

                MessageBox.Show(this,
                               "No data found in the database.",
                               "NO DATA FOUND",
                               MessageBoxButtons.OK,
                               MessageBoxIcon.Error);
            });
        }


        private  void FrmAddCandidates_Load(object sender, EventArgs e)
        {
            formShadow.SetShadowForm(this);
            //await RefreshDataSource().ConfigureAwait(false);
            this.Invoke((MethodInvoker)delegate
            {
                Styling.DataGridViewStyle(studentListDatagrid);

            });
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SearchData();
        }

        private void FrmAddCandidates_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)  {
                btnSearch.PerformClick();
            }
        }

        private async void FrmAddCandidates_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(addedNew) {
                await frmCandi.RefreshDataSource().ConfigureAwait(false);
            }
        }
    }
}