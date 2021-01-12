namespace PayrollerManager
{
    partial class frmGenerateSalary
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGenerateSalary));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tmr_Search = new System.Windows.Forms.Timer(this.components);
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.btnGenerateSalary = new System.Windows.Forms.Button();
            this.lblSearchColumn = new System.Windows.Forms.Label();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.DBSearchText = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSalaryperiod = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.DGUsermaster = new System.Windows.Forms.DataGridView();
            this.SELECT = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.EMPLOYEEID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLOYEECODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLOYEENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMAILID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsermaster)).BeginInit();
            this.SuspendLayout();
            // 
            // tmr_Search
            // 
            this.tmr_Search.Tick += new System.EventHandler(this.tmr_Search_Tick);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(323, 13);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 28;
            this.btnSelect.Text = "Select All";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(779, 505);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(107, 37);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSendMail
            // 
            this.btnSendMail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendMail.Location = new System.Drawing.Point(656, 505);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(107, 37);
            this.btnSendMail.TabIndex = 26;
            this.btnSendMail.Text = "Send Email";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnGenerateSalary
            // 
            this.btnGenerateSalary.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnGenerateSalary.Location = new System.Drawing.Point(532, 505);
            this.btnGenerateSalary.Name = "btnGenerateSalary";
            this.btnGenerateSalary.Size = new System.Drawing.Size(107, 37);
            this.btnGenerateSalary.TabIndex = 25;
            this.btnGenerateSalary.Text = "Generate Salary";
            this.btnGenerateSalary.UseVisualStyleBackColor = true;
            this.btnGenerateSalary.Click += new System.EventHandler(this.btnGenerateSalary_Click);
            // 
            // lblSearchColumn
            // 
            this.lblSearchColumn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSearchColumn.AutoSize = true;
            this.lblSearchColumn.ForeColor = System.Drawing.Color.Blue;
            this.lblSearchColumn.Location = new System.Drawing.Point(343, 511);
            this.lblSearchColumn.Name = "lblSearchColumn";
            this.lblSearchColumn.Size = new System.Drawing.Size(0, 13);
            this.lblSearchColumn.TabIndex = 24;
            // 
            // btnFindNext
            // 
            this.btnFindNext.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFindNext.FlatAppearance.BorderSize = 0;
            this.btnFindNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFindNext.Image = ((System.Drawing.Image)(resources.GetObject("btnFindNext.Image")));
            this.btnFindNext.Location = new System.Drawing.Point(295, 507);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(31, 27);
            this.btnFindNext.TabIndex = 23;
            this.btnFindNext.UseVisualStyleBackColor = true;
            // 
            // txtSearchText
            // 
            this.txtSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSearchText.Location = new System.Drawing.Point(87, 511);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(203, 20);
            this.txtSearchText.TabIndex = 22;
            this.txtSearchText.TextChanged += new System.EventHandler(this.txtSearchText_TextChanged);
            // 
            // DBSearchText
            // 
            this.DBSearchText.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DBSearchText.AutoSize = true;
            this.DBSearchText.Location = new System.Drawing.Point(18, 514);
            this.DBSearchText.Name = "DBSearchText";
            this.DBSearchText.Size = new System.Drawing.Size(68, 13);
            this.DBSearchText.TabIndex = 21;
            this.DBSearchText.Text = "Search Text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salary Period";
            // 
            // dtpSalaryperiod
            // 
            this.dtpSalaryperiod.Checked = false;
            this.dtpSalaryperiod.CustomFormat = "MMM-yyyy";
            this.dtpSalaryperiod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalaryperiod.Location = new System.Drawing.Point(103, 13);
            this.dtpSalaryperiod.Name = "dtpSalaryperiod";
            this.dtpSalaryperiod.ShowCheckBox = true;
            this.dtpSalaryperiod.Size = new System.Drawing.Size(200, 20);
            this.dtpSalaryperiod.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.DGUsermaster);
            this.groupBox1.Location = new System.Drawing.Point(12, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(875, 456);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Employee";
            // 
            // DGUsermaster
            // 
            this.DGUsermaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DGUsermaster.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DGUsermaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUsermaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECT,
            this.EMPLOYEEID,
            this.EMPLOYEECODE,
            this.EMPLOYEENAME,
            this.EMAILID});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DGUsermaster.DefaultCellStyle = dataGridViewCellStyle2;
            this.DGUsermaster.Location = new System.Drawing.Point(6, 19);
            this.DGUsermaster.Name = "DGUsermaster";
            this.DGUsermaster.Size = new System.Drawing.Size(863, 424);
            this.DGUsermaster.TabIndex = 0;
            this.DGUsermaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGUsermaster_CellClick);
            // 
            // SELECT
            // 
            this.SELECT.HeaderText = "SELECT";
            this.SELECT.Name = "SELECT";
            this.SELECT.Width = 50;
            // 
            // EMPLOYEEID
            // 
            this.EMPLOYEEID.HeaderText = "EMPLOYEEID";
            this.EMPLOYEEID.Name = "EMPLOYEEID";
            this.EMPLOYEEID.Visible = false;
            // 
            // EMPLOYEECODE
            // 
            this.EMPLOYEECODE.HeaderText = "EMPLOYEE CODE";
            this.EMPLOYEECODE.Name = "EMPLOYEECODE";
            this.EMPLOYEECODE.Width = 200;
            // 
            // EMPLOYEENAME
            // 
            this.EMPLOYEENAME.HeaderText = "EMPLOYEE NAME";
            this.EMPLOYEENAME.Name = "EMPLOYEENAME";
            this.EMPLOYEENAME.Width = 250;
            // 
            // EMAILID
            // 
            this.EMAILID.HeaderText = "EMIAL ID";
            this.EMAILID.Name = "EMAILID";
            this.EMAILID.Width = 250;
            // 
            // frmGenerateSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(900, 549);
            this.ControlBox = false;
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnSendMail);
            this.Controls.Add(this.btnGenerateSalary);
            this.Controls.Add(this.lblSearchColumn);
            this.Controls.Add(this.btnFindNext);
            this.Controls.Add(this.txtSearchText);
            this.Controls.Add(this.DBSearchText);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpSalaryperiod);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "frmGenerateSalary";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Email Salary Slip";
            this.Load += new System.EventHandler(this.GenerateSalary_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGUsermaster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView DGUsermaster;
        private System.Windows.Forms.DateTimePicker dtpSalaryperiod;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.Label DBSearchText;
        private System.Windows.Forms.Timer tmr_Search;
        private System.Windows.Forms.Label lblSearchColumn;
        private System.Windows.Forms.Button btnGenerateSalary;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECT;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLOYEEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLOYEECODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLOYEENAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAILID;
    }
}