using Password.Common;
using Password.Entity;
using Password.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Password.DAL
{
    public class ContentService : BaseService, Iservice<Content>
    {
        public ContentService(SendBackParameter sendBackParameter) : base(sendBackParameter) { }
        /// <summary>
        /// 增加
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Add(List<Content> list)
        {
            return BaseAddOrDelete<Content>(databaseContext.Contents.AddRange, list);
        }
        /// <summary>
        /// 删除
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Delete(List<Content> list)
        {
            return BaseAddOrDelete<Content>(databaseContext.Contents.RemoveRange, list);
        }
        /// <summary>
        /// 加载
        /// </summary>
        /// <returns></returns>
        public List<Content> Load()
        {
            return BaseLoad<Content>(databaseContext.Contents.ToList);
        }
        /// <summary>
        /// 更新
        /// </summary>
        /// <param name="list"></param>
        /// <returns></returns>
        public int Update(List<Content> list)
        {
            return BaseUpdate<Content>(() =>
            {
                foreach (var item in list)
                {
                    Content content = databaseContext.Contents.First(p => p.ContentID == item.ContentID);
                    content.Code = item.Code;
                    content.Title = item.Title;
                    content.Address = item.Address;
                    content.UserName = item.UserName;
                    content.Password = item.Password;
                    content.Email = item.Email;
                    content.Remarks = item.Remarks;
                    content.UpdateDate = item.UpdateDate;
                    content.UpdateUserGuid = item.UpdateUserGuid;
                    content.DataTypeGuid = item.DataTypeGuid;
                }
            }, list);
        }
    }
}
