namespace TemizlikNobetiApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            cbSinif = new ComboBox();
            label1 = new Label();
            btnYeniSinif = new Button();
            btnYeniOgrenci = new Button();
            lbOgrenciler = new ListBox();
            panel1 = new Panel();
            button3 = new Button();
            btnCikar = new Button();
            btnAta = new Button();
            label2 = new Label();
            lbSecilenler = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // cbSinif
            // 
            cbSinif.FormattingEnabled = true;
            cbSinif.Location = new Point(72, 40);
            cbSinif.Name = "cbSinif";
            cbSinif.Size = new Size(121, 23);
            cbSinif.TabIndex = 0;
            cbSinif.SelectedValueChanged += cbSinif_SelectedValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 48);
            label1.Name = "label1";
            label1.Size = new Size(30, 15);
            label1.TabIndex = 1;
            label1.Text = "Sınıf";
            // 
            // btnYeniSinif
            // 
            btnYeniSinif.BackColor = Color.FromArgb(128, 255, 128);
            btnYeniSinif.Location = new Point(49, 376);
            btnYeniSinif.Name = "btnYeniSinif";
            btnYeniSinif.Size = new Size(132, 41);
            btnYeniSinif.TabIndex = 2;
            btnYeniSinif.Text = "Yeni Sınıf";
            btnYeniSinif.UseVisualStyleBackColor = false;
            btnYeniSinif.Click += btnYeniSinif_Click;
            // 
            // btnYeniOgrenci
            // 
            btnYeniOgrenci.BackColor = Color.FromArgb(128, 255, 128);
            btnYeniOgrenci.Location = new Point(205, 376);
            btnYeniOgrenci.Name = "btnYeniOgrenci";
            btnYeniOgrenci.Size = new Size(132, 41);
            btnYeniOgrenci.TabIndex = 2;
            btnYeniOgrenci.Text = "Yeni Öğrenci";
            btnYeniOgrenci.UseVisualStyleBackColor = false;
            btnYeniOgrenci.Click += btnYeniOgrenci_Click;
            // 
            // lbOgrenciler
            // 
            lbOgrenciler.FormattingEnabled = true;
            lbOgrenciler.ItemHeight = 15;
            lbOgrenciler.Location = new Point(25, 94);
            lbOgrenciler.Name = "lbOgrenciler";
            lbOgrenciler.Size = new Size(184, 259);
            lbOgrenciler.TabIndex = 3;
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(btnCikar);
            panel1.Controls.Add(btnAta);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(lbSecilenler);
            panel1.Location = new Point(254, 94);
            panel1.Name = "panel1";
            panel1.Size = new Size(423, 257);
            panel1.TabIndex = 4;
            // 
            // button3
            // 
            button3.Location = new Point(321, 211);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 2;
            button3.Text = "Onayla";
            button3.UseVisualStyleBackColor = true;
            // 
            // btnCikar
            // 
            btnCikar.Location = new Point(19, 86);
            btnCikar.Name = "btnCikar";
            btnCikar.Size = new Size(75, 23);
            btnCikar.TabIndex = 2;
            btnCikar.Text = "< Çıkar ";
            btnCikar.UseVisualStyleBackColor = true;
            btnCikar.Click += btnCikar_Click;
            // 
            // btnAta
            // 
            btnAta.Location = new Point(19, 57);
            btnAta.Name = "btnAta";
            btnAta.Size = new Size(75, 23);
            btnAta.TabIndex = 2;
            btnAta.Text = "Ata >";
            btnAta.UseVisualStyleBackColor = true;
            btnAta.Click += btnAta_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(122, 18);
            label2.Name = "label2";
            label2.Size = new Size(146, 15);
            label2.TabIndex = 1;
            label2.Text = "Bugün Temizlik Yapacaklar";
            // 
            // lbSecilenler
            // 
            lbSecilenler.FormattingEnabled = true;
            lbSecilenler.ItemHeight = 15;
            lbSecilenler.Location = new Point(122, 36);
            lbSecilenler.Name = "lbSecilenler";
            lbSecilenler.Size = new Size(274, 169);
            lbSecilenler.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Controls.Add(lbOgrenciler);
            Controls.Add(btnYeniOgrenci);
            Controls.Add(btnYeniSinif);
            Controls.Add(label1);
            Controls.Add(cbSinif);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSinif;
        private Label label1;
        private Button btnYeniSinif;
        private Button btnYeniOgrenci;
        private ListBox lbOgrenciler;
        private Panel panel1;
        private Button button3;
        private Button btnCikar;
        private Button btnAta;
        private Label label2;
        private ListBox lbSecilenler;
    }
}
