namespace OCSSCESa
{
    partial class FrmCourses
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
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.windowLabel = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.courseName = new Guna.UI2.WinForms.Guna2TextBox();
            this.courseAbbreviation = new Guna.UI2.WinForms.Guna2TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.saveButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ShadowForm1 = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.guna2DragControl1 = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.SuspendLayout();
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(318, 12);
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
            this.windowLabel.Location = new System.Drawing.Point(12, 14);
            this.windowLabel.Name = "windowLabel";
            this.windowLabel.Size = new System.Drawing.Size(167, 30);
            this.windowLabel.TabIndex = 15;
            this.windowLabel.Text = "Add new course";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(13, 67);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 19);
            this.label10.TabIndex = 18;
            this.label10.Text = "Course name";
            // 
            // courseName
            // 
            this.courseName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.courseName.BorderRadius = 8;
            this.courseName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.courseName.DefaultText = "";
            this.courseName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.courseName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.courseName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.courseName.DisabledState.Parent = this.courseName;
            this.courseName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.courseName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.courseName.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.courseName.FocusedState.Parent = this.courseName;
            this.courseName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.courseName.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.courseName.HoverState.Parent = this.courseName;
            this.courseName.Location = new System.Drawing.Point(17, 87);
            this.courseName.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.courseName.Name = "courseName";
            this.courseName.PasswordChar = '\0';
            this.courseName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.courseName.PlaceholderText = "Bacherlor of Science ... ";
            this.courseName.SelectedText = "";
            this.courseName.ShadowDecoration.Parent = this.courseName;
            this.courseName.Size = new System.Drawing.Size(333, 42);
            this.courseName.TabIndex = 17;
            // 
            // courseAbbreviation
            // 
            this.courseAbbreviation.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.courseAbbreviation.BorderRadius = 8;
            this.courseAbbreviation.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.courseAbbreviation.DefaultText = "";
            this.courseAbbreviation.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.courseAbbreviation.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.courseAbbreviation.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.courseAbbreviation.DisabledState.Parent = this.courseAbbreviation;
            this.courseAbbreviation.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.courseAbbreviation.FillColor = System.Drawing.Color.WhiteSmoke;
            this.courseAbbreviation.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.courseAbbreviation.FocusedState.Parent = this.courseAbbreviation;
            this.courseAbbreviation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseAbbreviation.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.courseAbbreviation.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.courseAbbreviation.HoverState.Parent = this.courseAbbreviation;
            this.courseAbbreviation.Location = new System.Drawing.Point(17, 161);
            this.courseAbbreviation.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.courseAbbreviation.Name = "courseAbbreviation";
            this.courseAbbreviation.PasswordChar = '\0';
            this.courseAbbreviation.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.courseAbbreviation.PlaceholderText = "BSCS ...";
            this.courseAbbreviation.SelectedText = "";
            this.courseAbbreviation.ShadowDecoration.Parent = this.courseAbbreviation;
            this.courseAbbreviation.Size = new System.Drawing.Size(333, 42);
            this.courseAbbreviation.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 141);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Course abbreviation";
            // 
            // saveButton
            // 
            this.saveButton.BorderRadius = 8;
            this.saveButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.saveButton.CheckedState.Parent = this.saveButton;
            this.saveButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.saveButton.CustomImages.Parent = this.saveButton;
            this.saveButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.saveButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.White;
            this.saveButton.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.saveButton.HoverState.Parent = this.saveButton;
            this.saveButton.Image = global::OCSSCESa.Properties.Resources.icons8_save_96px;
            this.saveButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.saveButton.ImageSize = new System.Drawing.Size(30, 30);
            this.saveButton.Location = new System.Drawing.Point(17, 245);
            this.saveButton.Name = "saveButton";
            this.saveButton.ShadowDecoration.Parent = this.saveButton;
            this.saveButton.Size = new System.Drawing.Size(333, 53);
            this.saveButton.TabIndex = 19;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // guna2DragControl1
            // 
            this.guna2DragControl1.TargetControl = this;
            // 
            // FrmCourses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(362, 342);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.courseAbbreviation);
            this.Controls.Add(this.courseName);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.windowLabel);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmCourses";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmCourses";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmCourses_FormClosed);
            this.Load += new System.EventHandler(this.FrmCourses_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label windowLabel;
        private System.Windows.Forms.Label label10;
        private Guna.UI2.WinForms.Guna2TextBox courseName;
        private Guna.UI2.WinForms.Guna2TextBox courseAbbreviation;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button saveButton;
        private Guna.UI2.WinForms.Guna2ShadowForm guna2ShadowForm1;
        private Guna.UI2.WinForms.Guna2DragControl guna2DragControl1;
    }
}