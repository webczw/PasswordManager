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
    public partial class frmUserField : Form
    {
        frmMain parentMain;
        List<UserField> addUserFieldList = new List<UserField>();
        List<UserField> updateUserFieldList = new List<UserField>();
        List<UserField> deleteUserFieldList = new List<UserField>();
        List<UserField> thisUserFieldList = new List<UserField>();
        public frmUserField(frmMain main)
        {
            InitializeComponent();
            parentMain = main;
        }

        private void frmUserField_Load(object sender, EventArgs e)
        {
            thisUserFieldList = parentMain.userFieldList.FindAll(p => p.SystemField == 0 && p.CreateUserGuid == parentMain.ThisUser.Guid);
            LoadData();
        }

        private void LoadData()
        {
            List<UserField>  userFieldList = (from p in thisUserFieldList orderby p.SortID select p).ToList();
            for (int i = 0; i < userFieldList.Count; i++)
            {
                UserField userField = userFieldList[i];
                DataGridViewAddRow(userField);
            }
            dgvMain_SelectionChanged(null, null);
        }

        private int DataGridViewAddRow(UserField userField)
        {
            DataGridViewRow row = new DataGridViewRow();
            int rowIndex = this.dgvMain.Rows.Add(row);
            this.dgvMain.Rows[rowIndex].Cells["UserFieldID"].Value = userField.UserFieldID;
            this.dgvMain.Rows[rowIndex].Cells["Guid"].Value = userField.Guid;
            this.dgvMain.Rows[rowIndex].Cells["Code"].Value = userField.Code;
            this.dgvMain.Rows[rowIndex].Cells["StrName"].Value = userField.Name;
            this.dgvMain.Rows[rowIndex].Cells["DataType"].Value = userField.DataType;
            this.dgvMain.Rows[rowIndex].Cells["SortID"].Value = userField.SortID;
            return rowIndex;
        }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            Add();

        }
        /// <summary>
        /// 增加
        /// </summary>
        private void Add()
        {
            try
            {
                int maxSort = 1;

                if (addUserFieldList.Count > 0)
                {
                    maxSort = addUserFieldList.Max(p => p.SortID) + 1;
                }
                else
                {
                    if (thisUserFieldList.Count > 0)
                    {
                        maxSort = thisUserFieldList.Max(p => p.SortID) + 1;
                    }
                }
                UserField userField = new UserField();
                userField.Guid = System.Guid.NewGuid().ToString();
                userField.Code = "Code." + maxSort;
                userField.Name = "新字段";
                userField.DataType = "字符串";
                userField.SortID = maxSort;
                userField.CreateDate = DateTime.Now;
                userField.CreateUserGuid = parentMain.ThisUser.Guid;
                userField.UpdateDate = DateTime.Now;
                userField.UpdateUserGuid = parentMain.ThisUser.Guid;
                userField.SystemField = 0;
                addUserFieldList.Add(userField);

                int rowIndex = DataGridViewAddRow(userField);
                this.dgvMain.CurrentCell = this.dgvMain.Rows[rowIndex].Cells[2];
                dgvMain_SelectionChanged(null, null);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
        }

        /// <summary>
        /// 行更改事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMain_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                if (this.dgvMain.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.dgvMain.SelectedRows[0];
                    SetText(row);//Text
                    btnSave.Enabled = true;
                }
                else
                {
                    //btnSave.Enabled = false;
                    this.txtCode.Text = "";
                    this.txtCode.Tag = null;
                    this.txtName.Text = "";
                    this.cbDataType.SelectedText = "";
                    this.txtSortID.Text = "1";
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
        }

        /// <summary>
        /// 设置Text
        /// </summary>
        /// <param name="row"></param>
        private void SetText(DataGridViewRow row)
        {
            this.txtCode.Text = Convert.ToString(row.Cells["Code"].Value);
            this.txtCode.Tag = Convert.ToString(row.Cells["Guid"].Value);
            this.txtName.Text = Convert.ToString(row.Cells["StrName"].Value);
            this.cbDataType.SelectedItem = Convert.ToString(row.Cells["DataType"].Value);
            this.txtSortID.Text = Convert.ToString(row.Cells["SortID"].Value);
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
                /*if (this.dgvMain.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.dgvMain.SelectedRows[0];
                    int thisID = Convert.ToInt32(row.Cells["UserFieldID"].Value);

                    UserField userField = new UserField();
                    userField.UserFieldID = thisID;
                    userField.Code = this.txtCode.Text;
                    userField.Name = this.txtName.Text;
                    if (string.IsNullOrWhiteSpace(userField.Code) || string.IsNullOrWhiteSpace(userField.Name))
                    {
                        MessageBox.Show("保存失败：代码或名称为必填。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    userField.DataType = this.cbDataType.SelectedItem.ToString();
                    int sortId = 0;
                    int.TryParse(this.txtSortID.Text, out sortId);
                    userField.SortID = sortId;
                    userField.UpdateDate = DateTime.Now;
                    userField.UpdateUserGuid = parentMain.ThisUser.Guid;

                    List<UserField> userFieldList = parentMain.userFieldList;
                    if (userFieldList != null && userFieldList.Count > 0)
                    {
                        int rowCount = userFieldList.Where(p => p.UserFieldID != userField.UserFieldID && p.Code == userField.Code).ToList().Count;
                        if (rowCount > 0)
                        {
                            MessageBox.Show("保存失败：代码已经存在。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }
                    }

                    Save(userField);//保存更新
                    
                    parentMain.LoadData();
                    parentMain.LoadUserField();
                }*/
                int result = 0;
                if (addUserFieldList.Count > 0)
                {
                    result += parentMain.UserFieldManager.Add(addUserFieldList);
                }
                if (updateUserFieldList.Count > 0)
                {
                    result += parentMain.UserFieldManager.Update(updateUserFieldList);
                }
                if (deleteUserFieldList.Count > 0)
                {
                    result += parentMain.UserFieldManager.Delete(deleteUserFieldList);
                    foreach (var userField in deleteUserFieldList)
                    {
                        List<UserFieldValue> thisUserFieldValueList = (from p in parentMain.userFieldValueList where p.UserFieldGuid == userField.Guid select p).ToList();
                        if (thisUserFieldValueList != null && thisUserFieldValueList.Count > 0)
                        {
                            result += parentMain.UserFieldValueManager.Delete(thisUserFieldValueList);
                        }
                    }
                }

                if (result > 0)
                {
                    parentMain.LoadData();
                    parentMain.LoadUserField();
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
        }

        public void Save(UserField userField)
        {
            try
            {
                List<UserField> list = new List<UserField>();
                list.Add(userField);
                int result = parentMain.UserFieldManager.Update(list);
                if (result > 0)//如果更新条数大于1
                {
                    // LoadDgvMain();//重新加载内容控件
                    DataGridViewRow row = this.dgvMain.SelectedRows[0];
                    row.Cells["Code"].Value = userField.Code;
                    row.Cells["StrName"].Value = userField.Name;
                    row.Cells["DataType"].Value = userField.DataType;
                    row.Cells["SortID"].Value = userField.SortID;
                    dgvMain.Refresh();
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete();

        }
        /// <summary>
        /// 删除
        /// </summary>
        private void Delete()
        {
            try
            {
                DataGridViewSelectedRowCollection rows = dgvMain.SelectedRows;
                if (rows == null || rows.Count < 1|| !btnDelete.Enabled) return;

                DialogResult DialogResult = MessageBox.Show("确定要删除所选中的自定义字段,以及对于存储都数据吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.No) return;

                foreach (DataGridViewRow dataGridViewRow in rows)
                {
                    string strGuid = dataGridViewRow.Cells["Guid"].Value.ToString();
                    int old;
                    UserField userField = GetUserFieldByGuid(strGuid, out old);
                    if (userField != null && old == 0)
                    {
                        deleteUserFieldList.Add(userField);
                    }
                    if (userField != null && old == 1)
                    {
                        addUserFieldList.Remove(userField);
                    }
                    this.dgvMain.Rows.Remove(dataGridViewRow);

                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
        }

        /// <summary>
        /// 根据GUID获取自定义字段
        /// </summary>
        /// <param name="strGuid">GUID</param>
        /// <param name="old">是历史，还是新增</param>
        /// <returns></returns>
        private UserField GetUserFieldByGuid(string strGuid, out int old)
        {
            UserField userField = new UserField();
            old = -1;
            if (thisUserFieldList != null && thisUserFieldList.Count > 0)
            {
                userField = thisUserFieldList.Find(p => p.Guid == strGuid);//历史
                old = 0;
            }
            if (userField == null && addUserFieldList.Count > 0)
            {
                userField = addUserFieldList.Find(p => p.Guid == strGuid);//新增
                old = 1;
            }
            return userField;
        }

        private void txtSortID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// 代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCode_Leave(object sender, EventArgs e)
        {
            string strGuid = Convert.ToString(this.txtCode.Tag);
            string strValue = Convert.ToString(this.txtCode.Text);
            if (string.IsNullOrWhiteSpace(strValue)) return;
            int old;
            UserField userField = GetUserFieldByGuid(strGuid, out old);
            if (userField.Code != strValue)
            {
                var userField1 = thisUserFieldList.Find(p1 => p1.Guid != userField.Guid && p1.Code == strValue);
                var userField2 = addUserFieldList.Find(p1 => p1.Guid != userField.Guid && p1.Code == strValue);
                if (userField1 != null || userField2 != null)
                {
                    MessageBox.Show("代码不可重复，请重新录入。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtCode.Text = userField.Code;
                    return;
                }
                userField.Code = strValue;
                userField.UpdateDate = DateTime.Now;
                userField.UpdateUserGuid = parentMain.ThisUser.Guid;
                dgvMain.SelectedRows[0].Cells["Code"].Value = strValue;
                if (old == 0)
                {
                    updateUserFieldList.Add(userField);
                }
            }
        }
        /// <summary>
        /// 名称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_Leave(object sender, EventArgs e)
        {
            string strGuid = Convert.ToString(this.txtCode.Tag);
            string strValue = Convert.ToString(this.txtName.Text);
            if (string.IsNullOrWhiteSpace(strValue)) return;
            int old;
            UserField userField = GetUserFieldByGuid(strGuid, out old);
            if (userField.Name != strValue)
            {
                userField.Name = strValue;
                userField.UpdateDate = DateTime.Now;
                userField.UpdateUserGuid = parentMain.ThisUser.Guid;
                dgvMain.SelectedRows[0].Cells["strName"].Value = strValue;
                if (old == 0)
                {
                    updateUserFieldList.Add(userField);
                }
            }
        }
        /// <summary>
        /// 序号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSortID_Leave(object sender, EventArgs e)
        {
            string strGuid = Convert.ToString(this.txtCode.Tag);
            int intValue = Convert.ToInt32(this.txtSortID.Text);
            int old;
            UserField userField = GetUserFieldByGuid(strGuid, out old);
            if (userField.SortID != intValue)
            {
                userField.SortID = intValue;
                userField.UpdateDate = DateTime.Now;
                userField.UpdateUserGuid = parentMain.ThisUser.Guid;
                dgvMain.SelectedRows[0].Cells["SortID"].Value = intValue;
                if (old == 0)
                {
                    updateUserFieldList.Add(userField);
                }
            }
        }
        /// <summary>
        /// 数据类型
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cbDataType_SelectedIndexChanged(object sender, EventArgs e)
        {
            string strGuid = Convert.ToString(this.txtCode.Tag);
            string strValue = Convert.ToString(this.cbDataType.SelectedItem);
            int old;
            UserField userField = GetUserFieldByGuid(strGuid, out old);
            if (userField.DataType != strValue)
            {
                userField.DataType = strValue;
                userField.UpdateDate = DateTime.Now;
                userField.UpdateUserGuid = parentMain.ThisUser.Guid;
                dgvMain.SelectedRows[0].Cells["DataType"].Value = strValue;
                if (old == 0)
                {
                    updateUserFieldList.Add(userField);
                }
            }
        }

        private void frmUserField_KeyDown(object sender, KeyEventArgs e)
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

        private void btnHelp_Click(object sender, EventArgs e)
        {
            Help();
        }

        /// <summary>
        /// 帮助
        /// </summary>
        private void Help()
        {
            parentMain.ShowHelp(HelpIdDefines.HId_自定义);
        }
    }
}
