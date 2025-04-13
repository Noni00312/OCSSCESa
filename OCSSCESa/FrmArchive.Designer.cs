namespace OCSSCESa
{
    partial class FrmArchive
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.formShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.formDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.windowLabel = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.loadingIndicator = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.archiveDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.searchArchiveText = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // formDragControl
            // 
            this.formDragControl.TargetControl = this.guna2Panel1;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.windowLabel);
            this.guna2Panel1.Controls.Add(this.guna2ControlBox1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.guna2Panel1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(716, 43);
            this.guna2Panel1.TabIndex = 21;
            // 
            // windowLabel
            // 
            this.windowLabel.AutoSize = true;
            this.windowLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.windowLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.windowLabel.Location = new System.Drawing.Point(10, 7);
            this.windowLabel.Name = "windowLabel";
            this.windowLabel.Size = new System.Drawing.Size(74, 28);
            this.windowLabel.TabIndex = 20;
            this.windowLabel.Text = "Archive";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.Transparent;
            this.guna2ControlBox1.BorderRadius = 16;
            this.guna2ControlBox1.Cursor = System.Windows.Forms.Cursors.Default;
            this.guna2ControlBox1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2ControlBox1.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.guna2ControlBox1.HoverState.IconColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.HoverState.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.IconColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.Location = new System.Drawing.Point(670, 5);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(32, 32);
            this.guna2ControlBox1.TabIndex = 17;
            // 
            // formElipse
            // 
            this.formElipse.BorderRadius = 0;
            this.formElipse.TargetControl = this;
            // 
            // loadingIndicator
            // 
            this.loadingIndicator.AutoStart = true;
            this.loadingIndicator.CircleSize = 1F;
            this.loadingIndicator.Location = new System.Drawing.Point(313, 215);
            this.loadingIndicator.Name = "loadingIndicator";
            this.loadingIndicator.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loadingIndicator.Size = new System.Drawing.Size(90, 90);
            this.loadingIndicator.TabIndex = 19;
            this.loadingIndicator.Visible = false;
            // 
            // archiveDataGrid
            // 
            this.archiveDataGrid.AllowUserToAddRows = false;
            this.archiveDataGrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            this.archiveDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.archiveDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.archiveDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.archiveDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.archiveDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.archiveDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.archiveDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.archiveDataGrid.ColumnHeadersHeight = 4;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.archiveDataGrid.DefaultCellStyle = dataGridViewCellStyle6;
            this.archiveDataGrid.EnableHeadersVisualStyles = false;
            this.archiveDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.archiveDataGrid.Location = new System.Drawing.Point(15, 105);
            this.archiveDataGrid.Name = "archiveDataGrid";
            this.archiveDataGrid.ReadOnly = true;
            this.archiveDataGrid.RowHeadersVisible = false;
            this.archiveDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.archiveDataGrid.Size = new System.Drawing.Size(687, 398);
            this.archiveDataGrid.TabIndex = 18;
            this.archiveDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.archiveDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.archiveDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.archiveDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.archiveDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.archiveDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.archiveDataGrid.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.archiveDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.archiveDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.archiveDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.archiveDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archiveDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.archiveDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.archiveDataGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.archiveDataGrid.ThemeStyle.ReadOnly = true;
            this.archiveDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.archiveDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.archiveDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.archiveDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.archiveDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.archiveDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.archiveDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.archiveDataGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.archiveDataGrid_CellMouseClick);
            // 
            // searchArchiveText
            // 
            this.searchArchiveText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.searchArchiveText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.searchArchiveText.BorderRadius = 5;
            this.searchArchiveText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.searchArchiveText.DefaultText = "";
            this.searchArchiveText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.searchArchiveText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.searchArchiveText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchArchiveText.DisabledState.Parent = this.searchArchiveText;
            this.searchArchiveText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.searchArchiveText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.searchArchiveText.FocusedState.BorderColor = System.Drawing.Color.Navy;
            this.searchArchiveText.FocusedState.Parent = this.searchArchiveText;
            this.searchArchiveText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchArchiveText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.searchArchiveText.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.searchArchiveText.HoverState.Parent = this.searchArchiveText;
            this.searchArchiveText.IconLeft = global::OCSSCESa.Properties.Resources.icons8_search_client_64px_1;
            this.searchArchiveText.IconLeftSize = new System.Drawing.Size(30, 30);
            this.searchArchiveText.IconRightSize = new System.Drawing.Size(30, 30);
            this.searchArchiveText.Location = new System.Drawing.Point(15, 52);
            this.searchArchiveText.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.searchArchiveText.Name = "searchArchiveText";
            this.searchArchiveText.PasswordChar = '\0';
            this.searchArchiveText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.searchArchiveText.PlaceholderText = "Search";
            this.searchArchiveText.SelectedText = "";
            this.searchArchiveText.ShadowDecoration.Parent = this.searchArchiveText;
            this.searchArchiveText.Size = new System.Drawing.Size(687, 41);
            this.searchArchiveText.TabIndex = 16;
            this.searchArchiveText.TextChanged += new System.EventHandler(this.searchArchiveText_TextChanged);
            // 
            // FrmArchive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(716, 520);
            this.Controls.Add(this.loadingIndicator);
            this.Controls.Add(this.guna2Panel1);
            this.Controls.Add(this.archiveDataGrid);
            this.Controls.Add(this.searchArchiveText);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmArchive";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmArchive";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FrmArchive_FormClosed);
            this.Load += new System.EventHandler(this.FrmArchive_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.archiveDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm formShadow;
        private Guna.UI2.WinForms.Guna2DragControl formDragControl;
        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private Guna.UI2.WinForms.Guna2TextBox searchArchiveText;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator loadingIndicator;
        private Guna.UI2.WinForms.Guna2DataGridView archiveDataGrid;
        private System.Windows.Forms.Label windowLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}