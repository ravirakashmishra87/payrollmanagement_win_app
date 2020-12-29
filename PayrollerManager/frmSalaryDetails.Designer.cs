namespace PayrollerManager
{
    partial class frmSalaryDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalaryDetails));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.TSFixingMaster = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnModify = new System.Windows.Forms.ToolStripButton();
            this.toolStripDelete = new System.Windows.Forms.ToolStripButton();
            this.dgSalary = new System.Windows.Forms.DataGridView();
            this.SALARYID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PERIOD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.rtbSalaryRemark = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpSalaryPeriod = new System.Windows.Forms.DateTimePicker();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.label53 = new System.Windows.Forms.Label();
            this.label54 = new System.Windows.Forms.Label();
            this.txtEmployerPF = new System.Windows.Forms.TextBox();
            this.txtEmployerESIC = new System.Windows.Forms.TextBox();
            this.txtAdmnChrgs = new System.Windows.Forms.TextBox();
            this.txtGrandTotal = new System.Windows.Forms.TextBox();
            this.txtTotalSalary = new System.Windows.Forms.TextBox();
            this.txtNetSalary = new System.Windows.Forms.TextBox();
            this.txtTotalCTC = new System.Windows.Forms.TextBox();
            this.label57 = new System.Windows.Forms.Label();
            this.label56 = new System.Windows.Forms.Label();
            this.label55 = new System.Windows.Forms.Label();
            this.label52 = new System.Windows.Forms.Label();
            this.label51 = new System.Windows.Forms.Label();
            this.txtConv = new System.Windows.Forms.TextBox();
            this.txtHRA = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.label44 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label46 = new System.Windows.Forms.Label();
            this.label48 = new System.Windows.Forms.Label();
            this.label50 = new System.Windows.Forms.Label();
            this.label49 = new System.Windows.Forms.Label();
            this.txtEmployeePF = new System.Windows.Forms.TextBox();
            this.txtEmployeeESIC = new System.Windows.Forms.TextBox();
            this.txtEmployeePT = new System.Windows.Forms.TextBox();
            this.txtEmployeeDeduction = new System.Windows.Forms.TextBox();
            this.txtGross = new System.Windows.Forms.TextBox();
            this.txtDays = new System.Windows.Forms.TextBox();
            this.txtAllowances = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtBasic = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.label43 = new System.Windows.Forms.Label();
            this.label47 = new System.Windows.Forms.Label();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.TSFixingMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalary)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TSFixingMaster);
            this.groupBox1.Controls.Add(this.dgSalary);
            this.groupBox1.Location = new System.Drawing.Point(11, 10);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(248, 551);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // TSFixingMaster
            // 
            this.TSFixingMaster.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnModify,
            this.toolStripDelete});
            this.TSFixingMaster.Location = new System.Drawing.Point(4, 18);
            this.TSFixingMaster.Name = "TSFixingMaster";
            this.TSFixingMaster.Size = new System.Drawing.Size(240, 38);
            this.TSFixingMaster.TabIndex = 37;
            // 
            // btnNew
            // 
            this.btnNew.Image = ((System.Drawing.Image)(resources.GetObject("btnNew.Image")));
            this.btnNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(33, 35);
            this.btnNew.Text = "Add";
            this.btnNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnModify
            // 
            this.btnModify.Image = ((System.Drawing.Image)(resources.GetObject("btnModify.Image")));
            this.btnModify.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(49, 35);
            this.btnModify.Text = "Modify";
            this.btnModify.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // toolStripDelete
            // 
            this.toolStripDelete.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDelete.Image")));
            this.toolStripDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDelete.Name = "toolStripDelete";
            this.toolStripDelete.Size = new System.Drawing.Size(44, 35);
            this.toolStripDelete.Text = "Delete";
            this.toolStripDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripDelete.Click += new System.EventHandler(this.toolStripDelete_Click);
            // 
            // dgSalary
            // 
            this.dgSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.SALARYID,
            this.PERIOD});
            this.dgSalary.Location = new System.Drawing.Point(7, 68);
            this.dgSalary.Margin = new System.Windows.Forms.Padding(4);
            this.dgSalary.Name = "dgSalary";
            this.dgSalary.Size = new System.Drawing.Size(234, 473);
            this.dgSalary.TabIndex = 0;
            this.dgSalary.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgSalary_CellClick);
            // 
            // SALARYID
            // 
            this.SALARYID.HeaderText = "SALARYID";
            this.SALARYID.Name = "SALARYID";
            this.SALARYID.ReadOnly = true;
            this.SALARYID.Visible = false;
            // 
            // PERIOD
            // 
            this.PERIOD.HeaderText = "PERIOD";
            this.PERIOD.Name = "PERIOD";
            this.PERIOD.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rtbSalaryRemark);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.dtpSalaryPeriod);
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.txtAdmnChrgs);
            this.groupBox2.Controls.Add(this.txtGrandTotal);
            this.groupBox2.Controls.Add(this.txtTotalSalary);
            this.groupBox2.Controls.Add(this.txtNetSalary);
            this.groupBox2.Controls.Add(this.txtTotalCTC);
            this.groupBox2.Controls.Add(this.label57);
            this.groupBox2.Controls.Add(this.label56);
            this.groupBox2.Controls.Add(this.label55);
            this.groupBox2.Controls.Add(this.label52);
            this.groupBox2.Controls.Add(this.label51);
            this.groupBox2.Controls.Add(this.txtConv);
            this.groupBox2.Controls.Add(this.txtHRA);
            this.groupBox2.Controls.Add(this.label45);
            this.groupBox2.Controls.Add(this.label44);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txtGross);
            this.groupBox2.Controls.Add(this.txtDays);
            this.groupBox2.Controls.Add(this.txtAllowances);
            this.groupBox2.Controls.Add(this.label40);
            this.groupBox2.Controls.Add(this.txtBasic);
            this.groupBox2.Controls.Add(this.label42);
            this.groupBox2.Controls.Add(this.label43);
            this.groupBox2.Controls.Add(this.label47);
            this.groupBox2.Location = new System.Drawing.Point(267, 10);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(739, 554);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Salary Breakup";
            // 
            // rtbSalaryRemark
            // 
            this.rtbSalaryRemark.Location = new System.Drawing.Point(385, 413);
            this.rtbSalaryRemark.Margin = new System.Windows.Forms.Padding(4);
            this.rtbSalaryRemark.Name = "rtbSalaryRemark";
            this.rtbSalaryRemark.Size = new System.Drawing.Size(322, 120);
            this.rtbSalaryRemark.TabIndex = 12;
            this.rtbSalaryRemark.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(389, 395);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 15);
            this.label2.TabIndex = 41;
            this.label2.Text = "Remark";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 41);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 15);
            this.label1.TabIndex = 40;
            this.label1.Text = "Salary Period";
            // 
            // dtpSalaryPeriod
            // 
            this.dtpSalaryPeriod.Checked = false;
            this.dtpSalaryPeriod.CustomFormat = "MMM-yyyy";
            this.dtpSalaryPeriod.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpSalaryPeriod.Location = new System.Drawing.Point(116, 41);
            this.dtpSalaryPeriod.Margin = new System.Windows.Forms.Padding(4);
            this.dtpSalaryPeriod.Name = "dtpSalaryPeriod";
            this.dtpSalaryPeriod.ShowCheckBox = true;
            this.dtpSalaryPeriod.Size = new System.Drawing.Size(203, 21);
            this.dtpSalaryPeriod.TabIndex = 0;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.label53);
            this.groupBox4.Controls.Add(this.label54);
            this.groupBox4.Controls.Add(this.txtEmployerPF);
            this.groupBox4.Controls.Add(this.txtEmployerESIC);
            this.groupBox4.Location = new System.Drawing.Point(385, 255);
            this.groupBox4.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox4.Size = new System.Drawing.Size(328, 122);
            this.groupBox4.TabIndex = 38;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Employer Part";
            // 
            // label53
            // 
            this.label53.AutoSize = true;
            this.label53.Location = new System.Drawing.Point(13, 30);
            this.label53.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label53.Name = "label53";
            this.label53.Size = new System.Drawing.Size(55, 15);
            this.label53.TabIndex = 13;
            this.label53.Text = "PF(13%)";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(13, 74);
            this.label54.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(77, 15);
            this.label54.TabIndex = 14;
            this.label54.Text = "ESIC(3.25%)";
            // 
            // txtEmployerPF
            // 
            this.txtEmployerPF.Location = new System.Drawing.Point(113, 27);
            this.txtEmployerPF.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployerPF.Name = "txtEmployerPF";
            this.txtEmployerPF.Size = new System.Drawing.Size(203, 21);
            this.txtEmployerPF.TabIndex = 0;
            // 
            // txtEmployerESIC
            // 
            this.txtEmployerESIC.Location = new System.Drawing.Point(113, 74);
            this.txtEmployerESIC.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployerESIC.Name = "txtEmployerESIC";
            this.txtEmployerESIC.Size = new System.Drawing.Size(203, 21);
            this.txtEmployerESIC.TabIndex = 1;
            // 
            // txtAdmnChrgs
            // 
            this.txtAdmnChrgs.Location = new System.Drawing.Point(116, 469);
            this.txtAdmnChrgs.Margin = new System.Windows.Forms.Padding(4);
            this.txtAdmnChrgs.Name = "txtAdmnChrgs";
            this.txtAdmnChrgs.Size = new System.Drawing.Size(203, 21);
            this.txtAdmnChrgs.TabIndex = 10;
            // 
            // txtGrandTotal
            // 
            this.txtGrandTotal.Location = new System.Drawing.Point(116, 511);
            this.txtGrandTotal.Margin = new System.Windows.Forms.Padding(4);
            this.txtGrandTotal.Name = "txtGrandTotal";
            this.txtGrandTotal.Size = new System.Drawing.Size(203, 21);
            this.txtGrandTotal.TabIndex = 11;
            // 
            // txtTotalSalary
            // 
            this.txtTotalSalary.Location = new System.Drawing.Point(116, 383);
            this.txtTotalSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalSalary.Name = "txtTotalSalary";
            this.txtTotalSalary.Size = new System.Drawing.Size(203, 21);
            this.txtTotalSalary.TabIndex = 8;
            // 
            // txtNetSalary
            // 
            this.txtNetSalary.Location = new System.Drawing.Point(116, 340);
            this.txtNetSalary.Margin = new System.Windows.Forms.Padding(4);
            this.txtNetSalary.Name = "txtNetSalary";
            this.txtNetSalary.Size = new System.Drawing.Size(203, 21);
            this.txtNetSalary.TabIndex = 7;
            // 
            // txtTotalCTC
            // 
            this.txtTotalCTC.Location = new System.Drawing.Point(116, 426);
            this.txtTotalCTC.Margin = new System.Windows.Forms.Padding(4);
            this.txtTotalCTC.Name = "txtTotalCTC";
            this.txtTotalCTC.Size = new System.Drawing.Size(203, 21);
            this.txtTotalCTC.TabIndex = 9;
            // 
            // label57
            // 
            this.label57.AutoSize = true;
            this.label57.Location = new System.Drawing.Point(18, 511);
            this.label57.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label57.Name = "label57";
            this.label57.Size = new System.Drawing.Size(71, 15);
            this.label57.TabIndex = 37;
            this.label57.Text = "Grand Total";
            // 
            // label56
            // 
            this.label56.AutoSize = true;
            this.label56.Location = new System.Drawing.Point(18, 469);
            this.label56.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label56.Name = "label56";
            this.label56.Size = new System.Drawing.Size(74, 15);
            this.label56.TabIndex = 36;
            this.label56.Text = "Admn Chrgs";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(18, 426);
            this.label55.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(60, 15);
            this.label55.TabIndex = 35;
            this.label55.Text = "Total CTC";
            // 
            // label52
            // 
            this.label52.AutoSize = true;
            this.label52.Location = new System.Drawing.Point(18, 383);
            this.label52.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label52.Name = "label52";
            this.label52.Size = new System.Drawing.Size(71, 15);
            this.label52.TabIndex = 34;
            this.label52.Text = "Total Salary";
            // 
            // label51
            // 
            this.label51.AutoSize = true;
            this.label51.Location = new System.Drawing.Point(18, 340);
            this.label51.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label51.Name = "label51";
            this.label51.Size = new System.Drawing.Size(63, 15);
            this.label51.TabIndex = 33;
            this.label51.Text = "Net Salary";
            // 
            // txtConv
            // 
            this.txtConv.Location = new System.Drawing.Point(116, 298);
            this.txtConv.Margin = new System.Windows.Forms.Padding(4);
            this.txtConv.Name = "txtConv";
            this.txtConv.Size = new System.Drawing.Size(203, 21);
            this.txtConv.TabIndex = 6;
            // 
            // txtHRA
            // 
            this.txtHRA.Location = new System.Drawing.Point(116, 255);
            this.txtHRA.Margin = new System.Windows.Forms.Padding(4);
            this.txtHRA.Name = "txtHRA";
            this.txtHRA.Size = new System.Drawing.Size(203, 21);
            this.txtHRA.TabIndex = 5;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(18, 298);
            this.label45.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(37, 15);
            this.label45.TabIndex = 25;
            this.label45.Text = "Conv.";
            // 
            // label44
            // 
            this.label44.AutoSize = true;
            this.label44.Location = new System.Drawing.Point(18, 255);
            this.label44.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label44.Name = "label44";
            this.label44.Size = new System.Drawing.Size(32, 15);
            this.label44.TabIndex = 24;
            this.label44.Text = "HRA";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label46);
            this.groupBox3.Controls.Add(this.label48);
            this.groupBox3.Controls.Add(this.label50);
            this.groupBox3.Controls.Add(this.label49);
            this.groupBox3.Controls.Add(this.txtEmployeePF);
            this.groupBox3.Controls.Add(this.txtEmployeeESIC);
            this.groupBox3.Controls.Add(this.txtEmployeePT);
            this.groupBox3.Controls.Add(this.txtEmployeeDeduction);
            this.groupBox3.Location = new System.Drawing.Point(385, 41);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox3.Size = new System.Drawing.Size(328, 193);
            this.groupBox3.TabIndex = 23;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Employee Part";
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(13, 26);
            this.label46.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(55, 15);
            this.label46.TabIndex = 6;
            this.label46.Text = "PF(12%)";
            // 
            // label48
            // 
            this.label48.AutoSize = true;
            this.label48.Location = new System.Drawing.Point(11, 67);
            this.label48.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label48.Name = "label48";
            this.label48.Size = new System.Drawing.Size(77, 15);
            this.label48.TabIndex = 8;
            this.label48.Text = "ESIC(0.75%)";
            // 
            // label50
            // 
            this.label50.AutoSize = true;
            this.label50.Location = new System.Drawing.Point(11, 107);
            this.label50.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label50.Name = "label50";
            this.label50.Size = new System.Drawing.Size(22, 15);
            this.label50.TabIndex = 10;
            this.label50.Text = "PT";
            // 
            // label49
            // 
            this.label49.AutoSize = true;
            this.label49.Location = new System.Drawing.Point(13, 148);
            this.label49.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label49.Name = "label49";
            this.label49.Size = new System.Drawing.Size(69, 15);
            this.label49.TabIndex = 9;
            this.label49.Text = "Deductions";
            // 
            // txtEmployeePF
            // 
            this.txtEmployeePF.Location = new System.Drawing.Point(113, 26);
            this.txtEmployeePF.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeePF.Name = "txtEmployeePF";
            this.txtEmployeePF.Size = new System.Drawing.Size(203, 21);
            this.txtEmployeePF.TabIndex = 0;
            // 
            // txtEmployeeESIC
            // 
            this.txtEmployeeESIC.Location = new System.Drawing.Point(113, 67);
            this.txtEmployeeESIC.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeESIC.Name = "txtEmployeeESIC";
            this.txtEmployeeESIC.Size = new System.Drawing.Size(203, 21);
            this.txtEmployeeESIC.TabIndex = 1;
            // 
            // txtEmployeePT
            // 
            this.txtEmployeePT.Location = new System.Drawing.Point(113, 107);
            this.txtEmployeePT.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeePT.Name = "txtEmployeePT";
            this.txtEmployeePT.Size = new System.Drawing.Size(203, 21);
            this.txtEmployeePT.TabIndex = 2;
            // 
            // txtEmployeeDeduction
            // 
            this.txtEmployeeDeduction.Location = new System.Drawing.Point(113, 148);
            this.txtEmployeeDeduction.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmployeeDeduction.Name = "txtEmployeeDeduction";
            this.txtEmployeeDeduction.Size = new System.Drawing.Size(203, 21);
            this.txtEmployeeDeduction.TabIndex = 3;
            // 
            // txtGross
            // 
            this.txtGross.Location = new System.Drawing.Point(116, 212);
            this.txtGross.Margin = new System.Windows.Forms.Padding(4);
            this.txtGross.Name = "txtGross";
            this.txtGross.Size = new System.Drawing.Size(203, 21);
            this.txtGross.TabIndex = 4;
            // 
            // txtDays
            // 
            this.txtDays.Location = new System.Drawing.Point(116, 84);
            this.txtDays.Margin = new System.Windows.Forms.Padding(4);
            this.txtDays.Name = "txtDays";
            this.txtDays.Size = new System.Drawing.Size(203, 21);
            this.txtDays.TabIndex = 1;
            // 
            // txtAllowances
            // 
            this.txtAllowances.Location = new System.Drawing.Point(116, 170);
            this.txtAllowances.Margin = new System.Windows.Forms.Padding(4);
            this.txtAllowances.Name = "txtAllowances";
            this.txtAllowances.Size = new System.Drawing.Size(203, 21);
            this.txtAllowances.TabIndex = 3;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(18, 84);
            this.label40.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(34, 15);
            this.label40.TabIndex = 11;
            this.label40.Text = "Days";
            // 
            // txtBasic
            // 
            this.txtBasic.Location = new System.Drawing.Point(116, 127);
            this.txtBasic.Margin = new System.Windows.Forms.Padding(4);
            this.txtBasic.Name = "txtBasic";
            this.txtBasic.Size = new System.Drawing.Size(203, 21);
            this.txtBasic.TabIndex = 2;
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(18, 127);
            this.label42.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(37, 15);
            this.label42.TabIndex = 13;
            this.label42.Text = "Basic";
            // 
            // label43
            // 
            this.label43.AutoSize = true;
            this.label43.Location = new System.Drawing.Point(18, 170);
            this.label43.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label43.Name = "label43";
            this.label43.Size = new System.Drawing.Size(69, 15);
            this.label43.TabIndex = 15;
            this.label43.Text = "Allowances";
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(18, 212);
            this.label47.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(39, 15);
            this.label47.TabIndex = 16;
            this.label47.Text = "Gross";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(776, 22);
            this.btnSave.Margin = new System.Windows.Forms.Padding(4);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(94, 45);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnClose
            // 
            this.btnClose.Location = new System.Drawing.Point(881, 22);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(94, 45);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(657, 22);
            this.btnPrint.Margin = new System.Windows.Forms.Padding(4);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(94, 45);
            this.btnPrint.TabIndex = 5;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPrint);
            this.groupBox5.Controls.Add(this.btnSave);
            this.groupBox5.Controls.Add(this.btnClose);
            this.groupBox5.Location = new System.Drawing.Point(11, 569);
            this.groupBox5.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox5.Size = new System.Drawing.Size(995, 83);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            // 
            // frmSalaryDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1021, 656);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmSalaryDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Salary Details";
            this.Load += new System.EventHandler(this.SalaryDetails_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.TSFixingMaster.ResumeLayout(false);
            this.TSFixingMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgSalary)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtGross;
        private System.Windows.Forms.TextBox txtDays;
        private System.Windows.Forms.TextBox txtAllowances;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtBasic;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.Label label43;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.Label label48;
        private System.Windows.Forms.Label label50;
        private System.Windows.Forms.Label label49;
        private System.Windows.Forms.TextBox txtEmployeePF;
        private System.Windows.Forms.TextBox txtEmployeeESIC;
        private System.Windows.Forms.TextBox txtEmployeePT;
        private System.Windows.Forms.TextBox txtEmployeeDeduction;
        private System.Windows.Forms.TextBox txtConv;
        private System.Windows.Forms.TextBox txtHRA;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.Label label44;
        private System.Windows.Forms.TextBox txtAdmnChrgs;
        private System.Windows.Forms.TextBox txtGrandTotal;
        private System.Windows.Forms.TextBox txtTotalSalary;
        private System.Windows.Forms.TextBox txtNetSalary;
        private System.Windows.Forms.TextBox txtTotalCTC;
        private System.Windows.Forms.Label label57;
        private System.Windows.Forms.Label label56;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.Label label52;
        private System.Windows.Forms.Label label51;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label label53;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.TextBox txtEmployerPF;
        private System.Windows.Forms.TextBox txtEmployerESIC;
        private System.Windows.Forms.DataGridView dgSalary;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpSalaryPeriod;
        private System.Windows.Forms.RichTextBox rtbSalaryRemark;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.DataGridViewTextBoxColumn SALARYID;
        private System.Windows.Forms.DataGridViewTextBoxColumn PERIOD;
        private System.Windows.Forms.ToolStrip TSFixingMaster;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.ToolStripButton btnModify;
        private System.Windows.Forms.ToolStripButton toolStripDelete;
        private System.Windows.Forms.GroupBox groupBox5;
    }
}