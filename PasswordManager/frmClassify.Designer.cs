namespace Password.Manager
{
    partial class frmClassify
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmClassify));
            this.palRight = new System.Windows.Forms.Panel();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnHelp = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.palMain = new System.Windows.Forms.Panel();
            this.tvClassify = new System.Windows.Forms.TreeView();
            this.palBottom = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbIsSystem = new System.Windows.Forms.CheckBox();
            this.txtSort = new System.Windows.Forms.TextBox();
            this.lblSort = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.lblCode = new System.Windows.Forms.Label();
            this.palRight.SuspendLayout();
            this.palMain.SuspendLayout();
            this.palBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // palRight
            // 
            this.palRight.Controls.Add(this.btnCancel);
            this.palRight.Controls.Add(this.btnSave);
            this.palRight.Controls.Add(this.btnHelp);
            this.palRight.Controls.Add(this.btnDelete);
            this.palRight.Controls.Add(this.btnAdd);
            this.palRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.palRight.Location = new System.Drawing.Point(415, 0);
            this.palRight.Name = "palRight";
            this.palRight.Size = new System.Drawing.Size(100, 295);
            this.palRight.TabIndex = 13;
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
            this.btnSave.TabIndex = 4;
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
            this.btnHelp.TabIndex = 3;
            this.btnHelp.Text = "帮助";
            this.btnHelp.UseVisualStyleBackColor = false;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Window;
            this.btnDelete.Enabled = false;
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.Image = global::Password.Manager.Properties.Resources.delete;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(6, 122);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 28);
            this.btnDelete.TabIndex = 2;
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
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "新增";
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // palMain
            // 
            this.palMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.palMain.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palMain.Controls.Add(this.tvClassify);
            this.palMain.Location = new System.Drawing.Point(6, 6);
            this.palMain.Name = "palMain";
            this.palMain.Size = new System.Drawing.Size(409, 208);
            this.palMain.TabIndex = 1;
            // 
            // tvClassify
            // 
            this.tvClassify.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tvClassify.HideSelection = false;
            this.tvClassify.HotTracking = true;
            this.tvClassify.Location = new System.Drawing.Point(0, 0);
            this.tvClassify.Name = "tvClassify";
            this.tvClassify.Size = new System.Drawing.Size(407, 208);
            this.tvClassify.TabIndex = 0;
            this.tvClassify.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.tvClassify_BeforeSelect);
            this.tvClassify.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tvClassify_KeyDown);
            // 
            // palBottom
            // 
            this.palBottom.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.palBottom.BackColor = System.Drawing.Color.White;
            this.palBottom.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.palBottom.Controls.Add(this.label3);
            this.palBottom.Controls.Add(this.label1);
            this.palBottom.Controls.Add(this.label2);
            this.palBottom.Controls.Add(this.cbIsSystem);
            this.palBottom.Controls.Add(this.txtSort);
            this.palBottom.Controls.Add(this.lblSort);
            this.palBottom.Controls.Add(this.txtName);
            this.palBottom.Controls.Add(this.lblName);
            this.palBottom.Controls.Add(this.txtCode);
            this.palBottom.Controls.Add(this.lblCode);
            this.palBottom.Location = new System.Drawing.Point(6, 220);
            this.palBottom.Name = "palBottom";
            this.palBottom.Size = new System.Drawing.Size(409, 69);
            this.palBottom.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(215, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 17);
            this.label3.TabIndex = 9;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(39, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(39, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 17);
            this.label2.TabIndex = 7;
            this.label2.Text = "*";
            // 
            // cbIsSystem
            // 
            this.cbIsSystem.AutoSize = true;
            this.cbIsSystem.Enabled = false;
            this.cbIsSystem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbIsSystem.Location = new System.Drawing.Point(232, 37);
            this.cbIsSystem.Name = "cbIsSystem";
            this.cbIsSystem.Size = new System.Drawing.Size(96, 21);
            this.cbIsSystem.TabIndex = 6;
            this.cbIsSystem.Text = "是否系统数据";
            this.cbIsSystem.UseVisualStyleBackColor = true;
            // 
            // txtSort
            // 
            this.txtSort.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSort.Enabled = false;
            this.txtSort.Location = new System.Drawing.Point(57, 37);
            this.txtSort.Name = "txtSort";
            this.txtSort.Size = new System.Drawing.Size(120, 23);
            this.txtSort.TabIndex = 5;
            this.txtSort.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtSort_KeyPress);
            this.txtSort.Leave += new System.EventHandler(this.txtSort_Leave);
            // 
            // lblSort
            // 
            this.lblSort.AutoSize = true;
            this.lblSort.Location = new System.Drawing.Point(5, 40);
            this.lblSort.Name = "lblSort";
            this.lblSort.Size = new System.Drawing.Size(32, 17);
            this.lblSort.TabIndex = 4;
            this.lblSort.Text = "排序";
            // 
            // txtName
            // 
            this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtName.Enabled = false;
            this.txtName.Location = new System.Drawing.Point(232, 7);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(120, 23);
            this.txtName.TabIndex = 3;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(180, 10);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(32, 17);
            this.lblName.TabIndex = 2;
            this.lblName.Text = "名称";
            // 
            // txtCode
            // 
            this.txtCode.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtCode.Enabled = false;
            this.txtCode.Location = new System.Drawing.Point(57, 7);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(120, 23);
            this.txtCode.TabIndex = 0;
            this.txtCode.Leave += new System.EventHandler(this.txtCode_Leave);
            // 
            // lblCode
            // 
            this.lblCode.AutoSize = true;
            this.lblCode.Location = new System.Drawing.Point(5, 10);
            this.lblCode.Name = "lblCode";
            this.lblCode.Size = new System.Drawing.Size(32, 17);
            this.lblCode.TabIndex = 0;
            this.lblCode.Text = "代码";
            // 
            // frmClassify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(515, 295);
            this.Controls.Add(this.palBottom);
            this.Controls.Add(this.palMain);
            this.Controls.Add(this.palRight);
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmClassify";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "分类";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmClassify_FormClosing);
            this.Load += new System.EventHandler(this.frmClassify_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmClassify_KeyDown);
            this.palRight.ResumeLayout(false);
            this.palMain.ResumeLayout(false);
            this.palBottom.ResumeLayout(false);
            this.palBottom.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel palRight;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnHelp;
        private System.Windows.Forms.Panel palMain;
        private System.Windows.Forms.TreeView tvClassify;
        private System.Windows.Forms.Panel palBottom;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtSort;
        private System.Windows.Forms.Label lblSort;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label lblCode;
        private System.Windows.Forms.CheckBox cbIsSystem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnCancel;
    }
}