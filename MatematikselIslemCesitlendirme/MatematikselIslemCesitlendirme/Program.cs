using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatematikselIslemCesitlendirme
{
    class Toplayici
    {
        public int Topla(int a, int b)
        {
            return a + b;
        }

        public int Topla(int a, int b, int c)
        {
            return a + b + c;
        }
        public int Topla(int[] sayilar)
        {
            int toplam = 0;
            foreach (int sayi in sayilar)
            {
                toplam += sayi;
            }
            return toplam;
        }
    }
    class Program
    {
        static void Main()
        {
            Toplayici toplayici = new Toplayici();

            Console.WriteLine("İki tam sayının toplamı: " + toplayici.Topla(23, 7));

            Console.WriteLine("Üç tam sayının toplamı: " + toplayici.Topla(5, 10, 15));

            int[] dizi = { 1, 2, 3, 4, 5 };

            Console.WriteLine("Dizi elemanlarının toplamı: " + toplayici.Topla(dizi));
            Console.ReadLine();
        }
        
    }
    
}
