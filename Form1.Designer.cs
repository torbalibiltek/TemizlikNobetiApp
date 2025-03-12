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
            SuspendLayout();
            // 
            // cbSinif
            // 
            cbSinif.FormattingEnabled = true;
            cbSinif.Location = new Point(72, 40);
            cbSinif.Name = "cbSinif";
            cbSinif.Size = new Size(121, 23);
            cbSinif.TabIndex = 0;
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
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnYeniSinif);
            Controls.Add(label1);
            Controls.Add(cbSinif);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbSinif;
        private Label label1;
        private Button btnYeniSinif;
    }
}
