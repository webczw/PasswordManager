namespace Password.Manager
{
    partial class frmUserManager
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserManager));
            this.palBottom = new System.Windows.Forms.Panel();
            this.btnPassword = new System.Windows.Forms.Button();
            this.txtRemark = new System.Windows.Forms.TextBox();
            this.lblRemark = new System.Windows.Forms.Label();
            this.lblIsAdmin = new System.Windows.Forms.Label();
            this.cbIsAdmin = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblSex = new System.Windows.Forms.Label();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtChineseName = new System.Windows.Forms.TextBox();
            this.lblChineseName = new System.Windows.Forms.Label();
            this.txtLoginName = new System.Windows.Forms.TextBox();
            this.lblLoginName = new System.Windows.Forms.Label();
            this.dgvMain = new System.Windows.Forms.DataGridView();
            this.dgvPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvUserID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvLoginName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvChineseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvSex = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvIsAdmin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRemark = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.palRight = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.palBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).BeginInit();
            this.palRight.SuspendLayout();
            this.SuspendLayout();
            // 
            // palBottom
            // 
            this.palBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.palBottom.BackColor = System.Drawing.Color.White;
            this.palBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palBottom.Controls.Add(this.btnPassword);
            this.palBottom.Controls.Add(this.txtRemark);
            this.palBottom.Controls.Add(this.lblRemark);
            this.palBottom.Controls.Add(this.lblIsAdmin);
            this.palBottom.Controls.Add(this.cbIsAdmin);
            this.palBottom.Controls.Add(this.label1);
            this.palBottom.Controls.Add(this.label2);
            this.palBottom.Controls.Add(this.txtEmail);
            this.palBottom.Controls.Add(this.lblSex);
            this.palBottom.Controls.Add(this.cbSex);
            this.palBottom.Controls.Add(this.lblEmail);
            this.palBottom.Controls.Add(this.txtChineseName);
            this.palBottom.Controls.Add(this.lblChineseName);
            this.palBottom.Controls.Add(this.txtLoginName);
            this.palBottom.Controls.Add(this.lblLoginName);
            this.palBottom.Location = new System.Drawing.Point(6, 205);
            this.palBottom.Name = "palBottom";
            this.palBottom.Size = new System.Drawing.Size(570, 136);
            this.palBottom.TabIndex = 13;
            // 
            // btnPassword
            // 
            this.btnPassword.BackColor = System.Drawing.SystemColors.Window;
            this.btnPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPassword.Location = new System.Drawing.Point(166, 6);
            this.btnPassword.Name = "btnPassword";
            this.btnPassword.Size = new System.Drawing.Size(26, 23);
            this.btnPassword.TabIndex = 21;
            this.btnPassword.Text = "...";
            this.btnPassword.UseVisualStyleBackColor = false;
            this.btnPassword.Click += new System.EventHandler(this.btnPassword_Click);
            // 
            // txtRemark
            // 
            this.txtRemark.Location = new System.Drawing.Point(62, 66);
            this.txtRemark.Multiline = true;
            this.txtRemark.Name = "txtRemark";
            this.txtRemark.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtRemark.Size = new System.Drawing.Size(500, 62);
            this.txtRemark.TabIndex = 14;
            this.txtRemark.Leave += new System.EventHandler(this.txtRemark_Leave);
            // 
            // lblRemark
            // 
            this.lblRemark.AutoSize = true;
            this.lblRemark.Location = new System.Drawing.Point(3, 83);
            this.lblRemark.Name = "lblRemark";
            this.lblRemark.Size = new System.Drawing.Size(32, 17);
            this.lblRemark.TabIndex = 13;
            this.lblRemark.Text = "备注";
            // 
            // lblIsAdmin
            // 
            this.lblIsAdmin.AutoSize = true;
            this.lblIsAdmin.Location = new System.Drawing.Point(198, 39);
            this.lblIsAdmin.Name = "lblIsAdmin";
            this.lblIsAdmin.Size = new System.Drawing.Size(56, 17);
            this.lblIsAdmin.TabIndex = 12;
            this.lblIsAdmin.Text = "用户类型";
            // 
            // cbIsAdmin
            // 
            this.cbIsAdmin.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbIsAdmin.FormattingEnabled = true;
            this.cbIsAdmin.Items.AddRange(new object[] {
            "普通用户",
            "管理用户"});
            this.cbIsAdmin.Location = new System.Drawing.Point(258, 35);
            this.cbIsAdmin.Name = "cbIsAdmin";
            this.cbIsAdmin.Size = new System.Drawing.Size(130, 25);
            this.cbIsAdmin.TabIndex = 11;
            this.cbIsAdmin.SelectedIndexChanged += new System.EventHandler(this.cbIsAdmin_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(45, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(238, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 8;
            this.label2.Text = "*";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(432, 6);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(130, 23);
            this.txtEmail.TabIndex = 4;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(3, 38);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(32, 17);
            this.lblSex.TabIndex = 6;
            this.lblSex.Text = "性别";
            // 
            // cbSex
            // 
            this.cbSex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbSex.Location = new System.Drawing.Point(62, 35);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(130, 25);
            this.cbSex.TabIndex = 3;
            this.cbSex.SelectedIndexChanged += new System.EventHandler(this.cbSex_SelectedIndexChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(394, 9);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 17);
            this.lblEmail.TabIndex = 4;
            this.lblEmail.Text = "邮箱";
            // 
            // txtChineseName
            // 
            this.txtChineseName.Location = new System.Drawing.Point(258, 6);
            this.txtChineseName.Name = "txtChineseName";
            this.txtChineseName.Size = new System.Drawing.Size(130, 23);
            this.txtChineseName.TabIndex = 2;
            this.txtChineseName.Leave += new System.EventHandler(this.txtChineseName_Leave);
            // 
            // lblChineseName
            // 
            this.lblChineseName.AutoSize = true;
            this.lblChineseName.Location = new System.Drawing.Point(198, 9);
            this.lblChineseName.Name = "lblChineseName";
            this.lblChineseName.Size = new System.Drawing.Size(44, 17);
            this.lblChineseName.TabIndex = 2;
            this.lblChineseName.Text = "显示名";
            // 
            // txtLoginName
            // 
            this.txtLoginName.Location = new System.Drawing.Point(62, 6);
            this.txtLoginName.Name = "txtLoginName";
            this.txtLoginName.Size = new System.Drawing.Size(130, 23);
            this.txtLoginName.TabIndex = 1;
            this.txtLoginName.Leave += new System.EventHandler(this.txtLoginName_Leave);
            // 
            // lblLoginName
            // 
            this.lblLoginName.AutoSize = true;
            this.lblLoginName.Location = new System.Drawing.Point(3, 9);
            this.lblLoginName.Name = "lblLoginName";
            this.lblLoginName.Size = new System.Drawing.Size(44, 17);
            this.lblLoginName.TabIndex = 0;
            this.lblLoginName.Text = "登录名";
            // 
            // dgvMain
            // 
            this.dgvMain.AllowUserToAddRows = false;
            this.dgvMain.AllowUserToDeleteRows = false;
            this.dgvMain.AllowUserToResizeRows = false;
            this.dgvMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvMain.BackgroundColor = System.Drawing.Color.White;
            this.dgvMain.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMain.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dgvPassword,
            this.dgvUserID,
            this.dgvGuid,
            this.dgvLoginName,
            this.dgvChineseName,
            this.dgvEmail,
            this.dgvSex,
            this.dgvIsAdmin,
            this.dgvRemark});
            this.dgvMain.Location = new System.Drawing.Point(6, 6);
            this.dgvMain.MultiSelect = false;
            this.dgvMain.Name = "dgvMain";
            this.dgvMain.ReadOnly = true;
            this.dgvMain.RowHeadersVisible = false;
            this.dgvMain.RowTemplate.Height = 23;
            this.dgvMain.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMain.Size = new System.Drawing.Size(570, 193);
            this.dgvMain.TabIndex = 12;
            this.dgvMain.SelectionChanged += new System.EventHandler(this.dgvMain_SelectionChanged);
            this.dgvMain.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dgvMain_KeyDown);
            // 
            // dgvPassword
            // 
            this.dgvPassword.HeaderText = "dgvPassword";
            this.dgvPassword.Name = "dgvPassword";
            this.dgvPassword.ReadOnly = true;
            this.dgvPassword.Visible = false;
            // 
            // dgvUserID
            // 
            this.dgvUserID.HeaderText = "dgvUserID";
            this.dgvUserID.Name = "dgvUserID";
            this.dgvUserID.ReadOnly = true;
            this.dgvUserID.Visible = false;
            // 
            // dgvGuid
            // 
            this.dgvGuid.HeaderText = "dgvGuid";
            this.dgvGuid.Name = "dgvGuid";
            this.dgvGuid.ReadOnly = true;
            this.dgvGuid.Visible = false;
            // 
            // dgvLoginName
            // 
            this.dgvLoginName.HeaderText = "登录名";
            this.dgvLoginName.Name = "dgvLoginName";
            this.dgvLoginName.ReadOnly = true;
            // 
            // dgvChineseName
            // 
            this.dgvChineseName.HeaderText = "显示名";
            this.dgvChineseName.Name = "dgvChineseName";
            this.dgvChineseName.ReadOnly = true;
            // 
            // dgvEmail
            // 
            this.dgvEmail.HeaderText = "邮箱";
            this.dgvEmail.Name = "dgvEmail";
            this.dgvEmail.ReadOnly = true;
            // 
            // dgvSex
            // 
            this.dgvSex.HeaderText = "性别";
            this.dgvSex.Name = "dgvSex";
            this.dgvSex.ReadOnly = true;
            this.dgvSex.Width = 70;
            // 
            // dgvIsAdmin
            // 
            this.dgvIsAdmin.HeaderText = "用户类型";
            this.dgvIsAdmin.Name = "dgvIsAdmin";
            this.dgvIsAdmin.ReadOnly = true;
            // 
            // dgvRemark
            // 
            this.dgvRemark.HeaderText = "备注";
            this.dgvRemark.Name = "dgvRemark";
            this.dgvRemark.ReadOnly = true;
            // 
            // palRight
            // 
            this.palRight.Controls.Add(this.btnCancel);
            this.palRight.Controls.Add(this.btnSave);
            this.palRight.Controls.Add(this.btnHelp);
            this.palRight.Controls.Add(this.btnDelete);
            this.palRight.Controls.Add(this.btnAdd);
            this.palRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.palRight.Location = new System.Drawing.Point(576, 0);
            this.palRight.Name = "palRight";
            this.palRight.Size = new System.Drawing.Size(100, 347);
            this.palRight.TabIndex = 14;
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.SystemColors.Window;
            this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancel.Image = global::Password.Manager.Properties.Resources.cancel;
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCancel.Location = new System.Drawing.Point(6, 40);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(88, 28);
            this.btnCancel.TabIndex = 10;
            this.btnCancel.Text = "取消";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.SystemColors.Window;
            this.btnSave.Enabled = false;
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::Password.Manager.Properties.Resources.page_save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 28);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "保存";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.BackColor = System.Drawing.SystemColors.Window;
            this.btnHelp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHelp.Image = global::Password.Manager.Properties.Resources.help;
            this.btnHelp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHelp.Location = new System.Drawing.Point(6, 170);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(88, 28);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "帮助";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Window;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::Password.Manager.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(6, 122);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 28);
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "删除";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Window;
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.Image = global::Password.Manager.Properties.Resources.add;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(6, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(88, 28);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // frmUserManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 347);
            this.Controls.Add(this.palBottom);
            this.Controls.Add(this.dgvMain);
            this.Controls.Add(this.palRight);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmUserManager";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "用户";
            this.Load += new System.EventHandler(this.frmUserManager_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUserManager_KeyDown);
            this.palBottom.ResumeLayout(false);
            this.palBottom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMain)).EndInit();
            this.palRight.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palBottom;
        private System.Windows.Forms.TextBox txtRemark;
        private System.Windows.Forms.Label lblRemark;
        private System.Windows.Forms.Label lblIsAdmin;
        private System.Windows.Forms.ComboBox cbIsAdmin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.TextBox txtChineseName;
        private System.Windows.Forms.Label lblChineseName;
        private System.Windows.Forms.TextBox txtLoginName;
        private System.Windows.Forms.Label lblLoginName;
        private System.Windows.Forms.DataGridView dgvMain;
        private System.Windows.Forms.Panel palRight;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvUserID;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvLoginName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvChineseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvSex;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvIsAdmin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dgvRemark;
    }
}