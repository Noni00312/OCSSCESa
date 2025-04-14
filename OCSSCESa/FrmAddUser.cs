using MySql.Data.MySqlClient;
using OCSSCESa.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCSSCESa
{
    public partial class FrmAddUser : Form
    {
        private FrmUsers frmUser;

        public FrmAddUser(FrmUsers frmUser)
        {
            InitializeComponent();
            this.frmUser = frmUser;
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

        private void saveButton_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
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
                crud.AddParameters("@userId", userId.Text);

                int userIdCount = crud.ExecuteScalarHelper(checkUserIdQuery);

                if (userIdCount > 0)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Account ID already exists.", "ACCOUNT ID EXISTS",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string checkUsernameQuery = "SELECT COUNT(*) FROM adminTbl WHERE accountUsername = @username;";
                crud.AddParameters("@username", userName.Text);

                int usernameCount = crud.ExecuteScalarHelper(checkUsernameQuery);

                if (usernameCount > 0)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Username already used.", "USERNAME TAKEN",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                string insertQuery = @"INSERT INTO adminTbl(fullName, userId, picture, accountUsername, accountPassword) 
                                 VALUES (@fullName, @userId, @picture, @accountUsername, @accountPassword);";

                crud.AddParameters("@fullName", fullName.Text);
                crud.AddParameters("@userId", userId.Text);
                crud.AddParameters("@picture",
                                  PublicHelper.ImageToBase64(userPicture.Image,
                                  PublicHelper.GetImageFormat_2(userPicture.Image)));
                crud.AddParameters("@accountUsername", userName.Text);
                string hashedPassword = PasswordHasher.Hash(userPassword.Text);
                crud.AddParameters("@accountPassword", hashedPassword);

                if (crud.ExecuteNonQuery(insertQuery, true))
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

    }
}
