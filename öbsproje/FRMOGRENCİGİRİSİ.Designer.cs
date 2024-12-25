namespace öbsproje
{
    partial class FRMOGRENCİGİRİSİ
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FRMOGRENCİGİRİSİ));
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.TxtOgrNo = new System.Windows.Forms.TextBox();
            this.TxtSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtGuvenlik = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.LblGuvenlikKodu = new System.Windows.Forms.Label();
            this.PbDegistir = new System.Windows.Forms.PictureBox();
            this.BtnGirisYap = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbDegistir)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(28)))), ((int)(((byte)(43)))));
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(756, 67);
            this.panel1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Red;
            this.button1.Dock = System.Windows.Forms.DockStyle.Right;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(693, 0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 67);
            this.button1.TabIndex = 1;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(76, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 31);
            this.label1.TabIndex = 1;
            this.label1.Text = "ÖĞRENCİ GİRİŞ EKRANI";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label2.Location = new System.Drawing.Point(8, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 35);
            this.label2.TabIndex = 1;
            this.label2.Text = "ÖĞRENCİ NUMARASI";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // TxtOgrNo
            // 
            this.TxtOgrNo.Location = new System.Drawing.Point(279, 83);
            this.TxtOgrNo.MaxLength = 10;
            this.TxtOgrNo.Name = "TxtOgrNo";
            this.TxtOgrNo.Size = new System.Drawing.Size(419, 38);
            this.TxtOgrNo.TabIndex = 2;
            this.TxtOgrNo.TextChanged += new System.EventHandler(this.TxtOgrNo_TextChanged);
            // 
            // TxtSifre
            // 
            this.TxtSifre.Location = new System.Drawing.Point(279, 152);
            this.TxtSifre.Name = "TxtSifre";
            this.TxtSifre.Size = new System.Drawing.Size(419, 38);
            this.TxtSifre.TabIndex = 4;
            this.TxtSifre.TextChanged += new System.EventHandler(this.TxtSifre_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label3.Location = new System.Drawing.Point(185, 155);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 35);
            this.label3.TabIndex = 3;
            this.label3.Text = "ŞİFRE";
            // 
            // TxtGuvenlik
            // 
            this.TxtGuvenlik.Location = new System.Drawing.Point(279, 219);
            this.TxtGuvenlik.Name = "TxtGuvenlik";
            this.TxtGuvenlik.Size = new System.Drawing.Size(288, 38);
            this.TxtGuvenlik.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.label4.Location = new System.Drawing.Point(54, 222);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(206, 35);
            this.label4.TabIndex = 5;
            this.label4.Text = "GÜVENLİK KODU";
            // 
            // LblGuvenlikKodu
            // 
            this.LblGuvenlikKodu.AutoSize = true;
            this.LblGuvenlikKodu.Font = new System.Drawing.Font("Segoe UI", 15F);
            this.LblGuvenlikKodu.Location = new System.Drawing.Point(573, 219);
            this.LblGuvenlikKodu.Name = "LblGuvenlikKodu";
            this.LblGuvenlikKodu.Size = new System.Drawing.Size(93, 35);
            this.LblGuvenlikKodu.TabIndex = 7;
            this.LblGuvenlikKodu.Text = "YENİLE";
            this.LblGuvenlikKodu.Click += new System.EventHandler(this.label5_Click);
            // 
            // PbDegistir
            // 
            this.PbDegistir.Image = ((System.Drawing.Image)(resources.GetObject("PbDegistir.Image")));
            this.PbDegistir.Location = new System.Drawing.Point(662, 219);
            this.PbDegistir.Name = "PbDegistir";
            this.PbDegistir.Size = new System.Drawing.Size(36, 38);
            this.PbDegistir.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PbDegistir.TabIndex = 8;
            this.PbDegistir.TabStop = false;
            this.PbDegistir.Click += new System.EventHandler(this.PbDegistir_Click);
            // 
            // BtnGirisYap
            // 
            this.BtnGirisYap.BackColor = System.Drawing.Color.MidnightBlue;
            this.BtnGirisYap.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnGirisYap.ForeColor = System.Drawing.SystemColors.Window;
            this.BtnGirisYap.Location = new System.Drawing.Point(279, 285);
            this.BtnGirisYap.Name = "BtnGirisYap";
            this.BtnGirisYap.Size = new System.Drawing.Size(419, 63);
            this.BtnGirisYap.TabIndex = 9;
            this.BtnGirisYap.Text = "GİRİŞ YAP";
            this.BtnGirisYap.UseVisualStyleBackColor = false;
            this.BtnGirisYap.Click += new System.EventHandler(this.BtnGirisYap_Click);
            this.BtnGirisYap.MouseLeave += new System.EventHandler(this.BtnGirisYap_MouseLeave);
            this.BtnGirisYap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.BtnGirisYap_MouseMove);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.checkBox1.Location = new System.Drawing.Point(493, 354);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(205, 27);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "ŞİFREYİ GÖSTER/GİZLE";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // FRMOGRENCİGİRİSİ
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(756, 409);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.BtnGirisYap);
            this.Controls.Add(this.PbDegistir);
            this.Controls.Add(this.LblGuvenlikKodu);
            this.Controls.Add(this.TxtGuvenlik);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TxtSifre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.TxtOgrNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(5, 6, 5, 6);
            this.Name = "FRMOGRENCİGİRİSİ";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FRMOGRENCİGİRİSİ_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PbDegistir)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox TxtOgrNo;
        private System.Windows.Forms.TextBox TxtSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtGuvenlik;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label LblGuvenlikKodu;
        private System.Windows.Forms.PictureBox PbDegistir;
        private System.Windows.Forms.Button BtnGirisYap;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}

