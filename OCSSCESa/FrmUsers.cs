using Microsoft.VisualBasic.ApplicationServices;
using OCSSCESa.Helper;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Media;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCSSCESa
{
    public partial class FrmUsers : Form
    {
        private CRUD _crud = new CRUD();
        private DataTable _users = new DataTable();

        public FrmUsers()
        {
            InitializeComponent();
        }

        private async void FrmUsers_Load(object sender, EventArgs e)
        {
            await RefreshDataSource();
        }

        public async Task RefreshDataSource()
        {
            loadingIndicator.Visible = true;
            usersFlowLayoutPanel.Visible = false;

            await DisplayAllUsersData();

            loadingIndicator.Visible = false;
            usersFlowLayoutPanel.Visible = true;
        }


        private async Task DisplayAllUsersData()
        {
            try
            {
                string query = "SELECT * FROM adminTbl";
                DataTable users = await Task.Run(() => _crud.ReadData(query, true));

                if (users != null)
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        _users = users;
                        DisplayAllUsers();
                    });
                }
                else
                {
                    this.Invoke((MethodInvoker)delegate
                    {
                        SystemSounds.Hand.Play();
                        MessageBox.Show("No data found in the database.", "NO DATA FOUND", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error during database operation: " + ex.Message);
            }
        }

        private void DisplayAllUsers()
        {
            if (_users == null || _users.Rows.Count == 0) return;

            usersFlowLayoutPanel.SuspendLayout();
            usersFlowLayoutPanel.Controls.Clear();

            foreach (DataRow row in _users.Rows)
            {
                try
                {
                    string name = row["fullName"].ToString();
                    string id = row["userId"].ToString();
                    string base64Image = row["picture"].ToString();
                    Image img = PublicHelper.Base64ToImage(base64Image);

                    AddUserControl(name, id, img);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error loading user control: {ex.Message}");
                }
            }

            usersFlowLayoutPanel.ResumeLayout();
        }

        public void AddUserControl(string name, string id, Image img)
        {
            ucUsers ucUser = new ucUsers(this)
            {
                Size = new Size((usersFlowLayoutPanel.Width / 3) + 70, 121),
                Username = name,
                UserId = id,
                UserImage = img
            };

            usersFlowLayoutPanel.Controls.Add(ucUser);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            FrmUsers frmUser = new FrmUsers();
            FrmAddUser frmAddUser = new FrmAddUser(frmUser, isAdd:true);
            frmAddUser.ShowDialog(this);
        }

        private async void btnSearch_Click(object sender, EventArgs e)
        {
            string keyword = searchTextbox.Text.Trim();

            if (string.IsNullOrWhiteSpace(keyword))
            {
                await RefreshDataSource();
                return;
            }

            SearchUsers(keyword);
        }


        private void SearchUsers(string keyword)
        {
            if (_users == null || _users.Rows.Count == 0) return;

            var filteredRows = _users.AsEnumerable()
                .Where(row => row["fullName"].ToString().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0
                           || row["userId"].ToString().IndexOf(keyword, StringComparison.OrdinalIgnoreCase) >= 0)
                .ToList();

            usersFlowLayoutPanel.SuspendLayout();
            usersFlowLayoutPanel.Controls.Clear();

            foreach (var row in filteredRows)
            {
                try
                {
                    string name = row["fullName"].ToString();
                    string id = row["userId"].ToString();
                    string base64Image = row["picture"].ToString();
                    Image img = PublicHelper.Base64ToImage(base64Image);

                    AddUserControl(name, id, img);
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Error filtering user: {ex.Message}");
                }
            }

            usersFlowLayoutPanel.ResumeLayout();
        }

        private void searchTextbox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch.PerformClick();
                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }
    }
}
