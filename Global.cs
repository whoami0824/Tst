using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.NetworkInformation;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace RotatingViscometer.Nithons._190724
{
    class Global
    {
        #region [变量数：4] 子窗体是否开启状态

        /// <summary>
        /// [公共参数]
        /// [布尔值]
        /// [静态变量]
        /// 基础参数窗体是否处于开启状态
        /// </summary>
        public static bool _IsBasParmFrmOpen = false;

        /// <summary>
        /// [公共参数]
        /// [布尔值]
        /// [静态变量]
        /// 帮助信息窗体是否处于开启状态
        /// </summary>
        public static bool _IsHelpInfoFrmOpen = false;

        /// <summary>
        /// [公共参数]
        /// [布尔值]
        /// [静态变量]
        /// 扫描进度窗体是否处于开启状态
        /// </summary>
        public static bool _IsScanProgFrmOpen = false;

        /// <summary>
        /// [公共参数]
        /// [布尔值]
        /// [静态变量]
        /// 测试配置窗体是否处于开启状态
        /// </summary>
        public static bool _IsTstConfFrmOpen = false;

        #endregion

        #region [变量数：2] 语言类型/编码方式

        /// <summary>
        /// [公共参数]
        /// [整型值]
        /// [静态变量]
        /// 语言类型：默认1252
        /// 874 = ANSI/OEM - 泰文；
        /// 932 = ANSI/OEM - 日文 Shift-JIS；
        /// *936 = ANSI/OEM - 简体中文 GBK；
        /// 949 = ANSI/OEM - 韩文；
        /// 950 = ANSI/OEM - 繁体中文 Big5；
        /// 1250 = ANSI - 中欧；
        /// *1251 = ANSI - 西里尔文；
        /// *1252 = ANSI - 拉丁文；
        /// 1253 = ANSI - 希腊文；
        /// 1254 = ANSI - 土耳其文；
        /// 1255 = ANSI - 希伯来文；
        /// 1256 = ANSI - 阿拉伯文；
        /// 1257 = ANSI - 波罗的海文；
        /// 1258 = ANSI - 越南；
        /// </summary>
        public static int _LanRecord = 1252;

        /// <summary>
        /// [公共参数]
        /// [文本值]
        /// [静态变量]
        /// 编码方式：
        /// *936 - gb2312 - 2；
        /// *1251 - windows-1251 - 6；
        /// *1252 - unicode - 7； 
        /// </summary>
        public static string _CustomEncoding = string.Empty;

        #endregion

        #region [变量数：4] 测试属性数组

        /// <summary>
        /// [公共参数]
        /// [文本值数组 * 4]
        /// [静态变量]
        /// 测试名称数组
        /// </summary>
        public static string[] _TstNames = new string[4];

        /// <summary>
        /// [公共参数]
        /// [文本值数组 * 4]
        /// [静态变量]
        /// 主检人数组
        /// </summary>
        public static string[] _MainCensors = new string[4];

        /// <summary>
        /// [公共参数]
        /// [文本值数组 * 4]
        /// [静态变量]
        /// 测试日期数组
        /// </summary>
        public static string[] _TstDates = new string[4];

        /// <summary>
        /// [公共参数]
        /// [文本值数组 * 4]
        /// [静态变量]
        /// 测试备注数组
        /// </summary>
        public static string[] _TstNotes = new string[4];

        #endregion

        #region [变量数：3] 基础参数数组

        /// <summary>
        /// [公共参数]
        /// [文本值数组 * 4]
        /// [静态变量]
        /// ip地址数组
        /// </summary>
        public static string[] _IpAddrs = new string[4];

        /// <summary>
        /// [公共参数]
        /// [整型值数组 * 40]
        /// [静态变量]
        /// 端口范围
        /// </summary>
        public static int[] _PortRanges = new int[40];

        /// <summary>
        /// [公共参数]
        /// [整型值数组 * 4]
        /// [静态变量]
        /// 可用端口
        /// </summary>
        public static int[] _UsablePorts = new int[4];


        #endregion

        #region [变量数：4] 在线标识参数数组

        /// <summary>
        /// [公共参数]
        /// [布尔值数组 * 4]
        /// [静态变量]
        /// 是否在线
        /// </summary>
        public static bool[] _IsOnStatus = new bool[4];

        /// <summary>
        /// [公共参数]
        /// [文本值数组 * 4]
        /// [静态变量]
        /// 在线状态标识
        /// </summary>
        public static string[] _OnStatuMarks = new string[4];

        /// <summary>
        /// [公共参数]
        /// [文本值数组 * 4]
        /// [静态变量]
        /// 测试模式
        /// </summary>
        public static string[] _TstModes = new string[4];

        /// <summary>
        /// [公共参数]
        /// [文本值数组 * 4]
        /// [静态变量]
        /// 测试状态
        /// </summary>
        public static string[] _TstStatus = new string[4];

        #endregion

        #region [变量数：1] 窗体状态

        /// <summary>
        /// [公共参数]
        /// [布尔值]
        /// [静态变量]
        /// 窗体是否处于最大化状态
        /// </summary>
        public static bool _IsFormMax = false;

        #endregion

        #region [函数：4] 窗体操作

        /// <summary>
        /// [公共方法]
        /// 窗体最大化（排除任务栏）
        /// </summary>
        /// <param name="form"></param>
        public void Maximized(Form form)
        {
            Rectangle screen = Screen.GetWorkingArea(form);
            form.Location = new Point(0, 0);
            form.Size = screen.Size;
        }

        /// <summary>
        /// [公共方法]
        /// 窗体大小自适应
        /// </summary>
        /// <param name="form"></param>
        public void ThisSizeResize(Form form)
        {
            Rectangle screen = Screen.GetWorkingArea(form);
            form.Size = new Size(
                ToInt32(screen.Width * 0.9),
                ToInt32(screen.Height * 0.867)
                );
            form.Location = new Point(
                ToInt32(screen.Width * 0.05),
                ToInt32(screen.Height * 0.0665)
                );
        }

        /// user32.dll是Windows用户界面相关应用程序接口，
        /// 用于包括Windows处理，基本用户界面等特性，如创建窗口和发送消息。
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int SetClassLong(IntPtr hWnd, int nIndex, int dwNewLong);
        [System.Runtime.InteropServices.DllImport("user32.dll", CharSet = System.Runtime.InteropServices.CharSet.Auto)]
        private static extern int GetClassLong(IntPtr hWnd, int nIndex);

        /// <summary>
        /// [公共方法]
        /// 窗体阴影配置
        /// </summary>
        /// <param name="form"></param>
        public void ThisSetShadow(Form form)
        {
            SetClassLong(form.Handle, -26, GetClassLong(form.Handle, -26) | 0x20000);
        }

        /// <summary>
        /// [公共方法]
        /// 去除窗体阴影配置
        /// </summary>
        /// <param name="form"></param>
        public void ThisRemShadow(Form form)
        {
            SetClassLong(form.Handle, -26, GetClassLong(form.Handle, 0) | 0x00000);
        }

        /// <summary>
        /// [公共方法]
        /// 窗体边框配置
        /// </summary>
        /// <param name="form"></param>
        public void ThisSetBorder(Form form)
        {
            Color color = Color.FromArgb(255, 0, 174, 219);

            Panel top = new Panel();
            Panel left = new Panel();
            Panel right = new Panel();
            Panel bottom = new Panel();

            top.Size = bottom.Size = new Size(form.Width, 1);
            left.Size = right.Size = new Size(1, form.Height);

            top.BackColor = bottom.BackColor = left.BackColor = right.BackColor = color;

            top.Location = left.Location = new Point(0, 0);
            bottom.Location = new Point(0, form.Height - 1);
            right.Location = new Point(form.Width - 1, 0);

            form.Controls.Add(top);
            form.Controls.Add(left);
            form.Controls.Add(bottom);
            form.Controls.Add(right);
        }

        /// <summary>
        /// [公共方法]
        /// 子窗体居中
        /// </summary>
        /// <param name="pfrm">父窗体</param>
        /// <param name="cfrm">子窗体</param>
        public void ThisInMid(Form pfrm, Form cfrm)
        {
            cfrm.Location = new Point(
                ToInt32(pfrm.Location.X + (pfrm.Width - cfrm.Width) / 2.000),
                ToInt32(pfrm.Location.Y + (pfrm.Height - cfrm.Height) / 2.000)
                );
        }

        #endregion

        #region [函数：4] 工具方法

        #region 类型转整型值

        /// <summary>
        /// [工具方法]
        /// 浮点型转整型值
        /// </summary>
        /// <param name="val"></param>
        /// <returns></returns>
        public int ToInt32(double val)
        {
            return int.Parse(val.ToString("f0"));
        }

        #endregion

        #region 简化语言参数变量

        /// <summary>
        /// 语言编码方式
        /// </summary>
        public string[] _CustomEncodes = {
            "",
            "",
            "gb2312",
            "",
            "",
            "",
            "windows-1251",
            "unicode",
            "",
            "",
            "",
            "",
            "",
            ""
        };

        /// <summary>
        /// [工具方法]
        /// 简化语言参数变量
        /// </summary>
        /// <returns>元素排位</returns>
        public int SimpLanRecord()
        {
            int l;
            switch (_LanRecord)
            {
                case 874:
                    l = 0;
                    break;
                case 932:
                    l = 1;
                    break;
                case 936:
                    l = 2;
                    break;
                case 949:
                    l = 3;
                    break;
                case 950:
                    l = 4;
                    break;
                case 1250:
                    l = 5;
                    break;
                case 1251:
                    l = 6;
                    break;
                case 1253:
                    l = 8;
                    break;
                case 1254:
                    l = 9;
                    break;
                case 1255:
                    l = 10;
                    break;
                case 1256:
                    l = 11;
                    break;
                case 1257:
                    l = 12;
                    break;
                case 1258:
                    l = 13;
                    break;
                default:
                    //1252
                    l = 7;
                    break;
            }

            return l;
        }

        #endregion

        #region 格式验证

        /// <summary>
        /// [公共方法]
        /// ip地址格式验证
        /// </summary>
        /// <param name="ipAddr"></param>
        /// <returns></returns>
        public bool IsLegalizeIpAddr(string ipAddr)
        {
            bool res = false;
            if (!string.IsNullOrEmpty(ipAddr))
            {
                ipAddr = ipAddr.Trim();
                //正则表达式
                string Regular =
                    @"^(?:(?:1[0-9][0-9]\.)|(?:2[0-4][0-9]\.)|(?:25[0-5]\.)|(?:[1-9][0-9]\.)|(?:[0-9]\.)){3}(?:(?:1[0-9][0-9])|(?:2[0-4][0-9])|(?:25[0-5])|(?:[1-9][0-9])|(?:[0-9]))$";
                res = Regex.IsMatch(ipAddr, Regular);
            }
            return res;
        }

        /// <summary>
        /// [公共方法]
        /// 端口范围格式验证
        /// </summary>
        /// <param name="portRange"></param>
        /// <returns></returns>
        public bool IsLegalizePortRange(string portRange)
        {
            bool res = false;
            if (!string.IsNullOrEmpty(portRange))
            {
                portRange = portRange.Trim();

                if (portRange.Contains(','))
                {
                    int sPort = int.Parse(portRange.Split(',')[0]);
                    int ePort = int.Parse(portRange.Split(',')[1]);
                    if (ePort - sPort == 9
                        && sPort > 0 && sPort < 65536
                        && ePort > 0 && ePort < 65536)
                    {
                        res = true;
                    }
                }
            }
            return res;
        }

        #endregion

        #region Ping

        /// <summary>
        /// Ping测试
        /// </summary>
        /// <param name="ip"></param>
        /// <returns></returns>
        public bool Ping(string ip)
        {
            bool res = false;
            Ping p = new Ping();
            PingReply pr = p.Send(ip);
            if (pr.Status == IPStatus.Success)
            {
                res = true;
            }

            return res;
        }

        #endregion

        #region 求取参数

        /// <summary>
        /// 求μρ/ n
        /// </summary>
        /// <param name="Xs"></param>
        /// <param name="Ys"></param>
        /// <param name="isLog">是否为对数</param>
        /// <returns></returns>
        public double ObtainUorP(double[] Xs, double[] Ys, bool isLog)
        {
            double a = 0;
            double b = 0;
            double _x = 0;
            double _y = 0;

            int n = (Xs.Length + Ys.Length) / 2;

            if (isLog == true)
            {
                for (int i = 0; i < n; i++)
                {
                    _x += Math.Log(Xs[i]);
                    _y += Math.Log(Ys[i]);
                }

                _x = _x / n;
                _y = _y / n;

                for (int i = 0; i < n; i++)
                {
                    a += Math.Log(Xs[i]) * Math.Log(Ys[i]) - _x * _y;
                    b += Math.Pow(Math.Log(Xs[i]), 2) - n * Math.Pow(_x, 2);
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    _x += Xs[i];
                    _y += Ys[i];
                }

                _x = _x / n;
                _y = _y / n;

                for (int i = 0; i < n; i++)
                {
                    a += Xs[i] * Ys[i] - _x * _y;
                    b += Math.Pow(Xs[i], 2) - n * Math.Pow(_x, 2);
                }
            }

            return a / b;
        }

        /// <summary>
        /// 求το/ k
        /// </summary>
        /// <param name="Xs"></param>
        /// <param name="Ys"></param>
        /// <param name="sp"></param>
        /// <param name="isLog"></param>
        /// <returns></returns>
        public double ObtainTorO(double[] Xs, double[] Ys, double sp, bool isLog)
        {
            double _x = 0;
            double _y = 0;

            int n = (Xs.Length + Ys.Length) / 2;

            if (isLog == true)
            {
                for (int i = 0; i < n; i++)
                {
                    _x += Math.Log(Xs[i]);
                    _y += Math.Log(Ys[i]);
                }

                _x = _x / n;
                _y = _y / n;
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    _x += Xs[i];
                    _y += Ys[i];
                }

                _x = _x / n;
                _y = _y / n;
            }

            return _y - sp * _x;
        }

        /// <summary>
        /// 求相关系数
        /// </summary>
        /// <param name="Xs"></param>
        /// <param name="Ys"></param>
        /// <param name="isLog"></param>
        /// <returns></returns>
        public double ObtainCorCoef(double[] Xs, double[] Ys, bool isLog)
        {
            double a = 0;
            double b = 0;
            double _x = 0;
            double _y = 0;

            int n = (Xs.Length + Ys.Length) / 2;

            if (isLog == true)
            {
                for (int i = 0; i < n; i++)
                {
                    _x += Math.Log(Xs[i]);
                    _y += Math.Log(Ys[i]);
                }

                _x = _x / n;
                _y = _y / n;

                for (int i = 0; i < n; i++)
                {
                    a += (Math.Log(Xs[i]) - _x) * (Math.Log(Ys[i]) - _y);
                    b += Math.Sqrt(Math.Log(Xs[i]) - Math.Pow(_x, 2)) * Math.Sqrt(Math.Log(Ys[i]) - Math.Pow(_y, 2));
                }
            }
            else
            {
                for (int i = 0; i < n; i++)
                {
                    _x += Xs[i];
                    _x += Ys[i];
                }

                _x = _x / n;
                _y = _y / n;

                for (int i = 0; i < n; i++)
                {
                    a += (Xs[i] - _x) * (Ys[i] - _y);
                    b += Math.Sqrt(Xs[i] - Math.Pow(_x, 2)) * Math.Sqrt(Ys[i] - Math.Pow(_y, 2));
                }
            }

            return a / b;
        }

        #endregion

        #endregion

        #region [函数 * 1] 安全方法

        /// <summary>
        /// [公共方法]
        /// 安全关闭连接
        /// </summary>
        /// <param name="socket"></param>
        public void SafeCloseSocket(Socket socket)
        {
            try
            {
                socket.Shutdown(SocketShutdown.Both);
            }
            catch
            { }

            try
            {
                socket.Close();
            }
            catch
            { }
        }

        #endregion
    }
}
