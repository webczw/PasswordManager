using Password.Common;
using Password.Entity;
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
    public partial class frmUserManager : Form
    {
        int maxUserID = 0;//最大用户ID
        string loginName = "NewUser";//默认用户登录名
       public frmMain parentMain;
        /// <summary>
        /// 新增用户集合
        /// </summary>
        List<User> addUserList = new List<User>();
        /// <summary>
        /// 更新用户集合
        /// </summary>
        List<User> updateUserList = new List<User>();
        /// <summary>
        /// 删除用户集合
        /// </summary>
        List<User> deleteUserList = new List<User>();

        /// <summary>
        /// 新增分类集合
        /// </summary>
        List<DataType> addDataTypeList = new List<DataType>();

        /// <summary>
        /// 新增用户设置信息集合
        /// </summary>
        List<Setting> addSettingList = new List<Setting>();

        public frmUserManager(frmMain parentMain)
        {
            InitializeComponent();
            this.parentMain = parentMain;
        }
        /// <summary>
        /// 窗体加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmUserManager_Load(object sender, EventArgs e)
        {
            if (parentMain.ThisUser.IsAdmin == 0)//如果是普通用户，只能编辑查看自己的信息
            {
                AddDgvRow(parentMain.ThisUser);//添加数据行
                dgvMain_SelectionChanged(null, null);
                cbIsAdmin.Enabled = false;//不允许修改用户类型
                btnAdd.Enabled = false;
            }
            else
            {
                cbIsAdmin.Enabled = true;
                btnAdd.Enabled = true;
                if (parentMain.userList != null && parentMain.userList.Count > 0)
                {
                    foreach (var user in parentMain.userList)
                    {
                        AddDgvRow(user);//添加数据行
                    }
                    dgvMain_SelectionChanged(null, null);
                }
            }
        }
        /// <summary>
        /// 添加数据行
        /// </summary>
        /// <param name="user"></param>
        private int AddDgvRow(User user)
        {
            int rowIndex = dgvMain.Rows.Add();
            dgvMain.Rows[rowIndex].Cells["dgvPassword"].Value = user.Password;
            dgvMain.Rows[rowIndex].Cells["dgvUserID"].Value = user.UserID;
            dgvMain.Rows[rowIndex].Cells["dgvGuid"].Value = user.Guid;
            dgvMain.Rows[rowIndex].Cells["dgvLoginName"].Value = user.LoginName;
            dgvMain.Rows[rowIndex].Cells["dgvChineseName"].Value = user.ChineseName;
            dgvMain.Rows[rowIndex].Cells["dgvEmail"].Value = user.Email;
            dgvMain.Rows[rowIndex].Cells["dgvSex"].Value = GetSex(user.Sex);
            dgvMain.Rows[rowIndex].Cells["dgvIsAdmin"].Value = GetIsAdmin(user.IsAdmin);
            dgvMain.Rows[rowIndex].Cells["dgvRemark"].Value = user.Remark;
            dgvMain.Rows[rowIndex].Tag = user;
            return rowIndex;
        }

        #region 用户类型、性别
        /// <summary>
        /// 获取字符用户类型
        /// </summary>
        /// <param name="isAdmin"></param>
        /// <returns></returns>
        private string GetIsAdmin(int isAdmin)
        {
            string strIsAdmin = "普通用户";
            if (isAdmin == 1)
            {
                strIsAdmin = "管理用户";
            }
            return strIsAdmin;
        }
        /// <summary>
        /// 获取INT用户类型
        /// </summary>
        /// <param name="strIsAdmin"></param>
        /// <returns></returns>
        private int GetIsAdmin(string strIsAdmin)
        {
            int isAdmin = 0;
            if (strIsAdmin == "管理用户")
            {
                isAdmin = 1;
            }
            return isAdmin;
        }
        /// <summary>
        /// 获取字符串性别
        /// </summary>
        /// <param name="sex"></param>
        /// <returns></returns>
        private string GetSex(int sex)
        {
            string strSex = "男";
            if (sex == 1)
            {
                strSex = "女";
            }
            return strSex;
        }
        /// <summary>
        /// 获取INT性别
        /// </summary>
        /// <param name="strSex"></param>
        /// <returns></returns>
        private int GetSex(string strSex)
        {
            int sex = 0;
            if (strSex == "女")
            {
                sex = 1;
            }
            return sex;
        }
        #endregion
        /// <summary>
        /// 数据行切换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMain_SelectionChanged(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            if (dgvMain.SelectedRows.Count == 1)
            {
                User user = (User)dgvMain.SelectedRows[0].Tag;

                if (user == null) return;
                txtLoginName.Text = user.LoginName;
                txtChineseName.Text = user.ChineseName;
                txtEmail.Text = user.Email;
                txtRemark.Text = user.Remark;
                cbSex.Text = GetSex(user.Sex);
                cbIsAdmin.Text = GetIsAdmin(user.IsAdmin);
                btnSave.Enabled = true;

                if (user.Guid == parentMain.ThisUser.Guid)//如果是当前用户，不允许修改用户类型，也不允许删除
                {
                    btnDelete.Enabled = false;
                    cbIsAdmin.Enabled = false;
                }
                else
                {
                    btnDelete.Enabled = true;
                    cbIsAdmin.Enabled = true;
                }
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
        /// 新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();
        }
        /// <summary>
        /// 新增
        /// </summary>
        private void Add()
        {
            User user = new User();

            if (parentMain.userList.Count > 0)
            {
                maxUserID++;
                CreateLoginName();
            }
            user.LoginName = loginName;
            user.ChineseName = "新用户";
            user.Guid = Guid.NewGuid().ToString();
            user.IsAdmin = 0;
            user.Sex = 0;
            user.CreateDate = DateTime.Now;
            user.CreateUserGuid = parentMain.ThisUser.Guid;
            user.UpdateDate = DateTime.Now;
            user.UpdateUserGuid = parentMain.ThisUser.Guid;
            user.Password = TripleDES.EncryptPassword("888888");
            addUserList.Add(user);
            int rowIndex = AddDgvRow(user);//添加数据行
            dgvMain.Rows[rowIndex].Selected = true;

            AddDataType(user);//初始化用户默认分类数据

            AddSetting(user);//初始化用户默认设置数据
        }

        /// <summary>
        /// 初始化用户默认分类数据
        /// </summary>
        /// <returns></returns>
        private void AddDataType(User user)
        {
            DataType newDataType = new DataType();//创建分类实例
            newDataType.Code = "PM0001";
            newDataType.Name = "密码管理";
            newDataType.IsSystem = "1";
            newDataType.SortID = 1;
            newDataType.Guid = Guid.NewGuid().ToString();
            newDataType.Level = 1;
            newDataType.CreateDate = DateTime.Now;
            newDataType.CreateUserGuid = user.Guid;
            newDataType.UpdateDate = DateTime.Now;
            newDataType.UpdateUserGuid = user.Guid;
            addDataTypeList.Add(newDataType);
        }
        /// <summary>
        /// 初始化用户默认设置数据
        /// </summary>
        /// <param name="user"></param>
        private void AddSetting(User user)
        {
            List<string> codes = new List<string>() { Enum.GetName(typeof(SetCodes), SetCodes.YesOrNoTools), Enum.GetName(typeof(SetCodes), SetCodes.ToolsButtonWay), Enum.GetName(typeof(SetCodes), SetCodes.YesOrNoStatus), Enum.GetName(typeof(SetCodes), SetCodes.ViewWay), Enum.GetName(typeof(SetCodes), SetCodes.TimeOut) };
            foreach (var code in codes)
            {
                Setting s1 = new Setting();
                s1.SetCode = code;
                if (code == Enum.GetName(typeof(SetCodes), SetCodes.TimeOut))
                {
                    s1.SetValue = "1200";
                }
                else {
                    s1.SetValue = "0";
                }
                s1.Guid = Guid.NewGuid().ToString();
                s1.UserGuid = user.Guid;
                s1.UpdateDate = DateTime.Now;
                addSettingList.Add(s1);
            }

        }


        /// <summary>
        /// 递归创建登录名
        /// </summary>
        /// <param name="loginName"></param>
        /// <returns></returns>
        private void CreateLoginName()
        {

            loginName = "NewUser_" + maxUserID;
            var user1 = parentMain.userList.Find(p => p.LoginName == loginName);
            var user2 = addUserList.Find(p => p.LoginName == loginName);
            if (user1 != null || user2 != null)
            {
                if (maxUserID == 0)
                {
                    maxUserID = parentMain.userList.Max(p => p.UserID);
                }
                else
                {
                    maxUserID++;
                }
                CreateLoginName();
            }
        }

        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();
        }
        /// <summary>
        /// 删除
        /// </summary>
        private void Delete()
        {
            if (dgvMain.SelectedRows.Count == 1 && btnDelete.Enabled)
            {
                DataGridViewRow row = dgvMain.SelectedRows[0];
                User user = (User)row.Tag;
                if (user.UserID > 0)
                {
                    deleteUserList.Add(user);
                    int count = updateUserList.Where(p => p.UserID == user.UserID).Count();
                    if (count > 0)
                    {
                        updateUserList.Remove(user);
                    }
                }
                else
                {
                    addUserList.Remove(user);
                    addDataTypeList.Remove(addDataTypeList.Find(p => p.CreateUserGuid == user.Guid));//移除该新增用户对应的分类数据
                    addSettingList.Remove(addSettingList.Find(p => p.UserGuid == user.Guid));//移除对应的设置数据
                }
                dgvMain.Rows.Remove(row);
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
            int retVal = 0;
            if (addUserList.Count > 0)
            {
                retVal += parentMain.UserManager.Add(addUserList);
                if (addDataTypeList.Count > 0)
                {
                    retVal += parentMain.DataTypeManager.Add(addDataTypeList);//添加分类
                }
                if (addSettingList.Count > 0)
                {
                    retVal += parentMain.SettingManager.Add(addSettingList);//添加设置信息
                }
            }
            if (updateUserList.Count > 0)
            {
                retVal += parentMain.UserManager.Update(updateUserList);
            }
            if (deleteUserList.Count > 0)
            {
                retVal += parentMain.UserManager.Delete(deleteUserList);


                List<DataType> deleteDataTypeList = new List<DataType>();
                List<UserField> deleteUserFieldList = new List<UserField>();
                List<UserFieldValue> deleteUserFieldValueList = new List<UserFieldValue>();
                List<Content> deleteContentList = new List<Content>();
                List<Log> deleteLogList = new List<Log>();
                List<Setting> deleteSettingList = new List<Setting>();
                List<Field> deleteFieldList = new List<Field>();
                foreach (var deleteUser in deleteUserList)
                {
                    var thisDataTypeList = parentMain.dataTypeList.FindAll(p => p.CreateUserGuid == deleteUser.Guid);
                    deleteDataTypeList.AddRange(thisDataTypeList);

                    var thisUserFieldList = parentMain.userFieldList.FindAll(p => p.CreateUserGuid == deleteUser.Guid);
                    deleteUserFieldList.AddRange(thisUserFieldList);

                    var thisContentList = parentMain.contentList.FindAll(p => p.CreateUserGuid == deleteUser.Guid);
                    deleteContentList.AddRange(thisContentList);

                    var thisLogList = parentMain.logList.FindAll(p => p.UserID == deleteUser.UserID);
                    deleteLogList.AddRange(thisLogList);

                    var thisSettingList = parentMain.settingAllList.FindAll(p => p.UserGuid == deleteUser.Guid);
                    deleteSettingList.AddRange(thisSettingList);

                    var thisFieldList = parentMain.fieldAllList.FindAll(p => p.CreateUserGuid == deleteUser.Guid);
                    deleteFieldList.AddRange(thisFieldList);
                }

                if (deleteDataTypeList.Count > 0)
                {
                    retVal += parentMain.DataTypeManager.Delete(deleteDataTypeList);//删除分类
                }

                if (deleteUserFieldList.Count > 0)
                {
                    retVal += parentMain.UserFieldManager.Delete(deleteUserFieldList);//删除自定义字段
                    foreach (var userField in deleteUserFieldList)
                    {
                        var thisUserFieldValueList = parentMain.userFieldValueList.FindAll(p => p.UserFieldGuid == userField.Guid);
                        deleteUserFieldValueList.AddRange(thisUserFieldValueList);
                    }
                    if (deleteUserFieldValueList.Count > 0)
                    {
                        retVal += parentMain.UserFieldValueManager.Delete(deleteUserFieldValueList);//删除自定义字段值
                    }
                }

                if (deleteContentList.Count > 0)
                {
                    retVal += parentMain.ContentManager.Delete(deleteContentList);//删除内容
                }

                if (deleteLogList.Count > 0)
                {
                    retVal += parentMain.LogManager.Delete(deleteLogList);//删除日志
                }

                if (deleteSettingList.Count > 0)
                {
                    retVal += parentMain.SettingManager.Delete(deleteSettingList);//删除设置信息
                }

                if (deleteFieldList.Count > 0)
                {
                    retVal += parentMain.FieldManager.Delete(deleteFieldList);//删除栏位信息
                }



            }
            if (retVal > 0)
            {
                parentMain.LoadData();
            }
            this.Close();
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
        /// <summary>
        /// 登录名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtLoginName_Leave(object sender, EventArgs e)
        {
            string strValue = txtLoginName.Text.Trim();
            if (string.IsNullOrWhiteSpace(strValue)) return;
            UpdateUser((p) =>
            {
                bool retVal = false;
                var user1 = parentMain.userList.Find(p1 => p1.Guid != p.Guid && p1.LoginName == strValue);
                var user2 = addUserList.Find(p1 => p1.Guid != p.Guid && p1.LoginName == strValue);
                if (user1 != null || user2 != null)
                {
                    MessageBox.Show("登录名不可重复，请重新录入。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLoginName.Text = p.LoginName;
                    return retVal;
                };

                if (p.LoginName != strValue)
                {
                    p.LoginName = strValue;
                    dgvMain.SelectedRows[0].Cells["dgvLoginName"].Value = strValue;
                    retVal = true;
                }
                return retVal;
            });
        }
        /// <summary>
        /// 显示名
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtChineseName_Leave(object sender, EventArgs e)
        {
            string strValue = txtChineseName.Text.Trim();
            if (string.IsNullOrWhiteSpace(strValue)) return;

            UpdateUser((p) =>
            {
                bool retVal = false;
                if (p.ChineseName != strValue)
                {
                    p.ChineseName = strValue;
                    dgvMain.SelectedRows[0].Cells["dgvChineseName"].Value = strValue;
                    retVal = true;
                }
                return retVal;
            });

        }

        /// <summary>
        /// 更新用户信息
        /// </summary>
        /// <param name="action"></param>
        public void UpdateUser(Func<User, bool> action)
        {
            if (dgvMain.SelectedRows.Count == 1)
            {
                bool retVal = false;
                User updateUser = new User();
                User user = (User)dgvMain.SelectedRows[0].Tag;
                if (user.UserID > 0)//如果用户ID大于0表示为非本次新增的，否则就是本次新增的用户
                {
                    updateUser = parentMain.userList.Find(p => p.Guid == user.Guid);//从历史用户信息集合获取GUID等于当前修改的
                    retVal = action(updateUser);//设置字段值
                    if (retVal)
                    {
                        updateUserList.RemoveAll(p => p.Guid == user.Guid);//移除已经存在的修改用户
                        updateUser.UpdateDate = DateTime.Now;
                        updateUser.UpdateUserGuid = parentMain.ThisUser.Guid;
                        updateUserList.Add(updateUser);//添加到修改用户集合
                    }
                }
                else
                {
                    updateUser = addUserList.Find(p => p.Guid == user.Guid);//从新增用户信息集合获取GUID等于当前修改的
                    updateUser.UpdateDate = DateTime.Now;
                    updateUser.UpdateUserGuid = parentMain.ThisUser.Guid;
                    retVal = action(updateUser);//设置字段值
                }
                if (retVal)
                {
                    dgvMain.SelectedRows[0].Tag = updateUser;
                }
            }
        }
        /// <summary>
        /// 邮箱
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            string strValue = txtEmail.Text.Trim();
            if (string.IsNullOrWhiteSpace(strValue)) return;

            UpdateUser((p) =>
            {
                bool retVal = false;
                if (p.Email != strValue)
                {
                    p.Email = strValue;
                    dgvMain.SelectedRows[0].Cells["dgvEmail"].Value = strValue;
                    retVal = true;
                }
                return retVal;
            });
        }
        /// <summary>
        /// 备注
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtRemark_Leave(object sender, EventArgs e)
        {
            string strValue = txtRemark.Text.Trim();
            if (string.IsNullOrWhiteSpace(strValue)) return;

            UpdateUser((p) =>
            {
                bool retVal = false;
                if (p.Remark != strValue)
                {
                    p.Remark = strValue;
                    dgvMain.SelectedRows[0].Cells["dgvRemark"].Value = strValue;
                    retVal = true;
                }
                return retVal;
            });
        }
        /// <summary>
        /// 性别
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbSex_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strValue = cbSex.Text.Trim();
            if (string.IsNullOrWhiteSpace(strValue)) return;

            UpdateUser((p) =>
            {
                int sex = GetSex(strValue);//转换数值
                bool retVal = false;
                if (p.Sex != sex)
                {
                    p.Sex = sex;
                    dgvMain.SelectedRows[0].Cells["dgvSex"].Value = strValue;
                    retVal = true;
                }
                return retVal;
            });
        }
        /// <summary>
        /// 用户类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbIsAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strValue = cbIsAdmin.Text.Trim();
            if (string.IsNullOrWhiteSpace(strValue)) return;

            UpdateUser((p) =>
            {
                int isAdmin = GetIsAdmin(strValue);//转换数值
                bool retVal = false;
                if (p.IsAdmin != isAdmin)
                {
                    p.IsAdmin = isAdmin;
                    dgvMain.SelectedRows[0].Cells["dgvIsAdmin"].Value = strValue;
                    retVal = true;
                }
                return retVal;
            });
        }

        private void btnPassword_Click(object sender, EventArgs e)
        {
            if (dgvMain.SelectedRows.Count == 1)
            {
                User user = (User)dgvMain.SelectedRows[0].Tag;
                frmSetPassword frm = new frmSetPassword(this);
                frm.ShowDialog();
            }
        }

        private void frmUserManager_KeyDown(object sender, KeyEventArgs e)
        {
            //注册键事件
            FormKeyEvent formKeyEvent = new FormKeyEvent();//创建键事件处理实例类
            formKeyEvent.KeyEnterEvent += new FormKeyEvent.FormKey(Save);//确定
            formKeyEvent.KeyEscapeEvent += new FormKeyEvent.FormKey(Cancel);//取消
            formKeyEvent.KeyF1Event += new FormKeyEvent.FormKey(Help);//帮助
            formKeyEvent.Run(e);//运行注册的方法
        }

        private void dgvMain_KeyDown(object sender, KeyEventArgs e)
        {
            //注册键事件
            FormKeyEvent formKeyEvent = new FormKeyEvent();//创建键事件处理实例类
            formKeyEvent.KeyInsertEvent += new FormKeyEvent.FormKey(Add);//增加
            formKeyEvent.KeyDeleteEvent += new FormKeyEvent.FormKey(Delete);//删除
            formKeyEvent.Run(e);//运行注册的方法
        }

        /// <summary>
        /// 帮助
        /// </summary>
        private void Help()
        {
            parentMain.ShowHelp(HelpIdDefines.HId_用户);
        }
    }
}
