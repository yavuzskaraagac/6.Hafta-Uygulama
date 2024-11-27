using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HavaDurumuTahmini
{
    enum WeatherCondition
    {
        Sunny,
        Rainy,
        Cloudy,
        Stormy
    }

    class WeatherAdvisor
    {
        public static string GetAdvice(WeatherCondition condition)
        {
            switch (condition)
            {
                case WeatherCondition.Sunny:
                    return "Hava güneşli, dışarıda vakit geçirin!";
                case WeatherCondition.Rainy:
                    return "Yağmurlu hava, yanınıza şemsiye alın.";
                case WeatherCondition.Cloudy:
                    return "Bulutlu hava, hafif serin olabilir.";
                case WeatherCondition.Stormy:
                    return "Fırtınalı hava, içeride kalmanız önerilir!";
                default:
                    throw new ArgumentOutOfRangeException(nameof(condition), "Geçersiz hava durumu.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            WeatherCondition today = WeatherCondition.Sunny;
            Console.WriteLine($"Bugünkü hava durumu: {today}");
            Console.WriteLine($"Tavsiye: {WeatherAdvisor.GetAdvice(today)}");
            Console.ReadKey();
        }
    }
}
