namespace OCSSCESa
{
    partial class FrmMain
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
            this.sidebarPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.resultsButton = new Guna.UI2.WinForms.Guna2Button();
            this.usersButton = new Guna.UI2.WinForms.Guna2Button();
            this.candidatesButton = new Guna.UI2.WinForms.Guna2Button();
            this.studentButton = new Guna.UI2.WinForms.Guna2Button();
            this.dashboardButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.userPicture = new Guna.UI2.WinForms.Guna2PictureBox();
            this.dropdown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.windowLabel = new System.Windows.Forms.Label();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnGenerate = new Guna.UI2.WinForms.Guna2Button();
            this.sidebarPanel.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).BeginInit();
            this.SuspendLayout();
            // 
            // sidebarPanel
            // 
            this.sidebarPanel.Controls.Add(this.resultsButton);
            this.sidebarPanel.Controls.Add(this.btnGenerate);
            this.sidebarPanel.Controls.Add(this.usersButton);
            this.sidebarPanel.Controls.Add(this.candidatesButton);
            this.sidebarPanel.Controls.Add(this.studentButton);
            this.sidebarPanel.Controls.Add(this.dashboardButton);
            this.sidebarPanel.Controls.Add(this.guna2Panel3);
            this.sidebarPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidebarPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.sidebarPanel.Location = new System.Drawing.Point(0, 0);
            this.sidebarPanel.Name = "sidebarPanel";
            this.sidebarPanel.ShadowDecoration.Parent = this.sidebarPanel;
            this.sidebarPanel.Size = new System.Drawing.Size(260, 589);
            this.sidebarPanel.TabIndex = 0;
            // 
            // resultsButton
            // 
            this.resultsButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.resultsButton.CheckedState.Parent = this.resultsButton;
            this.resultsButton.CustomImages.Parent = this.resultsButton;
            this.resultsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.resultsButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.resultsButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultsButton.ForeColor = System.Drawing.Color.White;
            this.resultsButton.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.resultsButton.HoverState.Parent = this.resultsButton;
            this.resultsButton.Image = global::OCSSCESa.Properties.Resources.icons8_print_64px;
            this.resultsButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.resultsButton.ImageSize = new System.Drawing.Size(32, 32);
            this.resultsButton.Location = new System.Drawing.Point(0, 357);
            this.resultsButton.Name = "resultsButton";
            this.resultsButton.ShadowDecoration.Parent = this.resultsButton;
            this.resultsButton.Size = new System.Drawing.Size(260, 53);
            this.resultsButton.TabIndex = 5;
            this.resultsButton.Text = "Results";
            this.resultsButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.resultsButton.TextOffset = new System.Drawing.Point(3, 0);
            this.resultsButton.Click += new System.EventHandler(this.resultsButton_Click);
            // 
            // usersButton
            // 
            this.usersButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.usersButton.CheckedState.Parent = this.usersButton;
            this.usersButton.CustomImages.Parent = this.usersButton;
            this.usersButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.usersButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.usersButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.ForeColor = System.Drawing.Color.White;
            this.usersButton.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.usersButton.HoverState.Parent = this.usersButton;
            this.usersButton.Image = global::OCSSCESa.Properties.Resources.icons8_user_64px;
            this.usersButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usersButton.ImageSize = new System.Drawing.Size(32, 32);
            this.usersButton.Location = new System.Drawing.Point(0, 251);
            this.usersButton.Name = "usersButton";
            this.usersButton.ShadowDecoration.Parent = this.usersButton;
            this.usersButton.Size = new System.Drawing.Size(260, 53);
            this.usersButton.TabIndex = 4;
            this.usersButton.Text = "Users";
            this.usersButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.usersButton.TextOffset = new System.Drawing.Point(3, 0);
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // candidatesButton
            // 
            this.candidatesButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.candidatesButton.CheckedState.Parent = this.candidatesButton;
            this.candidatesButton.CustomImages.Parent = this.candidatesButton;
            this.candidatesButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.candidatesButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.candidatesButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.candidatesButton.ForeColor = System.Drawing.Color.White;
            this.candidatesButton.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.candidatesButton.HoverState.Parent = this.candidatesButton;
            this.candidatesButton.Image = global::OCSSCESa.Properties.Resources.icons8_education_64px;
            this.candidatesButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.candidatesButton.ImageSize = new System.Drawing.Size(35, 35);
            this.candidatesButton.Location = new System.Drawing.Point(0, 198);
            this.candidatesButton.Name = "candidatesButton";
            this.candidatesButton.ShadowDecoration.Parent = this.candidatesButton;
            this.candidatesButton.Size = new System.Drawing.Size(260, 53);
            this.candidatesButton.TabIndex = 3;
            this.candidatesButton.Text = "Candidates";
            this.candidatesButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.candidatesButton.Click += new System.EventHandler(this.candidatesButton_Click);
            // 
            // studentButton
            // 
            this.studentButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.studentButton.CheckedState.Parent = this.studentButton;
            this.studentButton.CustomImages.Parent = this.studentButton;
            this.studentButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.studentButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.studentButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentButton.ForeColor = System.Drawing.Color.White;
            this.studentButton.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.studentButton.HoverState.Parent = this.studentButton;
            this.studentButton.Image = global::OCSSCESa.Properties.Resources.icons8_student_male_64px;
            this.studentButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.studentButton.ImageSize = new System.Drawing.Size(31, 31);
            this.studentButton.Location = new System.Drawing.Point(0, 145);
            this.studentButton.Name = "studentButton";
            this.studentButton.ShadowDecoration.Parent = this.studentButton;
            this.studentButton.Size = new System.Drawing.Size(260, 53);
            this.studentButton.TabIndex = 2;
            this.studentButton.Text = "Student";
            this.studentButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.studentButton.TextOffset = new System.Drawing.Point(4, 0);
            this.studentButton.Click += new System.EventHandler(this.studentButton_Click);
            // 
            // dashboardButton
            // 
            this.dashboardButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.dashboardButton.CheckedState.Parent = this.dashboardButton;
            this.dashboardButton.CustomImages.Parent = this.dashboardButton;
            this.dashboardButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.dashboardButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.dashboardButton.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashboardButton.ForeColor = System.Drawing.Color.White;
            this.dashboardButton.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.dashboardButton.HoverState.Parent = this.dashboardButton;
            this.dashboardButton.Image = global::OCSSCESa.Properties.Resources.icons8_dashboard_64px;
            this.dashboardButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboardButton.ImageSize = new System.Drawing.Size(30, 30);
            this.dashboardButton.Location = new System.Drawing.Point(0, 92);
            this.dashboardButton.Name = "dashboardButton";
            this.dashboardButton.ShadowDecoration.Parent = this.dashboardButton;
            this.dashboardButton.Size = new System.Drawing.Size(260, 53);
            this.dashboardButton.TabIndex = 1;
            this.dashboardButton.Text = "Dashboard";
            this.dashboardButton.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.dashboardButton.TextOffset = new System.Drawing.Point(4, 0);
            this.dashboardButton.Click += new System.EventHandler(this.dashboardButton_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel3.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(260, 92);
            this.guna2Panel3.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.guna2Panel2);
            this.guna2Panel1.Controls.Add(this.windowLabel);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.Location = new System.Drawing.Point(260, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Padding = new System.Windows.Forms.Padding(0, 8, 8, 0);
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(747, 92);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.userPicture);
            this.guna2Panel2.Controls.Add(this.dropdown);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel2.Location = new System.Drawing.Point(695, 8);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(44, 84);
            this.guna2Panel2.TabIndex = 4;
            // 
            // userPicture
            // 
            this.userPicture.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.userPicture.BorderRadius = 5;
            this.userPicture.Cursor = System.Windows.Forms.Cursors.Hand;
            this.userPicture.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(50)))), ((int)(((byte)(75)))));
            this.userPicture.Image = global::OCSSCESa.Properties.Resources.icons8_circled_user_male_skin_type_7_480px;
            this.userPicture.Location = new System.Drawing.Point(2, 0);
            this.userPicture.Name = "userPicture";
            this.userPicture.ShadowDecoration.Parent = this.userPicture;
            this.userPicture.Size = new System.Drawing.Size(42, 42);
            this.userPicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.userPicture.TabIndex = 4;
            this.userPicture.TabStop = false;
            this.userPicture.Click += new System.EventHandler(this.userPicture_Click_1);
            // 
            // dropdown
            // 
            this.dropdown.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.dropdown.BackColor = System.Drawing.Color.Transparent;
            this.dropdown.BorderColor = System.Drawing.Color.WhiteSmoke;
            this.dropdown.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.dropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.dropdown.FillColor = System.Drawing.Color.WhiteSmoke;
            this.dropdown.FocusedColor = System.Drawing.Color.Empty;
            this.dropdown.FocusedState.Parent = this.dropdown;
            this.dropdown.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.dropdown.FormattingEnabled = true;
            this.dropdown.HoverState.Parent = this.dropdown;
            this.dropdown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.dropdown.ItemHeight = 30;
            this.dropdown.Items.AddRange(new object[] {
            "My profile",
            "Logout"});
            this.dropdown.ItemsAppearance.Parent = this.dropdown;
            this.dropdown.Location = new System.Drawing.Point(-92, 9);
            this.dropdown.Name = "dropdown";
            this.dropdown.ShadowDecoration.Parent = this.dropdown;
            this.dropdown.Size = new System.Drawing.Size(134, 36);
            this.dropdown.TabIndex = 3;
            this.dropdown.SelectedIndexChanged += new System.EventHandler(this.dropdown_SelectedIndexChanged);
            // 
            // windowLabel
            // 
            this.windowLabel.AutoSize = true;
            this.windowLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.windowLabel.Location = new System.Drawing.Point(3, 61);
            this.windowLabel.Name = "windowLabel";
            this.windowLabel.Size = new System.Drawing.Size(118, 30);
            this.windowLabel.TabIndex = 3;
            this.windowLabel.Text = "Dashboard";
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(260, 92);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.ShadowDecoration.Parent = this.mainPanel;
            this.mainPanel.Size = new System.Drawing.Size(747, 497);
            this.mainPanel.TabIndex = 1;
            // 
            // btnGenerate
            // 
            this.btnGenerate.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.btnGenerate.CheckedState.Parent = this.btnGenerate;
            this.btnGenerate.CustomImages.Parent = this.btnGenerate;
            this.btnGenerate.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGenerate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnGenerate.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.ForeColor = System.Drawing.Color.White;
            this.btnGenerate.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.btnGenerate.HoverState.Parent = this.btnGenerate;
            this.btnGenerate.Image = global::OCSSCESa.Properties.Resources.icons8_available_updates_96px_1;
            this.btnGenerate.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGenerate.ImageSize = new System.Drawing.Size(32, 32);
            this.btnGenerate.Location = new System.Drawing.Point(0, 304);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.ShadowDecoration.Parent = this.btnGenerate;
            this.btnGenerate.Size = new System.Drawing.Size(260, 53);
            this.btnGenerate.TabIndex = 6;
            this.btnGenerate.Text = "Generate Code";
            this.btnGenerate.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btnGenerate.TextOffset = new System.Drawing.Point(3, 0);
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1007, 589);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.sidebarPanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.sidebarPanel.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.userPicture)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel sidebarPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Button dashboardButton;
        private Guna.UI2.WinForms.Guna2Button resultsButton;
        private Guna.UI2.WinForms.Guna2Button usersButton;
        private Guna.UI2.WinForms.Guna2Button candidatesButton;
        private Guna.UI2.WinForms.Guna2Button studentButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label windowLabel;
        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2PictureBox userPicture;
        private Guna.UI2.WinForms.Guna2ComboBox dropdown;
        private Guna.UI2.WinForms.Guna2Button btnGenerate;
    }
}