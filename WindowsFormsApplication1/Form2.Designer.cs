﻿namespace WindowsFormsApplication1
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form2));
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.bunifuGradientPanel1 = new Bunifu.Framework.UI.BunifuGradientPanel();
            this.btnKyt2 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.btnDur = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn3 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbl3 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.btn2 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.lbl2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.txt1 = new Bunifu.Framework.UI.BunifuMetroTextbox();
            this.bunifuCustomLabel2 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuCustomLabel1 = new Bunifu.Framework.UI.BunifuCustomLabel();
            this.bunifuGradientPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 60;
            this.bunifuElipse1.TargetControl = this;
            // 
            // bunifuGradientPanel1
            // 
            this.bunifuGradientPanel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuGradientPanel1.BackgroundImage")));
            this.bunifuGradientPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuGradientPanel1.Controls.Add(this.btnKyt2);
            this.bunifuGradientPanel1.Controls.Add(this.btnDur);
            this.bunifuGradientPanel1.Controls.Add(this.btn3);
            this.bunifuGradientPanel1.Controls.Add(this.lbl3);
            this.bunifuGradientPanel1.Controls.Add(this.btn2);
            this.bunifuGradientPanel1.Controls.Add(this.lbl2);
            this.bunifuGradientPanel1.Controls.Add(this.txt1);
            this.bunifuGradientPanel1.Controls.Add(this.bunifuCustomLabel2);
            this.bunifuGradientPanel1.Controls.Add(this.panel1);
            this.bunifuGradientPanel1.GradientBottomLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientBottomRight = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.bunifuGradientPanel1.GradientTopLeft = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.bunifuGradientPanel1.GradientTopRight = System.Drawing.Color.Yellow;
            this.bunifuGradientPanel1.Location = new System.Drawing.Point(-2, 0);
            this.bunifuGradientPanel1.Name = "bunifuGradientPanel1";
            this.bunifuGradientPanel1.Quality = 10;
            this.bunifuGradientPanel1.Size = new System.Drawing.Size(425, 327);
            this.bunifuGradientPanel1.TabIndex = 1;
            // 
            // btnKyt2
            // 
            this.btnKyt2.ActiveBorderThickness = 1;
            this.btnKyt2.ActiveCornerRadius = 20;
            this.btnKyt2.ActiveFillColor = System.Drawing.Color.Black;
            this.btnKyt2.ActiveForecolor = System.Drawing.Color.White;
            this.btnKyt2.ActiveLineColor = System.Drawing.Color.Black;
            this.btnKyt2.BackColor = System.Drawing.SystemColors.Control;
            this.btnKyt2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnKyt2.BackgroundImage")));
            this.btnKyt2.ButtonText = "Kayıt Ol";
            this.btnKyt2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnKyt2.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnKyt2.ForeColor = System.Drawing.Color.Black;
            this.btnKyt2.IdleBorderThickness = 1;
            this.btnKyt2.IdleCornerRadius = 20;
            this.btnKyt2.IdleFillColor = System.Drawing.Color.White;
            this.btnKyt2.IdleForecolor = System.Drawing.Color.Black;
            this.btnKyt2.IdleLineColor = System.Drawing.Color.Black;
            this.btnKyt2.Location = new System.Drawing.Point(120, 225);
            this.btnKyt2.Margin = new System.Windows.Forms.Padding(5);
            this.btnKyt2.Name = "btnKyt2";
            this.btnKyt2.Size = new System.Drawing.Size(181, 41);
            this.btnKyt2.TabIndex = 9;
            this.btnKyt2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnKyt2.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // btnDur
            // 
            this.btnDur.AutoSize = true;
            this.btnDur.BackColor = System.Drawing.Color.Transparent;
            this.btnDur.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Italic);
            this.btnDur.Location = new System.Drawing.Point(251, 267);
            this.btnDur.Name = "btnDur";
            this.btnDur.Size = new System.Drawing.Size(0, 21);
            this.btnDur.TabIndex = 8;
            // 
            // btn3
            // 
            this.btn3.BorderColorFocused = System.Drawing.Color.Blue;
            this.btn3.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn3.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.btn3.BorderThickness = 3;
            this.btn3.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn3.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn3.isPassword = false;
            this.btn3.Location = new System.Drawing.Point(155, 179);
            this.btn3.Margin = new System.Windows.Forms.Padding(4);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(168, 23);
            this.btn3.TabIndex = 6;
            this.btn3.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn3.OnValueChanged += new System.EventHandler(this.btn3_OnValueChanged);
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.BackColor = System.Drawing.Color.Transparent;
            this.lbl3.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Italic);
            this.lbl3.Location = new System.Drawing.Point(106, 179);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(46, 21);
            this.lbl3.TabIndex = 5;
            this.lbl3.Text = "Şifre :";
            // 
            // btn2
            // 
            this.btn2.BorderColorFocused = System.Drawing.Color.Blue;
            this.btn2.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn2.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.btn2.BorderThickness = 3;
            this.btn2.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btn2.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.btn2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btn2.isPassword = false;
            this.btn2.Location = new System.Drawing.Point(155, 148);
            this.btn2.Margin = new System.Windows.Forms.Padding(4);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(168, 23);
            this.btn2.TabIndex = 4;
            this.btn2.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.btn2.OnValueChanged += new System.EventHandler(this.btn2_OnValueChanged);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.BackColor = System.Drawing.Color.Transparent;
            this.lbl2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Italic);
            this.lbl2.Location = new System.Drawing.Point(47, 148);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(105, 21);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Mail Adresiniz :";
            // 
            // txt1
            // 
            this.txt1.BorderColorFocused = System.Drawing.Color.Blue;
            this.txt1.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt1.BorderColorMouseHover = System.Drawing.Color.Blue;
            this.txt1.BorderThickness = 3;
            this.txt1.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt1.Font = new System.Drawing.Font("Century Gothic", 9.75F);
            this.txt1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txt1.isPassword = false;
            this.txt1.Location = new System.Drawing.Point(155, 113);
            this.txt1.Margin = new System.Windows.Forms.Padding(4);
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(168, 23);
            this.txt1.TabIndex = 2;
            this.txt1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txt1.OnValueChanged += new System.EventHandler(this.txt1_OnValueChanged);
            // 
            // bunifuCustomLabel2
            // 
            this.bunifuCustomLabel2.AutoSize = true;
            this.bunifuCustomLabel2.BackColor = System.Drawing.Color.Transparent;
            this.bunifuCustomLabel2.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 12F, System.Drawing.FontStyle.Italic);
            this.bunifuCustomLabel2.Location = new System.Drawing.Point(57, 114);
            this.bunifuCustomLabel2.Name = "bunifuCustomLabel2";
            this.bunifuCustomLabel2.Size = new System.Drawing.Size(95, 21);
            this.bunifuCustomLabel2.TabIndex = 1;
            this.bunifuCustomLabel2.Text = "Kullanıcı Adı :";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.bunifuCustomLabel1);
            this.panel1.Location = new System.Drawing.Point(-19, 23);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(782, 52);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuCustomLabel1
            // 
            this.bunifuCustomLabel1.AutoSize = true;
            this.bunifuCustomLabel1.Font = new System.Drawing.Font("Franklin Gothic Demi Cond", 18.25F, System.Drawing.FontStyle.Italic);
            this.bunifuCustomLabel1.Location = new System.Drawing.Point(93, 12);
            this.bunifuCustomLabel1.Name = "bunifuCustomLabel1";
            this.bunifuCustomLabel1.Size = new System.Drawing.Size(242, 32);
            this.bunifuCustomLabel1.TabIndex = 0;
            this.bunifuCustomLabel1.Text = "Dava Takip Otomasyonu";
            this.bunifuCustomLabel1.Click += new System.EventHandler(this.bunifuCustomLabel1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 320);
            this.Controls.Add(this.bunifuGradientPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.bunifuGradientPanel1.ResumeLayout(false);
            this.bunifuGradientPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuThinButton2 btnKyt2;
        private Bunifu.Framework.UI.BunifuMetroTextbox btn3;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel1;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl3;
        private Bunifu.Framework.UI.BunifuMetroTextbox btn2;
        private Bunifu.Framework.UI.BunifuCustomLabel lbl2;
        private Bunifu.Framework.UI.BunifuGradientPanel bunifuGradientPanel1;
        private Bunifu.Framework.UI.BunifuCustomLabel btnDur;
        private Bunifu.Framework.UI.BunifuMetroTextbox txt1;
        private Bunifu.Framework.UI.BunifuCustomLabel bunifuCustomLabel2;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;

    }
}