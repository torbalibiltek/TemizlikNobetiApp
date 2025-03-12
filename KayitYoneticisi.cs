using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace TemizlikNobetiApp
{
    //Bu Sınıf Tüm kayıt işlemlerinden
    //ve verinin diğer formlar ile 
    //paylaşılmasından sorumludur
    public static class KayitYoneticisi
    {
        public static BindingList<Sinif> Siniflar { get; set; }

        public static void Kaydet()
        {
            //Kaydetme işlemleri
            string metin = JsonSerializer.Serialize(Siniflar);

            File.WriteAllText("siniflar.txt", metin);
        }
        public static void Yukle()
        {
            //Yükleme işlemleri
            if (File.Exists("siniflar.txt"))
            {
                string metin = File.ReadAllText("siniflar.txt");

                var liste = JsonSerializer.Deserialize<List<Sinif>>(metin);
                Siniflar = new BindingList<Sinif>(liste);
            }
            else
            {
                //Boş liste olarak oluştur
                Siniflar = new BindingList<Sinif>();
            }
        }
    }
}
