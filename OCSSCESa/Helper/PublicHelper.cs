using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Media;
using System.Drawing;

namespace OCSSCESa.Helper
{
    public class PublicHelper
    {

       // Display data to Data grid

        public void DisplayData(Guna2DataGridView dataGridView, DataTable dataSource, List<String> columnNames)
        { 
            try
            {
                if (dataSource != null && dataSource.Rows.Count > 0)
                {
                    dataGridView.DataSource = dataSource;

                    if (columnNames != null && columnNames.Count == dataSource.Columns.Count)
                    {

                        int columnIndex = 0;

                        foreach (DataColumn column in dataSource.Columns)
                        {
                            dataGridView.Columns[column.ColumnName].HeaderText = columnNames[columnIndex];

                            columnIndex++;
                        }
                    }
                    else
                    {
                        SystemSounds.Hand.Play();
                        MessageBox.Show("Column names list does not match the number of columns in the DataTable.", "COLUMN COUNT NOT MATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    SystemSounds.Asterisk.Play();
                    MessageBox.Show("No data found.", "NO DATA FOUND", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                }
                
            }
            catch (Exception ex) 
            {
                SystemSounds.Hand.Play();
                MessageBox.Show($"Error occur while displaying data. Error: {ex.Message}", "DATA FAILED TO DISPLAY", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void ClearTextBox(Form frm)
        {
            try
            {
               ClearControlRecursive(frm);
            }
            catch (Exception ex)
            {
                SystemSounds.Hand.Play();
                MessageBox.Show($"An error occur while clear controls. Error: {ex}", "CONTROLS FAILED TO CLEAR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ClearControlRecursive(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is Guna2TextBox)
                {
                    Guna2TextBox textBox = (Guna2TextBox)ctrl;
                    textBox.Clear();
                }
                else if (ctrl is Guna2ComboBox)
                {
                    Guna2ComboBox comboBox = (Guna2ComboBox)ctrl;
                    comboBox.SelectedIndex = -1;
                }

                if (ctrl.HasChildren)
                {
                    ClearControlRecursive(ctrl);
                }
            }
        }


        public Boolean ValidateControls(Form frm, List<String> exceptionControl)
        {
            bool isValid = true;

            foreach (Control control in frm.Controls)
            {
                if (exceptionControl != null && exceptionControl.Contains(control.Name))
                {
                    continue;
                }

                if (control is Guna2TextBox)
                {
                    Guna2TextBox txt = (Guna2TextBox)control;
                    if (String.IsNullOrEmpty(txt.Text))
                    {
                        isValid = false;
                        break;
                    }
                   
                }
                else if (control is Guna2ComboBox)
                {
                    Guna2ComboBox comboBox = (Guna2ComboBox)control;
                    if (comboBox.SelectedIndex == -1)
                    {
                        isValid = false;
                        break;
                    }
                }
                else if (control is Guna2DateTimePicker )
                {
                    Guna2DateTimePicker dateTimePicker = (Guna2DateTimePicker)control;
                    if (dateTimePicker.Value == DateTime.Now)
                    {
                        isValid = false;
                        break;
                    }
                }
            }

            return isValid;
            

        }

    }

    public class Styling
    {
        public Color primaryColor = Color.WhiteSmoke;
        public Color secondaryColor = Color.FromArgb(44, 62, 80);
        public Color accentColors = Color.Maroon;
        public Color primaryTextColor1 = Color.FromArgb(51, 51, 51);
        public Color primaryTextColor2 = Color.FromArgb(51, 51, 51);
        public Color secondaryText1 = Color.FromArgb(44, 62, 80);
        public Color secondaryText2 = Color.FromArgb(52, 73, 94);
        public Color accentText1 = Color.FromArgb(128, 0, 0);
        public Color accentText2 = Color.FromArgb(139, 0, 0);


        public void DataGridViewStyle(Guna2DataGridView dataGrid)
        {
            dataGrid.ColumnHeadersDefaultCellStyle.Font = new Font("Bookman Old Style", 12, FontStyle.Bold);
            dataGrid.ColumnHeadersDefaultCellStyle.WrapMode = DataGridViewTriState.False;
            dataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGrid.RowsDefaultCellStyle.Font = new Font("Bookman Old Style", 12, FontStyle.Regular);
            dataGrid.ThemeStyle.HeaderStyle.Height = 40;

        }
    }
}
