using System;
using System.Text;

namespace RotatingViscometer.Nithons._190724.Utils.Security
{
    class Base64Helper
    {
        /// <summary>
        /// Base64 加密
        /// </summary>
        /// <param name="oriStr">未加密原始字符</param>
        /// <returns>加密后字符</returns>
        public string EncryptBase64(string oriStr)
        {
            return Convert.ToBase64String(Encoding.Default.GetBytes(oriStr));
        }

        /// <summary>
        /// Base64 解密
        /// </summary>
        /// <param name="oriStr">未解密原始字符</param>
        /// <returns>解密后字符</returns>
        public string DecodeBase64(string oriStr)
        {
            return Encoding.Default.GetString(Convert.FromBase64String(oriStr));
        }
    }
}
