namespace PayrollerManager
{
    partial class frmUsermasterListView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsermasterListView));
            this.tmr_Search = new System.Windows.Forms.Timer(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.TSFixingMaster = new System.Windows.Forms.ToolStrip();
            this.btnNew = new System.Windows.Forms.ToolStripButton();
            this.btnModify = new System.Windows.Forms.ToolStripButton();
            this.btnDelete = new System.Windows.Forms.ToolStripButton();
            this.btnPrevious = new System.Windows.Forms.ToolStripButton();
            this.btnNext = new System.Windows.Forms.ToolStripButton();
            this.btnRefresh = new System.Windows.Forms.ToolStripButton();
            this.DGUsermaster = new System.Windows.Forms.DataGridView();
            this.USERIID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLOYEECODE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMPLOYEENAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DEPARTMENT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERLOGINID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.USERTYPE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CONTACTNO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AADHAR = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grpSearch = new System.Windows.Forms.GroupBox();
            this.lblSearchColumn = new System.Windows.Forms.Label();
            this.btnFindNext = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.DBFilterText = new System.Windows.Forms.Label();
            this.txtFilterText = new System.Windows.Forms.TextBox();
            this.txtSearchText = new System.Windows.Forms.TextBox();
            this.DBSearchText = new System.Windows.Forms.Label();
            this.TSFixingMaster.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsermaster)).BeginInit();
            this.grpSearch.SuspendLayout();
            this.SuspendLayout();
            // 
            // tmr_Search
            // 
            this.tmr_Search.Tick += new System.EventHandler(this.tmr_Search_Tick);
            // 
            // TSFixingMaster
            // 
            this.TSFixingMaster.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnNew,
            this.btnModify,
            this.btnDelete,
            this.btnPrevious,
            this.btnNext,
            this.btnRefresh});
            this.TSFixingMaster.Location = new System.Drawing.Point(0, 0);
            this.TSFixingMaster.Name = "TSFixingMaster";
            this.TSFixingMaster.Size = new System.Drawing.Size(1223, 38);
            this.TSFixingMaster.TabIndex = 36;
            this.TSFixingMaster.Text = "toolStrip1";
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
            // btnDelete
            // 
            this.btnDelete.Image = ((System.Drawing.Image)(resources.GetObject("btnDelete.Image")));
            this.btnDelete.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(44, 35);
            this.btnDelete.Text = "Delete";
            this.btnDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnPrevious
            // 
            this.btnPrevious.Image = ((System.Drawing.Image)(resources.GetObject("btnPrevious.Image")));
            this.btnPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(56, 35);
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnNext
            // 
            this.btnNext.Image = ((System.Drawing.Image)(resources.GetObject("btnNext.Image")));
            this.btnNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(36, 35);
            this.btnNext.Text = "Next";
            this.btnNext.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // btnRefresh
            // 
            this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
            this.btnRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(50, 35);
            this.btnRefresh.Text = "Refresh";
            this.btnRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // DGUsermaster
            // 
            this.DGUsermaster.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGUsermaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGUsermaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.USERIID,
            this.EMPLOYEECODE,
            this.EMPLOYEENAME,
            this.DEPARTMENT,
            this.USERLOGINID,
            this.USERTYPE,
            this.CONTACTNO,
            this.AADHAR});
            this.DGUsermaster.Cursor = System.Windows.Forms.Cursors.Default;
            this.DGUsermaster.Location = new System.Drawing.Point(6, 44);
            this.DGUsermaster.MultiSelect = false;
            this.DGUsermaster.Name = "DGUsermaster";
            this.DGUsermaster.ReadOnly = true;
            this.DGUsermaster.RowHeadersWidth = 21;
            this.DGUsermaster.Size = new System.Drawing.Size(1209, 426);
            this.DGUsermaster.TabIndex = 34;
            this.DGUsermaster.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGUnitmasterlistview_CellClick);
            this.DGUsermaster.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGUnitmasterlistview_CellDoubleClick);
            // 
            // USERIID
            // 
            this.USERIID.HeaderText = "USERIID";
            this.USERIID.Name = "USERIID";
            this.USERIID.ReadOnly = true;
            this.USERIID.Visible = false;
            // 
            // EMPLOYEECODE
            // 
            this.EMPLOYEECODE.HeaderText = "EMPLOYEE CODE";
            this.EMPLOYEECODE.Name = "EMPLOYEECODE";
            this.EMPLOYEECODE.ReadOnly = true;
            this.EMPLOYEECODE.Width = 150;
            // 
            // EMPLOYEENAME
            // 
            this.EMPLOYEENAME.HeaderText = "EMPLOYEE NAME";
            this.EMPLOYEENAME.Name = "EMPLOYEENAME";
            this.EMPLOYEENAME.ReadOnly = true;
            this.EMPLOYEENAME.Width = 200;
            // 
            // DEPARTMENT
            // 
            this.DEPARTMENT.HeaderText = "DEPARTMENT";
            this.DEPARTMENT.Name = "DEPARTMENT";
            this.DEPARTMENT.ReadOnly = true;
            // 
            // USERLOGINID
            // 
            this.USERLOGINID.HeaderText = "LOGINID";
            this.USERLOGINID.Name = "USERLOGINID";
            this.USERLOGINID.ReadOnly = true;
            this.USERLOGINID.Width = 150;
            // 
            // USERTYPE
            // 
            this.USERTYPE.HeaderText = "USER TYPE";
            this.USERTYPE.Name = "USERTYPE";
            this.USERTYPE.ReadOnly = true;
            this.USERTYPE.Width = 150;
            // 
            // CONTACTNO
            // 
            this.CONTACTNO.HeaderText = "CONTACT NO";
            this.CONTACTNO.Name = "CONTACTNO";
            this.CONTACTNO.ReadOnly = true;
            this.CONTACTNO.Width = 150;
            // 
            // AADHAR
            // 
            this.AADHAR.HeaderText = "AADHAR NO";
            this.AADHAR.Name = "AADHAR";
            this.AADHAR.ReadOnly = true;
            this.AADHAR.Width = 150;
            // 
            // grpSearch
            // 
            this.grpSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpSearch.BackColor = System.Drawing.Color.Transparent;
            this.grpSearch.Controls.Add(this.lblSearchColumn);
            this.grpSearch.Controls.Add(this.btnFindNext);
            this.grpSearch.Controls.Add(this.btnReset);
            this.grpSearch.Controls.Add(this.btnApplyFilter);
            this.grpSearch.Controls.Add(this.DBFilterText);
            this.grpSearch.Controls.Add(this.txtFilterText);
            this.grpSearch.Controls.Add(this.txtSearchText);
            this.grpSearch.Controls.Add(this.DBSearchText);
            this.grpSearch.Location = new System.Drawing.Point(2, 475);
            this.grpSearch.Name = "grpSearch";
            this.grpSearch.Size = new System.Drawing.Size(1212, 93);
            this.grpSearch.TabIndex = 35;
            this.grpSearch.TabStop = false;
            // 
            // lblSearchColumn
            // 
            this.lblSearchColumn.AutoSize = true;
            this.lblSearchColumn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSearchColumn.ForeColor = System.Drawing.Color.Blue;
            this.lblSearchColumn.Location = new System.Drawing.Point(413, 23);
            this.lblSearchColumn.Name = "lblSearchColumn";
            this.lblSearchColumn.Size = new System.Drawing.Size(0, 13);
            this.lblSearchColumn.TabIndex = 42;
            // 
            // btnFindNext
            // 
            this.btnFindNext.FlatAppearance.BorderSize = 0;
            this.btnFindNext.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFindNext.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnFindNext.Image = ((System.Drawing.Image)(resources.GetObject("btnFindNext.Image")));
            this.btnFindNext.Location = new System.Drawing.Point(346, 23);
            this.btnFindNext.Name = "btnFindNext";
            this.btnFindNext.Size = new System.Drawing.Size(31, 27);
            this.btnFindNext.TabIndex = 20;
            this.btnFindNext.UseVisualStyleBackColor = true;
            this.btnFindNext.Click += new System.EventHandler(this.btnFindNext_Click);
            // 
            // btnReset
            // 
            this.btnReset.FlatAppearance.BorderSize = 0;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReset.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnReset.Image = ((System.Drawing.Image)(resources.GetObject("btnReset.Image")));
            this.btnReset.Location = new System.Drawing.Point(386, 58);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(27, 27);
            this.btnReset.TabIndex = 11;
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Visible = false;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.FlatAppearance.BorderSize = 0;
            this.btnApplyFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnApplyFilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnApplyFilter.Image = ((System.Drawing.Image)(resources.GetObject("btnApplyFilter.Image")));
            this.btnApplyFilter.Location = new System.Drawing.Point(346, 58);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(31, 27);
            this.btnApplyFilter.TabIndex = 10;
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Visible = false;
            // 
            // DBFilterText
            // 
            this.DBFilterText.AutoSize = true;
            this.DBFilterText.Location = new System.Drawing.Point(14, 61);
            this.DBFilterText.Name = "DBFilterText";
            this.DBFilterText.Size = new System.Drawing.Size(63, 15);
            this.DBFilterText.TabIndex = 9;
            this.DBFilterText.Text = "Filter Text:";
            this.DBFilterText.Visible = false;
            // 
            // txtFilterText
            // 
            this.txtFilterText.Location = new System.Drawing.Point(99, 58);
            this.txtFilterText.Name = "txtFilterText";
            this.txtFilterText.Size = new System.Drawing.Size(240, 21);
            this.txtFilterText.TabIndex = 8;
            this.txtFilterText.Visible = false;
            // 
            // txtSearchText
            // 
            this.txtSearchText.Location = new System.Drawing.Point(99, 23);
            this.txtSearchText.Name = "txtSearchText";
            this.txtSearchText.Size = new System.Drawing.Size(240, 21);
            this.txtSearchText.TabIndex = 7;
            this.txtSearchText.TextChanged += new System.EventHandler(this.txtSearchText_TextChanged);
            // 
            // DBSearchText
            // 
            this.DBSearchText.AutoSize = true;
            this.DBSearchText.Location = new System.Drawing.Point(14, 28);
            this.DBSearchText.Name = "DBSearchText";
            this.DBSearchText.Size = new System.Drawing.Size(75, 15);
            this.DBSearchText.TabIndex = 6;
            this.DBSearchText.Text = "Search Text:";
            // 
            // frmUsermasterListView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1223, 578);
            this.Controls.Add(this.TSFixingMaster);
            this.Controls.Add(this.DGUsermaster);
            this.Controls.Add(this.grpSearch);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmUsermasterListView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee Master List";
            this.Load += new System.EventHandler(this.frmSietelistview_Load);
            this.TSFixingMaster.ResumeLayout(false);
            this.TSFixingMaster.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGUsermaster)).EndInit();
            this.grpSearch.ResumeLayout(false);
            this.grpSearch.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer tmr_Search;
        private System.Windows.Forms.Label lblSearchColumn;
        private System.Windows.Forms.Button btnFindNext;
        private System.Windows.Forms.ToolStripButton btnModify;
        private System.Windows.Forms.ToolStripButton btnNew;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.ToolStripButton btnNext;
        private System.Windows.Forms.ToolStripButton btnPrevious;
        private System.Windows.Forms.ToolStripButton btnDelete;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Label DBFilterText;
        private System.Windows.Forms.ToolStrip TSFixingMaster;
        private System.Windows.Forms.ToolStripButton btnRefresh;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView DGUsermaster;
        private System.Windows.Forms.TextBox txtFilterText;
        private System.Windows.Forms.GroupBox grpSearch;
        private System.Windows.Forms.TextBox txtSearchText;
        private System.Windows.Forms.Label DBSearchText;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERIID;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLOYEECODE;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMPLOYEENAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DEPARTMENT;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERLOGINID;
        private System.Windows.Forms.DataGridViewTextBoxColumn USERTYPE;
        private System.Windows.Forms.DataGridViewTextBoxColumn CONTACTNO;
        private System.Windows.Forms.DataGridViewTextBoxColumn AADHAR;
    }
}