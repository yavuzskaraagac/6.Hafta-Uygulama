using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarkliSekillerinAlaniniHesaplama
{
    class AlanHesapla
    {
        // İlk sürüm: Karenin alanını hesaplar
        public double Alan(double kenar)
        {
            return kenar * kenar;
        }

        // İkinci sürüm: Dikdörtgenin alanını hesaplar
        public double Alan(double uzunKenar, double kisaKenar)
        {
            return uzunKenar * kisaKenar;
        }

        // Üçüncü sürüm: Dairenin alanını hesaplar
        public double Alan(double yaricap, bool daire)
        {
            return Math.PI * yaricap * yaricap;
        }
    }

    class Program
    {
        static void Main()
        {
            AlanHesapla hesaplayici = new AlanHesapla();

            // Karenin alanını hesapla
            Console.WriteLine("Karenin alanı: " + hesaplayici.Alan(5));

            // Dikdörtgenin alanını hesapla
            Console.WriteLine("Dikdörtgenin alanı: " + hesaplayici.Alan(7, 4));

            // Dairenin alanını hesapla
            Console.WriteLine("Dairenin alanı: " + hesaplayici.Alan(3, true));
        }
    }
}
