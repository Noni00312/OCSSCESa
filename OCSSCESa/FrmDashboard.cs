using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OCSSCESa.Helper;

namespace OCSSCESa
{
    public partial class FrmDashboard : Form
    {

        CRUD crud = new CRUD();

        List<String> columnNames = new List<String>()
        {
            "Ballot ID", "President", "VP IA", "VP EA", "Sec IA", "Sec EA",  "Treasurer", "Auditor", "BM", "PRO", "Representative",
        };

        private DataTable _ballots = new DataTable();

        public FrmDashboard()
        {
            InitializeComponent();
        }

        private async Task DisplayStudentData()
        {
            try
            {
                string ballotQuery = "SELECT ballotId, president, VPIA, VPEA, secIA, secEA, treasurer, auditor, BM, PRO, representative FROM ballotTbl";

                // Debug: Print the query being executed
                Debug.WriteLine("Executing query: " + ballotQuery);

                DataTable ballots = await Task.Run(() => crud.ReadData(ballotQuery, true));

                // Debug: Check what was returned
                if (ballots != null)
                {
                    Debug.WriteLine($"Query returned {ballots.Rows.Count} rows");
                    if (ballots.Rows.Count > 0)
                    {
                        Debug.WriteLine("First row: " + string.Join(",", ballots.Rows[0].ItemArray));
                    }
                }
                else
                {
                    Debug.WriteLine("Query returned null");
                }

                this.Invoke((MethodInvoker)delegate
                {
                    if (ballots != null && ballots.Rows.Count > 0)
                    {
                        _ballots = ballots;
                        PublicHelper.DisplayData(votersDatagrid, _ballots, columnNames);
                    }
                    else
                    {
                        votersDatagrid.DataSource = null; // Clear previous data
                        MessageBox.Show("No voting records found in the database.",
                                      "Information",
                                      MessageBoxButtons.OK,
                                      MessageBoxIcon.Information);
                    }
                });
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Error in DisplayStudentData: " + ex.ToString());
                this.Invoke((MethodInvoker)delegate
                {
                    MessageBox.Show($"Error loading ballot data: {ex.Message}",
                                  "Error",
                                  MessageBoxButtons.OK,
                                  MessageBoxIcon.Error);
                });
            }
        }



        //private async Task DisplayStudentData()
        //{
        //    try
        //    {
        //        string ballotQuery = @"SELECT 
        //                    ballotId AS [Ballot ID],
        //                    president AS President,
        //                    VPIA AS [VP IA],
        //                    VPEA AS [VP EA],
        //                    secIA AS [Sec IA],
        //                    secEA AS [Sec EA],
        //                    treasurer AS Treasurer,
        //                    auditor AS Auditor,
        //                    BM AS BM,
        //                    PRO AS PRO,
        //                    representative AS Representative FROM ballotTbl";

        //        DataTable ballots = await Task.Run(() => crud.ReadData(ballotQuery, false));

        //        this.Invoke((MethodInvoker)delegate
        //        {
        //            if (ballots != null && ballots.Rows.Count > 0)
        //            {
        //                votersDatagrid.DataSource = ballots;
        //                // No need for column name mapping since we aliased in SQL
        //            }
        //            else
        //            {
        //                votersDatagrid.DataSource = null;
        //                SystemSounds.Hand.Play();
        //                MessageBox.Show("No voting data found.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            }
        //        });
        //    }
        //    catch (Exception ex)
        //    {
        //        this.Invoke((MethodInvoker)delegate
        //        {
        //            MessageBox.Show($"Error loading ballots: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        });
        //    }
        //}


        public async void GetNumberOfVotes()
        {
            try
            {
                string query = "SELECT COUNT(*) AS StudentCount FROM studentInfoTbl";
                string queryBallots = "SELECT * FROM ballotTbl";
                string totalCourses = "SELECT COUNT(*) AS CoursesCount FROM coursesTbl";

                // Execute queries asynchronously
                DataTable studentCountTable = await Task.Run(() => crud.ReadData(query, true));
                DataTable ballotCountTable = await Task.Run(() => crud.ReadData(queryBallots, true));
                DataTable coursesCount = await Task.Run(() => crud.ReadData(totalCourses, true));

                this.Invoke((MethodInvoker)delegate
                {
                    if (studentCountTable != null && studentCountTable.Rows.Count > 0 &&
                        ballotCountTable != null && ballotCountTable.Rows.Count > 0)
                    {
                        // Extract counts from DataTables
                        int studentCount = Convert.ToInt32(studentCountTable.Rows[0]["StudentCount"]);
                        int ballotCount = Convert.ToInt32(ballotCountTable.Rows.Count);
                        int course = Convert.ToInt32(coursesCount.Rows[0]["CoursesCount"]);
                        int notCastCount = studentCount - ballotCount;

                        // Calculate percentage (with division by zero protection)
                        double percentageCast = studentCount > 0 ? Math.Round((ballotCount * 100.0) / studentCount, 1) : 0;
                        votesGraph.Value = (int)percentageCast;
                        courseGraph.Value = 0;
                        // Update UI
                        expectedVotersLabel.Text = studentCount.ToString();
                        votesCastLabel.Text = $"{ballotCount} ({percentageCast}%)";
                        notCastLabel.Text = notCastCount.ToString();
                        totalCourseLabel.Text = course.ToString();
                        courseCompleteLabel.Text = "0";
                        courseNotCompleteLabel.Text = course.ToString(); ;

                        // Optional: Add visual indicator for percentage
                        votesCastLabel.ForeColor = percentageCast >= 50 ? Color.Green : Color.Orange;
                    }
                    else
                    {
                        // Handle null or empty results
                        expectedVotersLabel.Text = "0";
                        votesCastLabel.Text = "0 (0%)";
                        notCastLabel.Text = "0";
                        totalCourseLabel.Text= "0";
                        courseCompleteLabel.Text = "0";
                        courseNotCompleteLabel.Text = "0";


                        SystemSounds.Hand.Play();
                        Console.WriteLine("No data found in the database.");
                    }
                });
            }
            catch (Exception ex)
            {
                this.Invoke((MethodInvoker)delegate
                {
                    expectedVotersLabel.Text = "Error";
                    votesCastLabel.Text = "Error";
                    notCastLabel.Text = "Error";

                    SystemSounds.Hand.Play();
                    Console.WriteLine($"Database error: {ex.Message}");
                });
            }
        }

        private async void Dashboard_Load(object sender, EventArgs e)
        {
            Styling.DataGridViewStyle(votersDatagrid);
            await DisplayStudentData();
            GetNumberOfVotes();
        }
    }
}
