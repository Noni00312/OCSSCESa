using OCSSCESa.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OCSSCESa
{
    public partial class FrmEditStudentData : Form
    {
        private FrmStudents _frmStudent;
        private bool dataUpdated = false;

        private string _studentId;
        private string _fName;
        private string _mName;
        private string _lName;
        private string _suffix;
        private string _birthday;
        private string _age;
        private string _gender;
        private string _civilStatus;
        private string _yearLevel;
        private string _contactNumber;
        private string _address;


        public FrmEditStudentData(string studentId, string fName, string mName, string lName, string suffix, string birthday, string age, string gender, string civilStatus, string yearLevel, string contactNumber, string address, FrmStudents frmStudent)
        {
            InitializeComponent();
            _frmStudent = frmStudent;
            try 
            {
                string[] formats = { "yyyy-MM-dd", "MM/dd/yyyy", "dd-MM-yyyy", "M/d/yyyy", "d/M/yyyy" };

                if (DateTime.TryParseExact(birthday, formats, CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime parsedDate))
                {
                    birthdayDateTimePicker.Value = parsedDate;
                }
                else
                {
                    MessageBox.Show($"Invalid date format: {birthday}. Expected formats: yyyy-MM-dd, MM/dd/yyyy, or dd-MM-yyyy");
                    birthdayDateTimePicker.Value = DateTime.Today;
                }

                int cs;

                int yl;

                if (civilStatus == "Single")
                {
                    cs = 0;
                }
                else if (civilStatus == "Married")
                {
                    cs = 1;
                }else
                {
                    cs = 2;
                }

                if (yearLevel == "1st Year")
                {
                    yl = 0;
                }
                else if (yearLevel == "2nd Year")
                {
                    yl = 1;
                }else if(yearLevel == "3rd Year")
                {
                    yl = 2;
                }
                else
                {
                    yl = 3;
                }



                studentIdText.Text = studentId;
                fNameText.Text = fName;
                mNameText.Text = mName;
                lNameText.Text = lName;
                suffixText.Text = suffix;
                ageNumeric.Value = Convert.ToInt32(age);
                genderComboBox.SelectedIndex = (gender == "Male") ? 0 : 1;
                statusComboBox.SelectedIndex = cs;
                yearLevelComboBox.SelectedIndex = yl;
                contactNumberText.Text = contactNumber;
                addressText.Text = address;
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }

        private void FrmEditStudentData_Load(object sender, EventArgs e)
        {
            formShadow.SetShadowForm(this);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            CRUD crud = new CRUD();
            //PublicHelper helper = new PublicHelper();
            //bool isValid = helper.ValidateControls(this);

            //if (!isValid)
            //{
            //    SystemSounds.Hand.Play();
            //    MessageBox.Show("Please fill all required fields.", "ALL FIELDS ARE REQUIRED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    return;
            //}

            try
            {
                string updateQuery = @"UPDATE studentInfoTbl 
                          SET fName = @fName,
                              lName = @lName,
                              mName = @mName,
                              suffix = @suffix,
                              birthdate = @birthday,
                              age = @age,
                              gender = @gender,
                              civilStatus = @civilStatus,
                              address = @address,
                              contactNumber = @contactNumber,
                              yearLevel = @yearLevel
                          WHERE studentId = @studentId";

                // Add parameters (same as your insert but with WHERE clause)
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

                bool isUpdateSuccess = crud.ExecuteNonQuery(updateQuery, true);

                if (isUpdateSuccess)
                {
                    dataUpdated = true;
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("Data successfully updated.", "STUDENT UPDATED", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    dataUpdated = false;
                    SystemSounds.Hand.Play();
                    MessageBox.Show("No records were updated. Student ID may not exist.", "UPDATE FAILED", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {
                dataUpdated = false;
                SystemSounds.Hand.Play();
                MessageBox.Show($"Error: {ex.Message}", "UPDATE ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private async void FrmEditStudentData_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (_frmStudent != null && dataUpdated)
            {
                await _frmStudent.RefreshDataSource();
            }
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
    }
}
