namespace RotatingViscometer.Nithons._190724.Forms
{
    partial class HelpInfoFrm
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
            this.Product = new System.Windows.Forms.Label();
            this.PhoneOrFax = new System.Windows.Forms.Label();
            this.Email = new System.Windows.Forms.Label();
            this.Website = new System.Windows.Forms.Label();
            this.Copyright = new System.Windows.Forms.Label();
            this.Submit = new System.Windows.Forms.Button();
            this.DotNet = new System.Windows.Forms.Label();
            this.tlp = new System.Windows.Forms.TableLayoutPanel();
            this.Nithons = new System.Windows.Forms.Label();
            this.More = new System.Windows.Forms.LinkLabel();
            this.cbtn = new System.Windows.Forms.Button();
            this.header = new System.Windows.Forms.Label();
            this.topPnl = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.picPhone = new System.Windows.Forms.PictureBox();
            this.picEmail = new System.Windows.Forms.PictureBox();
            this.picWeb = new System.Windows.Forms.PictureBox();
            this.tlp.SuspendLayout();
            this.topPnl.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeb)).BeginInit();
            this.SuspendLayout();
            // 
            // Product
            // 
            this.Product.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Product.AutoSize = true;
            this.Product.Location = new System.Drawing.Point(29, 75);
            this.Product.Name = "Product";
            this.Product.Size = new System.Drawing.Size(155, 30);
            this.Product.TabIndex = 8;
            this.Product.Text = "Nithons.PressurizedThickener.190712 Version 3.0.0.1";
            // 
            // PhoneOrFax
            // 
            this.PhoneOrFax.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.PhoneOrFax.AutoSize = true;
            this.PhoneOrFax.Location = new System.Drawing.Point(264, 32);
            this.PhoneOrFax.Name = "PhoneOrFax";
            this.PhoneOrFax.Size = new System.Drawing.Size(149, 30);
            this.PhoneOrFax.TabIndex = 12;
            this.PhoneOrFax.Text = "Phone : 022-58627718           Fax : 022-58627711";
            // 
            // Email
            // 
            this.Email.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Email.AutoSize = true;
            this.Email.Location = new System.Drawing.Point(264, 75);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(132, 30);
            this.Email.TabIndex = 10;
            this.Email.Text = "E-mail : abroadsales@nithons.com";
            // 
            // Website
            // 
            this.Website.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.Website.AutoSize = true;
            this.Website.Location = new System.Drawing.Point(264, 126);
            this.Website.Name = "Website";
            this.Website.Size = new System.Drawing.Size(125, 15);
            this.Website.TabIndex = 11;
            this.Website.Text = "Web : www.nithons.com";
            // 
            // Copyright
            // 
            this.Copyright.AutoSize = true;
            this.Copyright.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Copyright.ForeColor = System.Drawing.Color.Black;
            this.Copyright.Location = new System.Drawing.Point(11, 235);
            this.Copyright.Name = "Copyright";
            this.Copyright.Size = new System.Drawing.Size(265, 15);
            this.Copyright.TabIndex = 13;
            this.Copyright.Text = "©2019 天津宁赛科技有限公司 All Rights Reserved.";
            // 
            // Submit
            // 
            this.Submit.Location = new System.Drawing.Point(423, 231);
            this.Submit.Name = "Submit";
            this.Submit.Size = new System.Drawing.Size(84, 23);
            this.Submit.TabIndex = 12;
            this.Submit.Text = "Submit";
            this.Submit.UseVisualStyleBackColor = true;
            this.Submit.Click += new System.EventHandler(this.Confirm_Click);
            // 
            // DotNet
            // 
            this.DotNet.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.DotNet.AutoSize = true;
            this.DotNet.Location = new System.Drawing.Point(43, 32);
            this.DotNet.Name = "DotNet";
            this.DotNet.Size = new System.Drawing.Size(141, 30);
            this.DotNet.TabIndex = 6;
            this.DotNet.Text = "Microsoft .Net Framework Version 4.0";
            // 
            // tlp
            // 
            this.tlp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tlp.ColumnCount = 5;
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 5.180995F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.44531F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.45313F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.84654F));
            this.tlp.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.9256F));
            this.tlp.Controls.Add(this.DotNet, 1, 1);
            this.tlp.Controls.Add(this.Product, 1, 2);
            this.tlp.Controls.Add(this.PhoneOrFax, 3, 1);
            this.tlp.Controls.Add(this.Email, 3, 2);
            this.tlp.Controls.Add(this.Website, 3, 3);
            this.tlp.Controls.Add(this.picPhone, 2, 1);
            this.tlp.Controls.Add(this.picEmail, 2, 2);
            this.tlp.Controls.Add(this.picWeb, 2, 3);
            this.tlp.Location = new System.Drawing.Point(3, 3);
            this.tlp.Name = "tlp";
            this.tlp.RowCount = 5;
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 12F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tlp.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 28F));
            this.tlp.Size = new System.Drawing.Size(512, 217);
            this.tlp.TabIndex = 11;
            // 
            // Nithons
            // 
            this.Nithons.AutoSize = true;
            this.Nithons.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Nithons.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(186)))), ((int)(((byte)(36)))), ((int)(((byte)(39)))));
            this.Nithons.Location = new System.Drawing.Point(24, 42);
            this.Nithons.Name = "Nithons";
            this.Nithons.Size = new System.Drawing.Size(142, 39);
            this.Nithons.TabIndex = 13;
            this.Nithons.Text = "Nithons";
            // 
            // More
            // 
            this.More.AutoSize = true;
            this.More.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.More.LinkColor = System.Drawing.Color.Blue;
            this.More.Location = new System.Drawing.Point(412, 63);
            this.More.Name = "More";
            this.More.Size = new System.Drawing.Size(78, 15);
            this.More.TabIndex = 3;
            this.More.TabStop = true;
            this.More.Text = "Learn More...";
            this.More.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.More_LinkClicked);
            // 
            // cbtn
            // 
            this.cbtn.BackgroundImage = global::RotatingViscometer.Nithons._190724.Properties.Resources.Closed;
            this.cbtn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.cbtn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cbtn.FlatAppearance.BorderSize = 0;
            this.cbtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cbtn.Location = new System.Drawing.Point(472, 0);
            this.cbtn.Name = "cbtn";
            this.cbtn.Size = new System.Drawing.Size(46, 32);
            this.cbtn.TabIndex = 2;
            this.cbtn.UseVisualStyleBackColor = true;
            // 
            // header
            // 
            this.header.AutoSize = true;
            this.header.Location = new System.Drawing.Point(12, 9);
            this.header.Name = "header";
            this.header.Size = new System.Drawing.Size(138, 15);
            this.header.TabIndex = 0;
            this.header.Text = "About Rotating Viscometer";
            // 
            // topPnl
            // 
            this.topPnl.BackColor = System.Drawing.Color.White;
            this.topPnl.Controls.Add(this.More);
            this.topPnl.Controls.Add(this.cbtn);
            this.topPnl.Controls.Add(this.header);
            this.topPnl.Location = new System.Drawing.Point(1, 1);
            this.topPnl.Name = "topPnl";
            this.topPnl.Size = new System.Drawing.Size(518, 93);
            this.topPnl.TabIndex = 12;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.panel1.Controls.Add(this.Copyright);
            this.panel1.Controls.Add(this.Submit);
            this.panel1.Controls.Add(this.tlp);
            this.panel1.Location = new System.Drawing.Point(1, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(518, 265);
            this.panel1.TabIndex = 14;
            // 
            // picPhone
            // 
            this.picPhone.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picPhone.BackgroundImage = global::RotatingViscometer.Nithons._190724.Properties.Resources.Telephone;
            this.picPhone.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picPhone.Location = new System.Drawing.Point(226, 31);
            this.picPhone.Name = "picPhone";
            this.picPhone.Size = new System.Drawing.Size(32, 32);
            this.picPhone.TabIndex = 13;
            this.picPhone.TabStop = false;
            // 
            // picEmail
            // 
            this.picEmail.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picEmail.BackgroundImage = global::RotatingViscometer.Nithons._190724.Properties.Resources.Email;
            this.picEmail.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picEmail.Location = new System.Drawing.Point(226, 74);
            this.picEmail.Name = "picEmail";
            this.picEmail.Size = new System.Drawing.Size(32, 32);
            this.picEmail.TabIndex = 14;
            this.picEmail.TabStop = false;
            // 
            // picWeb
            // 
            this.picWeb.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.picWeb.BackgroundImage = global::RotatingViscometer.Nithons._190724.Properties.Resources.Address;
            this.picWeb.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.picWeb.Location = new System.Drawing.Point(226, 117);
            this.picWeb.Name = "picWeb";
            this.picWeb.Size = new System.Drawing.Size(32, 32);
            this.picWeb.TabIndex = 15;
            this.picWeb.TabStop = false;
            // 
            // HelpInfoFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(520, 360);
            this.Controls.Add(this.Nithons);
            this.Controls.Add(this.topPnl);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Times New Roman", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "HelpInfoFrm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "HelpInfoFrm";
            this.TopMost = true;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HelpInfoFrm_FormClosed);
            this.Load += new System.EventHandler(this.HelpInfoFrm_Load);
            this.tlp.ResumeLayout(false);
            this.tlp.PerformLayout();
            this.topPnl.ResumeLayout(false);
            this.topPnl.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picWeb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Product;
        private System.Windows.Forms.Label PhoneOrFax;
        private System.Windows.Forms.Label Email;
        private System.Windows.Forms.Label Website;
        private System.Windows.Forms.PictureBox picPhone;
        private System.Windows.Forms.PictureBox picWeb;
        private System.Windows.Forms.Label Copyright;
        private System.Windows.Forms.Button Submit;
        private System.Windows.Forms.Label DotNet;
        private System.Windows.Forms.TableLayoutPanel tlp;
        private System.Windows.Forms.PictureBox picEmail;
        private System.Windows.Forms.Label Nithons;
        private System.Windows.Forms.LinkLabel More;
        private System.Windows.Forms.Button cbtn;
        private System.Windows.Forms.Label header;
        private System.Windows.Forms.Panel topPnl;
        private System.Windows.Forms.Panel panel1;
    }
}