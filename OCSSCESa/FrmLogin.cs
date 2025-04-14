using OCSSCESa.Helper;
using System;
using System.Data;
using System.Diagnostics;
using System.Media;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace OCSSCESa
{
    public partial class FrmLogin : Form
    {
        CRUD crud = new CRUD();

        public FrmLogin()
        {
            InitializeComponent();
        }

        //private void loginButton_Click(object sender, EventArgs e)
        //{

        //    try
        //    {
        //        string username = usernameText.Text.Trim();
        //        string password = passwordText.Text;

        //        if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
        //        {
        //            SystemSounds.Hand.Play();
        //            MessageBox.Show("Please enter both username and password.", "MISSING CREDENTIALS",
        //                          MessageBoxButtons.OK, MessageBoxIcon.Warning);
        //            return;
        //        }

        //        // Special case for default admin (remove in production)
        //        if (username == "admin" && password == "admin")
        //        {
        //            this.DialogResult = DialogResult.OK;
        //            this.Close();
        //            return;
        //        }

        //        // 1. Get stored hash from database
        //        string query = "SELECT accountPassword FROM adminTbl WHERE accountUsername = @username";
        //        crud.AddParameters("@username", username);

        //        DataTable result = crud.ReadData(query, true);


        //        if (result.Rows.Count == 0)
        //        {
        //            // User not found
        //            SystemSounds.Hand.Play();
        //            MessageBox.Show("Invalid username or password.", "INVALID CREDENTIALS",
        //                          MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            return;
        //        }

        //        //string storedHash = result.ToString();
        //        //MessageBox.Show($"Hash from DB: {storedHash}");
        //        string storedHash = result.Rows[0]["accountPassword"]?.ToString() ?? string.Empty;

        //        try
        //        {
        //            if (PasswordHasher.Verify(password, storedHash))
        //            {

        //                if (PasswordHasher.NeedsUpgrade(storedHash))
        //                {
        //                    string newHash = PasswordHasher.Hash(password);

        //                    string updateQuery = "UPDATE adminTbl SET accountPassword = @newPassword " +
        //                                        "WHERE accountUsername = @username";

        //                    crud.AddParameters("@newPassword", newHash);
        //                    crud.AddParameters("@username", username);

        //                    if (!crud.ExecuteNonQuery(updateQuery, true))
        //                    {
        //                        Console.WriteLine("Warning: Failed to update password hash for user: " + username);
        //                    }
        //                }
        //                this.DialogResult = DialogResult.OK;
        //                this.Close();
        //            }
        //            else
        //            {
        //                SystemSounds.Hand.Play();
        //                MessageBox.Show("Invalid username or password.", "INVALID CREDENTIALS",
        //                              MessageBoxButtons.OK, MessageBoxIcon.Error);
        //            }
        //        }
        //        catch (FormatException)
        //        {
        //            SystemSounds.Hand.Play();
        //            MessageBox.Show("Invalid password format in database. Please contact administrator.",
        //                            "SYSTEM ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        }
        //    }
        //    catch (Exception ex)
        //    {
        //        SystemSounds.Hand.Play();
        //        MessageBox.Show($"Login error: {ex.Message}", "LOGIN ERROR",
        //                      MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}

        private async void loginButton_Click(object sender, EventArgs e)
        {
            // Disable button to prevent multiple clicks during processing
            loginButton.Enabled = false;

            try
            {
                string username = usernameText.Text.Trim();
                string password = passwordText.Text;

                // Validate input first (fastest check)
                if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Please enter both username and password.", "MISSING CREDENTIALS",
                                  MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                // Remove the hardcoded admin credentials - this is a security risk
                // if (username == "admin" && password == "admin") { ... }

                // Database operations should be async to prevent UI freezing
                bool loginSuccessful = await Task.Run(() => AuthenticateUser(username, password));

                if (loginSuccessful)
                {
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Invalid username or password.", "INVALID CREDENTIALS",
                                  MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Invalid username or password.", "INVALID CREDENTIALS",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
                // Log the actual exception details for debugging
                Debug.WriteLine($"Login error: {ex}");
            }
            finally
            {
                // Re-enable the button
                loginButton.Enabled = true;
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                string query = "SELECT accountPassword FROM adminTbl WHERE accountUsername = @username";
                crud.AddParameters("@username", username);

                DataTable result = crud.ReadData(query, true);

                if (result == null || result.Rows.Count == 0)
                {
                    MessageBox.Show("No user found with username: " + username,"NO USER FOUND", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                string storedHash = result.Rows[0]["accountPassword"]?.ToString() ?? string.Empty;

                if (string.IsNullOrEmpty(storedHash))
                {
                    Debug.WriteLine("Password hash is empty for user: " + username);
                    return false;
                }

                if (PasswordHasher.Verify(password, storedHash))
                {
                    if (PasswordHasher.NeedsUpgrade(storedHash))
                    {
                        string newHash = PasswordHasher.Hash(password);
                        UpdatePasswordHash(crud, username, newHash);
                    }
                    return true;
                }
            }
            catch (FormatException)
            {
                Debug.WriteLine("Invalid password hash format for user: " + username);
            }
            catch (Exception ex)
            {
                Debug.WriteLine("Authentication failed for user: " + username + " Error: " + ex.Message);
            }

            return false;
        }


        private void UpdatePasswordHash(CRUD crud, string username, string newHash)
        {
            try
            {
                string updateQuery = "UPDATE adminTbl SET accountPassword = @newPassword " +
                                    "WHERE accountUsername = @username";

                crud.ClearSqlParameters();
                crud.AddParameters("@newPassword", newHash);
                crud.AddParameters("@username", username);

                if (!crud.ExecuteNonQuery(updateQuery, true))
                {
                    Debug.WriteLine("Warning: Failed to update password hash for user: " + username);
                }
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Error updating password hash for {username}: {ex.Message}");
            }
        }

        private bool CreateUpdateLog(string infoId, bool isLogin)
        {
            bool isSuccess = true;
            string queryLogin = "INSET INTO loginLogsTbl (infoId,timeIn) VALUES (@infoId, @timeIn);";
            //string queryLogout = "UPDATE loginLogsTbl set timeOut = @timeOut WHERE infoId = @infoId AND timeIn != null;";

            crud.AddParameters("@infoId", infoId);
            crud.AddParameters("@timeIn", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt"));
            //crud.AddParameters("@timeOut", DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss tt"));
            
            if (!crud.ExecuteNonQuery(queryLogin, true))
            {
                //Message box
                isSuccess = false;
            }


            return isSuccess;
        }

        private void userPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void Login_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginButton.PerformClick();
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            formShadow.SetShadowForm(this);
        }

        private void passwordText_TextChanged(object sender, EventArgs e)
        {

        }

        private void usernameText_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
