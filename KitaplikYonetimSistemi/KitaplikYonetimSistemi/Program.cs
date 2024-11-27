using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KitaplikYonetimSistemi
{
    class Kitaplik
    {
        private string[] kitaplar;

        // Kitaplık sınıfı constructor ile kitap sayısını alır ve dizi oluşturur.
        public Kitaplik(int kitapSayisi)
        {
            kitaplar = new string[kitapSayisi];
        }

        // Tek boyutlu indeksleyici
        public string this[int indeks]
        {
            get
            {
                if (indeks < 0 || indeks >= kitaplar.Length)
                {
                    return "Geçersiz indeks. Lütfen 0 ile " + (kitaplar.Length - 1) + " arasında bir değer girin.";
                }
                return kitaplar[indeks] ?? "Henüz kitap eklenmedi.";
            }
            set
            {
                if (indeks < 0 || indeks >= kitaplar.Length)
                {
                    Console.WriteLine("Geçersiz indeks. Lütfen 0 ile " + (kitaplar.Length - 1) + " arasında bir değer girin.");
                }
                else
                {
                    kitaplar[indeks] = value;
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            // 5 kitaplık bir koleksiyon oluşturuluyor.
            Kitaplik kitaplik = new Kitaplik(5);

            // Kitap isimlerini ekleme
            kitaplik[0] = "Savaş ve Barış";
            kitaplik[1] = "1984";
            kitaplik[2] = "Suç ve Ceza";

            // Kitap isimlerini okuma
            Console.WriteLine("0. indeks: " + kitaplik[0]);
            Console.WriteLine("1. indeks: " + kitaplik[1]);
            Console.WriteLine("2. indeks: " + kitaplik[2]);
            Console.WriteLine("3. indeks: " + kitaplik[3]);

            // Geçersiz indeks ile erişim
            Console.WriteLine(kitaplik[10]);

            // Geçersiz indeks ile kitap adı değiştirme denemesi
            kitaplik[10] = "Deneme Kitabı";
            Console.ReadKey();
        }
    }
}
