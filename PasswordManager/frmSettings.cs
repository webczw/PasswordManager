using Password.Common;
using Password.Entity;
using Password.Interface;
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
    public partial class frmSettings : Form
    {
        frmMain parentMain;
        public frmSettings(frmMain parentMain)
        {
            InitializeComponent();
            this.parentMain = parentMain;
        }

        private void frmSettings_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            if (parentMain.userSetting != null)
            {
                if (parentMain.userSetting.YesOrNoTools == "0")
                {
                    rbYesOrNoTools0.Checked = true;
                }
                else
                {
                    rbYesOrNoTools1.Checked = true;
                }
                if (parentMain.userSetting.ToolsButtonWay == "0")
                {
                    rbToolsButtonWay0.Checked = true;
                }
                else if (parentMain.userSetting.ToolsButtonWay == "1")
                {
                    rbToolsButtonWay1.Checked = true;
                }
                else if (parentMain.userSetting.ToolsButtonWay == "2") {
                    rbToolsButtonWay2.Checked = true;
                }

                if (parentMain.userSetting.YesOrNoStatus == "0")
                {
                    rbYesOrNoStatus0.Checked = true;
                }
                else
                {
                    rbYesOrNoStatus1.Checked = true;
                }
                if (parentMain.userSetting.ViewWay == "0")
                {
                    rbViewWay0.Checked = true;
                }
                else
                {
                    rbViewWay1.Checked = true;
                }

                txtTimeOut.Text = parentMain.userSetting.TimeOut.ToString();
            }
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
                List<Setting> settingList = parentMain.settingList.FindAll(p => p.UserGuid == parentMain.ThisUser.Guid);
                if (settingList.Count > 0)
                {
                    foreach (var item in settingList)
                    {
                        if (item.SetCode == Enum.GetName(typeof(SetCodes), SetCodes.YesOrNoTools))
                        {
                            item.SetValue = rbYesOrNoTools0.Checked ? "0" : "1";
                            parentMain.userSetting.YesOrNoTools = item.SetValue;
                        }

                        if (item.SetCode == Enum.GetName(typeof(SetCodes), SetCodes.ToolsButtonWay))
                        {
                            if (rbToolsButtonWay0.Checked)
                            {
                                item.SetValue = "0";
                            }
                            else if (rbToolsButtonWay1.Checked)
                            {
                                item.SetValue = "1";
                            }
                            else if (rbToolsButtonWay2.Checked)
                            {
                                item.SetValue = "2";
                            }
                            parentMain.userSetting.ToolsButtonWay = item.SetValue;
                        }

                        if (item.SetCode == Enum.GetName(typeof(SetCodes), SetCodes.YesOrNoStatus))
                        {
                            item.SetValue = rbYesOrNoStatus0.Checked ? "0" : "1";
                            parentMain.userSetting.YesOrNoStatus = item.SetValue;
                        }

                        if (item.SetCode == Enum.GetName(typeof(SetCodes), SetCodes.ViewWay))
                        {
                            item.SetValue = rbViewWay0.Checked ? "0" : "1";
                            parentMain.userSetting.ViewWay = item.SetValue;
                        }

                        if (item.SetCode == Enum.GetName(typeof(SetCodes), SetCodes.TimeOut))
                        {
                            item.SetValue = txtTimeOut.Text;
                            parentMain.userSetting.TimeOut =Convert.ToInt32(item.SetValue);
                        }
                    }
                    var result = parentMain.SettingManager.Update(parentMain.settingList);
                    if (result > 0)
                    {
                        parentMain.LoadUserSetting();
                        MessageBox.Show("保存成功！", "系统提示");
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
        }

        private void frmSettings_KeyDown(object sender, KeyEventArgs e)
        {
            //注册键事件
            FormKeyEvent formKeyEvent = new FormKeyEvent();//创建键事件处理实例类
            formKeyEvent.KeyEnterEvent += new FormKeyEvent.FormKey(Save);//确定
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
            parentMain.ShowHelp(HelpIdDefines.HId_设置);
        }

        private void txtTimeOut_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
