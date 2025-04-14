using MathNet.Numerics.Distributions;
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
    public partial class FrmAddPosition : Form

    {
      
        public FrmAddPosition()
        {
            InitializeComponent();
        
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
           try
            {
               if(!String.IsNullOrEmpty(positionNameText.Text))
                {
                    CRUD crud = new CRUD();

                    string checkQuery = "SELECT positionName FROM positionTbl WHERE positionName = @positionName; LIMIT 1";

                    crud.AddParameters("@positionName", positionNameText.Text);

                    DataTable checkResult = crud.ReadData(checkQuery, true);

                    if (checkResult != null)
                    {
                        SystemSounds.Hand.Play();
                        MessageBox.Show("Position already exist.", "POSITION EXIST", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    string query = "INSERT INTO positionTbl(positionName) VALUES (@posName); ";

                    crud.AddParameters("@posName", positionNameText.Text);

                    bool result = crud.ExecuteNonQuery(query, true);

                    if(result)
                    {
                        positionNameText.Clear();
                        MessageBox.Show(crud.sqlParameters.Count.ToString());
                        SystemSounds.Asterisk.Play();
                        MessageBox.Show("Data successfully added.", "POSITION ADDED", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }else
                    {
                        SystemSounds.Hand.Play();
                        MessageBox.Show("Data failed to add.", "POSITION FAILED TO ADD", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } else
                {
                    SystemSounds.Hand.Play();
                    MessageBox.Show("Please fill position name first.", "POSITION NAME REQURED", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex){
                Console.WriteLine("Error INSERT POSITION: " + ex.Message);

            }
        }

        private void FrmAddPosition_Load(object sender, EventArgs e)
        {
            formShadow.SetShadowForm(this);
        }
    }
}
