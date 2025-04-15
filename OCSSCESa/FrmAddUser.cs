using MySql.Data.MySqlClient;
using NPOI.OpenXmlFormats.Dml;
using OCSSCESa.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.ServiceModel.Configuration;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media.TextFormatting;

namespace OCSSCESa
{
    public partial class FrmAddUser : Form
    {

        private CRUD _crud = new CRUD();
        private FrmUsers _frmUser;
        private string _accountId;
        private bool _isAdd;
        private bool _updateOp = false; 


        public FrmAddUser(FrmUsers frmUser, string accountId = "", bool isAdd = false)
        {
            InitializeComponent();
            this._accountId = accountId;
            this._isAdd = isAdd;
            this._frmUser = frmUser;
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
                        userPicture.Image = Image.FromFile(ofd.FileName);
                        userImagePath.Text = Path.GetFileName(ofd.FileName);

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Unable to load image: {ex.Message}", "Error",
                                      MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }
        }
         
        private bool ValidInput()
        {
            if (string.IsNullOrWhiteSpace(fullName.Text) ||
                string.IsNullOrWhiteSpace(userId.Text) ||
                string.IsNullOrWhiteSpace(userName.Text) ||
                string.IsNullOrWhiteSpace(userPassword.Text) ||
                userPicture.Image == null) 
            {
                return false;
            }

            return true;
        }

        private void SaveNewUser()
        {
            if (!ValidInput())
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Please fill all required fields.", "INCOMPLETE DATA",
                              MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {

                string checkUserIdQuery = "SELECT COUNT(*) FROM adminTbl WHERE userId = @userId;";
                _crud.AddParameters("@userId", userId.Text);

                int userIdCount = _crud.ExecuteScalarHelper(checkUserIdQuery);

                if (userIdCount > 0)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Account ID already exists.", "ACCOUNT ID EXISTS",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string checkUsernameQuery = "SELECT COUNT(*) FROM adminTbl WHERE accountUsername = @username;";
                _crud.AddParameters("@username", userName.Text);

                int usernameCount = _crud.ExecuteScalarHelper(checkUsernameQuery);

                if (usernameCount > 0)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Username already used.", "USERNAME TAKEN",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string insertQuery = @"INSERT INTO adminTbl(fullName, userId, picture, accountUsername, accountPassword) 
                                 VALUES (@fullName, @userId, @picture, @accountUsername, @accountPassword);";

                _crud.AddParameters("@fullName", fullName.Text);
                _crud.AddParameters("@userId", userId.Text);
                _crud.AddParameters("@picture",
                                  PublicHelper.ImageToBase64(userPicture.Image,
                                  PublicHelper.GetImageFormat_2(userPicture.Image)));
                _crud.AddParameters("@accountUsername", userName.Text);
                string hashedPassword = PasswordHasher.Hash(userPassword.Text);
                _crud.AddParameters("@accountPassword", hashedPassword);

                if (_crud.ExecuteNonQuery(insertQuery, true))
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Data successfully added.", "USER ADDED",
                                  MessageBoxButtons.OK, MessageBoxIcon.Information);
                    PublicHelper.ClearControls(this);
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Data failed to save.", "SAVE FAILED",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show($"Error: {ex.Message}", "ERROR",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }


        private void GetUserData()
        {
            string searchQuery = "SELECT * FROM adminTbl WHERE userId = @userId;";

            _crud.ClearSqlParameters();
            _crud.AddParameters("@userId", _accountId);

            DataTable result = _crud.ReadData(searchQuery, true);

            if (result != null && result.Rows.Count > 0)
            {
                DataRow row = result.Rows[0];

                string rowFullName = row["fullName"].ToString();
                string rowUserName = row["accountUsername"].ToString();
                string rowPictureBase64 = row["picture"].ToString();

                Image userImg = PublicHelper.Base64ToImage(rowPictureBase64);

                fullName.Text = rowFullName;
                userId.Text = _accountId;
                userName.Text = rowUserName;
                userPicture.Image = userImg;
            }
            else
            {
                MessageBox.Show("User not found.", "NOT FOUND", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }




        private void UpdateUserData()
        {
            try
            {
                string updateQuery = @"UPDATE adminTbl SET fullName = @fullName";
                _crud.AddParameters("@fullName", fullName.Text);
                if (!string.IsNullOrWhiteSpace(userPassword.Text))
                {
                    updateQuery += ", accountPassword = @accountPassword";
                    string hashedPassword = PasswordHasher.Hash(userPassword.Text);
                    _crud.AddParameters("@accountPassword", hashedPassword);
                }

                if (userPicture.Image != null)
                {
                    updateQuery += ", picture = @picture";
                    string base64Picture = PublicHelper.ImageToBase64(userPicture.Image, PublicHelper.GetImageFormat_2(userPicture.Image));
                    _crud.AddParameters("@picture", base64Picture);
                }

                updateQuery += " WHERE userId = @userId";
                _crud.AddParameters("@userId", _accountId);

                bool isUpdateSuccess = _crud.ExecuteNonQuery(updateQuery, true);

                if (isUpdateSuccess)
                {
                    _updateOp = true;
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Data successfully updated.", "USER UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
                }
                else
                {
                    _updateOp = false;
                    SystemSounds.Hand.Play();
                    MessageBox.Show("No records were updated. Account ID may not exist.", "UPDATE FAILED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                _updateOp = false;
                SystemSounds.Hand.Play();
                MessageBox.Show($"Error: {ex.Message}", "UPDATE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void saveButton_Click(object sender, EventArgs e)
        {
           if(_isAdd)
           {
                SaveNewUser();
           }else
           {
                UpdateUserData();
           }
        }

        private void FrmAddUser_Load(object sender, EventArgs e)
        {
            formShadow.SetShadowForm(this);
            if (!_isAdd)
            {
                userId.ReadOnly = true;
                userName.ReadOnly = true;
                GetUserData();
                infoIcon.Visible = true;
                infoText.Visible = true;
                windowLabel.Text = "Edit user data";
            }
            else
            {
                userId.ReadOnly = false;
                userName.ReadOnly = false;
                infoIcon.Visible = false;
                infoText.Visible = false;
                windowLabel.Text = "Add new user";
            }
        }

        private async void FrmAddUser_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_updateOp)
            {
                await _frmUser.RefreshDataSource().ConfigureAwait(false);
            }
        }
    }
}
