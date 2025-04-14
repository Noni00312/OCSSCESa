namespace OCSSCESa
{
    partial class FrmAddUser
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
            this.userPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.userImagePath = new Guna.UI2.WinForms.Guna2TextBox();
            this.saveButton = new Guna.UI2.WinForms.Guna2Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.browseImage = new Guna.UI2.WinForms.Guna2Button();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.windowLabel = new System.Windows.Forms.Label();
            this.formShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.fullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.userId = new Guna.UI2.WinForms.Guna2TextBox();
            this.userName = new Guna.UI2.WinForms.Guna2TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.userPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // formDragControl
            // 
            this.formDragControl.TargetControl = null;
            // 
            // userPicture
            // 
            this.userPicture.Location = new System.Drawing.Point(492, 82);
            this.userPicture.Name = "userPicture";
            this.userPicture.ShadowDecoration.Parent = this.userPicture;
            this.userPicture.Size = new System.Drawing.Size(135, 126);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicture.TabIndex = 35;
            this.userPicture.TabStop = false;
            // 
            // userImagePath
            // 
            this.userImagePath.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userImagePath.BorderRadius = 8;
            this.userImagePath.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userImagePath.DefaultText = "";
            this.userImagePath.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userImagePath.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userImagePath.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userImagePath.DisabledState.Parent = this.userImagePath;
            this.userImagePath.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userImagePath.FillColor = System.Drawing.Color.WhiteSmoke;
            this.userImagePath.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.userImagePath.FocusedState.Parent = this.userImagePath;
            this.userImagePath.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userImagePath.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.userImagePath.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.userImagePath.HoverState.Parent = this.userImagePath;
            this.userImagePath.Location = new System.Drawing.Point(39, 229);
            this.userImagePath.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.userImagePath.Name = "userImagePath";
            this.userImagePath.PasswordChar = '\0';
            this.userImagePath.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.userImagePath.PlaceholderText = "File Path";
            this.userImagePath.ReadOnly = true;
            this.userImagePath.SelectedText = "";
            this.userImagePath.ShadowDecoration.Parent = this.userImagePath;
            this.userImagePath.Size = new System.Drawing.Size(449, 36);
            this.userImagePath.TabIndex = 34;
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
            this.saveButton.Location = new System.Drawing.Point(37, 289);
            this.saveButton.Name = "saveButton";
            this.saveButton.ShadowDecoration.Parent = this.saveButton;
            this.saveButton.Size = new System.Drawing.Size(590, 53);
            this.saveButton.TabIndex = 5;
            this.saveButton.Text = "Save";
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(315, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 23);
            this.label2.TabIndex = 31;
            this.label2.Text = "ID number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 23);
            this.label1.TabIndex = 32;
            this.label1.Text = "Full name";
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
            this.browseImage.Location = new System.Drawing.Point(492, 229);
            this.browseImage.Name = "browseImage";
            this.browseImage.ShadowDecoration.Parent = this.browseImage;
            this.browseImage.Size = new System.Drawing.Size(135, 36);
            this.browseImage.TabIndex = 4;
            this.browseImage.Text = "Browse";
            this.browseImage.UseTransparentBackground = true;
            this.browseImage.Click += new System.EventHandler(this.browseImage_Click);
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(616, 18);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(32, 32);
            this.guna2ControlBox1.TabIndex = 26;
            // 
            // windowLabel
            // 
            this.windowLabel.AutoSize = true;
            this.windowLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.windowLabel.Location = new System.Drawing.Point(12, 19);
            this.windowLabel.Name = "windowLabel";
            this.windowLabel.Size = new System.Drawing.Size(144, 30);
            this.windowLabel.TabIndex = 25;
            this.windowLabel.Text = "Add new user";
            // 
            // fullName
            // 
            this.fullName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fullName.BorderRadius = 8;
            this.fullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullName.DefaultText = "";
            this.fullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.fullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.fullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullName.DisabledState.Parent = this.fullName;
            this.fullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.fullName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.fullName.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.fullName.FocusedState.Parent = this.fullName;
            this.fullName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.fullName.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.fullName.HoverState.Parent = this.fullName;
            this.fullName.Location = new System.Drawing.Point(37, 82);
            this.fullName.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.fullName.Name = "fullName";
            this.fullName.PasswordChar = '\0';
            this.fullName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.fullName.PlaceholderText = "Full name";
            this.fullName.SelectedText = "";
            this.fullName.ShadowDecoration.Parent = this.fullName;
            this.fullName.Size = new System.Drawing.Size(276, 36);
            this.fullName.TabIndex = 0;
            // 
            // userId
            // 
            this.userId.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userId.BorderRadius = 8;
            this.userId.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userId.DefaultText = "";
            this.userId.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userId.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userId.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userId.DisabledState.Parent = this.userId;
            this.userId.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userId.FillColor = System.Drawing.Color.WhiteSmoke;
            this.userId.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.userId.FocusedState.Parent = this.userId;
            this.userId.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userId.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.userId.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.userId.HoverState.Parent = this.userId;
            this.userId.Location = new System.Drawing.Point(319, 82);
            this.userId.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.userId.Name = "userId";
            this.userId.PasswordChar = '\0';
            this.userId.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.userId.PlaceholderText = "ID number";
            this.userId.SelectedText = "";
            this.userId.ShadowDecoration.Parent = this.userId;
            this.userId.Size = new System.Drawing.Size(167, 36);
            this.userId.TabIndex = 1;
            // 
            // userName
            // 
            this.userName.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userName.BorderRadius = 8;
            this.userName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userName.DefaultText = "";
            this.userName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userName.DisabledState.Parent = this.userName;
            this.userName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userName.FillColor = System.Drawing.Color.WhiteSmoke;
            this.userName.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.userName.FocusedState.Parent = this.userName;
            this.userName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.userName.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.userName.HoverState.Parent = this.userName;
            this.userName.Location = new System.Drawing.Point(37, 155);
            this.userName.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.userName.Name = "userName";
            this.userName.PasswordChar = '\0';
            this.userName.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.userName.PlaceholderText = "Enter your username here";
            this.userName.SelectedText = "";
            this.userName.ShadowDecoration.Parent = this.userName;
            this.userName.Size = new System.Drawing.Size(220, 36);
            this.userName.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 23);
            this.label3.TabIndex = 32;
            this.label3.Text = "Username";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(262, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 23);
            this.label4.TabIndex = 32;
            this.label4.Text = "Password";
            // 
            // userPassword
            // 
            this.userPassword.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.userPassword.BorderRadius = 8;
            this.userPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.userPassword.DefaultText = "";
            this.userPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.userPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.userPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userPassword.DisabledState.Parent = this.userPassword;
            this.userPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.userPassword.FillColor = System.Drawing.Color.WhiteSmoke;
            this.userPassword.FocusedState.BorderColor = System.Drawing.Color.LightCoral;
            this.userPassword.FocusedState.Parent = this.userPassword;
            this.userPassword.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.userPassword.HoverState.BorderColor = System.Drawing.Color.LightCoral;
            this.userPassword.HoverState.Parent = this.userPassword;
            this.userPassword.Location = new System.Drawing.Point(266, 155);
            this.userPassword.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.userPassword.Name = "userPassword";
            this.userPassword.PasswordChar = '\0';
            this.userPassword.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.userPassword.PlaceholderText = "Password";
            this.userPassword.SelectedText = "";
            this.userPassword.ShadowDecoration.Parent = this.userPassword;
            this.userPassword.Size = new System.Drawing.Size(220, 36);
            this.userPassword.TabIndex = 3;
            this.userPassword.UseSystemPasswordChar = true;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Poppins SemiBold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 23);
            this.label5.TabIndex = 32;
            this.label5.Text = "Full name";
            // 
            // FrmAddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(660, 380);
            this.Controls.Add(this.userPicture);
            this.Controls.Add(this.userId);
            this.Controls.Add(this.userPassword);
            this.Controls.Add(this.userName);
            this.Controls.Add(this.fullName);
            this.Controls.Add(this.userImagePath);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.browseImage);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.windowLabel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmAddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmAddUser";
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2DragControl formDragControl;
        private Guna.UI2.WinForms.Guna2PictureBox userPicture;
        private Guna.UI2.WinForms.Guna2TextBox userImagePath;
        private Guna.UI2.WinForms.Guna2Button saveButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button browseImage;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label windowLabel;
        private Guna.UI2.WinForms.Guna2ShadowForm formShadow;
        private Guna.UI2.WinForms.Guna2TextBox fullName;
        private Guna.UI2.WinForms.Guna2TextBox userId;
        private Guna.UI2.WinForms.Guna2TextBox userName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI2.WinForms.Guna2TextBox userPassword;
        private System.Windows.Forms.Label label5;
    }
}