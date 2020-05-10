namespace NDP_Project
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBoxAtık = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.cikisBtn = new System.Windows.Forms.Button();
            this.puanLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.sureLabel = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.yeniOyunBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.organikAtikEkleBtn = new System.Windows.Forms.Button();
            this.organikAtikBosaltBtn = new System.Windows.Forms.Button();
            this.prgsBarOrganikAtik = new System.Windows.Forms.ProgressBar();
            this.organikAtikListBox = new System.Windows.Forms.ListBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.kagitEkleBtn = new System.Windows.Forms.Button();
            this.kagitBosaltBtn = new System.Windows.Forms.Button();
            this.prgsBarKagit = new System.Windows.Forms.ProgressBar();
            this.kagitListBox = new System.Windows.Forms.ListBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.metalEkleBtn = new System.Windows.Forms.Button();
            this.metalBosaltBtn = new System.Windows.Forms.Button();
            this.prgsBarMetal = new System.Windows.Forms.ProgressBar();
            this.metalListBox = new System.Windows.Forms.ListBox();
            this.panel6 = new System.Windows.Forms.Panel();
            this.camEkleBtn = new System.Windows.Forms.Button();
            this.camBosaltBtn = new System.Windows.Forms.Button();
            this.prgsBarCam = new System.Windows.Forms.ProgressBar();
            this.camListBox = new System.Windows.Forms.ListBox();
            this.oyunTimer = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtık)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Lavender;
            this.panel1.Controls.Add(this.pictureBoxAtık);
            this.panel1.Location = new System.Drawing.Point(18, 15);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(185, 173);
            this.panel1.TabIndex = 0;
            // 
            // pictureBoxAtık
            // 
            this.pictureBoxAtık.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBoxAtık.Location = new System.Drawing.Point(12, 12);
            this.pictureBoxAtık.Name = "pictureBoxAtık";
            this.pictureBoxAtık.Size = new System.Drawing.Size(162, 147);
            this.pictureBoxAtık.TabIndex = 0;
            this.pictureBoxAtık.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Lavender;
            this.panel2.Controls.Add(this.cikisBtn);
            this.panel2.Controls.Add(this.puanLabel);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.sureLabel);
            this.panel2.Controls.Add(this.label24);
            this.panel2.Controls.Add(this.yeniOyunBtn);
            this.panel2.Location = new System.Drawing.Point(18, 205);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 390);
            this.panel2.TabIndex = 1;
            // 
            // cikisBtn
            // 
            this.cikisBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.cikisBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cikisBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.cikisBtn.Location = new System.Drawing.Point(12, 331);
            this.cikisBtn.Name = "cikisBtn";
            this.cikisBtn.Size = new System.Drawing.Size(162, 46);
            this.cikisBtn.TabIndex = 5;
            this.cikisBtn.Text = "ÇIKIŞ";
            this.cikisBtn.UseVisualStyleBackColor = false;
            this.cikisBtn.Click += new System.EventHandler(this.CikisBtn_Click);
            // 
            // puanLabel
            // 
            this.puanLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.puanLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.puanLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.puanLabel.Location = new System.Drawing.Point(12, 241);
            this.puanLabel.Name = "puanLabel";
            this.puanLabel.Size = new System.Drawing.Size(162, 65);
            this.puanLabel.TabIndex = 4;
            this.puanLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.CadetBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Location = new System.Drawing.Point(12, 207);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "PUAN";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // sureLabel
            // 
            this.sureLabel.BackColor = System.Drawing.Color.AliceBlue;
            this.sureLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sureLabel.ForeColor = System.Drawing.Color.DodgerBlue;
            this.sureLabel.Location = new System.Drawing.Point(12, 120);
            this.sureLabel.Name = "sureLabel";
            this.sureLabel.Size = new System.Drawing.Size(162, 65);
            this.sureLabel.TabIndex = 2;
            this.sureLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label24
            // 
            this.label24.BackColor = System.Drawing.Color.CadetBlue;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label24.Location = new System.Drawing.Point(12, 86);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(162, 25);
            this.label24.TabIndex = 1;
            this.label24.Text = "SÜRE";
            this.label24.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yeniOyunBtn
            // 
            this.yeniOyunBtn.BackColor = System.Drawing.Color.SteelBlue;
            this.yeniOyunBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.yeniOyunBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.yeniOyunBtn.Location = new System.Drawing.Point(12, 12);
            this.yeniOyunBtn.Name = "yeniOyunBtn";
            this.yeniOyunBtn.Size = new System.Drawing.Size(162, 57);
            this.yeniOyunBtn.TabIndex = 0;
            this.yeniOyunBtn.Text = "YENİ OYUN";
            this.yeniOyunBtn.UseVisualStyleBackColor = false;
            this.yeniOyunBtn.Click += new System.EventHandler(this.NewGame_Click);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Azure;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(219, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(318, 34);
            this.label1.TabIndex = 6;
            this.label1.Text = "ATIK KUTULARI";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel3.Controls.Add(this.organikAtikEkleBtn);
            this.panel3.Controls.Add(this.organikAtikBosaltBtn);
            this.panel3.Controls.Add(this.prgsBarOrganikAtik);
            this.panel3.Controls.Add(this.organikAtikListBox);
            this.panel3.Location = new System.Drawing.Point(220, 71);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(150, 256);
            this.panel3.TabIndex = 7;
            // 
            // organikAtikEkleBtn
            // 
            this.organikAtikEkleBtn.BackColor = System.Drawing.Color.Gray;
            this.organikAtikEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organikAtikEkleBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.organikAtikEkleBtn.Location = new System.Drawing.Point(13, 3);
            this.organikAtikEkleBtn.Name = "organikAtikEkleBtn";
            this.organikAtikEkleBtn.Size = new System.Drawing.Size(126, 30);
            this.organikAtikEkleBtn.TabIndex = 12;
            this.organikAtikEkleBtn.Text = "ORGANIK ATIK";
            this.organikAtikEkleBtn.UseVisualStyleBackColor = false;
            this.organikAtikEkleBtn.Click += new System.EventHandler(this.OrganikAtikEkleBtn_Click);
            // 
            // organikAtikBosaltBtn
            // 
            this.organikAtikBosaltBtn.BackColor = System.Drawing.Color.Gray;
            this.organikAtikBosaltBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.organikAtikBosaltBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.organikAtikBosaltBtn.Location = new System.Drawing.Point(13, 207);
            this.organikAtikBosaltBtn.Name = "organikAtikBosaltBtn";
            this.organikAtikBosaltBtn.Size = new System.Drawing.Size(126, 38);
            this.organikAtikBosaltBtn.TabIndex = 6;
            this.organikAtikBosaltBtn.Text = "BOŞALT";
            this.organikAtikBosaltBtn.UseVisualStyleBackColor = false;
            // 
            // prgsBarOrganikAtik
            // 
            this.prgsBarOrganikAtik.Location = new System.Drawing.Point(13, 178);
            this.prgsBarOrganikAtik.Name = "prgsBarOrganikAtik";
            this.prgsBarOrganikAtik.Size = new System.Drawing.Size(126, 23);
            this.prgsBarOrganikAtik.TabIndex = 8;
            // 
            // organikAtikListBox
            // 
            this.organikAtikListBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.organikAtikListBox.FormattingEnabled = true;
            this.organikAtikListBox.Location = new System.Drawing.Point(13, 38);
            this.organikAtikListBox.Name = "organikAtikListBox";
            this.organikAtikListBox.Size = new System.Drawing.Size(126, 134);
            this.organikAtikListBox.TabIndex = 7;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel4.Controls.Add(this.kagitEkleBtn);
            this.panel4.Controls.Add(this.kagitBosaltBtn);
            this.panel4.Controls.Add(this.prgsBarKagit);
            this.panel4.Controls.Add(this.kagitListBox);
            this.panel4.Location = new System.Drawing.Point(387, 71);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(150, 256);
            this.panel4.TabIndex = 8;
            // 
            // kagitEkleBtn
            // 
            this.kagitEkleBtn.BackColor = System.Drawing.Color.Gray;
            this.kagitEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kagitEkleBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kagitEkleBtn.Location = new System.Drawing.Point(12, 3);
            this.kagitEkleBtn.Name = "kagitEkleBtn";
            this.kagitEkleBtn.Size = new System.Drawing.Size(126, 30);
            this.kagitEkleBtn.TabIndex = 13;
            this.kagitEkleBtn.Text = "BOŞALT";
            this.kagitEkleBtn.UseVisualStyleBackColor = false;
            // 
            // kagitBosaltBtn
            // 
            this.kagitBosaltBtn.BackColor = System.Drawing.Color.Gray;
            this.kagitBosaltBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.kagitBosaltBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.kagitBosaltBtn.Location = new System.Drawing.Point(12, 207);
            this.kagitBosaltBtn.Name = "kagitBosaltBtn";
            this.kagitBosaltBtn.Size = new System.Drawing.Size(126, 38);
            this.kagitBosaltBtn.TabIndex = 9;
            this.kagitBosaltBtn.Text = "BOŞALT";
            this.kagitBosaltBtn.UseVisualStyleBackColor = false;
            // 
            // prgsBarKagit
            // 
            this.prgsBarKagit.Location = new System.Drawing.Point(12, 178);
            this.prgsBarKagit.Name = "prgsBarKagit";
            this.prgsBarKagit.Size = new System.Drawing.Size(126, 23);
            this.prgsBarKagit.TabIndex = 11;
            // 
            // kagitListBox
            // 
            this.kagitListBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.kagitListBox.FormattingEnabled = true;
            this.kagitListBox.Location = new System.Drawing.Point(12, 38);
            this.kagitListBox.Name = "kagitListBox";
            this.kagitListBox.Size = new System.Drawing.Size(126, 134);
            this.kagitListBox.TabIndex = 10;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel5.Controls.Add(this.metalEkleBtn);
            this.panel5.Controls.Add(this.metalBosaltBtn);
            this.panel5.Controls.Add(this.prgsBarMetal);
            this.panel5.Controls.Add(this.metalListBox);
            this.panel5.Location = new System.Drawing.Point(387, 339);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(150, 256);
            this.panel5.TabIndex = 9;
            // 
            // metalEkleBtn
            // 
            this.metalEkleBtn.BackColor = System.Drawing.Color.Gray;
            this.metalEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metalEkleBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metalEkleBtn.Location = new System.Drawing.Point(12, 6);
            this.metalEkleBtn.Name = "metalEkleBtn";
            this.metalEkleBtn.Size = new System.Drawing.Size(126, 30);
            this.metalEkleBtn.TabIndex = 15;
            this.metalEkleBtn.Text = "BOŞALT";
            this.metalEkleBtn.UseVisualStyleBackColor = false;
            // 
            // metalBosaltBtn
            // 
            this.metalBosaltBtn.BackColor = System.Drawing.Color.Gray;
            this.metalBosaltBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.metalBosaltBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.metalBosaltBtn.Location = new System.Drawing.Point(12, 211);
            this.metalBosaltBtn.Name = "metalBosaltBtn";
            this.metalBosaltBtn.Size = new System.Drawing.Size(126, 38);
            this.metalBosaltBtn.TabIndex = 12;
            this.metalBosaltBtn.Text = "BOŞALT";
            this.metalBosaltBtn.UseVisualStyleBackColor = false;
            // 
            // prgsBarMetal
            // 
            this.prgsBarMetal.Location = new System.Drawing.Point(12, 182);
            this.prgsBarMetal.Name = "prgsBarMetal";
            this.prgsBarMetal.Size = new System.Drawing.Size(126, 23);
            this.prgsBarMetal.TabIndex = 14;
            // 
            // metalListBox
            // 
            this.metalListBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.metalListBox.FormattingEnabled = true;
            this.metalListBox.Location = new System.Drawing.Point(12, 42);
            this.metalListBox.Name = "metalListBox";
            this.metalListBox.Size = new System.Drawing.Size(126, 134);
            this.metalListBox.TabIndex = 13;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.CornflowerBlue;
            this.panel6.Controls.Add(this.camEkleBtn);
            this.panel6.Controls.Add(this.camBosaltBtn);
            this.panel6.Controls.Add(this.prgsBarCam);
            this.panel6.Controls.Add(this.camListBox);
            this.panel6.Location = new System.Drawing.Point(220, 339);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(150, 256);
            this.panel6.TabIndex = 9;
            // 
            // camEkleBtn
            // 
            this.camEkleBtn.BackColor = System.Drawing.Color.Gray;
            this.camEkleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camEkleBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.camEkleBtn.Location = new System.Drawing.Point(13, 6);
            this.camEkleBtn.Name = "camEkleBtn";
            this.camEkleBtn.Size = new System.Drawing.Size(126, 30);
            this.camEkleBtn.TabIndex = 14;
            this.camEkleBtn.Text = "BOŞALT";
            this.camEkleBtn.UseVisualStyleBackColor = false;
            // 
            // camBosaltBtn
            // 
            this.camBosaltBtn.BackColor = System.Drawing.Color.Gray;
            this.camBosaltBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.camBosaltBtn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.camBosaltBtn.Location = new System.Drawing.Point(13, 211);
            this.camBosaltBtn.Name = "camBosaltBtn";
            this.camBosaltBtn.Size = new System.Drawing.Size(126, 38);
            this.camBosaltBtn.TabIndex = 9;
            this.camBosaltBtn.Text = "BOŞALT";
            this.camBosaltBtn.UseVisualStyleBackColor = false;
            // 
            // prgsBarCam
            // 
            this.prgsBarCam.Location = new System.Drawing.Point(13, 182);
            this.prgsBarCam.Name = "prgsBarCam";
            this.prgsBarCam.Size = new System.Drawing.Size(126, 23);
            this.prgsBarCam.TabIndex = 11;
            // 
            // camListBox
            // 
            this.camListBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.camListBox.FormattingEnabled = true;
            this.camListBox.Location = new System.Drawing.Point(13, 42);
            this.camListBox.Name = "camListBox";
            this.camListBox.Size = new System.Drawing.Size(126, 134);
            this.camListBox.TabIndex = 10;
            // 
            // oyunTimer
            // 
            this.oyunTimer.Tick += new System.EventHandler(this.OyunTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.ClientSize = new System.Drawing.Size(549, 607);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "ATIK TOPLAMA";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxAtık)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxAtık;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button yeniOyunBtn;
        private System.Windows.Forms.Button cikisBtn;
        private System.Windows.Forms.Label puanLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label sureLabel;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListBox organikAtikListBox;
        private System.Windows.Forms.Button organikAtikBosaltBtn;
        private System.Windows.Forms.ProgressBar prgsBarOrganikAtik;
        private System.Windows.Forms.Button kagitBosaltBtn;
        private System.Windows.Forms.ProgressBar prgsBarKagit;
        private System.Windows.Forms.ListBox kagitListBox;
        private System.Windows.Forms.Button metalBosaltBtn;
        private System.Windows.Forms.ProgressBar prgsBarMetal;
        private System.Windows.Forms.ListBox metalListBox;
        private System.Windows.Forms.Button camBosaltBtn;
        private System.Windows.Forms.ProgressBar prgsBarCam;
        private System.Windows.Forms.ListBox camListBox;
        private System.Windows.Forms.Button organikAtikEkleBtn;
        private System.Windows.Forms.Button kagitEkleBtn;
        private System.Windows.Forms.Button metalEkleBtn;
        private System.Windows.Forms.Button camEkleBtn;
        private System.Windows.Forms.Timer oyunTimer;
    }
}

