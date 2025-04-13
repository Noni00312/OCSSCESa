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
    public partial class FrmManualOrImport : Form
    {
        private FrmStudents _frmStudents;

        public FrmManualOrImport(FrmStudents frmStudents)
        {
            InitializeComponent();
            _frmStudents = frmStudents;
        }

        private void manualButton_Click(object sender, EventArgs e)
        {
            FrmAddNewStudent frmAddNewStudent = new FrmAddNewStudent(_frmStudents);
            FrmStudents frmStudents = new FrmStudents();

            this.Dispose();
            frmAddNewStudent.ShowDialog(frmStudents);
        }

        private void FrmManualOrImport_Load(object sender, EventArgs e)
        {
            formShadow.SetShadowForm(this);
        }

        private void importExcelButton_Click(object sender, EventArgs e)
        {

            FrmImportExcel frmImportExcel = new FrmImportExcel();
            FrmStudents frmStudents = new FrmStudents();

            this.Dispose();
            frmImportExcel.ShowDialog(frmStudents);
        }
    }
}
