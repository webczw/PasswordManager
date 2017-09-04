using Password.Common;
using Password.Entity;
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
    public partial class frmContentEdit : Form
    {
        frmMain parentMain = null;
        string strContentID = "";
        public frmContentEdit(frmMain main)
        {
            InitializeComponent();
            parentMain = main;
        }

        private void frmContentEdit_Load(object sender, EventArgs e)
        {
            try
            {
                if (parentMain.dgvMain.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = parentMain.dgvMain.SelectedRows[0];
                    this.txtCode.Text = Convert.ToString(row.Cells["Code"].Value);
                    this.txtTitle.Text = Convert.ToString(row.Cells["Title"].Value);
                    this.txtAddress.Text = Convert.ToString(row.Cells["Address"].Value);
                    this.txtUserName.Text = Convert.ToString(row.Cells["UserName"].Value);
                    string strPassword = Convert.ToString(row.Cells["Password"].Value);
                    if (!string.IsNullOrWhiteSpace(strPassword))
                    {
                        this.txtPassword.Text = TripleDES.DecryptPassword(strPassword);
                    }
                    else { this.txtPassword.Text = ""; }
                    this.txtEmail.Text = Convert.ToString(row.Cells["Email"].Value);
                    this.txtRemarks.Text = Convert.ToString(row.Cells["Remarks"].Value);//
                    strContentID = Convert.ToString(row.Cells["ContentID"].Value);
                    this.txtClassify.Text = parentMain.txtClassify.Text;
                    this.txtClassify.Tag = parentMain.txtClassify.Tag;
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
        }
        /// <summary>
        /// 保存
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            Save();
        }
        /// <summary>
        /// 保存
        /// </summary>
        private void Save()
        {
            try
            {
                if (parentMain.ContentManager != null)
                {
                    if (string.IsNullOrWhiteSpace(strContentID)) return;
                    Content content = new Content();
                    content.Code = this.txtCode.Text.Trim();
                    content.Title = this.txtTitle.Text.Trim();
                    content.Address = this.txtAddress.Text.Trim();
                    content.UserName = this.txtUserName.Text.Trim();
                    string strPassword = this.txtPassword.Text.Trim();
                    if (!string.IsNullOrWhiteSpace(strPassword))
                    {
                        content.Password = TripleDES.EncryptPassword(strPassword);
                    }
                    content.Email = this.txtEmail.Text.Trim();
                    content.Remarks = this.txtRemarks.Text.Trim();
                    content.UpdateUserGuid = parentMain.ThisUser.Guid;
                    content.UpdateDate = DateTime.Now;
                    content.ContentID = Convert.ToInt32(strContentID);
                    content.DataTypeGuid = this.txtClassify.Tag.ToString();
                    parentMain.SaveContent(content);//保存更新内容
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
            this.Close();
        }

        /// <summary>
        /// 预览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnView_Click(object sender, EventArgs e)
        {
            parentMain.OpenUrl(this.txtAddress.Text);
        }
        /// <summary>
        /// 取消
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

        /// <summary>
        /// 分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClassify_Click(object sender, EventArgs e)
        {
            frmSelectClassify frm = new frmSelectClassify(parentMain);
            frm.ShowDialog();
            if (frm.SelectDataType != null)
            {
                txtClassify.Text = frm.SelectDataType.Name;
                txtClassify.Tag = frm.SelectDataType.Guid;
                parentMain.txtClassify.Text = frm.SelectDataType.Name; ;
                parentMain.txtClassify.Tag = frm.SelectDataType.Guid;
            }
        }
        /// <summary>
        /// 解码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecoding_Click(object sender, EventArgs e)
        {
            Decoding();
        }
        /// <summary>
        /// 解码
        /// </summary>
        private void Decoding()
        {
            parentMain.OpenShowPassword(txtPassword.Text);
        }

        private void frmContentEdit_KeyDown(object sender, KeyEventArgs e)
        {
            //注册键事件
            FormKeyEvent formKeyEvent = new FormKeyEvent();//创建键事件处理实例类
            formKeyEvent.KeyEnterEvent += new FormKeyEvent.FormKey(Save);//保存
            formKeyEvent.KeyEscapeEvent += new FormKeyEvent.FormKey(Cancel);//取消
            formKeyEvent.KeyF1Event += new FormKeyEvent.FormKey(Help);//帮助
            formKeyEvent.KeyF8Event += new FormKeyEvent.FormKey(Decoding);//解码
            formKeyEvent.Run(e);//运行注册的方法
        }
        /// <summary>
        /// 帮助
        /// </summary>
        private void Help()
        {
            parentMain.ShowHelp(HelpIdDefines.HId_内容维护);
        }
        /// <summary>
        /// 帮助
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help();
        }
    }
}
