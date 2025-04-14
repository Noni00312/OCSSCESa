using OCSSCESa.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCSSCESa
{
    public partial class FrmCandidate : Form
    {

        private CRUD crud = new CRUD();
        private DataTable _candidatesData = new DataTable();

        List<String> columnNames = new List<String>()
        {
            "Candidate Id", "Student ID", "Full name", "Year level", "Position", "Candidate Picture"
        };

        public FrmCandidate()
        {
            InitializeComponent();
        }


        private async Task DisplayStudentData()
        {
            try
            {


                string query = "SELECT c.candidateId, i.studentId, CONCAT(' ', i.fName, i.mName, i.lName, i.suffix) AS fullName, i.yearLevel, p.positionName, c.candidatePic " +
                    "FROM studentInfoTbl i " +
                    "INNER JOIN candidateTbl c ON i.studentId = c.studentId " +
                    "INNER JOIN positionTbl p ON c.positionId = p.positionId;";

                DataTable candidates = await Task.Run(() => crud.ReadData(query, false));

                if (candidates != null)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        _candidatesData = candidates;
                        UpdateDataGrid();

                    });
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        _candidatesData = candidates;
                        candidateDatagrid.DataSource = _candidatesData;


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
                loadingIndicator.Visible = false;
                UpdateDataGrid();
            });
        }

        private void UpdateDataGrid()
        {
           // Styling.DataGridViewStyle(candidateDatagrid);
            this.Invoke((MethodInvoker)delegate
            {
                loadingIndicator.Visible = false;
            });
            PublicHelper.DisplayData(candidateDatagrid, _candidatesData, columnNames);

        }

        private async void FrmCandidate_Load(object sender, EventArgs e)
        {
            Styling.DataGridViewStyle(candidateDatagrid);
            candidateDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            await RefreshDataSource();
        }

        private void candidateDatagrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // 
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = candidateDatagrid.Rows[e.RowIndex];
                    DataGridViewColumn selectedColumn = candidateDatagrid.Columns[e.ColumnIndex];

                    ContextMenuStrip contextMenu = new ContextMenuStrip();

                    ToolStripMenuItem editCandidateData = new ToolStripMenuItem("Edit");
                    ToolStripMenuItem deleteData = new ToolStripMenuItem("Delete");
                    editCandidateData.Font = new Font("Segeo UI", 12, FontStyle.Regular);
                    deleteData.Font = new Font("Segeo UI", 12, FontStyle.Regular);
                    editCandidateData.Image = Properties.Resources.icons8_edit_96px;
                    deleteData.Image = Properties.Resources.icons8_remove_96px_1;

                    editCandidateData.Tag = e.RowIndex;
                    editCandidateData.Click += editStudentData_Click;
                    deleteData.Click += delete_Click;

                    contextMenu.Items.Add(editCandidateData);
                    contextMenu.Items.Add(deleteData);

                    contextMenu.Show(candidateDatagrid, candidateDatagrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location);
                }
            }
        }


        private void editStudentData_Click(object sender, EventArgs e)
        {
            string studentId = candidateDatagrid.CurrentRow.Cells[1].Value?.ToString();
            string studentName = candidateDatagrid.CurrentRow.Cells[2].Value?.ToString();
            string positionName = candidateDatagrid.CurrentRow.Cells[4].Value?.ToString();
            string candidatePic = candidateDatagrid.CurrentRow.Cells[5].Value?.ToString();
            FrmAddCandidates frmAddCandidates = new FrmAddCandidates(this);
            FrmSelectPosition frmSelectPosition = new FrmSelectPosition(studentName, studentId, frmAddCandidates, false, "Edit candidate" ,candidatePic, positionName);
            frmSelectPosition.ShowDialog(this);
        }

        private async void delete_Click(object sender, EventArgs e)
        {
            //if (MessageBox.Show("Are you sure you want to DELETE this data?", "DELETE DATA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            //{
            //    string studentId = candidateDatagrid.CurrentRow.Cells[1].Value?.ToString();

            //    crud.AddParameters("p_studentId", studentId);

            //    bool isDataDeleted = crud.CallStoredProcedure("SP_DELETE_DATA", true);

            //    if (isDataDeleted)
            //    {
            //        SystemSounds.Asterisk.Play();
            //        MessageBox.Show(this, "Data successfully DELETE.", "DELETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //        // Update data source

            //        await RefreshDataSource();
            //    }
            //    else
            //    {
            //        SystemSounds.Hand.Play();
            //        MessageBox.Show(this, "Data failed to DELETE.", "DELETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    }
            //}

        }

        private void addCandidateButton_Click(object sender, EventArgs e)
        {
            FrmAddCandidates addCandidate = new FrmAddCandidates(this);
            addCandidate.ShowDialog(this);
        }

        private void SearchAndDisplay()
        {
            loadingIndicator.Visible = true;
            candidateDatagrid.Visible = false;
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
                candidateDatagrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                candidateDatagrid.Visible = true;
            }
        }

        private void DisplayAllData()
        {
            Styling.DataGridViewStyle(candidateDatagrid);
            PublicHelper.DisplayData(candidateDatagrid, _candidatesData, columnNames);
        }

        private void SearchData()
        {
            if (_candidatesData == null || _candidatesData.Rows.Count == 0)
            {
                ShowNotFoundError();
                return;
            }

            var searchTerm = guna2TextBox1.Text.ToUpper();
            var filteredRows = _candidatesData.AsEnumerable()
                .Where(row => row.Field<string>("studentId")?.ToUpper().Contains(searchTerm) == true ||
                             row.Field<string>("fullName")?.ToUpper().Contains(searchTerm) == true ||
                             row.Field<string>("positionName")?.ToUpper().Contains(searchTerm) == true)
                .ToList();

            if (filteredRows.Any())
            {
                DataTable filteredData = filteredRows.CopyToDataTable();
                Styling.DataGridViewStyle(candidateDatagrid);
                PublicHelper.DisplayData(candidateDatagrid, filteredData, columnNames);
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

        private void positionsButton_Click(object sender, EventArgs e)
        {
            FrmAddPosition frmAddPosition = new FrmAddPosition();
            frmAddPosition.ShowDialog(this);
        }
    }
}