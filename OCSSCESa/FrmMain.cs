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
using Guna.UI2.WinForms;
using OCSSCESa.Helper;
using OCSSCESa.Properties;
using Org.BouncyCastle.Tls;

namespace OCSSCESa
{
    public partial class FrmMain : Form
    {

        private string currentPage = "";

        public FrmMain()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            // MessageBox.Show($"{Settings.Default.Port} {Settings.Default.Server} {Settings.Default.Username}");
            //DashboardButton.Checked = true;'
            windowLabel.Text = "Dashboard";
            currentPage = "Dashboard";
            FrmDashboard dashboard = new FrmDashboard();
            PublicHelper.DisplayChildForm(mainPanel, dashboard);
            
        }

        private void dashboardButton_Click(object sender, EventArgs e)
        {
            windowLabel.Text = "Dashboard";
            currentPage = "Dashboard";
            FrmDashboard dashboard = new FrmDashboard();
            PublicHelper.DisplayChildForm(mainPanel, dashboard);
        }

        public void studentButton_Click(object sender, EventArgs e)
        {
            windowLabel.Text = "Students";
            currentPage = "Students";
            FrmStudents student = new FrmStudents();
            PublicHelper.DisplayChildForm(mainPanel, student);
        }

        private void candidatesButton_Click(object sender, EventArgs e)
        {
            windowLabel.Text = "Candidates";
            currentPage = "Candidates";
            FrmCandidate candidates = new FrmCandidate();
            PublicHelper.DisplayChildForm(mainPanel, candidates);
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            windowLabel.Text = "Users";
            currentPage = "Users";
            FrmUsers users = new FrmUsers();
            PublicHelper.DisplayChildForm(mainPanel, users);
        }

        private void resultsButton_Click(object sender, EventArgs e)
        {
            FrmResult frmResult = new FrmResult();
            frmResult.Show(); 
        }

        private void userPicture_Click_1(object sender, EventArgs e)
        {
            dropdown.DroppedDown = true;
        }

        private void dropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (dropdown.SelectedIndex == 1)
            {
                if (MessageBox.Show("Are you sure you want to logout?", "LOGOUT", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    FrmMockup frmMockup = new FrmMockup();
                    frmMockup.Show();
                    this.Dispose();
                }
            }
        }

        private void btnGenerate_Click(object sender, EventArgs e)
        {
            FrmGenerateCode frmGenerateCode = new FrmGenerateCode();
            frmGenerateCode.ShowDialog();
        }

        private void ReloadPage(string pageName)
        {
            mainPanel.SuspendLayout();
            mainPanel.Visible = false;

            switch (pageName)
            {
                case "Dashboard":
                    mainPanel.Visible = false;
                    dashboardButton.PerformClick();
                    mainPanel.Visible = true;
                    break;
                case "Students":
                    mainPanel.Visible = false;
                    studentButton.PerformClick();
                    mainPanel.Visible = true;
                    break;
                case "Candidates":
                    mainPanel.Visible = false;
                    candidatesButton.PerformClick();
                    mainPanel.Visible = true;
                    break;
                case "Users":
                    mainPanel.Visible = false;
                    usersButton.PerformClick();
                    mainPanel.Visible = true;
                    break;
                default: break;
            }

            mainPanel.Visible = true;
            mainPanel.ResumeLayout(); 
        }

        private void menuButton_Click(object sender, EventArgs e)
        {
            
            if (sidebarPanel.Width == 204)
            {
                sidebarPanel.Width = 50;
                ReloadPage(currentPage);
            }
            else
            {
                sidebarPanel.Width = 204;
                ReloadPage(currentPage);
            }
        }
    }
}
