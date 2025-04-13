namespace OCSSCESa
{
    partial class FrmImportExcel
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.windowLabel = new System.Windows.Forms.Label();
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.loadingIndicator = new Guna.UI2.WinForms.Guna2WinProgressIndicator();
            this.excelDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.browseButton = new Guna.UI2.WinForms.Guna2Button();
            this.formShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.formDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.importButton = new Guna.UI2.WinForms.Guna2Button();
            this.filePathText = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.excelDataGrid)).BeginInit();
            this.SuspendLayout();
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
            this.guna2Panel1.TabIndex = 22;
            // 
            // windowLabel
            // 
            this.windowLabel.AutoSize = true;
            this.windowLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.windowLabel.Font = new System.Drawing.Font("Poppins SemiBold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.windowLabel.Location = new System.Drawing.Point(10, 7);
            this.windowLabel.Name = "windowLabel";
            this.windowLabel.Size = new System.Drawing.Size(146, 28);
            this.windowLabel.TabIndex = 20;
            this.windowLabel.Text = "Import EXCEL file";
            // 
            // guna2ControlBox1
            // 
            this.guna2ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2ControlBox1.Animated = true;
            this.guna2ControlBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
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
            // loadingIndicator
            // 
            this.loadingIndicator.AutoStart = true;
            this.loadingIndicator.CircleSize = 1F;
            this.loadingIndicator.Location = new System.Drawing.Point(313, 215);
            this.loadingIndicator.Name = "loadingIndicator";
            this.loadingIndicator.ProgressColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.loadingIndicator.Size = new System.Drawing.Size(90, 90);
            this.loadingIndicator.TabIndex = 25;
            this.loadingIndicator.Visible = false;
            // 
            // excelDataGrid
            // 
            this.excelDataGrid.AllowUserToAddRows = false;
            this.excelDataGrid.AllowUserToDeleteRows = false;
            this.excelDataGrid.AllowUserToOrderColumns = true;
            this.excelDataGrid.AllowUserToResizeColumns = false;
            this.excelDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.excelDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.excelDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.excelDataGrid.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.excelDataGrid.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.excelDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.excelDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.excelDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.excelDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.excelDataGrid.ColumnHeadersHeight = 4;
            this.excelDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.excelDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.excelDataGrid.EnableHeadersVisualStyles = false;
            this.excelDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.excelDataGrid.Location = new System.Drawing.Point(15, 105);
            this.excelDataGrid.Name = "excelDataGrid";
            this.excelDataGrid.ReadOnly = true;
            this.excelDataGrid.RowHeadersVisible = false;
            this.excelDataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.excelDataGrid.Size = new System.Drawing.Size(687, 337);
            this.excelDataGrid.TabIndex = 24;
            this.excelDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.excelDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.excelDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.excelDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.excelDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.excelDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.excelDataGrid.ThemeStyle.BackColor = System.Drawing.Color.WhiteSmoke;
            this.excelDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.excelDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.excelDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.excelDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excelDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.excelDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.excelDataGrid.ThemeStyle.HeaderStyle.Height = 4;
            this.excelDataGrid.ThemeStyle.ReadOnly = true;
            this.excelDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.excelDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.excelDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excelDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.excelDataGrid.ThemeStyle.RowsStyle.Height = 22;
            this.excelDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.excelDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // browseButton
            // 
            this.browseButton.Animated = true;
            this.browseButton.BackColor = System.Drawing.Color.Transparent;
            this.browseButton.BorderRadius = 5;
            this.browseButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.browseButton.CheckedState.Parent = this.browseButton;
            this.browseButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.browseButton.CustomImages.Parent = this.browseButton;
            this.browseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.browseButton.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.browseButton.ForeColor = System.Drawing.Color.White;
            this.browseButton.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.browseButton.HoverState.Parent = this.browseButton;
            this.browseButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.browseButton.ImageSize = new System.Drawing.Size(30, 30);
            this.browseButton.Location = new System.Drawing.Point(518, 52);
            this.browseButton.Name = "browseButton";
            this.browseButton.ShadowDecoration.Parent = this.browseButton;
            this.browseButton.Size = new System.Drawing.Size(184, 41);
            this.browseButton.TabIndex = 26;
            this.browseButton.Text = "Browse file";
            this.browseButton.UseTransparentBackground = true;
            this.browseButton.Click += new System.EventHandler(this.browseButton_Click);
            // 
            // formDragControl
            // 
            this.formDragControl.TargetControl = this.guna2Panel1;
            // 
            // formElipse
            // 
            this.formElipse.BorderRadius = 20;
            this.formElipse.TargetControl = this;
            // 
            // importButton
            // 
            this.importButton.Animated = true;
            this.importButton.BackColor = System.Drawing.Color.Transparent;
            this.importButton.BorderRadius = 5;
            this.importButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.importButton.CheckedState.Parent = this.importButton;
            this.importButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importButton.CustomImages.Parent = this.importButton;
            this.importButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.importButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.importButton.ForeColor = System.Drawing.Color.White;
            this.importButton.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.importButton.HoverState.Parent = this.importButton;
            this.importButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.importButton.ImageSize = new System.Drawing.Size(30, 30);
            this.importButton.Location = new System.Drawing.Point(15, 448);
            this.importButton.Name = "importButton";
            this.importButton.ShadowDecoration.Parent = this.importButton;
            this.importButton.Size = new System.Drawing.Size(687, 57);
            this.importButton.TabIndex = 26;
            this.importButton.Text = "Import";
            this.importButton.UseTransparentBackground = true;
            this.importButton.Click += new System.EventHandler(this.importButton_Click);
            // 
            // filePathText
            // 
            this.filePathText.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.filePathText.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.filePathText.BorderRadius = 5;
            this.filePathText.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.filePathText.DefaultText = "";
            this.filePathText.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.filePathText.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.filePathText.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filePathText.DisabledState.Parent = this.filePathText;
            this.filePathText.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.filePathText.FillColor = System.Drawing.Color.WhiteSmoke;
            this.filePathText.FocusedState.BorderColor = System.Drawing.Color.Navy;
            this.filePathText.FocusedState.Parent = this.filePathText;
            this.filePathText.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filePathText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.filePathText.HoverState.BorderColor = System.Drawing.Color.Navy;
            this.filePathText.HoverState.Parent = this.filePathText;
            this.filePathText.IconLeft = global::OCSSCESa.Properties.Resources.icons8_microsoft_excel_2019_480px;
            this.filePathText.IconLeftSize = new System.Drawing.Size(30, 30);
            this.filePathText.IconRightSize = new System.Drawing.Size(30, 30);
            this.filePathText.Location = new System.Drawing.Point(15, 52);
            this.filePathText.Margin = new System.Windows.Forms.Padding(11, 12, 11, 12);
            this.filePathText.Name = "filePathText";
            this.filePathText.PasswordChar = '\0';
            this.filePathText.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.filePathText.PlaceholderText = "File path";
            this.filePathText.ReadOnly = true;
            this.filePathText.SelectedText = "";
            this.filePathText.ShadowDecoration.Parent = this.filePathText;
            this.filePathText.Size = new System.Drawing.Size(499, 41);
            this.filePathText.TabIndex = 23;
            // 
            // FrmImportExcel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(716, 520);
            this.Controls.Add(this.loadingIndicator);
            this.Controls.Add(this.importButton);
            this.Controls.Add(this.browseButton);
            this.Controls.Add(this.excelDataGrid);
            this.Controls.Add(this.filePathText);
            this.Controls.Add(this.guna2Panel1);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmImportExcel";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmImportExcel";
            this.Load += new System.EventHandler(this.FrmImportExcel_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.excelDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label windowLabel;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2WinProgressIndicator loadingIndicator;
        private Guna.UI2.WinForms.Guna2DataGridView excelDataGrid;
        private Guna.UI2.WinForms.Guna2TextBox filePathText;
        private Guna.UI2.WinForms.Guna2Button browseButton;
        private Guna.UI2.WinForms.Guna2ShadowForm formShadow;
        private Guna.UI2.WinForms.Guna2DragControl formDragControl;
        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private Guna.UI2.WinForms.Guna2Button importButton;
    }
}