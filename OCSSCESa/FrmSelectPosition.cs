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
    public partial class FrmSelectPosition : Form
    {

        private CRUD _crud = new CRUD();
        private DataTable _positions = new DataTable();
        private string _studentName;
        private string _studentId;

        public FrmSelectPosition(string studentName, string studentId)
        {
            InitializeComponent();
            _studentName = studentName;
            _studentId = studentId; 
        }

        private async Task GetPositions()
        {
            try
            {
                try
                {
                    const string query = @"SELECT * FROM positionTbl";

                    var positions = await Task.Run(() => _crud.ReadData(query, false)).ConfigureAwait(false);

                    this.Invoke((MethodInvoker)delegate
                    {
                        _positions = positions;
                        if (_positions?.Rows.Count > 0)
                        {
                            foreach (DataRow row in _positions.Rows)
                            {
                                positionDropDown.Items.Add(row[1].ToString());
                            }
                        }
                        else
                        {
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
            catch (Exception ex) 
            { 
            }
        }

        private void guna2ControlBox1_Click(object sender, EventArgs e)
        {

        }

        private async void FrmSelectPosition_Load(object sender, EventArgs e)
        {
            if (_studentName != ""  && _studentId !="")
            {
                studentNameLabel.Text = _studentName;
                studentIdLabel.Text = _studentId;

            }

            await GetPositions().ConfigureAwait(false);
            formShadow.SetShadowForm(this);

        }
    }
}
