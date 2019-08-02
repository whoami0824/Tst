namespace RotatingViscometer.Nithons._190724.Forms
{
    partial class ScanProgFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.topPnl = new System.Windows.Forms.Panel();
            this.header = new System.Windows.Forms.Label();
            this.scanPrompt2 = new System.Windows.Forms.Label();
            this.scanPrompt1 = new System.Windows.Forms.Label();
            this.progressBar = new System.Windows.Forms.ProgressBar();
            this.topPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            this.topPnl.Controls.Add(this.header);
            this.topPnl.Location = new System.Drawing.Point(1, 1);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(498, 60);
            this.topPnl.TabIndex = 4;
            this.topPnl.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopPnl_MouseDown);
            this.topPnl.MouseMove += new System.Windows.Forms.MouseEventHandler(this.TopPnl_MouseMove);
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Font = new System.Drawing.Font("Times New Roman", 10F, System.Drawing.FontStyle.Bold);
            this.header.ForeColor = System.Drawing.Color.White;
            this.header.Location = new System.Drawing.Point(23, 22);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(262, 17);
            this.header.TabIndex = 2;
            this.header.Text = "Please wait while the device is scanning...";
            // 
            // scanPrompt2
            // 
            this.scanPrompt2.AutoSize = true;
            this.scanPrompt2.Location = new System.Drawing.Point(23, 96);
            this.scanPrompt2.Name = "scanPrompt2";
            this.scanPrompt2.Size = new System.Drawing.Size(314, 15);
            this.scanPrompt2.TabIndex = 7;
            this.scanPrompt2.Text = "Target device port connection verification (0/40) is in progress...";
            // 
            // scanPrompt1
            // 
            this.scanPrompt1.AutoSize = true;
            this.scanPrompt1.Location = new System.Drawing.Point(23, 71);
            this.scanPrompt1.Name = "scanPrompt1";
            this.scanPrompt1.Size = new System.Drawing.Size(196, 15);
            this.scanPrompt1.TabIndex = 6;
            this.scanPrompt1.Text = "Target device scan (0/4) is in progress...";
            // 
            // progressBar
            // 
            this.progressBar.Location = new System.Drawing.Point(12, 121);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(476, 3);
            this.progressBar.TabIndex = 5;
            // 
            // ScanProgFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(500, 136);
            this.Controls.Add(this.topPnl);
            this.Controls.Add(this.scanPrompt2);
            this.Controls.Add(this.scanPrompt1);
            this.Controls.Add(this.progressBar);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "ScanProgFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "ScanProgFrm";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.ScanProgFrm_FormClosed);
            this.Load += new System.EventHandler(this.ScanProgFrm_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.ScanProgFrm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.ScanProgFrm_MouseMove);
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Label scanPrompt2;
        private System.Windows.Forms.Label scanPrompt1;
        private System.Windows.Forms.ProgressBar progressBar;
    }
}