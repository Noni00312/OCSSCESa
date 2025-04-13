namespace OCSSCESa
{
    partial class FrmDashboard
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cardTable = new System.Windows.Forms.TableLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.votersDatagrid = new Guna.UI2.WinForms.Guna2DataGridView();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel4 = new Guna.UI2.WinForms.Guna2Panel();
            this.votesGraph = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.expectedVotersLabel = new System.Windows.Forms.Label();
            this.votesCastLabel = new System.Windows.Forms.Label();
            this.notCastLabel = new System.Windows.Forms.Label();
            this.guna2Panel5 = new Guna.UI2.WinForms.Guna2Panel();
            this.courseNotCompleteLabel = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.courseCompleteLabel = new System.Windows.Forms.Label();
            this.totalCourseLabel = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.guna2Panel6 = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel7 = new Guna.UI2.WinForms.Guna2Panel();
            this.courseGraph = new Guna.UI2.WinForms.Guna2CircleProgressBar();
            this.label9 = new System.Windows.Forms.Label();
            this.cardTable.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.votersDatagrid)).BeginInit();
            this.guna2Panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // cardTable
            // 
            this.cardTable.ColumnCount = 2;
            this.cardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cardTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.cardTable.Controls.Add(this.guna2Panel5, 1, 0);
            this.cardTable.Controls.Add(this.guna2Panel1, 0, 0);
            this.cardTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cardTable.Location = new System.Drawing.Point(9, 322);
            this.cardTable.Margin = new System.Windows.Forms.Padding(0);
            this.cardTable.Name = "cardTable";
            this.cardTable.RowCount = 1;
            this.cardTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.cardTable.Size = new System.Drawing.Size(990, 231);
            this.cardTable.TabIndex = 0;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.notCastLabel);
            this.guna2Panel1.Controls.Add(this.label5);
            this.guna2Panel1.Controls.Add(this.votesCastLabel);
            this.guna2Panel1.Controls.Add(this.label4);
            this.guna2Panel1.Controls.Add(this.expectedVotersLabel);
            this.guna2Panel1.Controls.Add(this.label3);
            this.guna2Panel1.Controls.Add(this.label2);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Controls.Add(this.guna2Panel4);
            this.guna2Panel1.Controls.Add(this.guna2Panel3);
            this.guna2Panel1.Controls.Add(this.votesGraph);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.ShadowDecoration.Parent = this.guna2Panel1;
            this.guna2Panel1.Size = new System.Drawing.Size(495, 231);
            this.guna2Panel1.TabIndex = 0;
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.votersDatagrid);
            this.guna2Panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel2.Location = new System.Drawing.Point(9, 9);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Padding = new System.Windows.Forms.Padding(0, 0, 0, 8);
            this.guna2Panel2.ShadowDecoration.Parent = this.guna2Panel2;
            this.guna2Panel2.Size = new System.Drawing.Size(990, 313);
            this.guna2Panel2.TabIndex = 1;
            // 
            // votersDatagrid
            // 
            this.votersDatagrid.AllowUserToAddRows = false;
            this.votersDatagrid.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.votersDatagrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.votersDatagrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.votersDatagrid.BackgroundColor = System.Drawing.Color.White;
            this.votersDatagrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.votersDatagrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.votersDatagrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.votersDatagrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.votersDatagrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.votersDatagrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.votersDatagrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.votersDatagrid.EnableHeadersVisualStyles = false;
            this.votersDatagrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.votersDatagrid.Location = new System.Drawing.Point(0, 0);
            this.votersDatagrid.Name = "votersDatagrid";
            this.votersDatagrid.ReadOnly = true;
            this.votersDatagrid.RowHeadersVisible = false;
            this.votersDatagrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.votersDatagrid.Size = new System.Drawing.Size(990, 305);
            this.votersDatagrid.TabIndex = 0;
            this.votersDatagrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Default;
            this.votersDatagrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.votersDatagrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.votersDatagrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.votersDatagrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.votersDatagrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.votersDatagrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.votersDatagrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.votersDatagrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.votersDatagrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.votersDatagrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.votersDatagrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.votersDatagrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.votersDatagrid.ThemeStyle.HeaderStyle.Height = 4;
            this.votersDatagrid.ThemeStyle.ReadOnly = true;
            this.votersDatagrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.votersDatagrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.votersDatagrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.votersDatagrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.votersDatagrid.ThemeStyle.RowsStyle.Height = 22;
            this.votersDatagrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.votersDatagrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.guna2Panel3.Location = new System.Drawing.Point(14, 171);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.ShadowDecoration.Parent = this.guna2Panel3;
            this.guna2Panel3.Size = new System.Drawing.Size(35, 18);
            this.guna2Panel3.TabIndex = 0;
            // 
            // guna2Panel4
            // 
            this.guna2Panel4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(139)))), ((int)(((byte)(201)))), ((int)(((byte)(77)))));
            this.guna2Panel4.Location = new System.Drawing.Point(14, 195);
            this.guna2Panel4.Name = "guna2Panel4";
            this.guna2Panel4.ShadowDecoration.Parent = this.guna2Panel4;
            this.guna2Panel4.Size = new System.Drawing.Size(35, 18);
            this.guna2Panel4.TabIndex = 0;
            // 
            // votesGraph
            // 
            this.votesGraph.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.votesGraph.Animated = true;
            this.votesGraph.AnimationSpeed = 0.3F;
            this.votesGraph.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.votesGraph.FillThickness = 28;
            this.votesGraph.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.votesGraph.Location = new System.Drawing.Point(342, 3);
            this.votesGraph.Name = "votesGraph";
            this.votesGraph.ProgressThickness = 28;
            this.votesGraph.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.votesGraph.ShadowDecoration.Parent = this.votesGraph;
            this.votesGraph.ShowPercentage = true;
            this.votesGraph.Size = new System.Drawing.Size(150, 150);
            this.votesGraph.TabIndex = 1;
            this.votesGraph.Value = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(55, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Percentage of voters have cast their ballots";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(55, 172);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Percentage of voters have\'nt cast their ballots";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(11, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Total expected voters :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(11, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 17);
            this.label4.TabIndex = 2;
            this.label4.Text = "Total Votes Casts :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 17);
            this.label5.TabIndex = 2;
            this.label5.Text = "Total Votes Not Cast :";
            // 
            // expectedVotersLabel
            // 
            this.expectedVotersLabel.AutoSize = true;
            this.expectedVotersLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.expectedVotersLabel.Location = new System.Drawing.Point(165, 3);
            this.expectedVotersLabel.Name = "expectedVotersLabel";
            this.expectedVotersLabel.Size = new System.Drawing.Size(22, 17);
            this.expectedVotersLabel.TabIndex = 2;
            this.expectedVotersLabel.Text = "12";
            // 
            // votesCastLabel
            // 
            this.votesCastLabel.AutoSize = true;
            this.votesCastLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.votesCastLabel.Location = new System.Drawing.Point(138, 23);
            this.votesCastLabel.Name = "votesCastLabel";
            this.votesCastLabel.Size = new System.Drawing.Size(22, 17);
            this.votesCastLabel.TabIndex = 2;
            this.votesCastLabel.Text = "12";
            // 
            // notCastLabel
            // 
            this.notCastLabel.AutoSize = true;
            this.notCastLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notCastLabel.Location = new System.Drawing.Point(157, 43);
            this.notCastLabel.Name = "notCastLabel";
            this.notCastLabel.Size = new System.Drawing.Size(22, 17);
            this.notCastLabel.TabIndex = 2;
            this.notCastLabel.Text = "12";
            // 
            // guna2Panel5
            // 
            this.guna2Panel5.Controls.Add(this.courseNotCompleteLabel);
            this.guna2Panel5.Controls.Add(this.label7);
            this.guna2Panel5.Controls.Add(this.courseCompleteLabel);
            this.guna2Panel5.Controls.Add(this.label9);
            this.guna2Panel5.Controls.Add(this.totalCourseLabel);
            this.guna2Panel5.Controls.Add(this.label11);
            this.guna2Panel5.Controls.Add(this.label12);
            this.guna2Panel5.Controls.Add(this.label13);
            this.guna2Panel5.Controls.Add(this.guna2Panel6);
            this.guna2Panel5.Controls.Add(this.guna2Panel7);
            this.guna2Panel5.Controls.Add(this.courseGraph);
            this.guna2Panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel5.Location = new System.Drawing.Point(495, 0);
            this.guna2Panel5.Margin = new System.Windows.Forms.Padding(0);
            this.guna2Panel5.Name = "guna2Panel5";
            this.guna2Panel5.ShadowDecoration.Parent = this.guna2Panel5;
            this.guna2Panel5.Size = new System.Drawing.Size(495, 231);
            this.guna2Panel5.TabIndex = 1;
            // 
            // courseNotCompleteLabel
            // 
            this.courseNotCompleteLabel.AutoSize = true;
            this.courseNotCompleteLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseNotCompleteLabel.Location = new System.Drawing.Point(285, 43);
            this.courseNotCompleteLabel.Name = "courseNotCompleteLabel";
            this.courseNotCompleteLabel.Size = new System.Drawing.Size(22, 17);
            this.courseNotCompleteLabel.TabIndex = 2;
            this.courseNotCompleteLabel.Text = "12";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(11, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 17);
            this.label7.TabIndex = 2;
            this.label7.Text = "Total course have NOT completed voting :";
            // 
            // courseCompleteLabel
            // 
            this.courseCompleteLabel.AutoSize = true;
            this.courseCompleteLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseCompleteLabel.Location = new System.Drawing.Point(233, 23);
            this.courseCompleteLabel.Name = "courseCompleteLabel";
            this.courseCompleteLabel.Size = new System.Drawing.Size(22, 17);
            this.courseCompleteLabel.TabIndex = 2;
            this.courseCompleteLabel.Text = "12";
            // 
            // totalCourseLabel
            // 
            this.totalCourseLabel.AutoSize = true;
            this.totalCourseLabel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCourseLabel.Location = new System.Drawing.Point(231, 3);
            this.totalCourseLabel.Name = "totalCourseLabel";
            this.totalCourseLabel.Size = new System.Drawing.Size(22, 17);
            this.totalCourseLabel.TabIndex = 2;
            this.totalCourseLabel.Text = "12";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(11, 3);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(91, 17);
            this.label11.TabIndex = 2;
            this.label11.Text = "Total course :";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(55, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(288, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Total course who have not completed voting.";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(55, 196);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(230, 17);
            this.label13.TabIndex = 2;
            this.label13.Text = "Total course who completed voting.";
            // 
            // guna2Panel6
            // 
            this.guna2Panel6.FillColor = System.Drawing.Color.Olive;
            this.guna2Panel6.Location = new System.Drawing.Point(14, 195);
            this.guna2Panel6.Name = "guna2Panel6";
            this.guna2Panel6.ShadowDecoration.Parent = this.guna2Panel6;
            this.guna2Panel6.Size = new System.Drawing.Size(35, 18);
            this.guna2Panel6.TabIndex = 0;
            // 
            // guna2Panel7
            // 
            this.guna2Panel7.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.guna2Panel7.Location = new System.Drawing.Point(14, 171);
            this.guna2Panel7.Name = "guna2Panel7";
            this.guna2Panel7.ShadowDecoration.Parent = this.guna2Panel7;
            this.guna2Panel7.Size = new System.Drawing.Size(35, 18);
            this.guna2Panel7.TabIndex = 0;
            // 
            // courseGraph
            // 
            this.courseGraph.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.courseGraph.Animated = true;
            this.courseGraph.AnimationSpeed = 0.3F;
            this.courseGraph.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.courseGraph.FillThickness = 28;
            this.courseGraph.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.courseGraph.Location = new System.Drawing.Point(342, 3);
            this.courseGraph.Name = "courseGraph";
            this.courseGraph.ProgressColor = System.Drawing.Color.Olive;
            this.courseGraph.ProgressColor2 = System.Drawing.Color.Olive;
            this.courseGraph.ProgressThickness = 28;
            this.courseGraph.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.courseGraph.ShadowDecoration.Parent = this.courseGraph;
            this.courseGraph.ShowPercentage = true;
            this.courseGraph.Size = new System.Drawing.Size(150, 150);
            this.courseGraph.TabIndex = 1;
            this.courseGraph.Value = 10;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(11, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 17);
            this.label9.TabIndex = 2;
            this.label9.Text = "Total course COMPLETED voting :";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(1008, 562);
            this.Controls.Add(this.guna2Panel2);
            this.Controls.Add(this.cardTable);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboard";
            this.Padding = new System.Windows.Forms.Padding(9);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.cardTable.ResumeLayout(false);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.votersDatagrid)).EndInit();
            this.guna2Panel5.ResumeLayout(false);
            this.guna2Panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel cardTable;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private Guna.UI2.WinForms.Guna2DataGridView votersDatagrid;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel4;
        private Guna.UI2.WinForms.Guna2CircleProgressBar votesGraph;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label notCastLabel;
        private System.Windows.Forms.Label votesCastLabel;
        private System.Windows.Forms.Label expectedVotersLabel;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel5;
        private System.Windows.Forms.Label courseNotCompleteLabel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label courseCompleteLabel;
        private System.Windows.Forms.Label totalCourseLabel;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel6;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel7;
        private Guna.UI2.WinForms.Guna2CircleProgressBar courseGraph;
        private System.Windows.Forms.Label label9;
    }
}