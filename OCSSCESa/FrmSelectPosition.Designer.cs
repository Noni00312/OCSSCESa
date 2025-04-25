namespace OCSSCESa
{
    partial class FrmSelectPosition
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
            this.formDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.windowLabel = new System.Windows.Forms.Label();
            this.positionDropDown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.candidateImagePath = new Guna.UI2.WinForms.Guna2TextBox();
            this.browseImage = new Guna.UI2.WinForms.Guna2Button();
            this.candidatePicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.saveButton = new Guna.UI2.WinForms.Guna2Button();
            this.formShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.candidatePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // formDragControl
            // 
            this.formDragControl.TargetControl = this;
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(616, 8);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(32, 32);
            this.guna2ControlBox1.TabIndex = 18;
            this.guna2ControlBox1.Click += new System.EventHandler(this.guna2ControlBox1_Click);
            // 
            // windowLabel
            // 
            this.windowLabel.AutoSize = true;
            this.windowLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.windowLabel.Location = new System.Drawing.Point(12, 9);
            this.windowLabel.Name = "windowLabel";
            this.windowLabel.Size = new System.Drawing.Size(153, 30);
            this.windowLabel.TabIndex = 17;
            this.windowLabel.Text = "Select position";
            // 
            // positionDropDown
            // 
            this.positionDropDown.BackColor = System.Drawing.Color.Transparent;
            this.positionDropDown.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.positionDropDown.BorderRadius = 8;
            this.positionDropDown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.positionDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.positionDropDown.FillColor = System.Drawing.Color.WhiteSmoke;
            this.positionDropDown.FocusedColor = System.Drawing.Color.Empty;
            this.positionDropDown.FocusedState.Parent = this.positionDropDown;
            this.positionDropDown.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.positionDropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.positionDropDown.FormattingEnabled = true;
            this.positionDropDown.HoverState.Parent = this.positionDropDown;
            this.positionDropDown.ItemHeight = 30;
            this.positionDropDown.ItemsAppearance.Parent = this.positionDropDown;
            this.positionDropDown.Location = new System.Drawing.Point(37, 239);
            this.positionDropDown.Name = "positionDropDown";
            this.positionDropDown.ShadowDecoration.Parent = this.positionDropDown;
            this.positionDropDown.Size = new System.Drawing.Size(590, 36);
            this.positionDropDown.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(107, 23);
            this.label1.TabIndex = 21;
            this.label1.Text = "Student Name";
            // 
            // studentNameLabel
            // 
            this.studentNameLabel.AutoEllipsis = true;
            this.studentNameLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameLabel.Location = new System.Drawing.Point(55, 73);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(422, 28);
            this.studentNameLabel.TabIndex = 21;
            this.studentNameLabel.Text = "Student Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 23);
            this.label2.TabIndex = 21;
            this.label2.Text = "Student ID";
            // 
            // studentIdLabel
            // 
            this.studentIdLabel.AutoEllipsis = true;
            this.studentIdLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdLabel.Location = new System.Drawing.Point(55, 122);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(422, 28);
            this.studentIdLabel.TabIndex = 21;
            this.studentIdLabel.Text = "Student Name";
            // 
            // candidateImagePath
            // 
            this.candidateImagePath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.candidateImagePath.BorderRadius = 8;
            this.candidateImagePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.candidateImagePath.DefaultText = "";
            this.candidateImagePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.candidateImagePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.candidateImagePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.candidateImagePath.DisabledState.Parent = this.candidateImagePath;
            this.candidateImagePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.candidateImagePath.FillColor = System.Drawing.Color.WhiteSmoke;
            this.candidateImagePath.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.candidateImagePath.FocusedState.Parent = this.candidateImagePath;
            this.candidateImagePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidateImagePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.candidateImagePath.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.candidateImagePath.HoverState.Parent = this.candidateImagePath;
            this.candidateImagePath.Location = new System.Drawing.Point(37, 188);
            this.candidateImagePath.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.candidateImagePath.Name = "candidateImagePath";
            this.candidateImagePath.PasswordChar = '\0';
            this.candidateImagePath.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.candidateImagePath.PlaceholderText = "File Path";
            this.candidateImagePath.ReadOnly = true;
            this.candidateImagePath.SelectedText = "";
            this.candidateImagePath.ShadowDecoration.Parent = this.candidateImagePath;
            this.candidateImagePath.Size = new System.Drawing.Size(449, 36);
            this.candidateImagePath.TabIndex = 23;
            // 
            // browseImage
            // 
            this.browseImage.BackColor = System.Drawing.Color.Transparent;
            this.browseImage.BorderRadius = 5;
            this.browseImage.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.browseImage.CheckedState.Parent = this.browseImage;
            this.browseImage.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseImage.CustomImages.Parent = this.browseImage;
            this.browseImage.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.browseImage.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseImage.ForeColor = System.Drawing.Color.White;
            this.browseImage.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.browseImage.HoverState.Parent = this.browseImage;
            this.browseImage.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.browseImage.ImageSize = new System.Drawing.Size(30, 30);
            this.browseImage.Location = new System.Drawing.Point(492, 188);
            this.browseImage.Name = "browseImage";
            this.browseImage.ShadowDecoration.Parent = this.browseImage;
            this.browseImage.Size = new System.Drawing.Size(135, 36);
            this.browseImage.TabIndex = 20;
            this.browseImage.Text = "Browse";
            this.browseImage.UseTransparentBackground = true;
            this.browseImage.Click += new System.EventHandler(this.browseImage_Click);
            // 
            // candidatePicture
            // 
            this.candidatePicture.Location = new System.Drawing.Point(492, 46);
            this.candidatePicture.Name = "candidatePicture";
            this.candidatePicture.ShadowDecoration.Parent = this.candidatePicture;
            this.candidatePicture.Size = new System.Drawing.Size(135, 126);
            this.candidatePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.candidatePicture.TabIndex = 24;
            this.candidatePicture.TabStop = false;
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
            this.saveButton.Location = new System.Drawing.Point(37, 305);
            this.saveButton.Name = "saveButton";
            this.saveButton.ShadowDecoration.Parent = this.saveButton;
            this.saveButton.Size = new System.Drawing.Size(590, 53);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // FrmSelectPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(660, 386);
            this.Controls.Add(this.candidatePicture);
            this.Controls.Add(this.candidateImagePath);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.studentIdLabel);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseImage);
            this.Controls.Add(this.positionDropDown);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.windowLabel);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmSelectPosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSelectPosition";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmSelectPosition_FormClosed);
            this.Load += new System.EventHandler(this.FrmSelectPosition_Load);
            ((System.ComponentModel.ISupportInitialize)(this.candidatePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2DragControl formDragControl;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label windowLabel;
        private Guna.UI2.WinForms.Guna2ComboBox positionDropDown;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label studentIdLabel;
        private Guna.UI2.WinForms.Guna2Button saveButton;
        private Guna.UI2.WinForms.Guna2TextBox candidateImagePath;
        private Guna.UI2.WinForms.Guna2Button browseImage;
        private Guna.UI2.WinForms.Guna2PictureBox candidatePicture;
        private Guna.UI2.WinForms.Guna2ShadowForm formShadow;
    }
}