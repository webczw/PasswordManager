using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Password.Entity;
using Password.Common;
using System.Reflection;
using Password.Manager.App_Code;

namespace Password.Manager
{
    public partial class frmSearch : Form
    {
        frmMain parentMain;
        public frmSearch(frmMain parentMain)
        {
            InitializeComponent();
            this.parentMain = parentMain;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }
        /// <summary>
        /// 查找
        /// </summary>
        private void Search()
        {
            try
            {
                bool isAllType = cbAllType.Checked;
                var newContentList = parentMain.contentList.Where(p => p.CreateUserGuid == parentMain.ThisUser.Guid).ToList();
                if (parentMain.contentList == null || parentMain.contentList.Count < 1) return;
                if (!isAllType)
                {
                    newContentList = (from p in parentMain.contentList where p.DataTypeGuid == parentMain.lblThisDataTypeGuid.Text select p).ToList();
                }

                if (newContentList == null || newContentList.Count < 1) return;

                newContentList = newContentList.FindAll(p =>
                {
                    if (isBool(p.Code) || isBool(p.Title) || isBool(p.Remarks) || isBool(p.Email) || isBool(p.Address))
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                });
                parentMain.AgainBintContent(newContentList);// 重新绑定内容
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
        }

        private bool isBool(string strText)
        {
            string strSearchContent = txtSearchContent.Text.Trim();
            bool isUpperLower = cbUpperLower.Checked;
            bool isValue = false;
            if (string.IsNullOrWhiteSpace(strSearchContent)) return isValue;
            if (!string.IsNullOrWhiteSpace(strText))
            {
                if (!isUpperLower)
                {
                    isValue = strText.ToUpper().Contains(strSearchContent.ToUpper());
                }
                else
                {
                    isValue = strText.Contains(strSearchContent);
                }
            }
            return isValue;
        }

        private void btnCancel_Click(object sender, EventArgs e)
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

        private void txtSearchContent_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSearchContent.Text))
            {
                btnSearch.Enabled = false;
            }
            else {
                btnSearch.Enabled = true;
            }
        }

        private void frmSearch_KeyDown(object sender, KeyEventArgs e)
        {
            //注册键事件
            FormKeyEvent formKeyEvent = new FormKeyEvent();//创建键事件处理实例类
            formKeyEvent.KeyEnterEvent += new FormKeyEvent.FormKey(Search);//保存
            formKeyEvent.KeyEscapeEvent += new FormKeyEvent.FormKey(Cancel);//取消
            formKeyEvent.Run(e);//运行注册的方法
        }
    }
}
