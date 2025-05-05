namespace OCSSCESa
{
    partial class FrmGenerateCode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.dSStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSStudents = new OCSSCESa.DSStudents();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.windowLabel = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.loadingIndicator = new Guna.UI2.WinForms.Guna2Panel();
            this.renderLabel = new System.Windows.Forms.Label();
            this.yearLevel = new Guna.UI2.WinForms.Guna2ComboBox();
            this.course = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.clearParams = new Guna.UI2.WinForms.Guna2Button();
            this.generateCodeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.excelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.printBtn = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)(this.dSStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSStudents)).BeginInit();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.loadingIndicator.SuspendLayout();
            this.SuspendLayout();
            // 
            // dSStudentsBindingSource
            // 
            this.dSStudentsBindingSource.DataSource = this.dSStudents;
            this.dSStudentsBindingSource.Position = 0;
            // 
            // dSStudents
            // 
            this.dSStudents.DataSetName = "DSStudents";
            this.dSStudents.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "StudentList";
            reportDataSource1.Value = this.dSStudentsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OCSSCESa.RPTStudentList.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1115, 383);
            this.reportViewer1.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.windowLabel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(1115, 48);
            this.guna2Panel1.TabIndex = 14;
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 16;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.Maroon;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.guna2ControlBox1.Location = new System.Drawing.Point(1071, 8);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(32, 32);
            this.guna2ControlBox1.TabIndex = 16;
            // 
            // windowLabel
            // 
            this.windowLabel.AutoSize = true;
            this.windowLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.windowLabel.Location = new System.Drawing.Point(12, 8);
            this.windowLabel.Name = "windowLabel";
            this.windowLabel.Size = new System.Drawing.Size(230, 30);
            this.windowLabel.TabIndex = 15;
            this.windowLabel.Text = "Voting code generator";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.clearParams);
            this.guna2Panel2.Controls.Add(this.course);
            this.guna2Panel2.Controls.Add(this.yearLevel);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Controls.Add(this.label1);
            this.guna2Panel2.Controls.Add(this.generateCodeBtn);
            this.guna2Panel2.Controls.Add(this.excelBtn);
            this.guna2Panel2.Controls.Add(this.printBtn);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 48);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(1115, 57);
            this.guna2Panel2.TabIndex = 15;
            // 
            // loadingIndicator
            // 
            this.loadingIndicator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingIndicator.BorderRadius = 10;
            this.loadingIndicator.Controls.Add(this.renderLabel);
            this.loadingIndicator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loadingIndicator.Location = new System.Drawing.Point(435, 219);
            this.loadingIndicator.Name = "loadingIndicator";
            this.loadingIndicator.ShadowDecoration.Parent = this.loadingIndicator;
            this.loadingIndicator.Size = new System.Drawing.Size(244, 119);
            this.loadingIndicator.TabIndex = 16;
            this.loadingIndicator.Visible = false;
            // 
            // renderLabel
            // 
            this.renderLabel.AutoSize = true;
            this.renderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.renderLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renderLabel.Location = new System.Drawing.Point(31, 51);
            this.renderLabel.Name = "renderLabel";
            this.renderLabel.Size = new System.Drawing.Size(183, 17);
            this.renderLabel.TabIndex = 7;
            this.renderLabel.Text = "Generating  code. Please wait.";
            // 
            // yearLevel
            // 
            this.yearLevel.BackColor = System.Drawing.Color.Transparent;
            this.yearLevel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.yearLevel.BorderRadius = 8;
            this.yearLevel.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.yearLevel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearLevel.FillColor = System.Drawing.Color.WhiteSmoke;
            this.yearLevel.FocusedColor = System.Drawing.Color.Empty;
            this.yearLevel.FocusedState.Parent = this.yearLevel;
            this.yearLevel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yearLevel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.yearLevel.FormattingEnabled = true;
            this.yearLevel.HoverState.Parent = this.yearLevel;
            this.yearLevel.ItemHeight = 30;
            this.yearLevel.Items.AddRange(new object[] {
            "1st Year",
            "2nd Year",
            "3rd Year",
            "4th Year"});
            this.yearLevel.ItemsAppearance.Parent = this.yearLevel;
            this.yearLevel.Location = new System.Drawing.Point(12, 19);
            this.yearLevel.Name = "yearLevel";
            this.yearLevel.ShadowDecoration.Parent = this.yearLevel;
            this.yearLevel.Size = new System.Drawing.Size(187, 36);
            this.yearLevel.TabIndex = 16;
            // 
            // course
            // 
            this.course.BackColor = System.Drawing.Color.Transparent;
            this.course.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.course.BorderRadius = 8;
            this.course.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.course.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.course.FillColor = System.Drawing.Color.WhiteSmoke;
            this.course.FocusedColor = System.Drawing.Color.Empty;
            this.course.FocusedState.Parent = this.course;
            this.course.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.course.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.course.FormattingEnabled = true;
            this.course.HoverState.Parent = this.course;
            this.course.ItemHeight = 30;
            this.course.ItemsAppearance.Parent = this.course;
            this.course.Location = new System.Drawing.Point(205, 19);
            this.course.Name = "course";
            this.course.ShadowDecoration.Parent = this.course;
            this.course.Size = new System.Drawing.Size(347, 36);
            this.course.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(8, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 19);
            this.label1.TabIndex = 17;
            this.label1.Text = "Year level";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label2.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(201, 3);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 17;
            this.label2.Text = "Course";
            // 
            // clearParams
            // 
            this.clearParams.BackColor = System.Drawing.Color.Transparent;
            this.clearParams.BorderRadius = 5;
            this.clearParams.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.clearParams.CheckedState.Parent = this.clearParams;
            this.clearParams.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clearParams.CustomImages.Parent = this.clearParams;
            this.clearParams.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.clearParams.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearParams.ForeColor = System.Drawing.Color.White;
            this.clearParams.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.clearParams.HoverState.Parent = this.clearParams;
            this.clearParams.Image = global::OCSSCESa.Properties.Resources.icons8_close_32px;
            this.clearParams.ImageOffset = new System.Drawing.Point(1, 0);
            this.clearParams.ImageSize = new System.Drawing.Size(30, 30);
            this.clearParams.Location = new System.Drawing.Point(558, 19);
            this.clearParams.Name = "clearParams";
            this.clearParams.ShadowDecoration.Parent = this.clearParams;
            this.clearParams.Size = new System.Drawing.Size(35, 35);
            this.clearParams.TabIndex = 19;
            this.clearParams.UseTransparentBackground = true;
            this.clearParams.Click += new System.EventHandler(this.clearParams_Click);
            // 
            // generateCodeBtn
            // 
            this.generateCodeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.generateCodeBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.generateCodeBtn.CheckedState.Parent = this.generateCodeBtn;
            this.generateCodeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateCodeBtn.CustomImages.Parent = this.generateCodeBtn;
            this.generateCodeBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.generateCodeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.generateCodeBtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateCodeBtn.ForeColor = System.Drawing.Color.White;
            this.generateCodeBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.generateCodeBtn.HoverState.Parent = this.generateCodeBtn;
            this.generateCodeBtn.Image = global::OCSSCESa.Properties.Resources.icons8_available_updates_96px_1;
            this.generateCodeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.generateCodeBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.generateCodeBtn.Location = new System.Drawing.Point(683, 0);
            this.generateCodeBtn.Name = "generateCodeBtn";
            this.generateCodeBtn.ShadowDecoration.Parent = this.generateCodeBtn;
            this.generateCodeBtn.Size = new System.Drawing.Size(144, 57);
            this.generateCodeBtn.TabIndex = 13;
            this.generateCodeBtn.Text = "Generate";
            this.generateCodeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.generateCodeBtn.Click += new System.EventHandler(this.generateCodeBtn_Click);
            // 
            // excelBtn
            // 
            this.excelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.excelBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.excelBtn.CheckedState.Parent = this.excelBtn;
            this.excelBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.excelBtn.CustomImages.Parent = this.excelBtn;
            this.excelBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.excelBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.excelBtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excelBtn.ForeColor = System.Drawing.Color.White;
            this.excelBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.excelBtn.HoverState.Parent = this.excelBtn;
            this.excelBtn.Image = global::OCSSCESa.Properties.Resources.icons8_microsoft_excel_96px;
            this.excelBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.excelBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.excelBtn.Location = new System.Drawing.Point(827, 0);
            this.excelBtn.Name = "excelBtn";
            this.excelBtn.ShadowDecoration.Parent = this.excelBtn;
            this.excelBtn.Size = new System.Drawing.Size(144, 57);
            this.excelBtn.TabIndex = 15;
            this.excelBtn.Text = "Excel";
            this.excelBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.excelBtn.Click += new System.EventHandler(this.excelBtn_Click);
            // 
            // printBtn
            // 
            this.printBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.printBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.printBtn.CheckedState.Parent = this.printBtn;
            this.printBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBtn.CustomImages.Parent = this.printBtn;
            this.printBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.printBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.printBtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBtn.ForeColor = System.Drawing.Color.White;
            this.printBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.printBtn.HoverState.Parent = this.printBtn;
            this.printBtn.Image = global::OCSSCESa.Properties.Resources.icons8_print_64px;
            this.printBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.printBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.printBtn.Location = new System.Drawing.Point(971, 0);
            this.printBtn.Name = "printBtn";
            this.printBtn.ShadowDecoration.Parent = this.printBtn;
            this.printBtn.Size = new System.Drawing.Size(144, 57);
            this.printBtn.TabIndex = 14;
            this.printBtn.Text = "Print";
            this.printBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // FrmGenerateCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1115, 488);
            this.Controls.Add(this.loadingIndicator);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmGenerateCode";
            this.Text = "FrmGenerateCode";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmGenerateCode_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dSStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSStudents)).EndInit();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.loadingIndicator.ResumeLayout(false);
            this.loadingIndicator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource dSStudentsBindingSource;
        private DSStudents dSStudents;
        private Guna.UI2.WinForms.Guna2Button generateCodeBtn;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label windowLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button excelBtn;
        private Guna.UI2.WinForms.Guna2Button printBtn;
        private Guna.UI2.WinForms.Guna2Panel loadingIndicator;
        private System.Windows.Forms.Label renderLabel;
        private Guna.UI2.WinForms.Guna2ComboBox course;
        private Guna.UI2.WinForms.Guna2ComboBox yearLevel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button clearParams;
    }
}