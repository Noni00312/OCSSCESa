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
        private DataTable candidatesData = new DataTable();

        List<String> columnNames = new List<String>()
        {
            "Candidate Id", "Student ID", "Full name", "Year level", "Position"
        };

        public FrmCandidate()
        {
            InitializeComponent();
        }


        private async Task DisplayStudentData()
        {
            try
            {


                string query = "SELECT c.candidateId, i.studentId, CONCAT(' ', i.fName, i.mName, i.lName, i.suffix) AS fullName, i.yearLevel, p.positionName " +
                    "FROM studentInfoTbl i " +
                    "INNER JOIN candidateTbl c ON i.studentId = c.studentId " +
                    "INNER JOIN positionTbl p ON c.positionId = p.positionId;";

                DataTable candidates = await Task.Run(() => crud.ReadData(query, false));

                if (candidates != null)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        candidatesData = candidates;
                        UpdateDataGrid();

                    });
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        candidatesData = candidates;
                        candidateDatagrid.DataSource = candidatesData;


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
            PublicHelper.DisplayData(candidateDatagrid, candidatesData, columnNames);

        }

        private async void FrmCandidate_Load(object sender, EventArgs e)
        {
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

                    ToolStripMenuItem editStudentData = new ToolStripMenuItem("Edit");
                    ToolStripMenuItem deleteData = new ToolStripMenuItem("Delete");
                    editStudentData.Font = new Font("Segeo UI", 12, FontStyle.Regular);
                    deleteData.Font = new Font("Segeo UI", 12, FontStyle.Regular);
                    editStudentData.Image = Properties.Resources.icons8_edit_96px;
                    deleteData.Image = Properties.Resources.icons8_remove_96px_1;

                    editStudentData.Tag = e.RowIndex;
                    editStudentData.Click += editStudentData_Click;
                    deleteData.Click += delete_Click;

                    contextMenu.Items.Add(editStudentData);
                    contextMenu.Items.Add(deleteData);

                    contextMenu.Show(candidateDatagrid, candidateDatagrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location);
                }
            }
        }


        private void editStudentData_Click(object sender, EventArgs e)
        {

        }

        private async void delete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to DELETE this data?", "DELETE DATA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string studentId = candidateDatagrid.CurrentRow.Cells[1].Value?.ToString();

                crud.AddParameters("p_studentId", studentId);

                bool isDataDeleted = crud.CallStoredProcedure("SP_DELETE_DATA", true);

                if (isDataDeleted)
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show(this, "Data successfully DELETE.", "DELETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update data source

                    await RefreshDataSource();
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show(this, "Data failed to DELETE.", "DELETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void addCandidateButton_Click(object sender, EventArgs e)
        {
            FrmAddCandidates addCandidate = new FrmAddCandidates();
            addCandidate.ShowDialog();
        }
    }
}

//using (MySqlConnection conn = new MySqlConnection(connectionString))
//{
//    MySqlCommand cmd = new MySqlCommand("SP_DELETE_DATA", conn);
//    cmd.CommandType = CommandType.StoredProcedure;
//    cmd.Parameters.AddWithValue("@p_studentId", studentId);

//    conn.Open();
//    using (MySqlDataReader reader = cmd.ExecuteReader())
//    {
//        if (reader.Read())
//        {
//            int status = reader.GetInt32("status");
//            string message = reader.GetString("message");
//            Console.WriteLine($"Status: {status}, Message: {message}");
//        }
//    }
//}
