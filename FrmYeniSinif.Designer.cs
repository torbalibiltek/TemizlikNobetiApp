namespace TemizlikNobetiApp
{
    partial class FrmYeniSinif
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
            btnKaydet = new Button();
            label1 = new Label();
            txtSinifAd = new TextBox();
            SuspendLayout();
            // 
            // btnKaydet
            // 
            btnKaydet.BackColor = Color.FromArgb(128, 255, 128);
            btnKaydet.Location = new Point(185, 117);
            btnKaydet.Name = "btnKaydet";
            btnKaydet.Size = new Size(142, 39);
            btnKaydet.TabIndex = 0;
            btnKaydet.Text = "Kaydet";
            btnKaydet.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(28, 70);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Sınıf Adı";
            // 
            // txtSinifAd
            // 
            txtSinifAd.BackColor = Color.FromArgb(255, 192, 192);
            txtSinifAd.Location = new Point(111, 67);
            txtSinifAd.Name = "txtSinifAd";
            txtSinifAd.Size = new Size(216, 23);
            txtSinifAd.TabIndex = 2;
            // 
            // FrmYeniSinif
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(355, 190);
            Controls.Add(txtSinifAd);
            Controls.Add(label1);
            Controls.Add(btnKaydet);
            Name = "FrmYeniSinif";
            Text = "FrmYeniSinif";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnKaydet;
        private Label label1;
        private TextBox txtSinifAd;
    }
}