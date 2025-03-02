using System;
using System.Windows.Forms;
using OCSSCESa.Properties;

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
                var port = Settings.Default.Port;
                var server = Settings.Default.Port;
                var databaseName = Settings.Default.Port;
                var username = Settings.Default.Port;
                var password = Settings.Default.Port;


                if (port.Equals("") || server.Equals("") || databaseName.Equals("") || username.Equals("") || password.Equals(""))
                {
                    
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
                Console.WriteLine(ex.ToString());
                MessageBox.Show("An unexpected error occurred. Please check the logs.", "FATAL ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           

        }
    }
}
