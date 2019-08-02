using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;

namespace RotatingViscometer.Nithons._190724.Utils.Modbus
{
    class Modbus_Tcp
    {
        /// <summary>
        /// [公共方法]
        /// 字节数组转2进制字符串
        /// </summary>
        /// <param name="bs">元素为2的字节数组</param>
        /// <returns>16位的2进制字符串</returns>
        public string ByteToBinStr(byte[] bs)
        {
            string res = string.Empty;
            if (bs != null)
            {
                for (int i = 0; i < bs.Length; i++)
                {
                    res += bs[i].ToString("x2");
                };
                res = Convert.ToString(Convert.ToInt32(res, 16), 2);
                res = res.ToString().PadLeft(16, '0');
            }

            return res;
        }

        /// <summary>
        /// [公共方法]
        /// [ByteToBinStr逆方法]
        /// </summary>
        /// <param name="binStrs">不必16位的2进制字符串</param>
        /// <returns>元素为2的字节数组</returns>
        public byte[] BinStrToByte(string binStr)
        {
            string res = string.Empty;
            res = Convert.ToString(Convert.ToInt32(binStr, 2), 16);
            res = res.ToString().PadLeft(4, '0');

            byte[] bs = new byte[2];
            for (int i = 0; i < bs.Length; i++)
            {
                bs[i] = (byte)((int.Parse(res.Substring(i * 2, 2), NumberStyles.HexNumber)) & 0xff);
            }

            return bs;
        }

        /// <summary>
        /// [公共方法]
        /// 字节数组转10进制字符串
        /// </summary>
        /// <param name="bs">元素为2的字节数组</param>
        /// <returns>10进制字符串</returns>
        public string ByteToDecStr(byte[] bs)
        {
            string res = string.Empty;
            if (bs != null)
            {
                for (int i = 0; i < bs.Length; i++)
                {
                    res += bs[i].ToString("x2");
                };
                res = (Convert.ToInt32(res, 16)).ToString();
            }

            return res;
        }

        /// <summary>
        /// [公共方法]
        /// [ByteToDecStr逆方法]
        /// </summary>
        /// <param name="decStr">10进制字符串</param>
        /// <returns>元素为2的字节数组</returns>
        public byte[] DecStrToByte(string decStr)
        {
            string res = string.Empty;
            res = Convert.ToString(int.Parse(decStr), 16);
            res = res.ToString().PadLeft(4, '0');

            byte[] bs = new byte[2];
            for (int i = 0; i < bs.Length; i++)
            {
                bs[i] = (byte)((int.Parse(res.Substring(i * 2, 2), NumberStyles.HexNumber)) & 0xff);
            }

            return bs;
        }

        /// <summary>
        /// [公共方法]
        /// 字节数组转浮点数（高低权重需置换）
        /// </summary>
        /// <param name="bs">元素为4的字节数组</param>
        /// <returns>浮点数字符串</returns>
        public string ByteToFloatStr(byte[] bs)
        {
            string res = string.Empty;
            //高低权重置换
            for (int i = 0; i < bs.Length / 2; i++)
            {
                //无论数组元素个数为奇数/偶数，都交换Len/2次
                byte temp = bs[i];
                bs[i] = bs[bs.Length - 1 - i];//交换变量的值
                bs[bs.Length - 1 - i] = temp;
            }
            res = (BitConverter.ToSingle(bs, 0)).ToString();

            return res;
        }

        /// <summary>
        /// [公共方法]
        /// [ByteToFloatStr逆方法]
        /// </summary>
        /// <param name="floatStr">浮点数字符串</param>
        /// <returns>元素为4的字节数组</returns>
        public byte[] FloatStrToByte(string floatStr)
        {
            byte[] bs = new byte[4];
            bs = BitConverter.GetBytes(float.Parse(floatStr));
            //高低权重置换
            for (int i = 0; i < bs.Length / 2; i++)
            {
                //无论数组元素个数为奇数/偶数，都交换Len/2次
                byte temp = bs[i];
                bs[i] = bs[bs.Length - 1 - i];//交换变量的值
                bs[bs.Length - 1 - i] = temp;
            }

            return bs;
        }
    }
}
