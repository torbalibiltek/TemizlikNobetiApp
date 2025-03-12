using System.ComponentModel;

namespace TemizlikNobetiApp
{
    public partial class Form1 : Form
    {
        BindingList<Ogrenci> SeciliOgrenciListesi = new();
        public Form1()
        {
            InitializeComponent();

            //�lk a��l��ta verileri y�kle 
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
                MessageBox.Show("Yeni S�n�f kay�t edildi.");
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
                //S�n�f se�ili de�ilse
                lbOgrenciler.DataSource = null;
                return;
            }

            //S�n�f se�ili
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

        private void btnAta_Click(object sender, EventArgs e)
        {
            //Se�ili olan� ��renci gibi al (as=gibi)
            //Alamazsan null de�er ver
            Ogrenci ogr = lbOgrenciler.SelectedItem as Ogrenci;

            if (ogr != null)
            {
                
                if(SeciliOgrenciListesi.Contains(ogr))
                {
                    MessageBox.Show("��renci zaten se�ili");
                    return;
                }

                SeciliOgrenciListesi.Add(ogr);
            }

        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            //Se�ili olan� ��renci gibi al (as=gibi)
            //Alamazsan null de�er ver
            Ogrenci ogr = lbSecilenler.SelectedItem as Ogrenci;

            if(ogr!=null)
            {
                SeciliOgrenciListesi.Remove(ogr);
            }
        }
    }
}
