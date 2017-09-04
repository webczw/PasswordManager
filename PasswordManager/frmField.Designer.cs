namespace Password.Manager
{
    partial class frmField
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmField));
            this.palRight = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.dgvLeft = new System.Windows.Forms.DataGridView();
            this.UserFieldsGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LeftSystemField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvRight = new System.Windows.Forms.DataGridView();
            this.FieldGuid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RightSystemField = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnLeft = new System.Windows.Forms.Button();
            this.btnTop = new System.Windows.Forms.Button();
            this.btnBottm = new System.Windows.Forms.Button();
            this.btnRight = new System.Windows.Forms.Button();
            this.palMain = new System.Windows.Forms.Panel();
            this.palRight.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeft)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRight)).BeginInit();
            this.palMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // palRight
            // 
            this.palRight.Controls.Add(this.btnCancel);
            this.palRight.Controls.Add(this.btnSave);
            this.palRight.Controls.Add(this.btnHelp);
            this.palRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.palRight.Location = new System.Drawing.Point(475, 0);
            this.palRight.Name = "palRight";
            this.palRight.Size = new System.Drawing.Size(100, 380);
            this.palRight.TabIndex = 8;
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
            this.btnSave.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSave.Image = global::Password.Manager.Properties.Resources.page_save;
            this.btnSave.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSave.Location = new System.Drawing.Point(6, 6);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 28);
            this.btnSave.TabIndex = 9;
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
            this.btnHelp.Location = new System.Drawing.Point(6, 88);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(88, 28);
            this.btnHelp.TabIndex = 11;
            this.btnHelp.Text = "帮助";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // dgvLeft
            // 
            this.dgvLeft.AllowUserToAddRows = false;
            this.dgvLeft.AllowUserToDeleteRows = false;
            this.dgvLeft.AllowUserToResizeRows = false;
            this.dgvLeft.BackgroundColor = System.Drawing.Color.White;
            this.dgvLeft.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLeft.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.UserFieldsGuid,
            this.LeftCode,
            this.LeftName,
            this.LeftSystemField});
            this.dgvLeft.Location = new System.Drawing.Point(6, 6);
            this.dgvLeft.MultiSelect = false;
            this.dgvLeft.Name = "dgvLeft";
            this.dgvLeft.ReadOnly = true;
            this.dgvLeft.RowHeadersVisible = false;
            this.dgvLeft.RowTemplate.Height = 23;
            this.dgvLeft.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvLeft.Size = new System.Drawing.Size(190, 354);
            this.dgvLeft.TabIndex = 2;
            this.dgvLeft.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvLeft_CellDoubleClick);
            // 
            // UserFieldsGuid
            // 
            this.UserFieldsGuid.HeaderText = "UserFieldsGuid";
            this.UserFieldsGuid.Name = "UserFieldsGuid";
            this.UserFieldsGuid.ReadOnly = true;
            this.UserFieldsGuid.Visible = false;
            // 
            // LeftCode
            // 
            this.LeftCode.HeaderText = "LeftCode";
            this.LeftCode.Name = "LeftCode";
            this.LeftCode.ReadOnly = true;
            this.LeftCode.Visible = false;
            // 
            // LeftName
            // 
            this.LeftName.HeaderText = "可选字段";
            this.LeftName.Name = "LeftName";
            this.LeftName.ReadOnly = true;
            // 
            // LeftSystemField
            // 
            this.LeftSystemField.HeaderText = "类型";
            this.LeftSystemField.Name = "LeftSystemField";
            this.LeftSystemField.ReadOnly = true;
            this.LeftSystemField.Width = 80;
            // 
            // dgvRight
            // 
            this.dgvRight.AllowUserToAddRows = false;
            this.dgvRight.AllowUserToDeleteRows = false;
            this.dgvRight.AllowUserToResizeRows = false;
            this.dgvRight.BackgroundColor = System.Drawing.Color.White;
            this.dgvRight.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRight.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FieldGuid,
            this.RightCode,
            this.RightName,
            this.RightSystemField});
            this.dgvRight.Location = new System.Drawing.Point(236, 6);
            this.dgvRight.MultiSelect = false;
            this.dgvRight.Name = "dgvRight";
            this.dgvRight.ReadOnly = true;
            this.dgvRight.RowHeadersVisible = false;
            this.dgvRight.RowTemplate.Height = 23;
            this.dgvRight.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvRight.Size = new System.Drawing.Size(190, 354);
            this.dgvRight.TabIndex = 5;
            this.dgvRight.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvRight_CellDoubleClick);
            // 
            // FieldGuid
            // 
            this.FieldGuid.HeaderText = "FieldGuid";
            this.FieldGuid.Name = "FieldGuid";
            this.FieldGuid.ReadOnly = true;
            this.FieldGuid.Visible = false;
            // 
            // RightCode
            // 
            this.RightCode.HeaderText = "RightCode";
            this.RightCode.Name = "RightCode";
            this.RightCode.ReadOnly = true;
            this.RightCode.Visible = false;
            // 
            // RightName
            // 
            this.RightName.HeaderText = "已选字段";
            this.RightName.Name = "RightName";
            this.RightName.ReadOnly = true;
            // 
            // RightSystemField
            // 
            this.RightSystemField.HeaderText = "类型";
            this.RightSystemField.Name = "RightSystemField";
            this.RightSystemField.ReadOnly = true;
            this.RightSystemField.Width = 80;
            // 
            // btnLeft
            // 
            this.btnLeft.BackColor = System.Drawing.SystemColors.Window;
            this.btnLeft.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLeft.Image = global::Password.Manager.Properties.Resources._1;
            this.btnLeft.Location = new System.Drawing.Point(202, 33);
            this.btnLeft.Name = "btnLeft";
            this.btnLeft.Size = new System.Drawing.Size(28, 28);
            this.btnLeft.TabIndex = 3;
            this.btnLeft.UseVisualStyleBackColor = false;
            this.btnLeft.Click += new System.EventHandler(this.btnLeft_Click);
            // 
            // btnTop
            // 
            this.btnTop.BackColor = System.Drawing.SystemColors.Window;
            this.btnTop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTop.Image = global::Password.Manager.Properties.Resources._3;
            this.btnTop.Location = new System.Drawing.Point(432, 33);
            this.btnTop.Name = "btnTop";
            this.btnTop.Size = new System.Drawing.Size(28, 28);
            this.btnTop.TabIndex = 6;
            this.btnTop.UseVisualStyleBackColor = false;
            this.btnTop.Click += new System.EventHandler(this.btnTop_Click);
            // 
            // btnBottm
            // 
            this.btnBottm.BackColor = System.Drawing.SystemColors.Window;
            this.btnBottm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBottm.Image = global::Password.Manager.Properties.Resources._4;
            this.btnBottm.Location = new System.Drawing.Point(432, 76);
            this.btnBottm.Name = "btnBottm";
            this.btnBottm.Size = new System.Drawing.Size(28, 28);
            this.btnBottm.TabIndex = 7;
            this.btnBottm.UseVisualStyleBackColor = false;
            this.btnBottm.Click += new System.EventHandler(this.btnBottm_Click);
            // 
            // btnRight
            // 
            this.btnRight.BackColor = System.Drawing.SystemColors.Window;
            this.btnRight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRight.Image = global::Password.Manager.Properties.Resources._2;
            this.btnRight.Location = new System.Drawing.Point(202, 76);
            this.btnRight.Name = "btnRight";
            this.btnRight.Size = new System.Drawing.Size(28, 28);
            this.btnRight.TabIndex = 4;
            this.btnRight.UseVisualStyleBackColor = false;
            this.btnRight.Click += new System.EventHandler(this.btnRight_Click);
            // 
            // palMain
            // 
            this.palMain.BackColor = System.Drawing.Color.White;
            this.palMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palMain.Controls.Add(this.dgvRight);
            this.palMain.Controls.Add(this.btnRight);
            this.palMain.Controls.Add(this.dgvLeft);
            this.palMain.Controls.Add(this.btnBottm);
            this.palMain.Controls.Add(this.btnLeft);
            this.palMain.Controls.Add(this.btnTop);
            this.palMain.Location = new System.Drawing.Point(6, 6);
            this.palMain.Margin = new System.Windows.Forms.Padding(6);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(469, 368);
            this.palMain.TabIndex = 1;
            // 
            // frmField
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 380);
            this.Controls.Add(this.palMain);
            this.Controls.Add(this.palRight);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmField";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "栏位";
            this.Load += new System.EventHandler(this.frmField_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmField_KeyDown);
            this.palRight.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRight)).EndInit();
            this.palMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palRight;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.DataGridView dgvLeft;
        private System.Windows.Forms.DataGridView dgvRight;
        private System.Windows.Forms.Button btnLeft;
        private System.Windows.Forms.Button btnTop;
        private System.Windows.Forms.Button btnBottm;
        private System.Windows.Forms.Button btnRight;
        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.DataGridViewTextBoxColumn UserFieldsGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftName;
        private System.Windows.Forms.DataGridViewTextBoxColumn LeftSystemField;
        private System.Windows.Forms.DataGridViewTextBoxColumn FieldGuid;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightName;
        private System.Windows.Forms.DataGridViewTextBoxColumn RightSystemField;
    }
}