namespace OCSSCESa
{
    partial class FrmResult
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.windowLabel = new System.Windows.Forms.Label();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.excelBtn = new Guna.UI2.WinForms.Guna2Button();
            this.printBtn = new Guna.UI2.WinForms.Guna2Button();
            this.generateCodeBtn = new Guna.UI2.WinForms.Guna2Button();
            this.dSStudents = new OCSSCESa.DSStudents();
            this.ResultBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dSStudentsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.resultBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.resultBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dSStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSStudentsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource2)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Controls.Add(this.windowLabel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(933, 48);
            this.guna2Panel1.TabIndex = 17;
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(889, 8);
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
            this.windowLabel.Size = new System.Drawing.Size(140, 30);
            this.windowLabel.TabIndex = 15;
            this.windowLabel.Text = "Result Viewer";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "OCSSCESa.Reports.RPTResult.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 105);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(933, 553);
            this.reportViewer1.TabIndex = 16;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.excelBtn);
            this.guna2Panel2.Controls.Add(this.printBtn);
            this.guna2Panel2.Controls.Add(this.generateCodeBtn);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel2.Location = new System.Drawing.Point(0, 48);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(933, 57);
            this.guna2Panel2.TabIndex = 18;
            // 
            // excelBtn
            // 
            this.excelBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.excelBtn.BorderRadius = 8;
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
            this.excelBtn.Location = new System.Drawing.Point(645, 0);
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
            this.printBtn.BorderRadius = 8;
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
            this.printBtn.Location = new System.Drawing.Point(789, 0);
            this.printBtn.Name = "printBtn";
            this.printBtn.ShadowDecoration.Parent = this.printBtn;
            this.printBtn.Size = new System.Drawing.Size(144, 57);
            this.printBtn.TabIndex = 14;
            this.printBtn.Text = "Print";
            this.printBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.printBtn.Click += new System.EventHandler(this.printBtn_Click);
            // 
            // generateCodeBtn
            // 
            this.generateCodeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.generateCodeBtn.BorderRadius = 8;
            this.generateCodeBtn.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.generateCodeBtn.CheckedState.Parent = this.generateCodeBtn;
            this.generateCodeBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.generateCodeBtn.CustomImages.Parent = this.generateCodeBtn;
            this.generateCodeBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.generateCodeBtn.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.generateCodeBtn.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generateCodeBtn.ForeColor = System.Drawing.Color.White;
            this.generateCodeBtn.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.generateCodeBtn.HoverState.Parent = this.generateCodeBtn;
            this.generateCodeBtn.Image = global::OCSSCESa.Properties.Resources.icons8_available_updates_96px_1;
            this.generateCodeBtn.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.generateCodeBtn.ImageSize = new System.Drawing.Size(30, 30);
            this.generateCodeBtn.Location = new System.Drawing.Point(0, 0);
            this.generateCodeBtn.Name = "generateCodeBtn";
            this.generateCodeBtn.ShadowDecoration.Parent = this.generateCodeBtn;
            this.generateCodeBtn.Size = new System.Drawing.Size(251, 57);
            this.generateCodeBtn.TabIndex = 13;
            this.generateCodeBtn.Text = "View Result";
            this.generateCodeBtn.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.generateCodeBtn.Click += new System.EventHandler(this.generateCodeBtn_Click);
            // 
            // dSStudents
            // 
            this.dSStudents.DataSetName = "DSStudents";
            this.dSStudents.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ResultBindingSource
            // 
            this.ResultBindingSource.DataMember = "Result";
            this.ResultBindingSource.DataSource = this.dSStudents;
            // 
            // dSStudentsBindingSource
            // 
            this.dSStudentsBindingSource.DataSource = this.dSStudents;
            this.dSStudentsBindingSource.Position = 0;
            // 
            // resultBindingSource1
            // 
            this.resultBindingSource1.DataMember = "Result";
            this.resultBindingSource1.DataSource = this.dSStudentsBindingSource;
            // 
            // resultBindingSource2
            // 
            this.resultBindingSource2.DataMember = "Result";
            this.resultBindingSource2.DataSource = this.dSStudents;
            // 
            // FrmResult
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(933, 658);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.guna2Panel1);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmResult";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmResult";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dSStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ResultBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dSStudentsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resultBindingSource2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label windowLabel;
        private DSStudents dSStudents;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2Button excelBtn;
        private Guna.UI2.WinForms.Guna2Button printBtn;
        private Guna.UI2.WinForms.Guna2Button generateCodeBtn;
        private System.Windows.Forms.BindingSource ResultBindingSource;
        private System.Windows.Forms.BindingSource resultBindingSource2;
        private System.Windows.Forms.BindingSource dSStudentsBindingSource;
        private System.Windows.Forms.BindingSource resultBindingSource1;
    }
}