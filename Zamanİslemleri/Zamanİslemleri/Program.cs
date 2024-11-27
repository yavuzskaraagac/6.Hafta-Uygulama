using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Zamanİslemleri
{
    struct Time
    {
        // Saat ve dakika özellikleri
        private int hour;
        private int minute;

        public int Hour
        {
            get => hour;
            set => hour = (value >= 0 && value < 24) ? value : 0; // Geçersizse 0
        }

        public int Minute
        {
            get => minute;
            set => minute = (value >= 0 && value < 60) ? value : 0; // Geçersizse 0
        }

        // Yapıcı (constructor)
        public Time(int hour, int minute)
        {
            this.hour = (hour >= 0 && hour < 24) ? hour : 0;
            this.minute = (minute >= 0 && minute < 60) ? minute : 0;
        }

        // Toplam dakika değerini döndüren metot
        public int TotalMinutes()
        {
            return hour * 60 + minute;
        }

        // İki zaman arasındaki farkı hesaplayan metot
        public static int DifferenceInMinutes(Time t1, Time t2)
        {
            return Math.Abs(t1.TotalMinutes() - t2.TotalMinutes());
        }

        // Zaman bilgisini güzel bir formatta yazdırmak için ToString metodu
        public override string ToString()
        {
            return $"{hour:D2}:{minute:D2}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Zaman nesneleri oluştur
            Time time1 = new Time(10, 30);
            Time time2 = new Time(14, 45);
            Time invalidTime = new Time(25, 70); // Geçersiz zaman

            // Zamanları yazdır
            Console.WriteLine($"Time 1: {time1}");
            Console.WriteLine($"Time 2: {time2}");
            Console.WriteLine($"Invalid Time: {invalidTime}");

            // Toplam dakika değerlerini yazdır
            Console.WriteLine($"Time 1 toplam dakika: {time1.TotalMinutes()}");
            Console.WriteLine($"Time 2 toplam dakika: {time2.TotalMinutes()}");

            // Zaman farkını hesapla
            Console.WriteLine($"Time 1 ve Time 2 arasındaki fark: {Time.DifferenceInMinutes(time1, time2)} dakika");
            Console.ReadKey();
        }
    }
}
