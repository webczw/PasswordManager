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

    public partial class frmClassify : Form
    {
        private bool isChanged = false;
        frmMain parentMain;
        List<DataType> deleteDataTypeList = new List<DataType>();//需要删除都对象集合
        int deleteDataTypeContentCount = 0;//删除节点对应内容的数量
        List<DataType> addDataTypeList = new List<DataType>();
        List<DataType> updateDataTypeList = new List<DataType>();
        public frmClassify(frmMain main)
        {
            InitializeComponent();
            parentMain = main;
        }

        private void frmClassify_Load(object sender, EventArgs e)
        {
            tvClassify.ImageList = new frmMain(parentMain.ThisUser, parentMain.userList).ilClassify;
            if (parentMain.DataTypeManager != null)
            {
                LoadDataType(this.tvClassify);
            }

        }

        public void LoadDataType(TreeView tv)
        {

            try
            {
                List<DataType> rootDataTypeList = parentMain.dataTypeList.Where(p => string.IsNullOrWhiteSpace(p.ParentGuid) && p.CreateUserGuid == parentMain.ThisUser.Guid).ToList();
                if (rootDataTypeList.Count < 1) return;
                tv.Nodes.Clear();
                DataType rootDataType = rootDataTypeList[0];
                TreeNode root = new TreeNode();
                root.Text = rootDataType.Code + " - " + rootDataType.Name;
                root.Tag = rootDataType;
                TreeNode allNode = LoadNode(root);

                tv.Nodes.Add(allNode);
                tv.ExpandAll();
                tv.SelectedNode = tv.Nodes[0];
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
        }

        private TreeNode LoadNode(TreeNode node)
        {
            try
            {
                if (parentMain.dataTypeList != null && parentMain.dataTypeList.Count > 0)
                {
                    List<DataType> nodeDataTypeList = parentMain.dataTypeList.Where(p => p.ParentGuid == (node.Tag as DataType).Guid).ToList();
                    List<DataType> sortDataTypeList = (from p in nodeDataTypeList orderby p.SortID select p).ToList();
                    if (sortDataTypeList != null && sortDataTypeList.Count > 0)
                    {
                        foreach (DataType dataType in sortDataTypeList)
                        {
                            TreeNode thisNode = new TreeNode();
                            thisNode.Text = dataType.Code + " - " + dataType.Name;
                            thisNode.Tag = dataType;
                            node.Nodes.Add(thisNode);
                            LoadNode(thisNode);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);//记录日志
            }
            return node;
        }


        private void tvClassify_BeforeSelect(object sender, TreeViewCancelEventArgs e)
        {
            try
            {
                DataType dataType = (DataType)e.Node.Tag;
                this.txtCode.Text = dataType.Code;
                this.txtName.Text = dataType.Name;
                this.txtSort.Text = dataType.SortID.ToString();
                bool isSystem = false;
                if (dataType.IsSystem == "1")
                {
                    isSystem = true;
                }
                this.cbIsSystem.Checked = isSystem;
                if (!isSystem)
                {
                    btnDelete.Enabled = true;
                }
                else { btnDelete.Enabled = false; }
                btnSave.Enabled = true;
                txtCode.Enabled = true;
                txtName.Enabled = true;
                txtSort.Enabled = true;
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);//记录日志
            }
        }

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

                DataType dataType = (DataType)this.tvClassify.SelectedNode.Tag;//当前选择项
                List<DataType> thisDataTypeList = parentMain.dataTypeList.Where(p => p.ParentGuid == dataType.Guid).ToList();
                int maxSortID = 0;

                if (addDataTypeList.Count > 0)
                {
                    maxSortID = addDataTypeList.Max(p => p.SortID);
                }
                else
                {
                    if (thisDataTypeList.Count > 0)
                    {
                        maxSortID = thisDataTypeList.Max(p => p.SortID);//获取当前结点所有子节点最大都排序号
                    }
                }

                DataType newDataType = new DataType();//创建分类实例
                newDataType.ParentGuid = dataType.Guid;
                newDataType.Code = dataType.Code + "." + (maxSortID + 1);
                newDataType.Name = "新分类";
                newDataType.IsSystem = "0";
                newDataType.SortID = (maxSortID + 1);
                newDataType.Guid = Guid.NewGuid().ToString();
                newDataType.Level = dataType.Level + 1;
                newDataType.CreateDate = DateTime.Now;
                newDataType.CreateUserGuid = parentMain.ThisUser.Guid;
                newDataType.UpdateDate = DateTime.Now;
                newDataType.UpdateUserGuid = parentMain.ThisUser.Guid;
                addDataTypeList.Add(newDataType);

                isChanged = true;
                TreeNode thisNode = new TreeNode();
                thisNode.Text = newDataType.Code + " - " + newDataType.Name;
                thisNode.Tag = newDataType;
                tvClassify.SelectedNode.Nodes.Add(thisNode);//在分类控件增加节点
                tvClassify.SelectedNode.Expand();//展开当前选择节点
                tvClassify.Focus();

            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);//记录日志
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
                if (!btnDelete.Enabled) return;
                deleteDataTypeContentCount = 0;

                GetNodesTag(tvClassify.SelectedNode);
                if (deleteDataTypeContentCount < 1)
                {
                    tvClassify.SelectedNode.Remove();//移除分类控件对应节点
                    isChanged = true;
                    tvClassify.Focus();
                }
                else
                {
                    MessageBox.Show(string.Format("删除失败：当前节点及所有字节包含了{0}条内容。\n请先删除或者移动内容。", deleteDataTypeContentCount), "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);//记录日志
            }
        }

        /// <summary>
        ///获得所有节点的TAG
        /// </summary>
        /// <param name="treeNode"></param>
        private void GetNodesTag(TreeNode treeNode)
        {
            DataType dataType = (DataType)treeNode.Tag;
            if (dataType.DataTypeID > 0)
            {
                deleteDataTypeList.Add(dataType);//获得所有节点的TAG
            }
            else
            {
                addDataTypeList.Remove(dataType);
            }
            var newContentList = (from p in parentMain.contentList where p.DataTypeGuid == dataType.Guid select p).ToList();
            deleteDataTypeContentCount += newContentList.Count;//记录行数

            if (treeNode.Nodes.Count > 0)//如果存在子节点
            {
                foreach (TreeNode thisTreeNode in treeNode.Nodes)
                {
                    GetNodesTag(thisTreeNode);
                }
            }
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
                /*if (parentMain.DataTypeManager == null) return;
                string strCode = txtCode.Text.Trim();
                string strName = txtName.Text.Trim();
                string strSortID = txtSort.Text.Trim();
                if (string.IsNullOrWhiteSpace(strCode) || string.IsNullOrWhiteSpace(strName) || string.IsNullOrWhiteSpace(strSortID))
                {
                    MessageBox.Show("保存失败：代码、名称、排序都为必填项。", "系统提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                DataType dataType = (DataType)this.tvClassify.SelectedNode.Tag;//当前选择项
                dataType.Code = strCode;
                dataType.Name = strName;
                dataType.SortID = Convert.ToInt32(strSortID);
                dataType.UpdateDate = DateTime.Now;
                dataType.UpdateUserGuid = parentMain.ThisUser.Guid;
                List<DataType> list = new List<DataType>();
                list.Add(dataType);
                int result = parentMain.DataTypeManager.Update(list);
                if (result > 0)//如果更新条数大于1
                {
                    this.tvClassify.SelectedNode.Text = strCode + " - " + strName;
                    if (this.tvClassify.SelectedNode.Parent != null && ((DataType)this.tvClassify.SelectedNode.Parent.Tag).Level > 1)
                    {
                        TreeNode tempTreeNode = this.tvClassify.SelectedNode;
                        this.tvClassify.SelectedNode.Remove();
                        this.tvClassify.SelectedNode.Parent.Nodes.Insert(dataType.SortID, tempTreeNode);
                    }

                    isChanged = true;
                    tvClassify.Focus();
                }*/
                int result = 0;
                if (addDataTypeList.Count > 0)
                {
                    result += parentMain.DataTypeManager.Add(addDataTypeList);
                }
                if (updateDataTypeList.Count > 0)
                {
                    result += parentMain.DataTypeManager.Update(updateDataTypeList);
                }
                if (deleteDataTypeList.Count > 0)
                {
                    result += parentMain.DataTypeManager.Delete(deleteDataTypeList);
                }
                if (result > 0)
                {
                    isChanged = true;
                }
                this.Close();
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);//记录日志
            }
        }

        private void frmClassify_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (isChanged)
            {
                parentMain.LoadData();//重新加载数据
                this.DialogResult = DialogResult.OK;
            }
        }

        private void txtSort_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar != 8 && !Char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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

        /// <summary>
        /// 代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtCode_Leave(object sender, EventArgs e)
        {
            DataType dataType = (DataType)tvClassify.SelectedNode.Tag;
            DataType thisDataType = GetDataTypeByGuid(dataType.Guid);
            string strCode = Convert.ToString(txtCode.Text);
            string strName = Convert.ToString(txtName.Text);
            if (string.IsNullOrWhiteSpace(strCode) || thisDataType == null) return;
            if (thisDataType.Code != strCode)
            {
                thisDataType.Code = strCode;
                thisDataType.UpdateDate = DateTime.Now;
                thisDataType.UpdateUserGuid = parentMain.ThisUser.Guid;
                tvClassify.SelectedNode.Text = strCode + " - " + strName;
                if (dataType.DataTypeID > 0)//表示历史
                {
                    updateDataTypeList.Add(thisDataType);
                }
            }

        }
        /// <summary>
        /// 根据GUID获取分类对象
        /// </summary>
        /// <param name="strGuid"></param>
        /// <returns></returns>
        private DataType GetDataTypeByGuid(string strGuid)
        {
            DataType thisDataType = new DataType();
            if (parentMain.dataTypeList != null && parentMain.dataTypeList.Count > 0)
            {
                thisDataType = parentMain.dataTypeList.Find(p => p.Guid == strGuid);
            }
            if (thisDataType == null && addDataTypeList.Count > 0)
            {
                thisDataType = addDataTypeList.Find(p => p.Guid == strGuid);
            }

            return thisDataType;
        }

        /// <summary>
        /// 名称
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtName_Leave(object sender, EventArgs e)
        {
            DataType dataType = (DataType)tvClassify.SelectedNode.Tag;
            DataType thisDataType = GetDataTypeByGuid(dataType.Guid);
            string strCode = Convert.ToString(txtCode.Text);
            string strName = Convert.ToString(txtName.Text);
            if (string.IsNullOrWhiteSpace(strName) || thisDataType == null) return;
            if (thisDataType.Name != strName)
            {
                thisDataType.Name = strName;
                thisDataType.UpdateDate = DateTime.Now;
                thisDataType.UpdateUserGuid = parentMain.ThisUser.Guid;
                tvClassify.SelectedNode.Text = strCode + " - " + strName;
                if (dataType.DataTypeID > 0)//表示历史
                {
                    updateDataTypeList.Add(thisDataType);
                }
            }
        }
        /// <summary>
        /// 排序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtSort_Leave(object sender, EventArgs e)
        {
            DataType dataType = (DataType)tvClassify.SelectedNode.Tag;
            DataType thisDataType = GetDataTypeByGuid(dataType.Guid);
            int intSort = Convert.ToInt32(txtSort.Text);
            if (thisDataType == null) return;
            if (thisDataType.SortID != intSort)
            {
                thisDataType.SortID = intSort;
                thisDataType.UpdateDate = DateTime.Now;
                thisDataType.UpdateUserGuid = parentMain.ThisUser.Guid;
                if (dataType.DataTypeID > 0)//表示历史
                {
                    updateDataTypeList.Add(thisDataType);
                }
            }
        }

        private void frmClassify_KeyDown(object sender, KeyEventArgs e)
        {
            //注册键事件
            FormKeyEvent formKeyEvent = new FormKeyEvent();//创建键事件处理实例类
            formKeyEvent.KeyEnterEvent += new FormKeyEvent.FormKey(Save);//保存
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
            parentMain.ShowHelp(HelpIdDefines.HId_分类);
        }

        private void tvClassify_KeyDown(object sender, KeyEventArgs e)
        {
            //注册键事件
            FormKeyEvent formKeyEvent = new FormKeyEvent();//创建键事件处理实例类
            formKeyEvent.KeyInsertEvent += new FormKeyEvent.FormKey(Add);//增加
            formKeyEvent.KeyDeleteEvent += new FormKeyEvent.FormKey(Delete);//删除
            formKeyEvent.Run(e);//运行注册的方法
        }
    }
}
