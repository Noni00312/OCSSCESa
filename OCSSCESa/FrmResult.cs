using Microsoft.Reporting.WinForms;
using OCSSCESa.Helper;
using System;
using System.Data;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCSSCESa
{
    public partial class FrmResult : Form
    {
        private readonly CRUD _crud = new CRUD();
        private DataTable _resultsTable = new DataTable();

        public FrmResult()
        {
            InitializeComponent();
            InitializeReportViewer();
        }

       
        private async void FrmResult_Load(object sender, EventArgs e)
        {
            // Initialize report viewer but don't generate results yet
            reportViewer1.LocalReport.ReportEmbeddedResource = "OCSSCESa.Reports.RPTResult.rdlc";
            reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("RPTResult", _resultsTable));
        }

        private async void generateCodeBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Show loading indicator
                generateCodeBtn.Enabled = false;
                generateCodeBtn.Text = "Generating...";
                Cursor = Cursors.WaitCursor;

                // Clear previous results
                _resultsTable.Clear();

                // Generate new results
                await GenerateResults();
                DisplayResults();

                MessageBox.Show("Results generated successfully!", "Success",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error generating results: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                // Restore UI state
                generateCodeBtn.Enabled = true;
                generateCodeBtn.Text = "Generate Results";
                Cursor = Cursors.Default;
            }
        }

        private async Task GenerateResults()
        {
            DataTable calculatedResults = await Task.Run(() => CalculateVotingResults());
            _resultsTable.Merge(calculatedResults);
        }

        public DataTable CalculateVotingResults()
        {
            DataTable finalResults = new DataTable();
            finalResults.Columns.Add("fullName", typeof(string));
            finalResults.Columns.Add("position", typeof(string));
            finalResults.Columns.Add("voteCount", typeof(int));
            finalResults.Columns.Add("ranking", typeof(int));

            try
            {
                var positions = new[]
                {
                    new { Column = "president", Name = "President" },
                    new { Column = "VPIA", Name = "Vice President (Internal Affairs)" },
                    new { Column = "VPEA", Name = "Vice President (External Affairs)" },
                    new { Column = "secIA", Name = "Secretary (Internal Affairs)" },
                    new { Column = "secEA", Name = "Secretary (External Affairs)" },
                    new { Column = "treasurer", Name = "Treasurer" },
                    new { Column = "auditor", Name = "Auditor" },
                    new { Column = "BM", Name = "Business Manager" },
                    new { Column = "PRO", Name = "Public Relations Officer" },
                    new { Column = "representative", Name = "Representative" }
                };

                foreach (var pos in positions)
                {
                    string query = $@"
                        SELECT 
                            CONCAT(s.fName, ' ', 
                                  COALESCE(s.mName + ' ', ''), 
                                  s.lName, 
                                  COALESCE(' ' + s.suffix, '')) AS fullName,
                            '{pos.Name}' AS position,
                            COUNT(b.{pos.Column}) AS voteCount
                        FROM ballotTbl b
                        INNER JOIN candidateTbl c ON b.{pos.Column} = c.candidateId
                        INNER JOIN studentInfoTbl s ON c.studentId = s.studentId
                        WHERE b.{pos.Column} IS NOT NULL
                        GROUP BY s.fName, s.mName, s.lName, s.suffix
                        ORDER BY voteCount DESC";

                    DataTable positionResults = _crud.ReadData(query, true);

                    if (positionResults != null && positionResults.Rows.Count > 0)
                    {
                        int rank = 1;
                        int previousVotes = -1;
                        int actualPosition = 0;

                        foreach (DataRow row in positionResults.Rows)
                        {
                            int currentVotes = Convert.ToInt32(row["voteCount"]);

                            if (currentVotes != previousVotes)
                            {
                                rank = actualPosition + 1;
                            }

                            finalResults.Rows.Add(
                                row["fullName"],
                                row["position"],
                                currentVotes,
                                rank
                            );

                            previousVotes = currentVotes;
                            actualPosition++;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error calculating results: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return finalResults;
        }

        private void InitializeReportViewer()
        {
            try
            {
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.ReportEmbeddedResource = "OCSSCESa.Reports.RPTResult.rdlc";

                // Verify the data source name matches your RDLC file
                string dataSourceName = "Results"; // Change this to whatever your RDLC expects
                reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource(dataSourceName, _resultsTable));
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Report initialization failed: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DisplayResults()
        {
            try
            {
                // Clear existing data sources
                reportViewer1.LocalReport.DataSources.Clear();

                // Add with the correct data source name
                reportViewer1.LocalReport.DataSources.Add(
                    new ReportDataSource("Results", _resultsTable));

                reportViewer1.RefreshReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error displaying results: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool IsReportReady()
        {
            return reportViewer1.LocalReport != null &&
                   reportViewer1.LocalReport.DataSources.Count > 0 &&
                   _resultsTable.Rows.Count > 0;
        }

        private void excelBtn_Click(object sender, EventArgs e)
        {
            if (!IsReportReady())
            {
                MessageBox.Show("Please generate the report first before exporting.",
                    "No Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog
                {
                    Filter = "Excel files (*.xlsx)|*.xlsx",
                    FileName = "ElectionResults.xlsx"
                };

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Warning[] warnings;
                    string[] streamIds;
                    string mimeType, encoding, extension;

                    byte[] reportBytes = reportViewer1.LocalReport.Render(
                        "EXCELOPENXML",
                        null,
                        out mimeType,
                        out encoding,
                        out extension,
                        out streamIds,
                        out warnings);

                    File.WriteAllBytes(saveFileDialog.FileName, reportBytes);
                    MessageBox.Show("Excel file exported successfully.", "Export",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error exporting to Excel: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printBtn_Click(object sender, EventArgs e)
        {
            if (!IsReportReady())
            {
                MessageBox.Show("Please generate the report first before printing.",
                    "No Report", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                reportViewer1.PrintDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing report: " + ex.Message, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}