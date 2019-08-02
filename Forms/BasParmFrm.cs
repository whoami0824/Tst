using RotatingViscometer.Nithons._190724.Lan;
using RotatingViscometer.Nithons._190724.Utils.SQL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;

namespace RotatingViscometer.Nithons._190724.Forms
{
    public partial class BasParmFrm : Form
    {
        public MainFrm mainFrm;
        Global glb = new Global();
        Multi_Language mul = new Multi_Language();
        SqliteHelper sql = new SqliteHelper();

        public BasParmFrm(MainFrm _mainFrm)
        {
            InitializeComponent();
            mainFrm = _mainFrm;
        }

        private void BasParmFrm_Load(object sender, EventArgs e)
        {
            Global._IsBasParmFrmOpen = true;

            glb.ThisSetBorder(this);
            glb.ThisSetShadow(this);
            glb.ThisInMid(mainFrm, this);
            MultiLanguage_Load();
            Controls_Resize();

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

            textBox1.Text = Global._IpAddrs[0].ToString();
            textBox3.Text = Global._IpAddrs[1].ToString();
            textBox5.Text = Global._IpAddrs[2].ToString();
            textBox7.Text = Global._IpAddrs[3].ToString();

            textBox2.Text = Global._PortRanges[0].ToString() + "," + Global._PortRanges[9].ToString();
            textBox4.Text = Global._PortRanges[10].ToString() + "," + Global._PortRanges[19].ToString();
            textBox6.Text = Global._PortRanges[20].ToString() + "," + Global._PortRanges[29].ToString();
            textBox8.Text = Global._PortRanges[30].ToString() + "," + Global._PortRanges[39].ToString();
        }

        #region [函数 * 4] 窗体移动处理

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
        private void BasParmFrm_MouseDown(object sender, MouseEventArgs e)
        {
            _MoveFrmAnchor = new Point(e.X, e.Y);
        }

        /// <summary>
        /// [私有方法]
        /// 主窗体的鼠标移动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void BasParmFrm_MouseMove(object sender, MouseEventArgs e)
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
        private void TitlePnl_MouseDown(object sender, MouseEventArgs e)
        {
            _MoveFrmAnchor = new Point(e.X, e.Y);
        }

        /// <summary>
        /// [私有方法]
        /// 主窗体的鼠标移动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TitlePnl_MouseMove(object sender, MouseEventArgs e)
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

        #region [函数 * 3] 窗体工具按钮

        /// <summary>
        /// [私有方法]
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// [私有方法]
        /// 鼠标在关闭按钮上方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBtn_MouseMove(object sender, MouseEventArgs e)
        {
            cBtn.BackColor = Color.FromArgb(255, 244, 84, 84);
        }

        /// <summary>
        /// [私有方法]
        /// 鼠标离开关闭按钮上方
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CBtn_MouseLeave(object sender, EventArgs e)
        {
            cBtn.BackColor = Color.White;
        }

        #endregion

        #region [函数 * 1] 多语言处理

        private void MultiLanguage_Load()
        {
            //简化语言参数变量 
            int l = glb.SimpLanRecord();

            //标题
            header.Font =
            //选项卡
            tabControl.Font = mul.Fn9[l];
            //按钮
            subBtn.Font =
            retBtn.Font = mul.Fn8[l];

            header.Text = mul.ParmConf[l];
            tabPage1.Text = mul.Dev[l] + "-1";
            tabPage2.Text = mul.Dev[l] + "-2";
            tabPage3.Text = mul.Dev[l] + "-3";
            tabPage4.Text = mul.Dev[l] + "-4";
            label1.Text = label3.Text = label5.Text = label7.Text = mul.IpAddr[l];
            label2.Text = label4.Text = label6.Text = label8.Text = mul.PortRange[l];
            subBtn.Text = mul.SubmitBtn[l];
            retBtn.Text = mul.ReturnBtn[l];
        }

        #endregion

        #region [函数 * 1] 内部控件自适应调整

        /// <summary>
        /// [私有方法]
        /// 内部控件自适应调整
        /// </summary>
        private void Controls_Resize()
        {
            int[] LblLens = { label1.Width, label2.Width, label3.Width, label4.Width, label5.Width, label6.Width, label7.Width, label8.Width };
            int mxLblLen = LblLens.Max();
            textBox1.Width = textBox3.Width = textBox5.Width = textBox7.Width =
            textBox2.Width = textBox4.Width = textBox6.Width = textBox8.Width = 328 - 48 - mxLblLen;
            textBox1.Location = textBox3.Location = textBox5.Location = textBox7.Location = new Point(24 + mxLblLen, 15);
            textBox2.Location = textBox4.Location = textBox6.Location = textBox8.Location = new Point(24 + mxLblLen, 42);
        }

        #endregion

        #region [函数 * 2] 按钮事件

        /// <summary>
        /// [私有方法]
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SubBtn_Click(object sender, EventArgs e)
        {
            //简化语言参数变量 
            int l = glb.SimpLanRecord();

            //格式验证
            if (glb.IsLegalizeIpAddr(textBox1.Text) == false || glb.IsLegalizePortRange(textBox2.Text) == false ||
                glb.IsLegalizeIpAddr(textBox3.Text) == false || glb.IsLegalizePortRange(textBox4.Text) == false ||
                glb.IsLegalizeIpAddr(textBox5.Text) == false || glb.IsLegalizePortRange(textBox6.Text) == false ||
                glb.IsLegalizeIpAddr(textBox7.Text) == false || glb.IsLegalizePortRange(textBox8.Text) == false)
            {
                MessageBox.Show(mul.InputError[l], mul.Error[l], MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string[] sqlStrs = new string[4];
            sqlStrs[0] = "UPDATE BasParmsInfo SET Bas_Ip = '" + textBox1.Text + "', Bas_Ports = '" + textBox2.Text + "' WHERE Bas_Id = 0";
            sqlStrs[1] = "UPDATE BasParmsInfo SET Bas_Ip = '" + textBox3.Text + "', Bas_Ports = '" + textBox4.Text + "' WHERE Bas_Id = 1";
            sqlStrs[2] = "UPDATE BasParmsInfo SET Bas_Ip = '" + textBox5.Text + "', Bas_Ports = '" + textBox6.Text + "' WHERE Bas_Id = 2";
            sqlStrs[3] = "UPDATE BasParmsInfo SET Bas_Ip = '" + textBox7.Text + "', Bas_Ports = '" + textBox8.Text + "' WHERE Bas_Id = 3";
            sql.ExecuteTransaction(sqlStrs);

            this.Close();
            MessageBox.Show(mul.ParmUpdate[l], mul.Success[l], MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        /// <summary>
        /// [私有方法]
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RetBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #endregion

        private void BasParmFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global._IsBasParmFrmOpen = false;
        }
    }
}
