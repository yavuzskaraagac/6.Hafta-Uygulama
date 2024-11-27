using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OgrenciNotSistemi
{
    class OgrenciNotSistemi
    {
        // Ders adları ve notlarını depolamak için sözlük kullanıyoruz.
        private Dictionary<string, int> dersNotlari = new Dictionary<string, int>();

        // Ders adına göre notlara erişim sağlayan indeksleyici.
        public int this[string dersAdi]
        {
            get
            {
                if (dersNotlari.ContainsKey(dersAdi))
                {
                    return dersNotlari[dersAdi];
                }
                else
                {
                    Console.WriteLine($"Hata: '{dersAdi}' adlı bir ders bulunamadı.");
                    return -1; // Hata durumunda özel bir değer döndürüyoruz.
                }
            }
            set
            {
                if (dersNotlari.ContainsKey(dersAdi))
                {
                    dersNotlari[dersAdi] = value;
                    Console.WriteLine($"'{dersAdi}' dersinin notu güncellendi: {value}");
                }
                else
                {
                    dersNotlari.Add(dersAdi, value);
                    Console.WriteLine($"'{dersAdi}' dersi ve notu eklendi: {value}");
                }
            }
        }
    }

    class Program
    {
        static void Main()
        {
            OgrenciNotSistemi notSistemi = new OgrenciNotSistemi();

            // Ders ekleme
            notSistemi["Matematik"] = 85;
            notSistemi["Fizik"] = 90;
            notSistemi["Kimya"] = 78;

            // Ders notlarını görüntüleme
            Console.WriteLine("Matematik notu: " + notSistemi["Matematik"]);
            Console.WriteLine("Fizik notu: " + notSistemi["Fizik"]);
            Console.WriteLine("Kimya notu: " + notSistemi["Kimya"]);

            // Geçersiz ders adına erişim
            Console.WriteLine("Biyoloji notu: " + notSistemi["Biyoloji"]);

            // Mevcut bir dersin notunu güncelleme
            notSistemi["Fizik"] = 95;
            Console.ReadKey();
        }
    }
}
