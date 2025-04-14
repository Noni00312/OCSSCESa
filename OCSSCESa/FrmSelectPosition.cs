using Guna.UI2.WinForms.Suite;
using NPOI.OpenXmlFormats.Shared;
using NPOI.SS.Formula.Functions;
using OCSSCESa.Helper;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCSSCESa
{
    public partial class FrmSelectPosition : Form
    {
        private FrmAddCandidates frmAddCandi;
        private CRUD _crud = new CRUD();
        private DataTable _positions = new DataTable();
        private string _studentName;
        private string _studentId;
        private string _stringPic;
        private bool _isAddOp = false;
        private string  _windowTitle;
        private string  _position;
        private bool hasUpdate = false;

        public FrmSelectPosition(string studentName, string studentId, FrmAddCandidates frmAddCandidates, bool isAdd, string windowTitle, string stringPic = null, string positionName = null)
        {
            InitializeComponent();
            _studentName = studentName;
            _studentId = studentId;
            frmAddCandi = frmAddCandidates;
            _isAddOp = isAdd;
            _stringPic = stringPic;
            _windowTitle = windowTitle;
            _position = positionName;
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


        private async Task<int> GetPositionId(string positionName)
        {
            if (_positions == null || string.IsNullOrWhiteSpace(positionName))
                return 0;

            try
            {
                string searchName = positionName.Trim();
                return await Task.Run(() =>
                {

                    var match = _positions.AsEnumerable()
                        .FirstOrDefault(row =>
                            row.Field<string>("PositionName")?.Equals(searchName, StringComparison.OrdinalIgnoreCase) == true);

                    return match != null ? match.Field<int>("PositionId") : 0;

                    

                });
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error finding position ID: {ex.Message}");
                return 0;
            }
        }



        public void HandleImageUpload()
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
 
                        Image originalImage = Image.FromFile(ofd.FileName);

   
                        string base64Image = PublicHelper.ImageToBase64(originalImage, PublicHelper.GetImageFormat(ofd.FileName));

                        Image reconstructedImage = PublicHelper.Base64ToImage(base64Image);

 
                        candidatePicture.Image = reconstructedImage;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error processing image: {ex.Message}");
                    }
                }
            }
        }

        private async void FrmSelectPosition_Load(object sender, EventArgs e)
        {
            if (_studentName != ""  && _studentId !="" && _stringPic != "" && _windowTitle != "")
            {
                studentNameLabel.Text = _studentName;
                studentIdLabel.Text = _studentId;
                candidatePicture.Image = PublicHelper.Base64ToImage(_stringPic);
                windowLabel.Text = _windowTitle;
            }

            formShadow.SetShadowForm(this); 
            await GetPositions().ConfigureAwait(false);
            this.Invoke((MethodInvoker)async delegate
            {
                positionDropDown.SelectedIndex = await GetPositionId(_position) - 1;
            });

        }

        private async void AddCandidate()
        {
            try
            {
                string convertedImage = await Task.Run(() =>
                    PublicHelper.ImageToBase64(candidatePicture.Image,
                                             PublicHelper.GetImageFormat(candidateImagePath.Text)));


                string positionName = positionDropDown.SelectedItem.ToString();
                int positionId = await GetPositionId(positionName);

                if (positionId <= 0)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Invalid position selected", "ERROR",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }


                string query = @"INSERT INTO candidateTbl(positionId, studentId, candidatePic) 
                        VALUES(@positionId, @studentId, @candidatePic)";

                _crud.AddParameters("@positionId", positionId);
                _crud.AddParameters("@studentId", studentIdLabel.Text.Trim());
                _crud.AddParameters("@candidatePic", convertedImage);


                bool result = await Task.Run(() => _crud.ExecuteNonQuery(query, true));

                if (result)
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Data successfully added.", "CANDIDATE ADDED",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmAddCandi.addedNew = true;
                    this.Close();
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Data failed to add.", "CANDIDATE FAILED TO ADD",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    frmAddCandi.addedNew = false;
                }
            }
            catch (Exception ex)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show($"An error occurred: {ex.Message}", "ERROR",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmAddCandi.addedNew = false;
            }
        }

        private async void UpdateCandidate()
        {
            try
            {
                string convertedImage = await Task.Run(() =>
                    PublicHelper.ImageToBase64(candidatePicture.Image, PublicHelper.GetImageFormat_2(candidatePicture.Image)));


                string positionName = positionDropDown.SelectedItem.ToString();

                int positionId = await GetPositionId(positionName);

                if (positionId <= 0)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Invalid position selected", "ERROR",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string updateQuery = @"UPDATE candidateTbl 
                          SET positionId = @positionId,
                              candidatePic = @candidatePic
                          WHERE studentId = @studentId";

                _crud.AddParameters("@studentId", _studentId);
                _crud.AddParameters("@positionId", positionId);
                _crud.AddParameters("@candidatePic", convertedImage);


                bool isUpdateSuccess = _crud.ExecuteNonQuery(updateQuery, true);

                if (isUpdateSuccess)
                {
                    //dataUpdated = true;
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Data successfully updated.", "STUDENT UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    hasUpdate = true;

                }
                else
                {
                    //dataUpdated = false;
                    SystemSounds.Hand.Play();
                    MessageBox.Show("No records were updated. Student ID may not exist.", "UPDATE FAILED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    hasUpdate = false;
                }
            }
            catch (Exception ex)
            {
                //dataUpdated = false;
                SystemSounds.Hand.Play();
                MessageBox.Show($"Error: {ex.Message}", "UPDATE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                hasUpdate = false;
            }

        }



        private void saveButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrWhiteSpace(studentIdLabel.Text) ||
                string.IsNullOrWhiteSpace(studentNameLabel.Text) ||
                positionDropDown.SelectedIndex == -1 ||
                candidatePicture.Image == null)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("All fields are required.", "EMPTY FIELD DETECTED",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                frmAddCandi.addedNew = false;
                return;
            }

            if(_isAddOp) {
                AddCandidate();
            }else
            {
                UpdateCandidate();
            }

           
        }

        private void browseImage_Click(object sender, EventArgs e)
        {
          
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Title = "Select an Image File";
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.gif";
                ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures);

                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        candidatePicture.Image = Image.FromFile(ofd.FileName);
                        candidateImagePath.Text = Path.GetFileName(ofd.FileName);
                       
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Unable to load image: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            
            }
        }

        private async void FrmSelectPosition_FormClosed(object sender, FormClosedEventArgs e)
        {
            //FrmCandidate frmCandidate = new FrmCandidate();
            //if(hasUpdate)
            //{
            //    await frmCandidate.RefreshDataSource().ConfigureAwait(false);
            //}
        }
    }
}
