using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarmasikSayiHesaplama
{
    struct ComplexNumber
    {
        // Karmaşık sayının gerçek ve hayali kısmı
        public double Real { get; set; }
        public double Imaginary { get; set; }

        // Yapıcı (constructor)
        public ComplexNumber(double real, double imaginary)
        {
            Real = real;
            Imaginary = imaginary;
        }

        // Toplama işlemi
        public static ComplexNumber Add(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real + c2.Real, c1.Imaginary + c2.Imaginary);
        }

        // Çıkarma işlemi
        public static ComplexNumber Subtract(ComplexNumber c1, ComplexNumber c2)
        {
            return new ComplexNumber(c1.Real - c2.Real, c1.Imaginary - c2.Imaginary);
        }

        // Karmaşık sayıyı "a + bi" formatında döndüren metot
        public override string ToString()
        {
            string sign = Imaginary >= 0 ? "+" : "-";
            return $"{Real} {sign} {Math.Abs(Imaginary)}i";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Karmaşık sayılar oluştur
            ComplexNumber c1 = new ComplexNumber(3, 4);
            ComplexNumber c2 = new ComplexNumber(1, -2);

            // Toplama ve çıkarma işlemleri
            ComplexNumber sum = ComplexNumber.Add(c1, c2);
            ComplexNumber difference = ComplexNumber.Subtract(c1, c2);

            // Sonuçları yazdır
            Console.WriteLine($"Karmaşık Sayı 1: {c1}");
            Console.WriteLine($"Karmaşık Sayı 2: {c2}");
            Console.WriteLine($"Toplama: {sum}");
            Console.WriteLine($"Çıkarma: {difference}");
            Console.ReadKey();
        }
    }
}
