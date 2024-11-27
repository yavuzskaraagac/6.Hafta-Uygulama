using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtoparkSistemi
{
    class MultiLevelParkingLot
    {
        // Otopark katlarını ve park yerlerini temsil eden çok boyutlu dizi
        private string[,] parkingSpots;

        // Yapıcı (constructor)
        public MultiLevelParkingLot(int levels, int spotsPerLevel)
        {
            // Kat ve park yeri sayısına göre dizi oluştur
            parkingSpots = new string[levels, spotsPerLevel];

            // Başlangıçta tüm park yerlerini "Empty" olarak ayarla
            for (int i = 0; i < levels; i++)
            {
                for (int j = 0; j < spotsPerLevel; j++)
                {
                    parkingSpots[i, j] = "Empty";
                }
            }
        }

        // Çift boyutlu indeksleyici
        public string this[int level, int spot]
        {
            get
            {
                if (IsValidPosition(level, spot))
                {
                    return parkingSpots[level, spot];
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Geçersiz kat veya park yeri!");
                }
            }
            set
            {
                if (IsValidPosition(level, spot))
                {
                    parkingSpots[level, spot] = value;
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Geçersiz kat veya park yeri!");
                }
            }
        }

        // Geçerli bir pozisyon olup olmadığını kontrol eden metot
        private bool IsValidPosition(int level, int spot)
        {
            return level >= 0 && level < parkingSpots.GetLength(0) &&
                   spot >= 0 && spot < parkingSpots.GetLength(1);
        }

        // Otoparkın durumunu yazdıran yardımcı metot
        public void PrintParkingLot()
        {
            for (int i = 0; i < parkingSpots.GetLength(0); i++)
            {
                Console.Write($"Kat {i + 1}: ");
                for (int j = 0; j < parkingSpots.GetLength(1); j++)
                {
                    Console.Write($"[{parkingSpots[i, j]}] ");
                }
                Console.WriteLine();
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Otopark oluştur (3 kat, her katta 5 park yeri)
            MultiLevelParkingLot parkingLot = new MultiLevelParkingLot(3, 5);

            // Araçlar park et
            parkingLot[0, 0] = "23GFB123"; // Kat 1, Park Yeri 1
            parkingLot[1, 2] = "01ADN123"; // Kat 2, Park Yeri 3
            parkingLot[2, 4] = "06ANK123"; // Kat 3, Park Yeri 5

            // Otopark durumunu yazdır
            parkingLot.PrintParkingLot();

            // Belirli bir park yerinin durumunu kontrol et
            Console.WriteLine("Kat 1, Park Yeri 1: " + parkingLot[0, 0]); 
            Console.WriteLine("Kat 2, Park Yeri 4: " + parkingLot[1, 3]); 

            try
            {
                // Geçersiz bir pozisyona erişmeye çalış
                Console.WriteLine(parkingLot[3, 1]);
            }
            catch (ArgumentOutOfRangeException e)
            {
                Console.WriteLine(e.Message);
                Console.ReadKey();
            }
        }
    }
}
