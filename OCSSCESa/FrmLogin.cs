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
using System.Media;


namespace OCSSCESa
{
    public partial class FrmLogin : Form
    {
        CRUD crud = new CRUD();

        public FrmLogin()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            if (usernameText.Text == "admin" && passwordText.Text == "admin")
            {
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            else
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Invalid username or password.", "INVALID CREDENTIALS", MessageBoxButtons.OK, MessageBoxIcon.Error); 
            }

        }

        private bool ValidateCredentials(string username, string password)
        {   
            // Login
            bool isValid = true;
            string encryptedPassword;
            try
            {
                string query = "SELECT infoId FROM accountTbl WHERE accountId = @accountId AND pass = @pass";

                crud.AddParameters("@accountId", username);
                crud.AddParameters("@password", password);

                
            }
            catch (Exception ex)
            {

            }


            return isValid;
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
