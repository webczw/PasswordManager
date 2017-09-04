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
    public partial class frmField : Form
    {
        frmMain parentMain;
        List<UserField> leftAllList;
        List<Field> fieldUpdateList = new List<Field>();
        List<Field> fieldDeleteList = new List<Field>();
        List<Field> fieldAddList = new List<Field>();
        public frmField(frmMain parentMain)
        {
            InitializeComponent();
            this.parentMain = parentMain;
        }

        private void frmField_Load(object sender, EventArgs e)
        {
            try
            {
                leftAllList = parentMain.userFieldList.OrderBy(p => p.SortID).ToList().FindAll(p => p.CreateUserGuid == parentMain.ThisUser.Guid || p.SystemField==1);
                var rightList = parentMain.fieldAllList.OrderBy(p => p.SortID).ToList().FindAll(p => p.CreateUserGuid == parentMain.ThisUser.Guid);
                var leftList = leftAllList.FindAll(p =>
                {
                    foreach (var field in rightList)
                    {
                        if (field.UserFieldsGuid == p.Guid)
                        {
                            return false;
                        }
                    }
                    return true;
                });

                foreach (var userField in leftList)
                {
                    BindDgvLeft(userField);//绑定可选字段控件
                }


                foreach (var field in rightList)
                {
                    BindDgvRight(field);//绑定已选字段控件
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
        }
        /// <summary>
        /// 绑定已选字段控件
        /// </summary>
        /// <param name="field"></param>
        /// <returns></returns>
        private int BindDgvRight(Field field)
        {
            int rowIndex = dgvRight.Rows.Add();
            dgvRight.Rows[rowIndex].Cells[0].Value = field.Guid;
            dgvRight.Rows[rowIndex].Cells[1].Value = field.Code;
            dgvRight.Rows[rowIndex].Cells[2].Value = field.Name;
            var userField = leftAllList.Find(p => p.Guid == field.UserFieldsGuid);
            dgvRight.Rows[rowIndex].Cells[3].Value = userField.SystemField == 0 ? "自定义" : "系统 ";
            return rowIndex;
        }

        /// <summary>
        /// 绑定可选字段控件
        /// </summary>
        /// <param name="userField"></param>
        /// <returns></returns>
        private int BindDgvLeft(UserField userField)
        {
            int rowIndex = dgvLeft.Rows.Add();
            dgvLeft.Rows[rowIndex].Cells[0].Value = userField.Guid;
            dgvLeft.Rows[rowIndex].Cells[1].Value = userField.Code;
            dgvLeft.Rows[rowIndex].Cells[2].Value = userField.Name;
            dgvLeft.Rows[rowIndex].Cells[3].Value = userField.SystemField == 0 ? "自定义" : "系统 ";
            return rowIndex;
        }

        /// <summary>
        /// 添加字段
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLeft_Click(object sender, EventArgs e)
        {
            AddField();// 添加字段

        }
        /// <summary>
        /// 添加字段
        /// </summary>
        private void AddField()
        {
            try
            {
                var selectRows = dgvLeft.SelectedRows;
                if (selectRows.Count < 1) return;
                foreach (DataGridViewRow row in selectRows)
                {
                    Field field = new Field();
                    field.Guid = System.Guid.NewGuid().ToString();
                    field.UserFieldsGuid = row.Cells["UserFieldsGuid"].Value.ToString();
                    field.Code = row.Cells["LeftCode"].Value.ToString();
                    field.Name = row.Cells["LeftName"].Value.ToString();
                    field.CreateDate = DateTime.Now;
                    field.CreateUserGuid = parentMain.ThisUser.Guid;
                    field.UpdateDate = DateTime.Now;
                    field.UpdateUserGuid = parentMain.ThisUser.Guid;
                    int maxSort = 1;
                    int maxId = 1;
                    if (parentMain.fieldAllList.Count > 0)
                    {
                        maxId = parentMain.fieldAllList.Max(p => p.FieldID) + 1;
                        maxSort = parentMain.fieldAllList.Max(p => p.SortID) + 1;
                    }
                    field.SortID = maxSort;
                    field.FieldID = maxId;
                    fieldAddList.Add(field);//添加记录
                    parentMain.fieldAllList.Add(field);
                    int rowIndex = BindDgvRight(field);//绑定已选字段控件
                    if (rowIndex != -1)
                    {
                        dgvLeft.Rows.Remove(row);
                    }
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
        }

        /// <summary>
        /// 移除字段
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRight_Click(object sender, EventArgs e)
        {
            RemoveField();//移除字段
        }
        /// <summary>
        /// 移除字段
        /// </summary>
        private void RemoveField()
        {
            try
            {
                var selectRows = dgvRight.SelectedRows;
                if (selectRows.Count < 1) return;
                List<Field> fieldList = new List<Field>();
                foreach (DataGridViewRow row in selectRows)
                {
                    UserField userField = new UserField();
                    Field field = parentMain.fieldAllList.Find(p => p.Guid == row.Cells["FieldGuid"].Value.ToString());
                    userField.Guid = field.UserFieldsGuid;
                    userField.Code = row.Cells["RightCode"].Value.ToString();
                    userField.Name = row.Cells["RightName"].Value.ToString();
                    fieldList.Add(field);
                    int rowIndex = BindDgvLeft(userField);//绑定已选字段控件
                    if (rowIndex != -1)
                    {
                        dgvRight.Rows.Remove(row);
                    }
                }
                if (fieldList.Count > 0)
                {
                    fieldDeleteList.AddRange(fieldList);
                    parentMain.fieldAllList.RemoveAll(p => fieldList.Contains(p));
                }
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
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
                if (fieldAddList.Count > 0)
                {
                    parentMain.FieldManager.Add(fieldAddList);
                }
                if (fieldUpdateList.Count > 0)
                {
                    parentMain.FieldManager.Update(fieldUpdateList);
                }
                if (fieldDeleteList.Count > 0)
                {
                    parentMain.FieldManager.Delete(fieldDeleteList);
                }
                parentMain.UploadDgvMainColumns();//重新加载主内容控件列
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
            this.Close();
        }

        /// <summary>
        /// 向上移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnTop_Click(object sender, EventArgs e)
        {
            try
            {
                var selectRows = dgvRight.SelectedRows;
                if (selectRows.Count != 1) return;
                DataGridViewRow row = dgvRight.SelectedRows[0];
                int rowIndex = row.Index;
                string strFieldGuid = row.Cells["FieldGuid"].Value.ToString();
                if (rowIndex < 1) return;
                DataGridViewRow newRow = CopyDataGriViewRow(row);
                dgvRight.Rows.Insert(rowIndex - 1, newRow);
                dgvRight.Rows.Remove(row);
                dgvRight.Rows[newRow.Index].Selected = true;

                AddFieldUpdateList(rowIndex - 1, strFieldGuid);//增加更新记录

                DataGridViewRow row1 = dgvRight.Rows[rowIndex];
                AddFieldUpdateList(rowIndex, row1.Cells["FieldGuid"].Value.ToString());//增加更新记录
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
        }
        /// <summary>
        /// 向下移动
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBottm_Click(object sender, EventArgs e)
        {
            try
            {
                var selectRows = dgvRight.SelectedRows;
                if (selectRows.Count != 1) return;
                DataGridViewRow row = dgvRight.SelectedRows[0];
                int rowIndex = row.Index;
                string strFieldGuid = row.Cells["FieldGuid"].Value.ToString();

                if (rowIndex == dgvRight.Rows.Count - 1) return;
                DataGridViewRow newRow = CopyDataGriViewRow(row);
                dgvRight.Rows.Remove(row);
                dgvRight.Rows.Insert(rowIndex + 1, newRow);
                dgvRight.Rows[newRow.Index].Selected = true;

                AddFieldUpdateList(rowIndex + 1, strFieldGuid);//增加更新记录

                DataGridViewRow row1 = dgvRight.Rows[rowIndex];
                AddFieldUpdateList(rowIndex, row1.Cells["FieldGuid"].Value.ToString());//增加更新记录
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), parentMain.ThisSendBackParameter);
            }
        }
        /// <summary>
        /// 增加更新记录
        /// </summary>
        /// <param name="rowIndex"></param>
        /// <param name="strFieldGuid"></param>
        private void AddFieldUpdateList(int rowIndex, string strFieldGuid)
        {
            Field field = parentMain.fieldAllList.Find(p => p.Guid == strFieldGuid);
            field.SortID = rowIndex;
            field.UpdateDate = DateTime.Now;
            field.UpdateUserGuid = parentMain.ThisUser.Guid;
            fieldUpdateList.Add(field);
        }

        /// <summary> 
        /// 复制一个行数据 
        /// </summary> 
        /// <param name="myCopyedDataGridViewRow"> </param> 
        /// <returns> </returns> 
        public DataGridViewRow CopyDataGriViewRow(DataGridViewRow myCopyedDataGridViewRow)
        {
            DataGridViewRow myNewDataGridViewRow = myCopyedDataGridViewRow.Clone() as DataGridViewRow;

            for (int i = 0; i < myCopyedDataGridViewRow.Cells.Count; i++)
            {
                myNewDataGridViewRow.Cells[i].Value = myCopyedDataGridViewRow.Cells[i].Value;
            }
            return myNewDataGridViewRow;
        }

        private void dgvRight_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            RemoveField();//移除字段
        }

        private void dgvLeft_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;
            AddField();// 添加字段
        }

        private void frmField_KeyDown(object sender, KeyEventArgs e)
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
            parentMain.ShowHelp(HelpIdDefines.HId_栏位);
        }
    }
}
