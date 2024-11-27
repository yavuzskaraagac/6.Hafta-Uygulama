using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GPSKonumMesafesi
{
    struct GPSLocation
    {
        // Enlem ve boylam
        public double Latitude { get; set; }
        public double Longitude { get; set; }

        // Dünya yarıçapı (kilometre olarak)
        private const double EarthRadiusKm = 6371.0;

        // Yapıcı (constructor)
        public GPSLocation(double latitude, double longitude)
        {
            Latitude = latitude;
            Longitude = longitude;
        }

        // İki GPS konumu arasındaki mesafeyi hesaplayan metot
        public static double CalculateDistance(GPSLocation location1, GPSLocation location2)
        {
            // Dereceleri radyanlara çevir
            double lat1Rad = DegreesToRadians(location1.Latitude);
            double lon1Rad = DegreesToRadians(location1.Longitude);
            double lat2Rad = DegreesToRadians(location2.Latitude);
            double lon2Rad = DegreesToRadians(location2.Longitude);

            // Haversine formülünü uygula
            double deltaLat = lat2Rad - lat1Rad;
            double deltaLon = lon2Rad - lon1Rad;

            double a = Math.Pow(Math.Sin(deltaLat / 2), 2) +
                       Math.Cos(lat1Rad) * Math.Cos(lat2Rad) * Math.Pow(Math.Sin(deltaLon / 2), 2);
            double c = 2 * Math.Atan2(Math.Sqrt(a), Math.Sqrt(1 - a));

            // Mesafeyi hesapla
            return EarthRadiusKm * c;
        }

        // Dereceleri radyanlara çeviren yardımcı metot
        private static double DegreesToRadians(double degrees)
        {
            return degrees * Math.PI / 180.0;
        }

        // GPS konumunu yazdırmak için ToString metodu
        public override string ToString()
        {
            return $"Latitude: {Latitude}, Longitude: {Longitude}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // GPS konumları oluştur
            GPSLocation location1 = new GPSLocation(41.0082, 28.9784); // İstanbul
            GPSLocation location2 = new GPSLocation(39.9042, 116.4074); // Pekin

            // Konumları yazdır
            Console.WriteLine($"Konum 1: {location1}");
            Console.WriteLine($"Konum 2: {location2}");

            // İki konum arasındaki mesafeyi hesapla
            double distance = GPSLocation.CalculateDistance(location1, location2);

            // Mesafeyi yazdır
            Console.WriteLine($"İki konum arasındaki mesafe: {distance:F2} km");
            Console.ReadKey();
        }
    }
}
