namespace OCSSCESa
{
    partial class FrmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUsers));
            this.addButton = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.searchTextbox = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSearch = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.renderLabel = new System.Windows.Forms.Label();
            this.loadingIndicator = new Guna.UI2.WinForms.Guna2Panel();
            this.usersFlowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel2.SuspendLayout();
            this.loadingIndicator.SuspendLayout();
            this.SuspendLayout();
            // 
            // addButton
            // 
            this.addButton.Animated = true;
            this.addButton.BackColor = System.Drawing.Color.Transparent;
            this.addButton.BorderRadius = 5;
            this.addButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.addButton.CheckedState.Parent = this.addButton;
            this.addButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addButton.CustomImages.Parent = this.addButton;
            this.addButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.addButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.addButton.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.White;
            this.addButton.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.addButton.HoverState.Parent = this.addButton;
            this.addButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.addButton.ImageSize = new System.Drawing.Size(30, 30);
            this.addButton.Location = new System.Drawing.Point(8, 8);
            this.addButton.Name = "addButton";
            this.addButton.ShadowDecoration.Parent = this.addButton;
            this.addButton.Size = new System.Drawing.Size(120, 45);
            this.addButton.TabIndex = 4;
            this.addButton.Text = "Add user";
            this.addButton.UseTransparentBackground = true;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.searchTextbox);
            this.guna2Panel2.Controls.Add(this.guna2Panel4);
            this.guna2Panel2.Controls.Add(this.btnSearch);
            this.guna2Panel2.Controls.Add(this.addButton);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel2.Location = new System.Drawing.Point(8, 8);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(8);
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(844, 61);
            this.guna2Panel2.TabIndex = 10;
            // 
            // searchTextbox
            // 
            this.searchTextbox.BackColor = System.Drawing.Color.Transparent;
            this.searchTextbox.BorderRadius = 5;
            this.searchTextbox.BorderThickness = 0;
            this.searchTextbox.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchTextbox.DefaultText = "";
            this.searchTextbox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchTextbox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchTextbox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextbox.DisabledState.Parent = this.searchTextbox;
            this.searchTextbox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchTextbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.searchTextbox.FillColor = System.Drawing.Color.WhiteSmoke;
            this.searchTextbox.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextbox.FocusedState.Parent = this.searchTextbox;
            this.searchTextbox.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchTextbox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.searchTextbox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.searchTextbox.HoverState.Parent = this.searchTextbox;
            this.searchTextbox.IconLeftSize = new System.Drawing.Size(30, 30);
            this.searchTextbox.IconRight = ((System.Drawing.Image)(resources.GetObject("searchTextbox.IconRight")));
            this.searchTextbox.IconRightSize = new System.Drawing.Size(30, 30);
            this.searchTextbox.Location = new System.Drawing.Point(444, 8);
            this.searchTextbox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.searchTextbox.Name = "searchTextbox";
            this.searchTextbox.PasswordChar = '\0';
            this.searchTextbox.PlaceholderText = "Search";
            this.searchTextbox.SelectedText = "";
            this.searchTextbox.ShadowDecoration.Parent = this.searchTextbox;
            this.searchTextbox.Size = new System.Drawing.Size(257, 45);
            this.searchTextbox.TabIndex = 7;
            this.searchTextbox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.searchTextbox_KeyDown);
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.Dock = System.Windows.Forms.DockStyle.Right;
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel4.Location = new System.Drawing.Point(701, 8);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(12, 45);
            this.guna2Panel4.TabIndex = 9;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.Transparent;
            this.btnSearch.BorderRadius = 5;
            this.btnSearch.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.btnSearch.CheckedState.Parent = this.btnSearch;
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.CustomImages.Parent = this.btnSearch;
            this.btnSearch.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnSearch.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnSearch.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.Color.White;
            this.btnSearch.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.btnSearch.HoverState.Parent = this.btnSearch;
            this.btnSearch.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnSearch.ImageSize = new System.Drawing.Size(30, 30);
            this.btnSearch.Location = new System.Drawing.Point(713, 8);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.ShadowDecoration.Parent = this.btnSearch;
            this.btnSearch.Size = new System.Drawing.Size(123, 45);
            this.btnSearch.TabIndex = 8;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseTransparentBackground = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel3.Location = new System.Drawing.Point(8, 69);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(844, 10);
            this.guna2Panel3.TabIndex = 11;
            // 
            // renderLabel
            // 
            this.renderLabel.AutoSize = true;
            this.renderLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.renderLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.renderLabel.Location = new System.Drawing.Point(36, 51);
            this.renderLabel.Name = "renderLabel";
            this.renderLabel.Size = new System.Drawing.Size(172, 17);
            this.renderLabel.TabIndex = 7;
            this.renderLabel.Text = "Rendering data. Please wait.";
            // 
            // loadingIndicator
            // 
            this.loadingIndicator.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loadingIndicator.BorderRadius = 10;
            this.loadingIndicator.Controls.Add(this.renderLabel);
            this.loadingIndicator.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.loadingIndicator.Location = new System.Drawing.Point(308, 200);
            this.loadingIndicator.Name = "loadingIndicator";
            this.loadingIndicator.ShadowDecoration.Parent = this.loadingIndicator;
            this.loadingIndicator.Size = new System.Drawing.Size(244, 119);
            this.loadingIndicator.TabIndex = 12;
            this.loadingIndicator.Visible = false;
            // 
            // usersFlowLayoutPanel
            // 
            this.usersFlowLayoutPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.usersFlowLayoutPanel.Location = new System.Drawing.Point(8, 79);
            this.usersFlowLayoutPanel.Name = "usersFlowLayoutPanel";
            this.usersFlowLayoutPanel.Size = new System.Drawing.Size(844, 431);
            this.usersFlowLayoutPanel.TabIndex = 13;
            // 
            // FrmUsers
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(860, 518);
            this.Controls.Add(this.loadingIndicator);
            this.Controls.Add(this.usersFlowLayoutPanel);
            this.Controls.Add(this.guna2Panel3);
            this.Controls.Add(this.guna2Panel2);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUsers";
            this.Padding = new System.Windows.Forms.Padding(8);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FrmUsers";
            this.Load += new System.EventHandler(this.FrmUsers_Load);
            this.guna2Panel2.ResumeLayout(false);
            this.loadingIndicator.ResumeLayout(false);
            this.loadingIndicator.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Button addButton;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2TextBox searchTextbox;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2Button btnSearch;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.Label renderLabel;
        private Guna.UI2.WinForms.Guna2Panel loadingIndicator;
        private System.Windows.Forms.FlowLayoutPanel usersFlowLayoutPanel;
    }
}