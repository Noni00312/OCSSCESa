using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OCSSCESa.Helper;

namespace OCSSCESa
{
    public partial class FrmDashboard : Form
    {
        public FrmDashboard()
        {
            InitializeComponent();
        }

        public DataTable CreateSampleDataTable()
        {
            // Create a new DataTable
            DataTable dataTable = new DataTable("SampleTable");

            // Add 10 columns to the DataTable
            for (int i = 1; i <= 11; i++)
            {
                dataTable.Columns.Add($"Column{i}", typeof(string));
            }

            // Add some sample rows to the DataTable
            for (int row = 1; row <= 5; row++) // Adding 5 rows for testing
            {
                DataRow dataRow = dataTable.NewRow();
                for (int col = 1; col <= 10; col++)
                {
                    dataRow[$"Column{col}"] = $"Row{row}Col{col}"; // Sample data
                }
                dataTable.Rows.Add(dataRow);
            }

            return dataTable;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DataTable sampleDataTable = CreateSampleDataTable();
            // Create sample DataTable

            // Create a list of column names
            List<string> columnNames = new List<string>
            {
                "Header 1", "Header 2", "Header 3", "Header 4", "Header 5",
                "Header 6", "Header 7", "Header 8", "Header 9", "Header 10", "Header 11"
            };

            // Call your DisplayData method
            PublicHelper.DisplayData(votersDatagrid, sampleDataTable, columnNames);

            Styling.DataGridViewStyle(votersDatagrid);
        }
    }
}
