using RotatingViscometer.Nithons._190724.Lan;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RotatingViscometer.Nithons._190724.Forms
{
    public partial class HelpInfoFrm : Form
    {
        public MainFrm mainFrm;
        Global glb = new Global();
        Multi_Language mul = new Multi_Language();
        public HelpInfoFrm(MainFrm _mainFrm)
        {
            InitializeComponent();
            mainFrm = _mainFrm;
        }

        private void HelpInfoFrm_Load(object sender, EventArgs e)
        {
            Global._IsHelpInfoFrmOpen = true;

            glb.ThisSetBorder(this);
            glb.ThisSetShadow(this);
            glb.ThisInMid(mainFrm, this);
            Multilingual_Load();

        }

        private void Multilingual_Load()
        {
            int l = glb.SimpLanRecord();

            header.Text = mul.About[l] + "  Rotating Viscometer";
            header.Font = mul.Fn9[l];

            More.Text = mul.More[l];
            More.Font = mul.Fn9[l];

            Submit.Text = mul.SubmitBtn[l];
            Submit.Font = mul.Fn9[l];
        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void HelpInfoFrm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Global._IsHelpInfoFrmOpen = false;
        }

        private void More_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Process.Start("http://www.nithons.com/");
        }
    }
}
