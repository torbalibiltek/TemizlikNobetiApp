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
        public static BindingList<Ogrenci> Ogrenciler { get; set; }
        public static BindingList<TemizlikKaydi> TemizlikKayitlari { get; set; }

        public static void Kaydet()
        {
            //Kaydetme işlemleri
            string metin = JsonSerializer.Serialize(Siniflar);

            File.WriteAllText("siniflar.txt", metin);

            string metin2 = JsonSerializer.Serialize(Ogrenciler);

            File.WriteAllText("ogrenciler.txt", metin2);

            string metin3 = JsonSerializer.Serialize(TemizlikKayitlari);

            File.WriteAllText("temizlik.txt", metin3);
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
            /////
            //Yükleme işlemleri
            if (File.Exists("ogrenciler.txt"))
            {
                string metin = File.ReadAllText("ogrenciler.txt");

                var liste = JsonSerializer.Deserialize<List<Ogrenci>>(metin);
                Ogrenciler = new BindingList<Ogrenci>(liste);
            }
            else
            {
                //Boş liste olarak oluştur
                Ogrenciler = new BindingList<Ogrenci>();
            }
            //******
            //Yükleme işlemleri
            if (File.Exists("temizlik.txt"))
            {
                string metin = File.ReadAllText("temizlik.txt");

                var liste = JsonSerializer.Deserialize<List<TemizlikKaydi>>(metin);
                TemizlikKayitlari = new BindingList<TemizlikKaydi>(liste);
            }
            else
            {
                //Boş liste olarak oluştur
                TemizlikKayitlari = new BindingList<TemizlikKaydi>();
            }
        }
    }
}
