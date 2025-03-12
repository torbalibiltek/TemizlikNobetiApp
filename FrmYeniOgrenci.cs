using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TemizlikNobetiApp
{
    public partial class FrmYeniOgrenci : Form
    {
        public FrmYeniOgrenci()
        {
            InitializeComponent();
            cbSinif.DisplayMember = "Ad";
            cbSinif.ValueMember = "Id";//SelectedValue kullanabilmek için
            cbSinif.DataSource = KayitYoneticisi.Siniflar;
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            Ogrenci yeni = new();
            yeni.Id = Guid.NewGuid().ToString();
            yeni.Ad = txtAd.Text;
            yeni.Soyad = txtSoyad.Text;
            yeni.Numara = Convert.ToInt32(mtxtNumara.Text);

            yeni.SinifId = cbSinif.SelectedValue.ToString();

            KayitYoneticisi.Ogrenciler.Add(yeni);
            KayitYoneticisi.Kaydet();
            DialogResult = DialogResult.OK;
        }
    }
}
