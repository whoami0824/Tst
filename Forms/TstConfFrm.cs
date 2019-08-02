using RotatingViscometer.Nithons._190724.Lan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RotatingViscometer.Nithons._190724.Forms
{
    public partial class TstConfFrm : Form
    {
        public MainFrm mainFrm;
        Global glb = new Global();
        Multi_Language mul = new Multi_Language();

        public TstConfFrm(MainFrm _mainFrm)
        {
            InitializeComponent();
            mainFrm = _mainFrm;
        }

        private void TstConfFrm_Load(object sender, EventArgs e)
        {
            Global._IsTstConfFrmOpen = true;

            glb.ThisSetBorder(this);
            glb.ThisSetShadow(this);
            glb.ThisInMid(mainFrm, this);
            MultiLanguage_Load();
            Controls_Resize();

            int l = glb.SimpLanRecord();
            textBox1.Text = mul.Dev[l] + "-1-" + mul.DefTitle[l];
            textBox2.Text = mul.NotSet[l];
            textBox3.Text = mul.Dev[l] + "-2-" + mul.DefTitle[l];
            textBox4.Text = mul.NotSet[l];
            textBox5.Text = mul.Dev[l] + "-3-" + mul.DefTitle[l];
            textBox6.Text = mul.NotSet[l];
            textBox7.Text = mul.Dev[l] + "-4-" + mul.DefTitle[l];
            textBox8.Text = mul.NotSet[l];

            if (Global._TstNames[0] != null)
            {
                textBox1.Text = Global._TstNames[0];
            }
            if (Global._MainCensors[0] != null)
            {
                textBox2.Text = Global._MainCensors[0];
            }
            if (Global._TstNotes[0] != null)
            {
                richTextBox1.Text = Global._TstNotes[0];
            }
            if (Global._TstNames[1] != null)
            {
                textBox3.Text = Global._TstNames[1];
            }
            if (Global._MainCensors[1] != null)
            {
                textBox4.Text = Global._MainCensors[1];
            }
            if (Global._TstNotes[1] != null)
            {
                richTextBox2.Text = Global._TstNotes[1];
            }
            if (Global._TstNames[2] != null)
            {
                textBox5.Text = Global._TstNames[2];
            }
            if (Global._MainCensors[2] != null)
            {
                textBox6.Text = Global._MainCensors[2];
            }
            if (Global._TstNotes[2] != null)
            {
                richTextBox3.Text = Global._TstNotes[2];
            }
            if (Global._TstNames[3] != null)
            {
                textBox7.Text = Global._TstNames[3];
            }
            if (Global._MainCensors[3] != null)
            {
                textBox8.Text = Global._MainCensors[3];
            }
            if (Global._TstNotes[3] != null)
            {
                richTextBox4.Text = Global._TstNotes[3];
            }
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
        private void TstConfFrm_MouseDown(object sender, MouseEventArgs e)
        {
            _MoveFrmAnchor = new Point(e.X, e.Y);
        }

        /// <summary>
        /// [私有方法]
        /// 窗体的鼠标移动事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TstConfFrm_MouseMove(object sender, MouseEventArgs e)
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

        #region [标签 * 1] 窗体工具按钮

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

        /// <summary>
        /// [私有方法]
        /// 多语言标签加载
        /// </summary>
        private void MultiLanguage_Load()
        {
            //简化语言参数变量
            int l = glb.SimpLanRecord();

            header.Text = mul.ParmConf[l];
            header.Font = mul.Fn9[l];

            tabControl.Font = mul.Fn9[l];
            tabPage1.Text = mul.Dev[l] + "-1";
            tabPage2.Text = mul.Dev[l] + "-2";
            tabPage3.Text = mul.Dev[l] + "-3";
            tabPage4.Text = mul.Dev[l] + "-4";
            label1.Font = label2.Font = label3.Font =
            label4.Font = label5.Font = label6.Font =
            label7.Font = label8.Font = label9.Font =
            label10.Font = label11.Font = label12.Font =
                mul.Fn9[l];
            label1.Text = label4.Text = label7.Text = label10.Text = mul.TstName[l];
            label2.Text = label5.Text = label8.Text = label11.Text = mul.MainCensor[l];
            label3.Text = label6.Text = label9.Text = label12.Text = mul.TstNote[l];
            Submit.Font = mul.Fn8[l];
            Submit.Text = mul.SubmitBtn[l];
            Return.Font = mul.Fn8[l];
            Return.Text = mul.ReturnBtn[l];
        }

        #endregion

        #region [函数 * 1] 内部控件自适应调整

        /// <summary>
        /// [私有方法]
        /// 内部控件自适应调整
        /// </summary>
        private void Controls_Resize()
        {
            int[] lenS = {
                label1.Width,
                label2.Width,
                label3.Width
            };

            int maxLenS = lenS.Max();
            textBox1.Width =
            textBox2.Width =
            textBox3.Width =
            textBox4.Width =
            textBox5.Width =
            textBox6.Width =
            textBox7.Width =
            textBox8.Width =
            richTextBox1.Width =
            richTextBox2.Width =
            richTextBox3.Width =
            richTextBox4.Width = tabPage1.Width - 48 - maxLenS;
            textBox1.Location = textBox3.Location = textBox5.Location = textBox7.Location = new Point(24 + maxLenS, 21);
            textBox2.Location = textBox4.Location = textBox6.Location = textBox8.Location = new Point(24 + maxLenS, 48);
            richTextBox1.Location = richTextBox2.Location = richTextBox3.Location = richTextBox4.Location = new Point(24 + maxLenS, 75);
        }

        #endregion

        /// <summary>
        /// 提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Submit_Click(object sender, EventArgs e)
        {
            int l = glb.SimpLanRecord();

            Global._TstNames[0] = textBox1.Text;
            Global._TstNames[1] = textBox3.Text;
            Global._TstNames[2] = textBox5.Text;
            Global._TstNames[3] = textBox7.Text;

            Global._MainCensors[0] = textBox2.Text;
            Global._MainCensors[1] = textBox4.Text;
            Global._MainCensors[2] = textBox6.Text;
            Global._MainCensors[3] = textBox8.Text;

            Global._TstNotes[0] = richTextBox1.Text;
            Global._TstNotes[1] = richTextBox2.Text;
            Global._TstNotes[2] = richTextBox3.Text;
            Global._TstNotes[3] = richTextBox4.Text;

            mainFrm.ToolStrip_ReLoad();
            this.Close();
            MessageBox.Show(mul.ParmUpdate[l], mul.Success[l], MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
            return;
        }

        /// <summary>
        /// 返回
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Return_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TstConfFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global._IsTstConfFrmOpen = false;
        }


    }
}
