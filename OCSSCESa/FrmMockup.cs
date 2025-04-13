using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCSSCESa
{
    public partial class FrmMockup : Form
    {
        public FrmMockup()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            using (FrmLogin frmLogin = new FrmLogin())
            {
                if (frmLogin.ShowDialog() == DialogResult.OK)
                {
                    this.Hide();
                    FrmMain mainForm = new FrmMain();
                    mainForm.FormClosed += (s, args) => this.Close();
                    mainForm.Show();
                }
            }
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Application.ExitThread();
        }
    }
}
