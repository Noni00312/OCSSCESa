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
            this.formShadow = new Guna.UI2.WinForms.Guna2ShadowForm(this.components);
            this.formDragControl = new Guna.UI2.WinForms.Guna2DragControl(this.components);
            this.guna2ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.windowLabel = new System.Windows.Forms.Label();
            this.positionDropDown = new Guna.UI2.WinForms.Guna2ComboBox();
            this.btnAddPosition = new Guna.UI2.WinForms.Guna2Button();
            this.label1 = new System.Windows.Forms.Label();
            this.studentNameLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.studentIdLabel = new System.Windows.Forms.Label();
            this.saveButton = new Guna.UI2.WinForms.Guna2Button();
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
            this.positionDropDown.Location = new System.Drawing.Point(37, 169);
            this.positionDropDown.Name = "positionDropDown";
            this.positionDropDown.ShadowDecoration.Parent = this.positionDropDown;
            this.positionDropDown.Size = new System.Drawing.Size(449, 36);
            this.positionDropDown.TabIndex = 19;
            // 
            // btnAddPosition
            // 
            this.btnAddPosition.BackColor = System.Drawing.Color.Transparent;
            this.btnAddPosition.BorderRadius = 5;
            this.btnAddPosition.CheckedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(92)))), ((int)(((byte)(113)))));
            this.btnAddPosition.CheckedState.Parent = this.btnAddPosition;
            this.btnAddPosition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddPosition.CustomImages.Parent = this.btnAddPosition;
            this.btnAddPosition.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.btnAddPosition.Font = new System.Drawing.Font("Poppins", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddPosition.ForeColor = System.Drawing.Color.White;
            this.btnAddPosition.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(126)))), ((int)(((byte)(138)))));
            this.btnAddPosition.HoverState.Parent = this.btnAddPosition;
            this.btnAddPosition.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.btnAddPosition.ImageSize = new System.Drawing.Size(30, 30);
            this.btnAddPosition.Location = new System.Drawing.Point(492, 169);
            this.btnAddPosition.Name = "btnAddPosition";
            this.btnAddPosition.ShadowDecoration.Parent = this.btnAddPosition;
            this.btnAddPosition.Size = new System.Drawing.Size(135, 36);
            this.btnAddPosition.TabIndex = 20;
            this.btnAddPosition.Text = "Add position";
            this.btnAddPosition.UseTransparentBackground = true;
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
            this.studentNameLabel.AutoSize = true;
            this.studentNameLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNameLabel.Location = new System.Drawing.Point(55, 73);
            this.studentNameLabel.Name = "studentNameLabel";
            this.studentNameLabel.Size = new System.Drawing.Size(126, 28);
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
            this.studentIdLabel.AutoSize = true;
            this.studentIdLabel.Font = new System.Drawing.Font("Poppins", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentIdLabel.Location = new System.Drawing.Point(55, 122);
            this.studentIdLabel.Name = "studentIdLabel";
            this.studentIdLabel.Size = new System.Drawing.Size(126, 28);
            this.studentIdLabel.TabIndex = 21;
            this.studentIdLabel.Text = "Student Name";
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
            this.saveButton.Location = new System.Drawing.Point(37, 235);
            this.saveButton.Name = "saveButton";
            this.saveButton.ShadowDecoration.Parent = this.saveButton;
            this.saveButton.Size = new System.Drawing.Size(590, 53);
            this.saveButton.TabIndex = 22;
            this.saveButton.Text = "Save";
            // 
            // FrmSelectPosition
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(660, 340);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.studentIdLabel);
            this.Controls.Add(this.studentNameLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddPosition);
            this.Controls.Add(this.positionDropDown);
            this.Controls.Add(this.guna2ControlBox1);
            this.Controls.Add(this.windowLabel);
            this.Font = new System.Drawing.Font("Poppins", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "FrmSelectPosition";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmSelectPosition";
            this.Load += new System.EventHandler(this.FrmSelectPosition_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2ShadowForm formShadow;
        private Guna.UI2.WinForms.Guna2DragControl formDragControl;
        private Guna.UI2.WinForms.Guna2ControlBox guna2ControlBox1;
        private System.Windows.Forms.Label windowLabel;
        private Guna.UI2.WinForms.Guna2ComboBox positionDropDown;
        private Guna.UI2.WinForms.Guna2Button btnAddPosition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label studentNameLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label studentIdLabel;
        private Guna.UI2.WinForms.Guna2Button saveButton;
    }
}