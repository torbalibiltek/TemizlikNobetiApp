namespace TemizlikNobetiApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Ýlk açýlýþta verileri yükle 
            KayitYoneticisi.Yukle();

            cbSinif.DisplayMember = "Ad";
            cbSinif.ValueMember = "Id";
            cbSinif.DataSource = KayitYoneticisi.Siniflar;

            lbOgrenciler.DisplayMember = "AdSoyad";
            lbOgrenciler.ValueMember = "Id";
            lbOgrenciler.DataSource = KayitYoneticisi.Ogrenciler;

            Filtrele();
        }

        private void btnYeniSinif_Click(object sender, EventArgs e)
        {
            FrmYeniSinif form = new();
            var cevap = form.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                MessageBox.Show("Yeni Sýnýf kayýt edildi.");
            }
        }

        private void btnYeniOgrenci_Click(object sender, EventArgs e)
        {
            FrmYeniOgrenci form = new();
            var cevap = form.ShowDialog();

            if (cevap == DialogResult.OK)
            {
                Filtrele();
            }
        }

        private void Filtrele()
        {
            if (cbSinif.SelectedValue == null)
            {
                //Sýnýf seçili deðilse
                lbOgrenciler.DataSource = null;
                return;
            }

            //Sýnýf seçili
            string sinifId = cbSinif.SelectedValue.ToString();

            //LINQ ile sorgulama
            //Lambda x => x.....
            var liste = KayitYoneticisi.
                Ogrenciler.Where(x => x.SinifId == sinifId).ToList();

            lbOgrenciler.DisplayMember = "AdSoyad";
            lbOgrenciler.ValueMember = "Id";
            lbOgrenciler.DataSource = liste;
        }

        private void cbSinif_SelectedValueChanged(object sender, EventArgs e)
        {
            Filtrele();
        }
    }
}
