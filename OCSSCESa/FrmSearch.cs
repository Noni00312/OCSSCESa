using Google.Protobuf;
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
    public partial class FrmSearch : Form
    {
        CRUD crud = new CRUD();

        DataTable _studentData = new DataTable();

        List<String> columnNames = new List<String>()
        {
            "Student ID", "First name", "Middle name", "Last name", "Suffix",
            "Birthday",  "Age", "Gender", "Status", "Address", "Contact number",
            "Year level"
        };

        private FrmStudents _frmStudents;

        public FrmSearch(FrmStudents frmStudents, DataTable studentData)
        {
            InitializeComponent();
            _frmStudents = frmStudents;
            _studentData = studentData;
        }
       
        private async Task ReadData()
        {
            try
            {
                string query = "SELECT studentId, fName, mName, lName, suffix, birthdate, age, gender, " +
                                "civilStatus, address, contactNumber, yearLevel FROM studentInfoTbl";

                DataTable students = await Task.Run(() => crud.ReadData(query, false));

                if (students != null)
                {
                    _studentData = students;
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        _studentData = students;
                        searchVotersDataGrid.DataSource = _studentData;

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

            this.Invoke((MethodInvoker)delegate 
            { 
                loadingIndicator.Visible = false;
                UpdateDataGrid();
            });
        }

        private void UpdateDataGrid()
        {
            if (String.IsNullOrWhiteSpace(searchText.Text))
            {
                Styling.DataGridViewStyle(searchVotersDataGrid);

                PublicHelper.DisplayData(searchVotersDataGrid, _studentData, columnNames);
            }
            else
            {
                if (_studentData != null)
                {
                    var search = _studentData.AsEnumerable()
                                        .Where(row => !row.IsNull("studentId") && row.Field<string>("studentId").Contains(searchText.Text) || row.Field<string>("fName").Contains(searchText.Text)
                                        || row.Field<string>("lName").Contains(searchText.Text));

                    if (search.Any())
                    {
                        DataTable filteredData = search.CopyToDataTable();

                        Styling.DataGridViewStyle(searchVotersDataGrid);

                        PublicHelper.DisplayData(searchVotersDataGrid, filteredData, columnNames);
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

        private void FrmSearch_Load(object sender, EventArgs e)
        {
            formShadow.SetShadowForm(this);

            //await RefreshDataSource();

            if (_studentData != null)
            {
                searchVotersDataGrid.DataSource = _studentData;
            }

            //Styling.DataGridViewStyle(searchVotersDataGrid);
            loadingIndicator.Visible = false;
        }

        private void searchText_TextChanged(object sender, EventArgs e)
        {
            UpdateDataGrid();
        }

        private void searchVotersDataGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                // 
                if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
                {
                    DataGridViewRow selectedRow = searchVotersDataGrid.Rows[e.RowIndex];
                    DataGridViewColumn selectedColumn = searchVotersDataGrid.Columns[e.ColumnIndex];

                    ContextMenuStrip contextMenu = new ContextMenuStrip();

                    ToolStripMenuItem editItem = new ToolStripMenuItem("Edit");
                    ToolStripMenuItem archiveItem = new ToolStripMenuItem("Archive");
                    editItem.Font = new Font("Segeo UI", 12, FontStyle.Regular);
                    archiveItem.Font = new Font("Segeo UI", 12, FontStyle.Regular);
                    editItem.Image = Properties.Resources.icons8_edit_96px;
                    archiveItem.Image = Properties.Resources.icons8_archive_96px;

                    editItem.Click += (s, ev) => MessageBox.Show("Edit clicked");
                    archiveItem.Click += archive_Click;

                    contextMenu.Items.Add(editItem);
                    contextMenu.Items.Add(archiveItem);

                    contextMenu.Show(searchVotersDataGrid, searchVotersDataGrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, false).Location);
                }
            }
        }

        private async void archive_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to ARCHIVE this data?", "ARCHIVE DATA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string studentId = searchVotersDataGrid.CurrentRow.Cells[0].Value ?. ToString();

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

        private async void FrmSearch_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_frmStudents != null)
            {
                await _frmStudents.RefreshDataSource();
            }
        }
    }
}
