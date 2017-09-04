namespace Password.Manager
{
    partial class frmLog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLog));
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.LogId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RowNumer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLevel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLogger = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvMessage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLocation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvException = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cmsLog = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiSelectPanel = new System.Windows.Forms.ToolStripMenuItem();
            this.gbSelect = new System.Windows.Forms.GroupBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtContent = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.EndDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.StartDate = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel5 = new System.Windows.Forms.ToolStripLabel();
            this.tstPageIndex = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripLabel6 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.lblPageCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel8 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripLabel9 = new System.Windows.Forms.ToolStripLabel();
            this.lblRowsCount = new System.Windows.Forms.ToolStripLabel();
            this.toolStripLabel11 = new System.Windows.Forms.ToolStripLabel();
            this.bnLogPage = new System.Windows.Forms.BindingNavigator(this.components);
            this.tsbFirst = new System.Windows.Forms.ToolStripButton();
            this.tsbPrevious = new System.Windows.Forms.ToolStripButton();
            this.tsbNext = new System.Windows.Forms.ToolStripButton();
            this.tsbLast = new System.Windows.Forms.ToolStripButton();
            this.tsbGO = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.cmsLog.SuspendLayout();
            this.gbSelect.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnLogPage)).BeginInit();
            this.bnLogPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.LogId,
            this.RowNumer,
            this.dgvDate,
            this.dgvLevel,
            this.dgvLogger,
            this.dgvMessage,
            this.dgvLocation,
            this.dgvException});
            this.dgvMain.ContextMenuStrip = this.cmsLog;
            this.dgvMain.Location = new System.Drawing.Point(0, 0);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(800, 502);
            this.dgvMain.TabIndex = 0;
            this.dgvMain.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMain_CellDoubleClick);
            // 
            // LogId
            // 
            this.LogId.HeaderText = "LogId";
            this.LogId.Name = "LogId";
            this.LogId.ReadOnly = true;
            this.LogId.Visible = false;
            // 
            // RowNumer
            // 
            this.RowNumer.HeaderText = "序号";
            this.RowNumer.Name = "RowNumer";
            this.RowNumer.ReadOnly = true;
            this.RowNumer.Width = 80;
            // 
            // dgvDate
            // 
            this.dgvDate.HeaderText = "日期";
            this.dgvDate.Name = "dgvDate";
            this.dgvDate.ReadOnly = true;
            this.dgvDate.Width = 120;
            // 
            // dgvLevel
            // 
            this.dgvLevel.HeaderText = "级别";
            this.dgvLevel.Name = "dgvLevel";
            this.dgvLevel.ReadOnly = true;
            this.dgvLevel.Width = 120;
            // 
            // dgvLogger
            // 
            this.dgvLogger.HeaderText = "记录";
            this.dgvLogger.Name = "dgvLogger";
            this.dgvLogger.ReadOnly = true;
            this.dgvLogger.Width = 120;
            // 
            // dgvMessage
            // 
            this.dgvMessage.HeaderText = "消息";
            this.dgvMessage.Name = "dgvMessage";
            this.dgvMessage.ReadOnly = true;
            this.dgvMessage.Width = 120;
            // 
            // dgvLocation
            // 
            this.dgvLocation.HeaderText = "位置";
            this.dgvLocation.Name = "dgvLocation";
            this.dgvLocation.ReadOnly = true;
            this.dgvLocation.Width = 120;
            // 
            // dgvException
            // 
            this.dgvException.HeaderText = "异常";
            this.dgvException.Name = "dgvException";
            this.dgvException.ReadOnly = true;
            this.dgvException.Width = 120;
            // 
            // cmsLog
            // 
            this.cmsLog.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSelectPanel});
            this.cmsLog.Name = "cmsLog";
            this.cmsLog.Size = new System.Drawing.Size(192, 26);
            // 
            // tsmiSelectPanel
            // 
            this.tsmiSelectPanel.Image = global::Password.Manager.Properties.Resources.magnifier;
            this.tsmiSelectPanel.Name = "tsmiSelectPanel";
            this.tsmiSelectPanel.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.tsmiSelectPanel.Size = new System.Drawing.Size(191, 22);
            this.tsmiSelectPanel.Text = "打开查询面板";
            this.tsmiSelectPanel.Click += new System.EventHandler(this.tsmiSelectPanel_Click);
            // 
            // gbSelect
            // 
            this.gbSelect.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbSelect.Controls.Add(this.btnSelect);
            this.gbSelect.Controls.Add(this.txtContent);
            this.gbSelect.Controls.Add(this.label3);
            this.gbSelect.Controls.Add(this.EndDate);
            this.gbSelect.Controls.Add(this.label2);
            this.gbSelect.Controls.Add(this.StartDate);
            this.gbSelect.Controls.Add(this.label1);
            this.gbSelect.Location = new System.Drawing.Point(8, 0);
            this.gbSelect.Name = "gbSelect";
            this.gbSelect.Size = new System.Drawing.Size(784, 47);
            this.gbSelect.TabIndex = 2;
            this.gbSelect.TabStop = false;
            this.gbSelect.Text = "查询面板";
            this.gbSelect.Visible = false;
            // 
            // btnSelect
            // 
            this.btnSelect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSelect.BackColor = System.Drawing.SystemColors.Window;
            this.btnSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSelect.Image = global::Password.Manager.Properties.Resources.magnifier;
            this.btnSelect.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSelect.Location = new System.Drawing.Point(691, 13);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(88, 28);
            this.btnSelect.TabIndex = 10;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = false;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // txtContent
            // 
            this.txtContent.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtContent.Location = new System.Drawing.Point(360, 16);
            this.txtContent.Name = "txtContent";
            this.txtContent.Size = new System.Drawing.Size(325, 23);
            this.txtContent.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(322, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "内容";
            // 
            // EndDate
            // 
            this.EndDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.EndDate.Location = new System.Drawing.Point(208, 16);
            this.EndDate.Name = "EndDate";
            this.EndDate.Size = new System.Drawing.Size(108, 23);
            this.EndDate.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(182, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(20, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "到";
            // 
            // StartDate
            // 
            this.StartDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.StartDate.Location = new System.Drawing.Point(70, 16);
            this.StartDate.Name = "StartDate";
            this.StartDate.Size = new System.Drawing.Size(108, 23);
            this.StartDate.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "日期从";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel5
            // 
            this.toolStripLabel5.Name = "toolStripLabel5";
            this.toolStripLabel5.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel5.Text = "第";
            // 
            // tstPageIndex
            // 
            this.tstPageIndex.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tstPageIndex.Name = "tstPageIndex";
            this.tstPageIndex.Size = new System.Drawing.Size(40, 25);
            this.tstPageIndex.Text = "1";
            this.tstPageIndex.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tstPageIndex_KeyPress);
            // 
            // toolStripLabel6
            // 
            this.toolStripLabel6.Name = "toolStripLabel6";
            this.toolStripLabel6.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel6.Text = "页";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // lblPageCount
            // 
            this.lblPageCount.Name = "lblPageCount";
            this.lblPageCount.Size = new System.Drawing.Size(15, 22);
            this.lblPageCount.Text = "1";
            // 
            // toolStripLabel8
            // 
            this.toolStripLabel8.Name = "toolStripLabel8";
            this.toolStripLabel8.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel8.Text = "页";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripLabel9
            // 
            this.toolStripLabel9.Name = "toolStripLabel9";
            this.toolStripLabel9.Size = new System.Drawing.Size(20, 22);
            this.toolStripLabel9.Text = "共";
            // 
            // lblRowsCount
            // 
            this.lblRowsCount.Name = "lblRowsCount";
            this.lblRowsCount.Size = new System.Drawing.Size(15, 22);
            this.lblRowsCount.Text = "1";
            // 
            // toolStripLabel11
            // 
            this.toolStripLabel11.Name = "toolStripLabel11";
            this.toolStripLabel11.Size = new System.Drawing.Size(44, 22);
            this.toolStripLabel11.Text = "条记录";
            // 
            // bnLogPage
            // 
            this.bnLogPage.AddNewItem = null;
            this.bnLogPage.CountItem = null;
            this.bnLogPage.DeleteItem = null;
            this.bnLogPage.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bnLogPage.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.bnLogPage.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsbFirst,
            this.tsbPrevious,
            this.tsbNext,
            this.tsbLast,
            this.toolStripSeparator1,
            this.toolStripLabel5,
            this.tstPageIndex,
            this.toolStripLabel6,
            this.tsbGO,
            this.toolStripSeparator2,
            this.toolStripButton2,
            this.lblPageCount,
            this.toolStripLabel8,
            this.toolStripSeparator3,
            this.toolStripLabel9,
            this.lblRowsCount,
            this.toolStripLabel11});
            this.bnLogPage.Location = new System.Drawing.Point(0, 504);
            this.bnLogPage.MoveFirstItem = null;
            this.bnLogPage.MoveLastItem = null;
            this.bnLogPage.MoveNextItem = null;
            this.bnLogPage.MovePreviousItem = null;
            this.bnLogPage.Name = "bnLogPage";
            this.bnLogPage.PositionItem = null;
            this.bnLogPage.Size = new System.Drawing.Size(800, 25);
            this.bnLogPage.TabIndex = 1;
            this.bnLogPage.Text = "bindingNavigator1";
            // 
            // tsbFirst
            // 
            this.tsbFirst.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbFirst.Image = ((System.Drawing.Image)(resources.GetObject("tsbFirst.Image")));
            this.tsbFirst.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbFirst.Name = "tsbFirst";
            this.tsbFirst.Size = new System.Drawing.Size(48, 22);
            this.tsbFirst.Text = "第一页";
            this.tsbFirst.Click += new System.EventHandler(this.tsbFirst_Click);
            // 
            // tsbPrevious
            // 
            this.tsbPrevious.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbPrevious.Image = ((System.Drawing.Image)(resources.GetObject("tsbPrevious.Image")));
            this.tsbPrevious.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbPrevious.Name = "tsbPrevious";
            this.tsbPrevious.Size = new System.Drawing.Size(48, 22);
            this.tsbPrevious.Text = "上一页";
            this.tsbPrevious.Click += new System.EventHandler(this.tsbPrevious_Click);
            // 
            // tsbNext
            // 
            this.tsbNext.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbNext.Image = ((System.Drawing.Image)(resources.GetObject("tsbNext.Image")));
            this.tsbNext.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbNext.Name = "tsbNext";
            this.tsbNext.Size = new System.Drawing.Size(48, 22);
            this.tsbNext.Text = "下一页";
            this.tsbNext.Click += new System.EventHandler(this.tsbNext_Click);
            // 
            // tsbLast
            // 
            this.tsbLast.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbLast.Image = ((System.Drawing.Image)(resources.GetObject("tsbLast.Image")));
            this.tsbLast.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbLast.Name = "tsbLast";
            this.tsbLast.Size = new System.Drawing.Size(48, 22);
            this.tsbLast.Text = "最后页";
            this.tsbLast.Click += new System.EventHandler(this.tsbLast_Click);
            // 
            // tsbGO
            // 
            this.tsbGO.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.tsbGO.Image = ((System.Drawing.Image)(resources.GetObject("tsbGO.Image")));
            this.tsbGO.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsbGO.Name = "tsbGO";
            this.tsbGO.Size = new System.Drawing.Size(31, 22);
            this.tsbGO.Text = "GO";
            this.tsbGO.Click += new System.EventHandler(this.tsbGO_Click);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(20, 22);
            this.toolStripButton2.Text = "共";
            // 
            // frmLog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 529);
            this.Controls.Add(this.gbSelect);
            this.Controls.Add(this.bnLogPage);
            this.Controls.Add(this.dgvMain);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLog";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "日志";
            this.Load += new System.EventHandler(this.frmLog_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmLog_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.cmsLog.ResumeLayout(false);
            this.gbSelect.ResumeLayout(false);
            this.gbSelect.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bnLogPage)).EndInit();
            this.bnLogPage.ResumeLayout(false);
            this.bnLogPage.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn LogId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RowNumer;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLevel;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLogger;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvMessage;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLocation;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvException;
        private System.Windows.Forms.GroupBox gbSelect;
        private System.Windows.Forms.TextBox txtContent;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker EndDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker StartDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ToolStripButton tsbFirst;
        private System.Windows.Forms.ToolStripButton tsbPrevious;
        private System.Windows.Forms.ToolStripButton tsbNext;
        private System.Windows.Forms.ToolStripButton tsbLast;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel5;
        private System.Windows.Forms.ToolStripTextBox tstPageIndex;
        private System.Windows.Forms.ToolStripLabel toolStripLabel6;
        private System.Windows.Forms.ToolStripButton tsbGO;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripLabel toolStripButton2;
        private System.Windows.Forms.ToolStripLabel lblPageCount;
        private System.Windows.Forms.ToolStripLabel toolStripLabel8;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripLabel toolStripLabel9;
        private System.Windows.Forms.ToolStripLabel lblRowsCount;
        private System.Windows.Forms.ToolStripLabel toolStripLabel11;
        private System.Windows.Forms.BindingNavigator bnLogPage;
        private System.Windows.Forms.ContextMenuStrip cmsLog;
        private System.Windows.Forms.ToolStripMenuItem tsmiSelectPanel;
    }
}