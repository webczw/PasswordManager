using Password.Common;
using Password.Manager.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password.Manager
{
    public partial class frmShowPassword : Form
    {
        string pwd = "";
        frmMain parentMain;
        public frmShowPassword(string strPassword, frmMain main)
        {
            InitializeComponent();
            pwd = strPassword;
            parentMain = main;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Cancel();
        }
        /// <summary>
        /// 取消
        /// </summary>
        private void Cancel()
        {
            this.Close();
        }

        private void btnCopy_Click(object sender, EventArgs e)
        {
            Copy();
        }
        /// <summary>
        /// 复制
        /// </summary>
        private void Copy()
        {
            if (!string.IsNullOrWhiteSpace(txtPassowrd.Text))
            {
                txtPassowrd.SelectAll();
                Clipboard.SetDataObject(txtPassowrd.Text);
                MessageBox.Show("复制成功。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void frmShowPassword_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(pwd))
            {
                txtPassowrd.Text = pwd;// TripleDES.DecryptPassword(pwd);
                txtPassowrd.SelectAll();
            }
        }

        private void frmShowPassword_KeyDown(object sender, KeyEventArgs e)
        {
            //注册键事件
            FormKeyEvent formKeyEvent = new FormKeyEvent();//创建键事件处理实例类
            formKeyEvent.KeyEnterEvent += new FormKeyEvent.FormKey(Copy);//复制
            formKeyEvent.KeyEscapeEvent += new FormKeyEvent.FormKey(Cancel);//取消
            formKeyEvent.KeyF1Event += new FormKeyEvent.FormKey(Help);//帮助
            formKeyEvent.Run(e);//运行注册的方法
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help();
        }

        /// <summary>
        /// 帮助
        /// </summary>
        private void Help()
        {
            parentMain.ShowHelp(HelpIdDefines.HId_解码);
        }
    }
}
