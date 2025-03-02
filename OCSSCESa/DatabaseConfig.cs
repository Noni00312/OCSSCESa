using OCSSCESa.Helper;
using OCSSCESa.Properties;
using System;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics.Contracts;


namespace OCSSCESa
{
    public partial class DatabaseConfig : Form
    {
        public DatabaseConfig()
        {
            InitializeComponent();
        }

        private void DatabaseConfig_Load(object sender, EventArgs e)
        {
            formShadow.SetShadowForm(this);
            portText.Text = Settings.Default.Port;
            serverText.Text = Settings.Default.Server;
            databaseText.Text = Settings.Default.Database;
            usernameText.Text = Settings.Default.Username;
            passwordText.Text = Settings.Default.Password;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            var port = portText.Text;
            var server = serverText.Text;
            var databaseName = databaseText.Text;
            var username = usernameText.Text;
            var password = passwordText.Text;

            if (String.IsNullOrEmpty(port) || String.IsNullOrEmpty(server) || String.IsNullOrEmpty(databaseName) || String.IsNullOrEmpty(username))
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("All field are required.", "EMPTY FIELD DETECTED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
               
                Settings.Default.Port = port;
                Settings.Default.Server = server;
                Settings.Default.Database = databaseName;
                Settings.Default.Username = username;
                // encrypt password
                Settings.Default.Password = password;

                // Save settings
                Settings.Default.Save();

                var conn = DatabaseHelper.DatabaseConnection();

                try
                {
                    if(conn != null)
                    {
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Configuration successfully saved.", "CONNECTION STABLISHED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        SystemSounds.Hand.Play();
                        MessageBox.Show("Failed to stablish connection.", "CONNECTION FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
 
                }
                catch (Exception ex)
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show(ex.Message, "CONNECTION FAILED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    conn?.Close();
                }
              
            }


        }
    }
}
