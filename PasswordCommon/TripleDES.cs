using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Password.Common
{
    public static class TripleDES
    {
        //12个字符  
        private static string customIV = "4vHKRj3yfzU=";
        //32个字符  
        private static string customKey = "xhVs6DRXLfUGxw+AhtfQdpQGoa+8SA9d";
        
        /// <summary>  
        /// 加密字符串  
        /// </summary>  
        /// <param name="password"></param>  
        /// <returns></returns>  
        public static string EncryptPassword(string password)
        {
            string encryptPassword = string.Empty;

            SymmetricAlgorithm algorithm = new TripleDESCryptoServiceProvider();
            algorithm.Key = Convert.FromBase64String(customKey);
            algorithm.IV = Convert.FromBase64String(customIV);
            algorithm.Mode = CipherMode.ECB;
            algorithm.Padding = PaddingMode.PKCS7;

            ICryptoTransform transform = algorithm.CreateEncryptor();

            byte[] data = (new System.Text.UTF8Encoding()).GetBytes(password);
            MemoryStream memoryStream = new MemoryStream();
            CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Write);

            cryptoStream.Write(data, 0, data.Length);
            cryptoStream.FlushFinalBlock();
            encryptPassword = Convert.ToBase64String(memoryStream.ToArray());

            memoryStream.Close();
            cryptoStream.Close();

            return encryptPassword;
        }

        /// <summary>  
        /// 解密字符串  
        /// </summary>  
        /// <param name="password"></param>  
        /// <returns></returns>  
        public static string DecryptPassword(string password)
        {
            if (password.Length < 12) return "";
            string decryptPassword = string.Empty;

            SymmetricAlgorithm algorithm = new TripleDESCryptoServiceProvider();
            algorithm.Key = Convert.FromBase64String(customKey);
            algorithm.IV = Convert.FromBase64String(customIV);
            algorithm.Mode = CipherMode.ECB;
            algorithm.Padding = PaddingMode.PKCS7;

            ICryptoTransform transform = algorithm.CreateDecryptor(algorithm.Key, algorithm.IV);

            byte[] buffer = Convert.FromBase64String(password);
            MemoryStream memoryStream = new MemoryStream(buffer);
            CryptoStream cryptoStream = new CryptoStream(memoryStream, transform, CryptoStreamMode.Read);
            StreamReader reader = new StreamReader(cryptoStream, System.Text.Encoding.UTF8);
            decryptPassword = reader.ReadToEnd();

            reader.Close();
            cryptoStream.Close();
            memoryStream.Close();

            return decryptPassword;
        }
    }
}
