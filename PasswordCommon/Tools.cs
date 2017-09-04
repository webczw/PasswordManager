using Password.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Password.Common
{
    public static class Tools
    {
        /// <summary>
        /// 通过反射动态创建对象的实例
        /// </summary>
        /// <typeparam name="T">创建都对象类型</typeparam>
        /// <param name="className">类名</param>
        /// <returns></returns>
        public static T DynamicCreateClass<T>(string className, SendBackParameter sendBackParameter = null)
        {
            T t = default(T);
            try
            {
                object[] parameters = new object[1];
                parameters[0] = sendBackParameter;
                string[] assemblys = GetAppSession(className, sendBackParameter).Split(',');
                string assemblyName = assemblys[0];//程序集名称
                string strongClassName = assemblys[1];//命名空间.类名

                // 注意：这里类名必须为强类名
                // assemblyName可以通过工程的AssemblyInfo.cs中找到
                t = (T)Assembly.Load(assemblyName).CreateInstance(strongClassName, true, System.Reflection.BindingFlags.Default, null, parameters, null, null);
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), sendBackParameter);
            }
            return t;
        }
        /// <summary>
        /// 获取AppSetting配置信息
        /// </summary>
        /// <param name="key">配置信息主键名称</param>
        /// <returns></returns>
        public static string GetAppSession(string key, SendBackParameter sendBackParameter)
        {
            string appSetting = "";
            if (string.IsNullOrWhiteSpace(key)) return appSetting;
            try
            {
                appSetting = System.Configuration.ConfigurationManager.AppSettings[key];
            }
            catch (Exception ex)
            {
                Logger.Error(ex, MethodBase.GetCurrentMethod(), sendBackParameter);
            }

            return appSetting;
        }
    }
}
