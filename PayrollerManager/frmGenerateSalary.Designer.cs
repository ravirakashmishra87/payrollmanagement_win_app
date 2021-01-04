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
            this.btnSelect.Location = new System.Drawing.Point(377, 15);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(87, 27);
            this.btnSelect.TabIndex = 28;
            this.btnSelect.Text = "Select All";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(909, 614);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(125, 43);
            this.btnClose.TabIndex = 27;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(765, 614);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(125, 43);
            this.btnSendMail.TabIndex = 26;
            this.btnSendMail.Text = "Send Email";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // btnGenerateSalary
            // 
            this.btnGenerateSalary.Location = new System.Drawing.Point(621, 614);
            this.btnGenerateSalary.Name = "btnGenerateSalary";
            this.btnGenerateSalary.Size = new System.Drawing.Size(125, 43);
            this.btnGenerateSalary.TabIndex = 25;
            this.btnGenerateSalary.Text = "Generate Salary";
            this.btnGenerateSalary.UseVisualStyleBackColor = true;
            this.btnGenerateSalary.Click += new System.EventHandler(this.btnGenerateSalary_Click);
            // 
            // lblSearchColumn
            // 
            this.lblSearchColumn.AutoSize = true;
            this.lblSearchColumn.ForeColor = System.Drawing.Color.Blue;
            this.lblSearchColumn.Location = new System.Drawing.Point(400, 621);
            this.lblSearchColumn.Name = "lblSearchColumn";
            this.lblSearchColumn.Size = new System.Drawing.Size(0, 15);
            this.lblSearchColumn.TabIndex = 24;
            // 
            // btnFindNext
            // 
            this.btnFindNext.FlatAppearance.BorderSize = 0;
            this.btnFindNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFindNext.Image = ((System.Drawing.Image)(resources.GetObject("btnFindNext.Image")));
            this.btnFindNext.Location = new System.Drawing.Point(344, 616);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(36, 31);
            this.btnFindNext.TabIndex = 23;
            this.btnFindNext.UseVisualStyleBackColor = true;
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(102, 621);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(236, 21);
            this.txtSearchText.TabIndex = 22;
            this.txtSearchText.TextChanged += new System.EventHandler(this.txtSearchText_TextChanged);
            // 
            // DBSearchText
            // 
            this.DBSearchText.AutoSize = true;
            this.DBSearchText.Location = new System.Drawing.Point(21, 624);
            this.DBSearchText.Name = "DBSearchText";
            this.DBSearchText.Size = new System.Drawing.Size(75, 15);
            this.DBSearchText.TabIndex = 21;
            this.DBSearchText.Text = "Search Text:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 2;
            this.label1.Text = "Salary Period";
            // 
            // dtpSalaryperiod
            // 
            this.dtpSalaryperiod.Checked = false;
            this.dtpSalaryperiod.CustomFormat = "MMM-yyyy";
            this.dtpSalaryperiod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalaryperiod.Location = new System.Drawing.Point(120, 15);
            this.dtpSalaryperiod.Name = "dtpSalaryperiod";
            this.dtpSalaryperiod.ShowCheckBox = true;
            this.dtpSalaryperiod.Size = new System.Drawing.Size(233, 21);
            this.dtpSalaryperiod.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.DGUsermaster);
            this.groupBox1.Location = new System.Drawing.Point(14, 48);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1021, 560);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Select Employee";
            // 
            // DGUsermaster
            // 
            this.DGUsermaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUsermaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SELECT,
            this.EMPLOYEEID,
            this.EMPLOYEECODE,
            this.EMPLOYEENAME,
            this.EMAILID});
            this.DGUsermaster.Location = new System.Drawing.Point(7, 22);
            this.DGUsermaster.Name = "DGUsermaster";
            this.DGUsermaster.Size = new System.Drawing.Size(1007, 531);
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1049, 674);
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
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
        private System.Windows.Forms.DataGridViewCheckBoxColumn SELECT;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLOYEEID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLOYEECODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLOYEENAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMAILID;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.Label DBSearchText;
        private System.Windows.Forms.Timer tmr_Search;
        private System.Windows.Forms.Label lblSearchColumn;
        private System.Windows.Forms.Button btnGenerateSalary;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnSelect;
    }
}