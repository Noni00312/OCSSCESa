namespace OCSSCESa
{
    partial class FrmManualOrImport
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
            this.formShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.formDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.formElipse = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.manualButton = new Guna.UI2.WinForms.Guna2Button();
            this.windowLabel = new System.Windows.Forms.Label();
            this.importExcelButton = new Guna.UI2.WinForms.Guna2Button();
            this.SuspendLayout();
            // 
            // formDragControl
            // 
            this.formDragControl.TargetControl = this;
            // 
            // formElipse
            // 
            this.formElipse.BorderRadius = 0;
            this.formElipse.TargetControl = this;
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
            this.guna2ControlBox1.Location = new System.Drawing.Point(355, 3);
            this.guna2ControlBox1.Name = "guna2ControlBox1";
            this.guna2ControlBox1.PressedColor = System.Drawing.Color.WhiteSmoke;
            this.guna2ControlBox1.ShadowDecoration.Parent = this.guna2ControlBox1;
            this.guna2ControlBox1.Size = new System.Drawing.Size(32, 32);
            this.guna2ControlBox1.TabIndex = 19;
            // 
            // manualButton
            // 
            this.manualButton.BorderRadius = 8;
            this.manualButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.manualButton.CheckedState.Parent = this.manualButton;
            this.manualButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.manualButton.CustomImages.Parent = this.manualButton;
            this.manualButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.manualButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.manualButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(88)))));
            this.manualButton.HoverState.ForeColor = System.Drawing.Color.White;
            this.manualButton.HoverState.Parent = this.manualButton;
            this.manualButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.manualButton.ImageSize = new System.Drawing.Size(30, 30);
            this.manualButton.Location = new System.Drawing.Point(35, 145);
            this.manualButton.Name = "manualButton";
            this.manualButton.ShadowDecoration.Parent = this.manualButton;
            this.manualButton.Size = new System.Drawing.Size(325, 60);
            this.manualButton.TabIndex = 18;
            this.manualButton.Text = "Manual";
            this.manualButton.Click += new System.EventHandler(this.manualButton_Click);
            // 
            // windowLabel
            // 
            this.windowLabel.AutoSize = true;
            this.windowLabel.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.windowLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.windowLabel.Location = new System.Drawing.Point(30, 35);
            this.windowLabel.Name = "windowLabel";
            this.windowLabel.Size = new System.Drawing.Size(265, 30);
            this.windowLabel.TabIndex = 17;
            this.windowLabel.Text = "Choose what you prepare.";
            // 
            // importExcelButton
            // 
            this.importExcelButton.Animated = true;
            this.importExcelButton.BackColor = System.Drawing.Color.Transparent;
            this.importExcelButton.BorderRadius = 5;
            this.importExcelButton.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.importExcelButton.CheckedState.Parent = this.importExcelButton;
            this.importExcelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.importExcelButton.CustomImages.Parent = this.importExcelButton;
            this.importExcelButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.importExcelButton.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Bold);
            this.importExcelButton.ForeColor = System.Drawing.Color.White;
            this.importExcelButton.HoverState.FillColor = System.Drawing.Color.Maroon;
            this.importExcelButton.HoverState.Parent = this.importExcelButton;
            this.importExcelButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.importExcelButton.ImageSize = new System.Drawing.Size(30, 30);
            this.importExcelButton.Location = new System.Drawing.Point(35, 79);
            this.importExcelButton.Name = "importExcelButton";
            this.importExcelButton.ShadowDecoration.Parent = this.importExcelButton;
            this.importExcelButton.Size = new System.Drawing.Size(325, 60);
            this.importExcelButton.TabIndex = 16;
            this.importExcelButton.Text = "Import";
            this.importExcelButton.UseTransparentBackground = true;
            this.importExcelButton.Click += new System.EventHandler(this.importExcelButton_Click);
            // 
            // FrmManualOrImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(390, 241);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.manualButton);
            this.Controls.Add(this.windowLabel);
            this.Controls.Add(this.importExcelButton);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmManualOrImport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmManualOrImport";
            this.Load += new System.EventHandler(this.FrmManualOrImport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm formShadow;
        private Guna.UI2.WinForms.Guna2DragControl formDragControl;
        private Guna.UI2.WinForms.Guna2Elipse formElipse;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private Guna.UI2.WinForms.Guna2Button manualButton;
        private System.Windows.Forms.Label windowLabel;
        private Guna.UI2.WinForms.Guna2Button importExcelButton;
    }
}