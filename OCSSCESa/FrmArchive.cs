using NPOI.SS.Formula.Atp;
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
    public partial class FrmArchive : Form
    {
        CRUD crud = new CRUD();
        DataTable archiveData = new DataTable();

        private FrmStudents _frmStudent;

        public FrmArchive(FrmStudents frmStudents)
        {
            InitializeComponent();
            _frmStudent = frmStudents;      
        }

        List<String> columnNames = new List<String>()
        {
            "Student ID", "First name", "Middle name", "Last name", "Suffix",
            "Birthday",  "Age", "Gender", "Status", "Address", "Contact number",
            "Year level", "Course"
        };

        private async Task ReadData()
        {
            try
            {
                string query = "SELECT studentId, fName, mName, lName, suffix, birthdate, age, gender, " +
                                "civilStatus, address, contactNumber, yearLevel, course FROM archiveTbl";

                DataTable archive = await Task.Run(() => crud.ReadData(query, false));

                if (archive != null)
                {
                    archiveData = archive;
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        archiveData = archive;
                        archiveDataGrid.DataSource = archiveData;

                        SystemSounds.Hand.Play();
                        MessageBox.Show(this, "No data found in the database.", "NO DATA FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        loadingIndicator.Visible = false;
                    });
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine($"Search Error: {ex.Message}");
            }

        }

        private async Task RefreshDataSource()
        {

            loadingIndicator.Visible = true;

            await Task.Run(() => ReadData());

            //await Task.Delay(3000);

            this.Invoke((MethodInvoker)delegate
            {
                UpdateDataGrid();
                loadingIndicator.Visible = false;
            });
        }

        private void UpdateDataGrid()
        {
            if (String.IsNullOrWhiteSpace(searchArchiveText.Text))
            {
                Styling.DataGridViewStyle(archiveDataGrid);

                PublicHelper.DisplayData(archiveDataGrid, archiveData, columnNames);
            }
            else
            {
                if (archiveData != null)
                {
                    var search = archiveData.AsEnumerable()
                                        .Where(row => !row.IsNull("studentId") && row.Field<string>("studentId").Contains       (searchArchiveText.Text) || row.Field<string>("fName").Contains(searchArchiveText.Text)
                                        || row.Field<string>("lName").Contains(searchArchiveText.Text) || row.Field<string>("course").Contains(searchArchiveText.Text));

                    if (search.Any())
                    {
                        DataTable filteredData = search.CopyToDataTable();

                        Styling.DataGridViewStyle(archiveDataGrid);

                        PublicHelper.DisplayData(archiveDataGrid, filteredData, columnNames);
                    }
                    else
                    {
                        SystemSounds.Hand.Play();
                        MessageBox.Show(this, "No data found in the database.", "NO DATA FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show(this, "No data found in the database.", "NO DATA FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
        }

        private async void FrmArchive_Load(object sender, EventArgs e)
        {
            formShadow.SetShadowForm(this);

            await RefreshDataSource();
        }

        private void searchArchiveText_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void archiveDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = archiveDataGrid.Rows[e.RowIndex];
                    DataGridViewColumn selectedColumn = archiveDataGrid.Columns[e.ColumnIndex];

                    ContextMenuStrip contextMenu = new ContextMenuStrip();

                    ToolStripMenuItem retrieveItem = new ToolStripMenuItem("Retrieve");

                    retrieveItem.Font = new Font("Segeo UI", 12, FontStyle.Regular);
                    retrieveItem.Image = Properties.Resources.icons8_data_recovery_96px;
                    retrieveItem.Click += retrieveItem_Click;
                    
                   

                    contextMenu.Items.Add(retrieveItem);

                    contextMenu.Show(archiveDataGrid, archiveDataGrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location);
                }
            }
        }

        private async void retrieveItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to RETRIEVE this data?", "RETRIEVE DATA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string studentId = archiveDataGrid.CurrentRow.Cells[0].Value?.ToString();

                crud.AddParameters("p_studentId", studentId);

                bool isDataArchived = crud.CallStoredProcedure("SP_RETRIEVE_DATA", true);

                if (isDataArchived)
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show(this, "Data successfully RETRIEVE.", "RETRIEVE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update data source

                    await RefreshDataSource();
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show(this, "Data failed to RETRIEVE.", "RETRIEVE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private async void FrmArchive_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_frmStudent != null)
            {
                await _frmStudent.RefreshDataSource();
            }
        }
    }
}
