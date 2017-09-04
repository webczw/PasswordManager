using Password.Common;
using Password.Manager.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password.Manager
{
    public partial class frmLogView : Form
    {
        DataGridViewRow logRow;
        public frmLogView(DataGridViewRow row)
        {
            InitializeComponent();
            logRow = row;
        }

        private void frmLogView_Load(object sender, EventArgs e)
        {
            try
            {
                this.txtDate.Text = logRow.Cells["dgvDate"].Value.ToString();
                this.txtLevel.Text = logRow.Cells["dgvLevel"].Value.ToString();
                this.txtLogger.Text = logRow.Cells["dgvLogger"].Value.ToString();
                this.txtMessage.Text = logRow.Cells["dgvMessage"].Value.ToString();
                this.txtLocation.Text = logRow.Cells["dgvLocation"].Value.ToString();
                this.txtException.Text = logRow.Cells["dgvException"].Value.ToString();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod());
            }
        }

        private void frmLogView_KeyDown(object sender, KeyEventArgs e)
        {
            //注册键事件
            FormKeyEvent formKeyEvent = new FormKeyEvent();//创建键事件处理实例类
            formKeyEvent.KeyEscapeEvent += new FormKeyEvent.FormKey(Cancel);//取消
            formKeyEvent.Run(e);//运行注册的方法
        }
        /// <summary>
        /// 取消
        /// </summary>
        private void Cancel() {
            this.Close();
        }
    }
}
