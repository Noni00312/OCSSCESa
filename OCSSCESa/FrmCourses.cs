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
    public partial class FrmCourses : Form
    {

        FrmAddNewStudent _frmAddNewStudent;
        public FrmCourses(FrmAddNewStudent frmAddNewStudent)
        {
            InitializeComponent();
            this._frmAddNewStudent = frmAddNewStudent;
        }

        private void FrmCourses_Load(object sender, EventArgs e)
        {
            guna2ShadowForm1.SetShadowForm(this);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {

            CRUD crud = new CRUD();
            PublicHelper helper = new PublicHelper();
            bool isValid = helper.ValidateControls(this);

            if (!isValid)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Please fill all required field.", "ALL FIELD ARE REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = "SELECT * FROM coursesTbl WHERE courseName = @courseName OR courseAbbreviation = @courseAbbre;";

            crud.AddParameters("@courseName", courseName.Text);
            crud.AddParameters("@courseAbbre", courseAbbreviation.Text);

            DataTable result = crud.ReadData(query, true);

            if (result != null)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Course already exist.", "COURSE ALREADT EXIST", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string insertQuery = "INSERT INTO coursesTbl(courseName, courseAbbreviation) VALUES (@courseName, @courseAbbre);";

                crud.AddParameters("@courseName", courseName.Text);
                crud.AddParameters("@courseAbbre", courseAbbreviation.Text);
              


                bool isInsertSuccess = crud.ExecuteNonQuery(insertQuery, true);
                if (isInsertSuccess)
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Data successfully added.", "COURSE ADDED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    PublicHelper.ClearControls(this);
                }
                else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Data failed to save.", "DATA FAILED TO ADD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show($"Error {ex.Message}", "SOMETHING WENT WRONG", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FrmCourses_FormClosed(object sender, FormClosedEventArgs e)
        {
            _frmAddNewStudent.PopulateCourses();
        }
    }
}
