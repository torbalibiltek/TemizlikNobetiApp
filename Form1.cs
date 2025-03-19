using System.ComponentModel;

namespace TemizlikNobetiApp
{
    public partial class Form1 : Form
    {
        BindingList<Ogrenci> SeciliOgrenciListesi = new();
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

            lbSecilenler.DisplayMember = "AdSoyad";
            lbSecilenler.ValueMember = "Id";
            lbSecilenler.DataSource = SeciliOgrenciListesi;

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
            BuHaftaTemizlikYapacaklar();
        }

        private void btnAta_Click(object sender, EventArgs e)
        {
            //Seçili olaný öðrenci gibi al (as=gibi)
            //Alamazsan null deðer ver
            Ogrenci ogr = lbOgrenciler.SelectedItem as Ogrenci;

            if (ogr != null)
            {

                if (SeciliOgrenciListesi.Contains(ogr))
                {
                    MessageBox.Show("Öðrenci zaten seçili");
                    return;
                }

                SeciliOgrenciListesi.Add(ogr);
            }

        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            //Seçili olaný öðrenci gibi al (as=gibi)
            //Alamazsan null deðer ver
            Ogrenci ogr = lbSecilenler.SelectedItem as Ogrenci;

            if (ogr != null)
            {
                SeciliOgrenciListesi.Remove(ogr);
            }
        }

        private void btnOnayla_Click(object sender, EventArgs e)
        {
            if (SeciliOgrenciListesi.Count == 0)
            {
                MessageBox.Show("Öðrenci seçimi yapýnýz");
                return;
            }

            //Temizlik kaydý oluþtur
            foreach (Ogrenci ogr in SeciliOgrenciListesi)
            {
                TemizlikKaydi kayit = new();
                kayit.Id = Guid.NewGuid().ToString();
                kayit.OgrenciId = ogr.Id;
                kayit.Tarih = dtpTarih.Value;

                KayitYoneticisi.TemizlikKayitlari.Add(kayit);
            }

            SeciliOgrenciListesi.Clear();

            KayitYoneticisi.Kaydet();
            Filtrele();
            BuHaftaTemizlikYapacaklar();
            MessageBox.Show("Kayýt oluþturuldu");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        void BuHaftaTemizlikYapacaklar()
        {
            if (cbSinif.SelectedValue == null)
            {
                //Sýnýf seçili deðilse
                lbOgrenciler.DataSource = null;
                return;
            }

            //Sýnýf seçili
            string sinifId = cbSinif.SelectedValue.ToString();

            var liste = KayitYoneticisi.Ogrenciler
                .Where(x => x.SinifId == sinifId)
                .OrderBy(x => x.TemizlikPuani)
                .Take(2);
            lblBuHaftaSira.Text = "Bu haftaki Sýra:\n";

            if (liste.Count() == 0)
            {
                lblBuHaftaSira.Text += "Temizlik Yapacak Kiþi Yok";
            }

            foreach (Ogrenci ogr in liste)
            {
                lblBuHaftaSira.Text += $"{ogr.AdSoyad}\n";
            }
        }
        private void btnSec_Click(object sender, EventArgs e)
        {
            if (cbSinif.SelectedValue == null)
            {
                //Sýnýf seçili deðilse
                lbOgrenciler.DataSource = null;
                return;
            }

            //Sýnýf seçili
            string sinifId = cbSinif.SelectedValue.ToString();

            var liste = KayitYoneticisi.Ogrenciler
                .Where(x => x.SinifId == sinifId)
                .OrderBy(x => x.TemizlikPuani)
                .Take(2);

            foreach (Ogrenci ogr in liste)
            {
                if (!SeciliOgrenciListesi.Contains(ogr))
                    SeciliOgrenciListesi.Add(ogr);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now;
            lblTarih.Text = $"Bugün {dt:dd} {dt:MMMM} {dt:yyyy} Saat: {dt:HH}:{dt:mm}";
        }
    }
}
