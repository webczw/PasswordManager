using Password.Common;
using Password.Entity;
using Password.Interface;
using Password.Manager.App_Code;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Password.Manager
{
    public partial class frmMain : Form
    {
        /// <summary>
        /// 未操作记时
        /// </summary>
        public static int OperCount=0;
        /// <summary>
        /// 当前用户信息
        /// </summary>
        public User ThisUser { private set; get; }
        /// <summary>
        /// 客户端向后台传递参数对象 
        /// </summary>
        public SendBackParameter ThisSendBackParameter { private set; get; }
        public Imanager<Content> ContentManager = null;
        public Imanager<UserField> UserFieldManager = null;
        public Imanager<UserFieldValue> UserFieldValueManager = null;
        public Imanager<Setting> SettingManager = null;
        public Imanager<Field> FieldManager = null;
        public Imanager<DataType> DataTypeManager = null;
        public ILogManager<Log> LogManager = null;
        public Imanager<User> UserManager = null;
        /// <summary>
        /// 内容集合
        /// </summary>
        public List<Content> contentList;
        /// <summary>
        /// 当前显示内容集合 
        /// </summary>
        public List<Content> thisShowContentList;
        /// <summary>
        /// 自定义字段集合
        /// </summary>
        public List<UserField> userFieldList;
        /// <summary>
        /// 自定义字段值集合
        /// </summary>
        public List<UserFieldValue> userFieldValueList;
        /// <summary>
        /// 当前用户系统设置信息
        /// </summary>
        public List<Setting> settingList;
        /// <summary>
        /// 所有用户系统设置信息
        /// </summary>
        public List<Setting> settingAllList;
        /// <summary>
        /// 用户设置信息
        /// </summary>
        public UserSetting userSetting;
        /// <summary>
        /// 栏位数据集合
        /// </summary>
        public List<Field> fieldAllList;
        /// <summary>
        /// 分类集合
        /// </summary>
        public List<DataType> dataTypeList;
        /// <summary>
        /// 用户集合
        /// </summary>
        public List<User> userList;
        /// <summary>
        /// 日志集合
        /// </summary>
        public List<Log> logList;

        public frmMain(User user, List<User> userList)
        {
            ThisSendBackParameter = new SendBackParameter(user);//设置客户端向后台传递参数对象的用户信息
            this.ThisUser = user;
            this.userList = userList;
            App_Code.FormMessage msg = new App_Code.FormMessage();
            Application.AddMessageFilter(msg);
            InitializeComponent();
        }

        /// <summary>
        /// 加载主入口
        /// </summary>
        private void LoadMain()
        {
            LoadData();//加载数据
            LoadUserSetting();// 加载用户系统设置信息
            this.splitContainerTop.SplitterWidth = 1;
            tvClassify.LabelEdit = false;//不可编辑
            LoadDataType();//加载分类控件
            this.tssUserText.Text = ThisUser.ChineseName; LoadUserField();

            UploadDgvMainColumns();//重新加载主内容控件列

        }

        /// <summary>
        /// 重新加载主内容控件列
        /// </summary>
        public void UploadDgvMainColumns()
        {
            dgvMain.Columns.Clear();
            List<Field> fieldList = fieldAllList.OrderBy(p => p.SortID).ToList().FindAll(p => p.CreateUserGuid == ThisUser.Guid);//当前用户自定义的栏位
            if (fieldList.Count > 0)
            {
                foreach (var field in fieldList)
                {
                    AddMainColumn(field.Code, field.Name);
                }
            }
            else
            {
                List<UserField> list = userFieldList.OrderBy(p => p.SortID).ToList().FindAll(p => p.SystemField == 1);//系统默认的栏位
                foreach (var userField in list)
                {
                    AddMainColumn(userField.Code, userField.Name);
                }
            }
            string[] strSystemFields = new string[] { "ContentID", "Guid", "CreateUserGuid", "UpdateUserGuid", "DataTypeGuid" };//系统默认字段
            foreach (string field in strSystemFields)
            {
                AddMainColumn(field, field, false);
            }

            LoadDgvMain();//重新加载内容控件
        }

        /// <summary>
        /// 主内容控件添加列
        /// </summary>
        /// <param name="code"></param>
        /// <param name="name"></param>
        private void AddMainColumn(string code, string name, bool visible = true)
        {
            DataGridViewColumn column = new DataGridViewColumn();
            column.Name = code;
            column.HeaderText = name;
            column.Visible = visible;
            column.Width = 140;
            if (code == "Address")
            {
                column.CellTemplate = new DataGridViewLinkCell();
            }
            else
            {
                column.CellTemplate = new DataGridViewTextBoxCell();
            }
            dgvMain.Columns.Add(column);
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            LoadMain();
        }
        /// <summary>
        /// 创建管理类
        /// </summary>
        private void CreateManager()
        {
            ContentManager = Tools.DynamicCreateClass<Imanager<Content>>("ContentManager", ThisSendBackParameter);
            UserFieldManager = Tools.DynamicCreateClass<Imanager<UserField>>("UserFieldManager", ThisSendBackParameter);
            UserFieldValueManager = Tools.DynamicCreateClass<Imanager<UserFieldValue>>("UserFieldValueManager", ThisSendBackParameter);
            SettingManager = Tools.DynamicCreateClass<Imanager<Setting>>("SettingManager", ThisSendBackParameter);
            FieldManager = Tools.DynamicCreateClass<Imanager<Field>>("FieldManager", ThisSendBackParameter);
            DataTypeManager = Tools.DynamicCreateClass<Imanager<DataType>>("DataTypeManager", ThisSendBackParameter);
            LogManager = Tools.DynamicCreateClass<ILogManager<Log>>("LogManager", ThisSendBackParameter);
            UserManager = Tools.DynamicCreateClass<Imanager<User>>("UserManager");
        }

        /// <summary>
        /// 加载数据
        /// </summary>
        public void LoadData()
        {
            try
            {
                CreateManager();// 创建管理类
                if (ContentManager != null)
                {
                    contentList = ContentManager.Load();
                }
                if (UserFieldManager != null)
                {
                    userFieldList = UserFieldManager.Load();
                }
                if (UserFieldValueManager != null)
                {
                    userFieldValueList = UserFieldValueManager.Load();
                }
                if (FieldManager != null)
                {
                    fieldAllList = FieldManager.Load();
                }
                if (DataTypeManager != null)
                {
                    dataTypeList = DataTypeManager.Load();
                }
                if (UserManager != null)
                {
                    userList = UserManager.Load();
                }
                if (LogManager != null)
                {
                    logList = LogManager.Load();
                }
                if (SettingManager != null)
                {
                    settingAllList = SettingManager.Load();
                    if (settingAllList != null && settingAllList.Count > 0)
                    {
                        settingList = settingAllList.FindAll(p => p.UserGuid == ThisUser.Guid);
                        if (settingList == null && settingList.Count < 1) return;
                        userSetting = new UserSetting();
                        foreach (var item in settingList)
                        {
                            if (item.SetCode == Enum.GetName(typeof(SetCodes), SetCodes.YesOrNoTools))
                            {
                                userSetting.YesOrNoTools = item.SetValue;
                            }
                            if (item.SetCode == Enum.GetName(typeof(SetCodes), SetCodes.ToolsButtonWay))
                            {
                                userSetting.ToolsButtonWay = item.SetValue;
                            }
                            if (item.SetCode == Enum.GetName(typeof(SetCodes), SetCodes.YesOrNoStatus))
                            {
                                userSetting.YesOrNoStatus = item.SetValue;
                            }
                            if (item.SetCode == Enum.GetName(typeof(SetCodes), SetCodes.ViewWay))
                            {
                                userSetting.ViewWay = item.SetValue;
                            }
                            if (item.SetCode == Enum.GetName(typeof(SetCodes), SetCodes.TimeOut))
                            {
                                userSetting.TimeOut =Convert.ToInt32(item.SetValue);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), ThisSendBackParameter);
            }
        }
        /// <summary>
        /// 加载用户系统设置信息
        /// </summary>
        public void LoadUserSetting()
        {
            try
            {
                if (userSetting == null) return;
                if (userSetting.YesOrNoTools == "0")
                {
                    ToolStripTop.Visible = true;
                }
                else
                {
                    ToolStripTop.Visible = false;
                }

                if (userSetting.YesOrNoStatus == "0")
                {
                    StatusStripBottom.Visible = true;
                }
                else
                {
                    StatusStripBottom.Visible = false;
                }

                ToolStripItemDisplayStyle tsds = ToolStripItemDisplayStyle.ImageAndText;
                Padding padding = new Padding(6);
                if (userSetting.ToolsButtonWay == "0")
                {
                    tsds = ToolStripItemDisplayStyle.ImageAndText;
                    padding = new Padding(0);
                }
                else if (userSetting.ToolsButtonWay == "1")
                {
                    tsds = ToolStripItemDisplayStyle.Image;

                }
                else if (userSetting.ToolsButtonWay == "2")
                {
                    tsds = ToolStripItemDisplayStyle.Text;
                    padding = new Padding(3);
                }
                this.ToolStripTopAdd.Padding = padding;
                this.ToolStripTopDelete.Padding = padding;
                this.ToolStripTopEdit.Padding = padding;
                this.ToolStripTopPreview.Padding = padding;
                this.ToolStripTopDefined.Padding = padding;
                this.ToolStripTopClassify.Padding = padding;
                this.ToolStripTopSettings.Padding = padding;
                this.ToolStripTopReload.Padding = padding;
                this.ToolStripTopSearch.Padding = padding;
                this.ToolStripTopField.Padding = padding;
                this.ToolStripTopDetail.Padding = padding;
                this.ToolStripTopReport.Padding = padding;
                this.ToolStripTopImport.Padding = padding;
                this.ToolStripTopExport.Padding = padding;
                this.ToolStripTopAccount.Padding = padding;
                this.ToolStripTopHelp.Padding = padding;
                this.ToolStripTopMove.Padding = padding;
                this.ToolStripTopLogger.Padding = padding;
                this.ToolStripTopDecoding.Padding = padding;

                this.ToolStripTopAdd.DisplayStyle = tsds;
                this.ToolStripTopDelete.DisplayStyle = tsds;
                this.ToolStripTopEdit.DisplayStyle = tsds;
                this.ToolStripTopPreview.DisplayStyle = tsds;
                this.ToolStripTopDefined.DisplayStyle = tsds;
                this.ToolStripTopClassify.DisplayStyle = tsds;
                this.ToolStripTopSettings.DisplayStyle = tsds;
                this.ToolStripTopReload.DisplayStyle = tsds;
                this.ToolStripTopSearch.DisplayStyle = tsds;
                this.ToolStripTopField.DisplayStyle = tsds;
                this.ToolStripTopDetail.DisplayStyle = tsds;
                this.ToolStripTopReport.DisplayStyle = tsds;
                this.ToolStripTopImport.DisplayStyle = tsds;
                this.ToolStripTopExport.DisplayStyle = tsds;
                this.ToolStripTopAccount.DisplayStyle = tsds;
                this.ToolStripTopHelp.DisplayStyle = tsds;
                this.ToolStripTopMove.DisplayStyle = tsds;
                this.ToolStripTopLogger.DisplayStyle = tsds;
                this.ToolStripTopDecoding.DisplayStyle = tsds;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), ThisSendBackParameter);
            }

        }
        /// <summary>
        /// 加载用户自定义字段
        /// </summary>
        public void LoadUserField()
        {
            try
            {
                this.palUserField.Controls.Clear();
                if (userFieldList == null || userFieldList.Count < 1) return;
                List<UserField> thisUserFieldList = (from p in userFieldList where p.SystemField == 0 && p.CreateUserGuid == ThisUser.Guid orderby p.SortID select p).ToList();// userFileldList.Where(p=>p.CreateUserGuid==this.ThisUser.Guid).ToList();
                if (thisUserFieldList == null || thisUserFieldList.Count < 1) return;

                int i = 0;
                foreach (UserField userField in thisUserFieldList)
                {
                    //6 17
                    //26 23
                    i++;
                    int txy = (50 * (i - 1));
                    int lby = (50 * (i - 1));
                    if (i == 1)
                    {
                        txy = 29;
                        lby = 6;
                    }
                    else
                    {
                        txy = txy + 29;
                        lby = lby + 6;
                    }
                    Label lb = new Label();
                    lb.Name = "lbl" + userField.Code;
                    lb.Text = userField.Name;
                    lb.Location = new Point(6, lby);
                    palUserField.Controls.Add(lb);
                    if (userField.DataType == "字符串" || userField.DataType == "数值")
                    {
                        TextBox tx = new TextBox();
                        tx.Width = 260;
                        tx.Name = "text" + userField.Code;
                        tx.Location = new Point(6, txy);
                        if (userField.DataType == "数值")
                        {
                            tx.KeyPress += Tx_KeyPress;
                        }
                        palUserField.Controls.Add(tx);
                    }
                    else if (userField.DataType == "日期")
                    {
                        DateTimePicker dtp = new DateTimePicker();
                        dtp.Name = "text" + userField.Code;
                        dtp.Width = 260;
                        dtp.Location = new Point(6, txy);
                        palUserField.Controls.Add(dtp);
                    }

                    if (thisUserFieldList.Count == i)
                    {
                        palUserField.Controls.Add(new Label() { Height = 17, Location = new Point(6, txy + 17), Text = "" });//最底部增加占位符
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), ThisSendBackParameter);
            }

        }

        private void Tx_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsNumber(e.KeyChar)) && e.KeyChar != (char)13 && e.KeyChar != (char)8)
            {
                e.Handled = true;
            }
        }

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ToolStripTopClassify_Click(object sender, EventArgs e)
        {
            OpenFrmClassify();// 打开分类编辑窗口
        }

        /// <summary>
        /// 打开分类编辑窗口
        /// </summary>
        private void OpenFrmClassify()
        {
            frmClassify classify = new frmClassify(this);
            DialogResult result = classify.ShowDialog();
            if (result == DialogResult.OK)
            {
                LoadDataType();//加载分类控件
            }
        }

        /// <summary>
        /// 关于
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiAbout_Click(object sender, EventArgs e)
        {
            frmAbout about = new frmAbout(this);
            about.ShowDialog();
        }

        /// <summary>
        /// 加载分类控件
        /// </summary>
        private void LoadDataType()
        {
            //Imanager<DataType> manager = Tools.DynamicCreateClass<Imanager<DataType>>("DataTypeManager", ThisSendBackParameter);
            // if (manager != null)
            //{
            new frmClassify(this).LoadDataType(this.tvClassify);
            //}
            //else
            //{
            // string strError = "创建分类管理实例异常。";
            // Logger.Error(strError, MethodBase.GetCurrentMethod(),ThisSendBackParameter);//记录日志
            // MessageBox.Show(strError, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //}
        }
        /// <summary>
        /// 系统菜单分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiClassify_Click(object sender, EventArgs e)
        {
            OpenFrmClassify();// 打开分类编辑窗口
        }

        /// <summary>
        /// 右键分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmsTsmiClassify_Click(object sender, EventArgs e)
        {
            OpenFrmClassify();// 打开分类编辑窗口
        }

        private void ToolStripTopAdd_Click(object sender, EventArgs e)
        {
            AddContent();//添加内容项
        }
        /// <summary>
        /// 添加内容项
        /// </summary>
        private void AddContent()
        {
            try
            {
                if (ContentManager != null)
                {

                    Content content = new Content();
                    content.Guid = System.Guid.NewGuid().ToString();
                    int maxId = 1;
                    if (contentList.FindAll(p => p.CreateUserGuid == ThisUser.Guid).Count > 0)
                    {
                        maxId = contentList.FindAll(p => p.CreateUserGuid == ThisUser.Guid).Max(p => p.ContentID) + 1;
                    }
                    content.Code = "Code"+ maxId;
                    content.Title = "新内容";
                    content.CreateDate = DateTime.Now;
                    content.CreateUserGuid = this.ThisUser.Guid;
                    content.UpdateDate = DateTime.Now;
                    content.UpdateUserGuid = this.ThisUser.Guid;
                    content.DataTypeGuid = (this.tvClassify.SelectedNode.Tag as DataType).Guid;
                    List<Content> list = new List<Content>();
                    list.Add(content);
                    int result = ContentManager.Add(list);
                    if (result > 0)//如果更新条数大于1
                    {
                        //LoadDgvMain();//重新加载内容控件
                        //content.ContentID = maxId;
                        int rowIndex = DataGridViewAddRow(content);
                        //this.dgvMain.Rows[rowIndex].Selected = true;
                        //CurrentCell 
                        this.dgvMain.CurrentCell = this.dgvMain.Rows[rowIndex].Cells[0];
                        contentList.Add(content);
                        AfreshSetContentText();//按照当前选中的行重新设置内容控件
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), ThisSendBackParameter);
            }
        }

        /// <summary>
        /// 左侧分类节点切换事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tvClassify_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            DataType dataType = (DataType)e.Node.Tag;
            LoadDgvMain(e.Node);//重新加载内容控件
        }
        /// <summary>
        /// 重新加载内容控件
        /// </summary>
        private void LoadDgvMain(TreeNode node = null)
        {
            try
            {
                if (node == null)
                {
                    node = this.tvClassify.SelectedNode;
                }
                if (ContentManager == null) return;
                if (contentList == null || contentList.Count < 1) return;
                string strDataTypeGuid = ((DataType)node.Tag).Guid;
                this.lblThisDataTypeGuid.Text = strDataTypeGuid;
                var newContentList = (from p in contentList where p.DataTypeGuid == strDataTypeGuid && p.CreateUserGuid == ThisUser.Guid orderby p.CreateDate descending select p).ToList();
                AgainBintContent(newContentList);// 重新绑定内容
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), ThisSendBackParameter);
            }
        }
        /// <summary>
        /// 重新绑定内容
        /// </summary>
        /// <param name="newContentList"></param>
        public void AgainBintContent(List<Content> newContentList)
        {
            this.dgvMain.Rows.Clear();
            if (newContentList == null || newContentList.Count < 1)
            {
                SetContentTextNull();//设置内容控件为空
                return;
            }
            thisShowContentList = newContentList;//设置当前显示的内容，提供导出程序
            for (int i = 0; i < newContentList.Count; i++)
            {
                Content content = newContentList[i];
                DataGridViewAddRow(content);
            }
            AfreshSetContentText();//按照当前选中的行重新设置内容控件
        }
        /// <summary>
        /// 给内容控件添加数据行
        /// </summary>
        /// <param name="content"></param>
        /// <returns></returns>
        private int DataGridViewAddRow(Content content)
        {
            DataGridViewRow row = new DataGridViewRow();
            int rowIndex = this.dgvMain.Rows.Add(row);

            this.dgvMain.Rows[rowIndex].Cells["ContentID"].Value = content.ContentID;
            this.dgvMain.Rows[rowIndex].Cells["Guid"].Value = content.Guid;
            this.dgvMain.Rows[rowIndex].Cells["CreateUserGuid"].Value = content.CreateUserGuid;
            this.dgvMain.Rows[rowIndex].Cells["UpdateUserGuid"].Value = content.UpdateUserGuid;
            this.dgvMain.Rows[rowIndex].Cells["DataTypeGuid"].Value = content.DataTypeGuid;
            foreach (DataGridViewColumn column in dgvMain.Columns)
            {
                #region 系统字段
                if (column.Name == "Code")
                {
                    this.dgvMain.Rows[rowIndex].Cells[column.Name].Value = content.Code;
                }
                if (column.Name == "Title")
                {
                    this.dgvMain.Rows[rowIndex].Cells[column.Name].Value = content.Title;
                }
                if (column.Name == "Address")
                {
                    this.dgvMain.Rows[rowIndex].Cells[column.Name].Value = content.Address;
                }
                if (column.Name == "UserName")
                {
                    this.dgvMain.Rows[rowIndex].Cells[column.Name].Value = content.UserName;
                }
                if (column.Name == "Password")
                {
                    this.dgvMain.Rows[rowIndex].Cells[column.Name].Value = content.Password;
                }
                if (column.Name == "Email")
                {
                    this.dgvMain.Rows[rowIndex].Cells[column.Name].Value = content.Email;
                }
                if (column.Name == "Remarks")
                {
                    this.dgvMain.Rows[rowIndex].Cells[column.Name].Value = content.Remarks;
                }
                if (column.Name == "CreateDate")
                {
                    this.dgvMain.Rows[rowIndex].Cells[column.Name].Value = content.CreateDate;
                }
                if (column.Name == "UpdateDate")
                {
                    this.dgvMain.Rows[rowIndex].Cells[column.Name].Value = content.UpdateDate;
                }
                #endregion

                #region 自定义字段
                var thisUserFieldValue = (from p in userFieldValueList where p.ContentGuid == Convert.ToString(content.Guid) select p).ToList();//当前内容对应自定义字段值
                if (thisUserFieldValue != null && thisUserFieldValue.Count > 0)
                {
                    foreach (UserFieldValue userFieldValue in thisUserFieldValue)
                    {
                        var thisUserFieldList = userFieldList.Where(p => p.Guid == userFieldValue.UserFieldGuid).ToList();//当前自定义字段
                        if (thisUserFieldList != null && thisUserFieldList.Count == 1)
                        {
                            if (dgvMain.Columns.Contains(thisUserFieldList[0].Code))
                            {
                                this.dgvMain.Rows[rowIndex].Cells[thisUserFieldList[0].Code].Value = userFieldValue.FieldValue;//设置值
                            }
                        }
                    }
                }
                #endregion

            }
            return rowIndex;
        }
        /// <summary>
        /// 递归获取当前类型下都所有子类型GUID
        /// </summary>
        /// <param name="node"></param>
        /// <param name="dataTypeGuidList"></param>
        /// <returns></returns>
        private List<string> GetDataTypeGuidList(TreeNode node, List<string> dataTypeGuidList)
        {
            if (node.Nodes != null && node.Nodes.Count > 0)
            {
                foreach (TreeNode treeNode in node.Nodes)
                {
                    dataTypeGuidList.Add(((DataType)treeNode.Tag).Guid);
                    GetDataTypeGuidList(treeNode, dataTypeGuidList);
                }
            }
            return dataTypeGuidList;
        }

        private void CmsTsmiAdd_Click(object sender, EventArgs e)
        {
            AddContent();//添加内容项
        }

        private void tsmiAdd_Click(object sender, EventArgs e)
        {
            AddContent();//添加内容项
        }
        /// <summary>
        /// 绘制行号
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMain_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            //using (SolidBrush b = new SolidBrush(this.dgvMain.RowHeadersDefaultCellStyle.ForeColor))
            //{
            //    e.Graphics.DrawString(Convert.ToString(e.RowIndex + 1, CultureInfo.CurrentUICulture),
            //    e.InheritedRowStyle.Font, b, e.RowBounds.Location.X + 20, e.RowBounds.Location.Y + 4);
            //}
        }

        private void ToolStripTopDelete_Click(object sender, EventArgs e)
        {
            DeleteContent();//删除内容
        }
        /// <summary>
        /// 删除内容
        /// </summary>
        private void DeleteContent()
        {

            try
            {
                DataGridViewSelectedRowCollection rows = dgvMain.SelectedRows;
                if (rows == null || rows.Count < 1) return;
                if (ContentManager == null) return;
                DialogResult DialogResult = MessageBox.Show("确定要删除所选中的 " + rows.Count + "  条内容吗？", "系统提示", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (DialogResult == DialogResult.No) return;
                List<string> contentGuidList = new List<string>();
                foreach (DataGridViewRow dataGridViewRow in rows)
                {
                    contentGuidList.Add(Convert.ToString(dataGridViewRow.Cells["Guid"].Value));
                }
                //List<Content> contentList = ContentManager.Load();
                if (contentList == null || contentList.Count < 1) return;
                List<Content> newContentList = (from p in contentList where contentGuidList.Contains(p.Guid) select p).ToList();
                int result = ContentManager.Delete(newContentList);
                if (result > 0)//如果更新条数大于1
                {
                    // LoadDgvMain();//重新加载内容控件

                    foreach (DataGridViewRow dataGridViewRow in rows)
                    {
                        this.dgvMain.Rows.Remove(dataGridViewRow);
                    }
                    contentList.RemoveAll(p => newContentList.Contains(p));
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), ThisSendBackParameter);
            }
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            DeleteContent();//删除内容
        }

        private void CmsTsmiDelete_Click(object sender, EventArgs e)
        {
            DeleteContent();//删除内容
        }
        /// <summary>
        /// 内容行改变事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMain_SelectionChanged(object sender, EventArgs e)
        {
            AfreshSetContentText();//按照当前选中的行重新设置内容控件
        }
        /// <summary>
        /// 按照当前选中的行重新设置内容控件
        /// </summary>
        private void AfreshSetContentText()
        {
            try
            {
                if (this.dgvMain.SelectedRows.Count > 0)
                {
                    DataGridViewRow row = this.dgvMain.SelectedRows[0];
                    string strContentGuid = Convert.ToString(row.Cells["Guid"].Value);
                    Content content = contentList.Find(p => p.Guid == strContentGuid);
                    if (content == null) return;
                    SetContentText(content);//设置内容的Text
                    tpDefined.Enabled = true;
                    tpUsually.Enabled = true;

                    if (userFieldValueList == null || userFieldValueList.Count < 1 || userFieldList == null || userFieldList.Count < 1) return;
                    var thisUserFieldValue = (from p in userFieldValueList where p.ContentGuid == strContentGuid select p).ToList();
                    if (thisUserFieldValue != null && thisUserFieldValue.Count > 0)
                    {
                        foreach (UserFieldValue userFieldValue in thisUserFieldValue)
                        {
                            var thisUserFieldList = userFieldList.Where(p => p.Guid == userFieldValue.UserFieldGuid).ToList();
                            if (thisUserFieldList != null && thisUserFieldList.Count == 1)
                            {
                                Control[] controls = palUserField.Controls.Find("text" + thisUserFieldList[0].Code, false);
                                if (controls.Length != 1) continue;
                                if (thisUserFieldList[0].DataType == "日期")
                                {
                                    DateTimePicker dtp = (DateTimePicker)controls[0];
                                    dtp.Text = userFieldValue.FieldValue;

                                }
                                else
                                {
                                    TextBox tx = (TextBox)controls[0];
                                    tx.Text = userFieldValue.FieldValue;
                                }
                            }
                        }
                        //清空没有自定义字段值的控件
                        List<UserField> thisUserFieldAllList = (from p in userFieldList where p.SystemField == 0 && p.CreateUserGuid == ThisUser.Guid orderby p.SortID select p).ToList();//

                        foreach (UserField userField in thisUserFieldAllList)
                        {
                            // var thisUserFieldValueCount = thisUserFieldValue.Select(p => p.UserFieldGuid == userField.Guid && p.ContentGuid == this.lblThisContentID.Tag.ToString()).ToList();

                            var thisUserFieldValueCount = (from p in thisUserFieldValue where p.UserFieldGuid == userField.Guid && p.ContentGuid == this.lblThisContentID.Tag.ToString() select p).ToList();

                            if (thisUserFieldValueCount != null && thisUserFieldValueCount.Count > 0) continue;

                            Control[] controls = palUserField.Controls.Find("text" + userField.Code, false);
                            if (controls.Length != 1) continue;
                            if (userField.DataType == "日期")
                            {
                                DateTimePicker dtp = (DateTimePicker)controls[0];
                                dtp.Text = "";
                            }
                            else
                            {
                                TextBox tx = (TextBox)controls[0];
                                tx.Text = "";
                            }
                        }
                    }
                    else
                    {
                        List<UserField> thisUserFieldList = (from p in userFieldList where p.SystemField == 0 && p.CreateUserGuid == ThisUser.Guid orderby p.SortID select p).ToList();// 
                        foreach (UserField userField in thisUserFieldList)
                        {
                            Control[] controls = palUserField.Controls.Find("text" + userField.Code, false);
                            if (controls.Length != 1) continue;
                            if (userField.DataType == "日期")
                            {
                                DateTimePicker dtp = (DateTimePicker)controls[0];
                                dtp.Text = "";
                            }
                            else
                            {
                                TextBox tx = (TextBox)controls[0];
                                tx.Text = "";
                            }
                        }
                    }

                }
                else
                {
                    SetContentTextNull();//设置内容控件为空
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), ThisSendBackParameter);
            }
        }

        /// <summary>
        /// 设置内容控件为空
        /// </summary>
        private void SetContentTextNull()
        {
            tpDefined.Enabled = false;
            tpUsually.Enabled = false;
            this.txtCode.Text = "";
            this.txtTitle.Text = "";
            this.txtAddress.Text = "";
            this.txtUserName.Text = "";
            this.txtPassword.Text = "";
            this.txtEmail.Text = "";
            this.txtRemarks.Text = "";
            this.lblThisContentID.Text = "";
            this.lblThisContentID.Tag = "";
            this.txtClassify.Text = "";
            this.txtClassify.Tag = "";
        }



        /// <summary>
        /// 设置内容的Text
        /// </summary>
        /// <param name="row"></param>
        private void SetContentText(Content content)
        {
            this.txtCode.Text = content.Code;
            this.txtTitle.Text = content.Title;
            this.txtAddress.Text = content.Address;
            this.txtUserName.Text = content.UserName;
            string strPassword = content.Password;
            if (!string.IsNullOrWhiteSpace(strPassword))
            {
                this.txtPassword.Text = TripleDES.DecryptPassword(strPassword);
            }
            else { this.txtPassword.Text = ""; }
            this.txtEmail.Text = content.Email;
            this.txtRemarks.Text = content.Remarks;
            this.lblThisContentID.Text = content.ContentID.ToString();
            this.lblThisContentID.Tag = content.Guid;
            DataType dateType = dataTypeList.Find(p => p.Guid == content.DataTypeGuid);
            this.txtClassify.Text = dateType.Name;
            this.txtClassify.Tag = dateType.Guid;
        }
        /// <summary>
        /// 保存内容
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (ContentManager != null)
                {
                    string thisContentID = this.lblThisContentID.Text.Trim();
                    if (string.IsNullOrWhiteSpace(thisContentID)) return;
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
                    content.UpdateUserGuid = ThisUser.Guid;
                    content.UpdateDate = DateTime.Now;
                    content.ContentID = Convert.ToInt32(thisContentID);
                    content.DataTypeGuid = this.txtClassify.Tag.ToString();
                    SaveContent(content);//保存更新内容

                    MessageBox.Show("保存成功！", "系统提示");
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), ThisSendBackParameter);
            }
        }
        /// <summary>
        /// 保存更新内容
        /// </summary>
        /// <param name="content"></param>
        public void SaveContent(Content content)
        {
            try
            {
                List<Content> list = new List<Content>();
                list.Add(content);
                int result = ContentManager.Update(list);
                if (result > 0)//如果更新条数大于1
                {
                    // LoadDgvMain();//重新加载内容控件
                    DataGridViewRow row = this.dgvMain.SelectedRows[0];
                    if (dgvMain.Columns.Contains("Code"))
                    {
                        row.Cells["Code"].Value = content.Code;
                    }
                    if (dgvMain.Columns.Contains("Title"))
                    {
                        row.Cells["Title"].Value = content.Title;
                    }
                    if (dgvMain.Columns.Contains("Address"))
                    {
                        row.Cells["Address"].Value = content.Address;
                    }
                    if (dgvMain.Columns.Contains("UserName"))
                    {
                        row.Cells["UserName"].Value = content.UserName;
                    }
                    if (dgvMain.Columns.Contains("Password"))
                    {
                        row.Cells["Password"].Value = content.Password;
                    }
                    if (dgvMain.Columns.Contains("Email"))
                    {
                        row.Cells["Email"].Value = content.Email;
                    }
                    if (dgvMain.Columns.Contains("Remarks"))
                    {
                        row.Cells["Remarks"].Value = content.Remarks;
                    }
                    if (dgvMain.Columns.Contains("UpdateDate"))
                    {
                        row.Cells["UpdateDate"].Value = content.UpdateDate;
                    }
                    row.Cells["ContentID"].Value = content.ContentID;

                    //如果调整了内容分类，即可移除对应数据行
                    if (content.DataTypeGuid != (this.tvClassify.SelectedNode.Tag as DataType).Guid)
                    {
                        this.dgvMain.Rows.Remove(row);
                    }


                    LoadData();//重新获取数据
                    dgvMain.Refresh();
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), ThisSendBackParameter);
            }
        }

        private void ToolStripTopEdit_Click(object sender, EventArgs e)
        {
            OpenContentEdit();//打开内容编辑窗口
        }

        private void dgvMain_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex > -1)
            {
                OpenContentEdit();//打开内容编辑窗口
            }
        }
        /// <summary>
        /// 打开内容编辑窗口
        /// </summary>
        private void OpenContentEdit()
        {
            DataGridViewSelectedRowCollection rows = dgvMain.SelectedRows;
            if (rows == null || rows.Count < 1) return;
            frmContentEdit frm = new frmContentEdit(this);
            frm.ShowDialog();
            AfreshSetContentText();//按照当前选中的行重新设置内容控件
        }
        /// <summary>
        /// 工具栏预览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripTopPreview_Click(object sender, EventArgs e)
        {
            OpenView();//打开预览
        }
        /// <summary>
        /// 打开预览
        /// </summary>
        private void OpenView()
        {
            if (this.dgvMain.SelectedRows.Count > 0)
            {
                DataGridViewRow row = this.dgvMain.SelectedRows[0];
                if (dgvMain.Columns.Contains("Address"))
                {
                    OpenUrl(Convert.ToString(row.Cells["Address"].Value));// 打开URL地址
                }
            }
        }

        /// <summary>
        /// 预览按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnView_Click(object sender, EventArgs e)
        {
            OpenUrl(this.txtAddress.Text);// 打开URL地址
        }

        /// <summary>
        /// 打开URL地址
        /// </summary>
        /// <param name="url">URL地址</param>
        public void OpenUrl(string url)
        {
            if (string.IsNullOrWhiteSpace(url) || userSetting == null) return;
            try
            {
                if (userSetting.ViewWay == "0")
                {
                    frmView frm = new frmView();
                    frm.wbMain.Url = new Uri(url);
                    frm.ShowDialog();
                }
                else
                {
                    System.Diagnostics.Process.Start(url);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), ThisSendBackParameter);//记录日志
                MessageBox.Show(ex.Message, "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        /// <summary>
        /// 单击单元格事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgvMain_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvMain.Columns[e.ColumnIndex].Name == "Address" && e.RowIndex > -1)
            {
                OpenUrl(this.dgvMain.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());//打开URL地址
            }

        }
        /// <summary>
        /// 右键编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmsTsmiEdit_Click(object sender, EventArgs e)
        {
            OpenContentEdit();//打开内容编辑窗口
        }
        /// <summary>
        /// 右键预览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmsTsmiPreview_Click(object sender, EventArgs e)
        {
            OpenView();//打开预览
        }
        /// <summary>
        /// 菜单编辑
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiEdit_Click(object sender, EventArgs e)
        {
            OpenContentEdit();//打开内容编辑窗口
        }
        /// <summary>
        /// 菜单预览
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiPreview_Click(object sender, EventArgs e)
        {
            OpenView();//打开预览
        }

        private void ToolStripTopDefined_Click(object sender, EventArgs e)
        {
            OpenUserField();//打开自定义字段窗口
        }

        private void tsmiDefined_Click(object sender, EventArgs e)
        {
            OpenUserField();//打开自定义字段窗口
        }
        /// <summary>
        /// 打开自定义字段窗口
        /// </summary>
        private void OpenUserField()
        {
            frmUserField frm = new frmUserField(this);
            frm.ShowDialog();
        }

        private void CmsTsmiDefined_Click(object sender, EventArgs e)
        {
            OpenUserField();//打开自定义字段窗口
        }
        /// <summary>
        /// 保存自定义字段信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnSaveUserField_Click(object sender, EventArgs e)
        {
            try
            {
                string thisContentID = this.lblThisContentID.Text.Trim();
                if (string.IsNullOrWhiteSpace(thisContentID) || userFieldList == null || userFieldList.Count < 1) return;
                string strContentGuid = this.lblThisContentID.Tag.ToString();
                if (userFieldValueList != null && userFieldValueList.Count > 0)
                {
                    var thisUserFieldValue = (from p in userFieldValueList where p.ContentGuid == strContentGuid select p).ToList();
                    if (thisUserFieldValue != null && thisUserFieldValue.Count > 0)
                    {
                        List<UserFieldValue> list = new List<UserFieldValue>();
                        foreach (UserFieldValue userFieldValue in thisUserFieldValue)
                        {
                            UserFieldValue ufv = new UserFieldValue();
                            ufv.UserFieldValueID = userFieldValue.UserFieldValueID;

                            var thisUserFieldList = userFieldList.Where(p => p.Guid == userFieldValue.UserFieldGuid).ToList();
                            if (thisUserFieldList != null && thisUserFieldList.Count == 1)
                            {
                                Control[] controls = palUserField.Controls.Find("text" + thisUserFieldList[0].Code, false);
                                if (controls.Length != 1) continue;
                                if (thisUserFieldList[0].DataType == "日期")
                                {
                                    DateTimePicker dtp = (DateTimePicker)controls[0];
                                    ufv.FieldValue = dtp.Text;
                                }
                                else
                                {
                                    TextBox tx = (TextBox)controls[0];
                                    ufv.FieldValue = tx.Text;
                                }

                                //设置内容控件的自定义字段数据
                                DataGridViewRow row = this.dgvMain.SelectedRows[0];
                                if (dgvMain.Columns.Contains(thisUserFieldList[0].Code))
                                {
                                    row.Cells[thisUserFieldList[0].Code].Value = ufv.FieldValue;
                                }

                            }
                            list.Add(ufv);
                        }
                        if (list.Count > 0)
                        {
                            UserFieldValueManager.Update(list);
                        }

                        //补充新增的字段
                        List<UserField> thisUserFieldAllList = (from p in userFieldList where p.SystemField == 0 && p.CreateUserGuid == ThisUser.Guid orderby p.SortID select p).ToList();//
                        List<UserFieldValue> thisUserFieldValueList = new List<UserFieldValue>();
                        foreach (UserField userField in thisUserFieldAllList)
                        {
                            var thisUserFieldValueCount = (from p in thisUserFieldValue where p.UserFieldGuid == userField.Guid && p.ContentGuid == this.lblThisContentID.Tag.ToString() select p).ToList();
                            if (thisUserFieldValueCount != null && thisUserFieldValueCount.Count > 0) continue;
                            UserFieldValue ufv = new UserFieldValue();
                            ufv.ContentGuid = this.lblThisContentID.Tag.ToString();
                            ufv.Guid = System.Guid.NewGuid().ToString();
                            ufv.UserFieldGuid = userField.Guid;
                            Control[] controls = palUserField.Controls.Find("text" + userField.Code, false);
                            if (controls.Length != 1) continue;
                            if (userField.DataType == "日期")
                            {
                                DateTimePicker dtp = (DateTimePicker)controls[0];
                                ufv.FieldValue = dtp.Text;
                            }
                            else
                            {
                                TextBox tx = (TextBox)controls[0];
                                ufv.FieldValue = tx.Text;
                            }
                            thisUserFieldValueList.Add(ufv);
                        }
                        if (thisUserFieldValueList.Count > 0)
                        {
                            UserFieldValueManager.Add(thisUserFieldValueList);
                        }

                    }
                    else
                    {
                        AddUserFieldValue();
                    }

                }
                else { AddUserFieldValue(); }

                LoadData();//重新获取数据

                MessageBox.Show("保存成功！", "系统提示");
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), ThisSendBackParameter);
            }
        }
        /// <summary>
        /// 添加用户自定义字段值
        /// </summary>
        private void AddUserFieldValue()
        {
            try
            {
                List<UserFieldValue> thisUserFieldValueList = new List<UserFieldValue>();
                List<UserField> thisUserFieldList = (from p in userFieldList where p.SystemField == 0 && p.CreateUserGuid == ThisUser.Guid orderby p.SortID select p).ToList();// 
                foreach (UserField userField in thisUserFieldList)
                {
                    UserFieldValue ufv = new UserFieldValue();
                    ufv.ContentGuid = this.lblThisContentID.Tag.ToString();
                    ufv.Guid = System.Guid.NewGuid().ToString();
                    ufv.UserFieldGuid = userField.Guid;
                    Control[] controls = palUserField.Controls.Find("text" + userField.Code, false);
                    if (controls.Length != 1) continue;
                    if (userField.DataType == "日期")
                    {
                        DateTimePicker dtp = (DateTimePicker)controls[0];
                        ufv.FieldValue = dtp.Text;
                    }
                    else
                    {
                        TextBox tx = (TextBox)controls[0];
                        ufv.FieldValue = tx.Text;
                    }
                    thisUserFieldValueList.Add(ufv);
                }
                UserFieldValueManager.Add(thisUserFieldValueList);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), ThisSendBackParameter);
            }
        }

        /// <summary>
        /// 删除自定义字段值
        /// </summary>
        /// <param name="strUserFieldGuid"></param>
        /// <returns></returns>
        public int DeleteUserFieldValue(string strUserFieldGuid)
        {
            int retVal = 0;
            try
            {
                if (UserFieldValueManager == null) return retVal;
                if (userFieldValueList != null)
                {
                    List<UserFieldValue> thisUserFieldValueList = (from p in userFieldValueList where p.UserFieldGuid == strUserFieldGuid select p).ToList();
                    if (thisUserFieldValueList != null && thisUserFieldValueList.Count > 0)
                    {
                        retVal = UserFieldValueManager.Delete(thisUserFieldValueList);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), ThisSendBackParameter);
            }
            return retVal;
        }
        #region 设置
        /// <summary>
        /// 设置
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripTopSettings_Click(object sender, EventArgs e)
        {
            OpenSettings();//打开设置窗口
        }
        /// <summary>
        /// 打开设置窗口
        /// </summary>
        private void OpenSettings()
        {
            frmSettings frm = new frmSettings(this);
            frm.ShowDialog();
        }

        private void tsmiSettings_Click(object sender, EventArgs e)
        {
            OpenSettings();//打开设置窗口
        }

        private void CmsTsmiSettings_Click(object sender, EventArgs e)
        {
            OpenSettings();//打开设置窗口
        }
        #endregion

        #region 刷新
        private void ToolStripTopReload_Click(object sender, EventArgs e)
        {
            LoadMain();
        }

        private void CmsTsmiReload_Click(object sender, EventArgs e)
        {
            LoadMain();
        }

        private void tsmiReload_Click(object sender, EventArgs e)
        {
            LoadMain();
        }
        #endregion

        #region 详情
        private void ToolStripTopDetail_Click(object sender, EventArgs e)
        {
            splitContainerMain.Panel2Collapsed = !splitContainerMain.Panel2Collapsed;
        }

        private void CmsTsmiDetail_Click(object sender, EventArgs e)
        {
            splitContainerMain.Panel2Collapsed = !splitContainerMain.Panel2Collapsed;
        }

        private void tsmiDetail_Click(object sender, EventArgs e)
        {
            splitContainerMain.Panel2Collapsed = !splitContainerMain.Panel2Collapsed;
        }
        #endregion

        #region 查找
        /// <summary>
        /// 查找
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripTopSearch_Click(object sender, EventArgs e)
        {
            OpenSearch();// 打开查找窗口
        }
        /// <summary>
        /// 打开查找窗口
        /// </summary>
        private void OpenSearch()
        {
            frmSearch frm = new frmSearch(this);
            frm.ShowDialog();
        }
        /// <summary>
        /// 查找
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiSearch_Click(object sender, EventArgs e)
        {
            OpenSearch();// 打开查找窗口
        }
        /// <summary>
        /// 查找
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmsTsmiSearch_Click(object sender, EventArgs e)
        {
            OpenSearch();// 打开查找窗口
        }
        #endregion

        #region 栏位
        /// <summary>
        /// 工具栏打开栏位窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripTopField_Click(object sender, EventArgs e)
        {
            OpenField();// 打开栏位窗口
        }
        /// <summary>
        /// 打开栏位窗口
        /// </summary>
        private void OpenField()
        {
            frmField frm = new frmField(this);
            frm.ShowDialog();
        }
        /// <summary>
        /// 菜单打开栏位窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiField_Click(object sender, EventArgs e)
        {
            OpenField();// 打开栏位窗口
        }
        /// <summary>
        /// 右键打开栏位窗口
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmsTsmiField_Click(object sender, EventArgs e)
        {
            OpenField();// 打开栏位窗口
        }
        #endregion

        #region 统计
        private void ToolStripTopReport_Click(object sender, EventArgs e)
        {
            OpenReport();//打开统计窗口
        }
        /// <summary>
        /// 打开统计窗口
        /// </summary>
        private void OpenReport()
        {
            frmReport frm = new frmReport(this);
            frm.ShowDialog();
        }

        private void tsmiReport_Click(object sender, EventArgs e)
        {
            OpenReport();//打开统计窗口
        }

        private void CmsTsmiReport_Click(object sender, EventArgs e)
        {
            OpenReport();//打开统计窗口
        }
        #endregion

        /// <summary>
        /// 选择分类
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClassify_Click(object sender, EventArgs e)
        {
            OpenSelectClassify();//打开选择分类窗口
        }

        /// <summary>
        /// 打开选择分类窗口
        /// </summary>
        private void OpenSelectClassify()
        {
            frmSelectClassify frm = new frmSelectClassify(this);
            frm.ShowDialog();
            if (frm.SelectDataType != null)
            {
                txtClassify.Text = frm.SelectDataType.Name;
                txtClassify.Tag = frm.SelectDataType.Guid;
            }
        }

        #region 移动
        /// <summary>
        /// 工具栏移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripTopMove_Click(object sender, EventArgs e)
        {
            ContentMove();//内容移动
        }
        /// <summary>
        /// 菜单栏位移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiMove_Click(object sender, EventArgs e)
        {
            ContentMove();//内容移动
        }
        /// <summary>
        /// 右键移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmsTsmiMove_Click(object sender, EventArgs e)
        {
            ContentMove();//内容移动
        }
        /// <summary>
        /// 内容移动
        /// </summary>
        private void ContentMove()
        {
            try
            {
                if (dgvMain.SelectedRows.Count < 1) return;
                OpenSelectClassify();//打开选择分类窗口
                string strDataTypeGuid = this.txtClassify.Tag.ToString();
                if (strDataTypeGuid != (this.tvClassify.SelectedNode.Tag as DataType).Guid)//如果调整了内容分类
                {
                    List<Content> upContentList = new List<Content>();
                    foreach (DataGridViewRow dataGridViewRow in dgvMain.SelectedRows)
                    {
                        int contentID = Convert.ToInt32(dataGridViewRow.Cells["ContentID"].Value);
                        var content = contentList.Find(p => p.ContentID == contentID);
                        content.DataTypeGuid = strDataTypeGuid;
                        content.UpdateDate = DateTime.Now;
                        content.UpdateUserGuid = ThisUser.Guid;
                        upContentList.Add(content);
                        this.dgvMain.Rows.Remove(dataGridViewRow);
                    }
                    ContentManager.Update(upContentList);//执行修改
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), ThisSendBackParameter);
            }
        }
        #endregion

        #region 日志
        /// <summary>
        /// 右键日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmsTsmiLogger_Click(object sender, EventArgs e)
        {
            OpenLog();//打开日志窗口
        }
        /// <summary>
        /// 工具栏日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripTopLogger_Click(object sender, EventArgs e)
        {
            OpenLog();//打开日志窗口
        }
        /// <summary>
        /// 菜单日志
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiLogger_Click(object sender, EventArgs e)
        {
            OpenLog();//打开日志窗口
        }
        /// <summary>
        /// 打开日志窗口
        /// </summary>
        private void OpenLog()
        {
            frmLog frm = new frmLog(this);
            frm.ShowDialog();
        }
        #endregion

        #region 解码
        /// <summary>
        /// 解码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDecoding_Click(object sender, EventArgs e)
        {
            OpenShowPassword(txtPassword.Text);//打开查看密码窗体
        }
        /// <summary>
        /// 打开查看密码窗体
        /// </summary>
        /// <param name="strPassword"></param>
        public void OpenShowPassword(string strPassword)
        {
            if (!string.IsNullOrWhiteSpace(strPassword))
            {
                frmShowPassword frm = new frmShowPassword(strPassword,this);
                frm.ShowDialog();
            }
        }
        /// <summary>
        /// 工具栏解码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripTopDecoding_Click(object sender, EventArgs e)
        {
            OpenShowPassword(GetRowPassword());//打开查看密码窗体
        }
        /// <summary>
        /// 右键解码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmsTsmiDecoding_Click(object sender, EventArgs e)
        {
            OpenShowPassword(GetRowPassword());//打开查看密码窗体
        }
        /// <summary>
        /// 菜单解码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiDecoding_Click(object sender, EventArgs e)
        {
            OpenShowPassword(GetRowPassword());//打开查看密码窗体
        }

        /// <summary>
        /// 获取选中行解码后的密码
        /// </summary>
        /// <returns></returns>
        private string GetRowPassword()
        {
            string strDecPassword = "";
            DataGridViewSelectedRowCollection rows = dgvMain.SelectedRows;
            if (rows == null || rows.Count < 1) return strDecPassword;
            DataGridViewRow row = dgvMain.SelectedRows[0];
            string strPassword = Convert.ToString(row.Cells["Password"].Value);

            if (!string.IsNullOrWhiteSpace(strPassword))
            {
                strDecPassword = TripleDES.DecryptPassword(strPassword);
            }
            return strDecPassword;
        }
        #endregion

        #region 导出
        /// <summary>
        /// 工具栏导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripTopExport_Click(object sender, EventArgs e)
        {
            OpenExport();//打开导出窗体
        }
        /// <summary>
        /// 菜单栏导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiExport_Click(object sender, EventArgs e)
        {
            OpenExport();//打开导出窗体
        }
        /// <summary>
        /// 右键导出
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmsTsmiExport_Click(object sender, EventArgs e)
        {
            OpenExport();//打开导出窗体
        }
        /// <summary>
        /// 打开导出窗体
        /// </summary>
        private void OpenExport()
        {
            frmExport frm = new frmExport(this);
            frm.ShowDialog();
        }
        #endregion

        #region 导入
        /// <summary>
        /// 工具栏导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripTopImport_Click(object sender, EventArgs e)
        {
            OpenImport();//打开导入窗体
        }
        /// <summary>
        /// 菜单栏导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiImport_Click(object sender, EventArgs e)
        {
            OpenImport();//打开导入窗体
        }
        /// <summary>
        /// 右键导入
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CmsTsmiImport_Click(object sender, EventArgs e)
        {
            OpenImport();//打开导入窗体
        }
        /// <summary>
        /// 打开导入窗体
        /// </summary>
        private void OpenImport()
        {
            frmImport frm = new frmImport(this);
            frm.ShowDialog();
        }
        #endregion

        #region 用户
        /// <summary>
        /// 工具栏用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ToolStripTopAccount_Click(object sender, EventArgs e)
        {
            OpenUserManager();//打开用户管理窗口
        }
        /// <summary>
        /// 菜单栏用户
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void tsmiAccount_Click(object sender, EventArgs e)
        {
            OpenUserManager();//打开用户管理窗口
        }
        /// <summary>
        /// 打开用户管理窗口
        /// </summary>
        private void OpenUserManager()
        {
            frmUserManager frm = new frmUserManager(this);
            frm.ShowDialog();
        }
        #endregion

        private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Logger.Info("用户 " + ThisUser.ChineseName + " 成功退出系统。", MethodBase.GetCurrentMethod(), this.ThisUser.UserID);
        }

        private void ToolStripTopHelp_Click(object sender, EventArgs e)
        {
            
            ShowHelp();
        }
        /// <summary>
        /// 打开帮助文档
        /// </summary>
        /// <param name="parameter">定位路径</param>
        public void ShowHelp(HelpIdDefines parameter = HelpIdDefines.HId_文档目录) {
            string index = ((int)parameter).ToString();
            string strHelpFile = @"PasswordManager V1.0.0.1 帮助文档.chm";
            Help.ShowHelp(this, strHelpFile, HelpNavigator.Topic, index + ".html");
        }

        private void tsmiViewHelp_Click(object sender, EventArgs e)
        {
            ShowHelp();
        }

        private void tsmiSupport_Click(object sender, EventArgs e)
        {
            OpenUrl("http://www.webczw.com/");
        }
        bool isTimeOut = true;
        private void timerOperCount_Tick(object sender, EventArgs e)
        {
            if (userSetting == null) return;
            OperCount++;
            if (OperCount > userSetting.TimeOut && isTimeOut) {//如果长时间没操作都时间秒数大于，用户配置的将提示超时
                isTimeOut = false;
                DialogResult result = MessageBox.Show("登录超时,请重新登陆。", "系统提示", MessageBoxButtons.OK,MessageBoxIcon.Information);
                if (result == DialogResult.OK) {
                    Application.Exit();
                }
            }
        }
    }
}
