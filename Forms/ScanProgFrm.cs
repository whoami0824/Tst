using RotatingViscometer.Nithons._190724.Lan;
using RotatingViscometer.Nithons._190724.Utils.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace RotatingViscometer.Nithons._190724.Forms
{
    public partial class ScanProgFrm : Form
    {
        public MainFrm mainFrm;
        Global glb = new Global();
        Multi_Language mul = new Multi_Language();
        SqliteHelper sql = new SqliteHelper();
        Socket socket;

        public ScanProgFrm(MainFrm _mainFrm)
        {
            InitializeComponent();
            mainFrm = _mainFrm;
        }

        private void ScanProgFrm_Load(object sender, EventArgs e)
        {
            Global._IsScanProgFrmOpen = true;

            glb.ThisSetBorder(this);
            glb.ThisSetShadow(this);
            glb.ThisInMid(mainFrm, this);
            MultiLanguage_Load();
            progressBar.Maximum = 1000;

            Global._IsOnStatus[0] =
            Global._IsOnStatus[1] =
            Global._IsOnStatus[2] =
            Global._IsOnStatus[3] = false;
            Global._OnStatuMarks[0] =
            Global._OnStatuMarks[1] =
            Global._OnStatuMarks[2] =
            Global._OnStatuMarks[3] = "";

            Thread th = new Thread(Th_ScanDevIsOnline);
            th.IsBackground = true;
            th.Start();
        }

        #region [函数 * 4] 窗体移动事件

        /// <summary>
        /// 移动窗体锚点
        /// </summary>
        Point _MoveFrmAnchor;

        /// <summary>
        /// [私有方法]
        /// 窗体的鼠标按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScanProgFrm_MouseDown(object sender, MouseEventArgs e)
        {
            _MoveFrmAnchor = new Point(e.X, e.Y);
        }

        /// <summary>
        /// [私有方法]
        /// 窗体的鼠标移动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ScanProgFrm_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                    this.Location.X + e.X - _MoveFrmAnchor.X,
                    this.Location.Y + e.Y - _MoveFrmAnchor.Y
                    );
            }
        }

        /// <summary>
        /// [私有方法]
        /// 窗体的鼠标按下事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopPnl_MouseDown(object sender, MouseEventArgs e)
        {
            _MoveFrmAnchor = new Point(e.X, e.Y);
        }

        /// <summary>
        /// [私有方法]
        /// 窗体的鼠标移动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TopPnl_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                this.Location = new Point(
                    this.Location.X + e.X - _MoveFrmAnchor.X,
                    this.Location.Y + e.Y - _MoveFrmAnchor.Y
                    );
            }
        }

        #endregion

        #region [函数 * 1] 多语言处理

        /// <summary>
        /// [私有方法]
        /// 多语言标签加载
        /// </summary>
        private void MultiLanguage_Load()
        {
            //简化语言参数变量
            int l = glb.SimpLanRecord();

            //标题
            header.Font = mul.Fn10b[l];
            //提示
            scanPrompt1.Font =
            scanPrompt2.Font = mul.Fn8[l];

            header.Text = mul.ScanHeader[l];
            scanPrompt1.Text = mul.ScanPrompt1[l];
            scanPrompt2.Text = mul.ScanPrompt2[l];
        }

        /// <summary>
        /// [私有方法]
        /// 进度信息重载
        /// </summary>
        /// <param name="val"></param>
        private void ScanProgress_ReLoad(int val)
        {
            //简化语言参数变量
            int l = glb.SimpLanRecord();

            header.Font = mul.Fn10b[l];
            header.Text = mul.ScanHeader[l];

            scanPrompt1.Font =
            scanPrompt2.Font = mul.Fn8[l];
            scanPrompt1.Text = mul.ScanPrompt1[l].Replace("0/4", ((val - val % 10 + 10) / 10).ToString() + "/4");
            scanPrompt1.Refresh();
            scanPrompt2.Text = mul.ScanPrompt2[l].Replace("0/40", (val + 1).ToString() + "/40");
            scanPrompt2.Refresh();
        }

        #endregion

        #region [函数 * 1] 线程

        /// <summary>
        /// [公共方法]
        /// 扫描设备是否在线
        /// </summary>
        private void Th_ScanDevIsOnline()
        {
            string sqlStr = "SELECT * FROM BasParmsInfo";
            DataTable tmpdt = sql.ExecuteReader(sqlStr);
            for (int i = 0; i < tmpdt.Rows.Count; i++)
            {
                Global._IpAddrs[i] = tmpdt.Rows[i]["Bas_Ip"].ToString();
                for (int j = 0; j < 10; j++)
                {
                    Global._PortRanges[10 * i + j] = int.Parse(tmpdt.Rows[i]["Bas_Ports"].ToString().Split(',')[0]) + j;
                }
            }

            for (int i = 0; i < 4; i++)
            {
                //检测ip是否能ping通
                if (glb.Ping(Global._IpAddrs[0]) == true)
                {
                    //可ping通，准备下一步
                    for (int j = 10 * i; j < 10 * (i + 1); j++)
                    {
                        try
                        {
                            ProgressBar_Load(j);

                            socket = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                            socket.Connect(Global._IpAddrs[i], Global._PortRanges[j]);

                            byte[] buffSend = { 0x00, 0x00, 0x00, 0x00, 0x00, 0x06, 0x01, 0x03, 0x00, 0x00, 0x00, 0x02 };
                            byte[] buffRece = new byte[13];

                            socket.Send(buffSend, buffSend.Length, 0);
                            socket.Receive(buffRece, buffRece.Length, 0);

                            if (buffRece[0] == 0 && buffRece[1] == 0 && buffRece[2] == 0 && buffRece[3] == 0 && buffRece[4] == 0
                             && buffRece[5] == 7 && buffRece[6] == 1 && buffRece[7] == 3 && buffRece[8] == 4
                             && buffRece[9] == 0 && buffRece[10] == 0 && buffRece[11] == 0 && buffRece[12] == 2)
                            {
                                Global._UsablePorts[i] = Global._PortRanges[j];
                                Global._IsOnStatus[i] = true;
                                break;
                            }
                            else
                            {
                                Global._IsOnStatus[i] = false;
                            }
                        }
                        catch
                        {
                            Global._IsOnStatus[i] = false;
                        }
                    }
                }
                else
                {
                    //跳过10端口
                    ProgressBar_Load(10 * i + 9);
                    continue;
                }
            }

            ProgressBar_Load(39);
        }

        #endregion

        #region [函数 * 1] 进度加载

        /// <summary>
        /// [公共方法]
        /// 进度加载
        /// </summary>
        /// <param name="val"></param>
        private void ProgressBar_Load(int val)
        {
            if (progressBar.InvokeRequired)
            {
                progressBar.Invoke(new MethodInvoker(() =>
                {
                    progressBar.Value = (val + 1) * 25;
                    ScanProgress_ReLoad(val);

                    if (val == 39)
                    {
                        for (int i = 0; i < 4; i++)
                        {
                            if (Global._IsOnStatus[i] == true)
                            {
                                Global._OnStatuMarks[i] = " ●";
                            }
                            else
                            {
                                Global._OnStatuMarks[i] = "";
                            }
                        }

                        mainFrm.TabControl_ReLoad();
                        this.Close();
                    }
                }));
            }
            else
            {
                progressBar.Value = (val + 1) * 25;
                ScanProgress_ReLoad(val);

                if (val == 39)
                {
                    for (int i = 0; i < 4; i++)
                    {
                        if (Global._IsOnStatus[i] == true)
                        {
                            Global._OnStatuMarks[i] = " ●";
                        }
                        else
                        {
                            Global._OnStatuMarks[i] = "";
                        }
                    }

                    mainFrm.TabControl_ReLoad();
                    this.Close();
                }
            }
        }

        #endregion

        private void ScanProgFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global._IsScanProgFrmOpen = false;
        }
    }
}
