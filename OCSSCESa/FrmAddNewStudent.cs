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
    public partial class FrmAddNewStudent : Form
    {
        private FrmStudents _frmStudent;

        public FrmAddNewStudent(FrmStudents frmStudent)
        {
            InitializeComponent();
            _frmStudent = frmStudent;
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

            string query = "SELECT studentId FROM studentInfoTbl WHERE studentId = @studentId " +
                           "UNION " +
                           "SELECT studentId FROM archiveTbl WHERE studentId = @studentId;";

            crud.AddParameters("@studentId", studentIdText.Text);

            DataTable result = crud.ReadData(query, true);

            if (result != null )
            {
                SystemSounds.Hand.Play();
                MessageBox.Show("Student ID already exist.", "STUDENT ID ALREADT EXIST", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                string insertQuery = "INSERT INTO studentinfotbl(studentId, fName, lName, mName, suffix, birthdate, age, gender, civilStatus, address, contactNumber, yearLevel) VALUES (@studentId,  @fName, @lName, @mName, @suffix, @birthday, @age, @gender, @civilStatus, @address, @contactNumber, @yearLevel);";

                crud.AddParameters("@studentId", studentIdText.Text, DbType.String); 
                crud.AddParameters("@fName", fNameText.Text, DbType.String); 
                crud.AddParameters("@lName", lNameText.Text, DbType.String); 
                crud.AddParameters("@mName", mNameText.Text, DbType.String); 
                crud.AddParameters("@suffix", suffixText.Text, DbType.String); 
                crud.AddParameters("@birthday", birthdayDateTimePicker.Value, DbType.Date); 
                crud.AddParameters("@age", ageNumeric.Value, DbType.String); 
                crud.AddParameters("@gender", genderComboBox.Text, DbType.String); 
                crud.AddParameters("@civilStatus", statusComboBox.Text, DbType.String); 
                crud.AddParameters("@address", addressText.Text, DbType.String); 
                crud.AddParameters("@contactNumber", contactNumberText.Text, DbType.String); 
                crud.AddParameters("@yearLevel", yearLevelComboBox.Text, DbType.String);


                bool isInsertSuccess = crud.ExecuteNonQuery(insertQuery, true);
                if (isInsertSuccess)
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Data successfully added.", "STUDENT ADDED", MessageBoxButtons.OK, MessageBoxIcon.Information);

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

        private void AddNewStudent_Load(object sender, EventArgs e)
        {
            formShadow.SetShadowForm(this);
          
        }

        private void birthdayDateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            DateTime birthday = birthdayDateTimePicker.Value;
            DateTime dateToday = DateTime.Today;

            int age = dateToday.Year - birthday.Year;

            if (birthday.Date > dateToday.AddYears(-age))
            {
                age--;
            }

            ageNumeric.Value = age;
        }

        private async void FrmAddNewStudent_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_frmStudent != null)
            {
                //await _frmStudent.RefreshDataSource();
            }
        }
    }
}
