namespace TemizlikNobetiApp
{
    partial class FrmYeniOgrenci
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
            label1 = new Label();
            mtxtNumara = new MaskedTextBox();
            label2 = new Label();
            txtAd = new TextBox();
            label3 = new Label();
            txtSoyad = new TextBox();
            label4 = new Label();
            cbSinif = new ComboBox();
            btnKaydet = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(48, 41);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Numara";
            // 
            // mtxtNumara
            // 
            mtxtNumara.BackColor = Color.FromArgb(255, 192, 192);
            mtxtNumara.Location = new Point(104, 33);
            mtxtNumara.Mask = "00000";
            mtxtNumara.Name = "mtxtNumara";
            mtxtNumara.Size = new Size(100, 23);
            mtxtNumara.TabIndex = 1;
            mtxtNumara.ValidatingType = typeof(int);
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(48, 72);
            label2.Name = "label2";
            label2.Size = new Size(22, 15);
            label2.TabIndex = 0;
            label2.Text = "Ad";
            // 
            // txtAd
            // 
            txtAd.BackColor = Color.FromArgb(255, 192, 192);
            txtAd.Location = new Point(104, 64);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(170, 23);
            txtAd.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(48, 101);
            label3.Name = "label3";
            label3.Size = new Size(39, 15);
            label3.TabIndex = 0;
            label3.Text = "Soyad";
            // 
            // txtSoyad
            // 
            txtSoyad.BackColor = Color.FromArgb(255, 192, 192);
            txtSoyad.Location = new Point(104, 93);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(170, 23);
            txtSoyad.TabIndex = 2;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(48, 128);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 0;
            label4.Text = "Sınıf";
            // 
            // cbSinif
            // 
            cbSinif.BackColor = Color.FromArgb(255, 192, 192);
            cbSinif.FormattingEnabled = true;
            cbSinif.Location = new Point(104, 122);
            cbSinif.Name = "cbSinif";
            cbSinif.Size = new Size(89, 23);
            cbSinif.TabIndex = 3;
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.MediumAquamarine;
            btnKaydet.Location = new Point(175, 160);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(143, 36);
            btnKaydet.TabIndex = 4;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            btnKaydet.Click += btnKaydet_Click;
            // 
            // FrmYeniOgrenci
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 208);
            Controls.Add(btnKaydet);
            Controls.Add(cbSinif);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(mtxtNumara);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FrmYeniOgrenci";
            Text = "FrmYeniOgrenci";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private MaskedTextBox mtxtNumara;
        private Label label2;
        private TextBox txtAd;
        private Label label3;
        private TextBox txtSoyad;
        private Label label4;
        private ComboBox cbSinif;
        private Button btnKaydet;
    }
}