using System;
using System.Windows.Forms;
using OCSSCESa.Properties;
using System.Media;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace OCSSCESa
{
    internal static class Program
    {

        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

       
        static void Main()
        {
            try
            {

                Settings.Default.Port = "";
                Settings.Default.Server = "";
                Settings.Default.Database = "";
                Settings.Default.Username = "";
                // encrypt password
                Settings.Default.Password = "";

                // Save settings
                Settings.Default.Save();


                var port = Settings.Default.Port;
                var server = Settings.Default.Port;
                var databaseName = Settings.Default.Port;
                var username = Settings.Default.Port;
                var password = Settings.Default.Port;


                if (String.IsNullOrEmpty(port) || String.IsNullOrEmpty(server) || String.IsNullOrEmpty(databaseName) || String.IsNullOrEmpty(username))
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Application failed to open due to a connection failure.", "CONNECTION FAILURE", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Application.Run(new DatabaseConfig());
                    return;
                }

                

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new Login());
            } 
            catch (Exception ex)
            {
                SystemSounds.Hand.Play();
                Console.WriteLine(ex.ToString());
                MessageBox.Show("An unexpected error occurred. Please check the logs.", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
    }
}
