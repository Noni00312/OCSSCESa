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

namespace OCSSCESa
{
    public partial class ucUsers : UserControl
    {

        private CRUD _crud = new CRUD();
        private FrmUsers frmUser;

        public ucUsers(FrmUsers frmUsers)
        {
            InitializeComponent();
            this.frmUser = frmUsers;
        }

        public string Username
        {
            get { return userName.Text; }
            set { userName.Text = value; }
        }


        public string UserId
        {
            get { return userId.Text; }
            set { userId.Text = value; }
        }



        public Image UserImage
        {
            get { return userImage.Image; }
            set { userImage.Image = value; }
        }

        private void guna2Separator1_Click(object sender, EventArgs e)
        {

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure you want to DELETE this data?", "DELETE DATA", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string id = userId.Text;
                string deleteQuery = "DELETE FROM adminTbl WHERE userId = @userId";

                _crud.AddParameters("@userId",  id);

                bool isDataDeleted = _crud.ExecuteNonQuery(deleteQuery, true);

                if (isDataDeleted)
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show(this, "Data successfully DELETE.", "DELETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Update data source
                    await frmUser.RefreshDataSource();
                    //await RefreshDataSource();
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show(this, "Data failed to DELETE.", "DELETE DATA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
