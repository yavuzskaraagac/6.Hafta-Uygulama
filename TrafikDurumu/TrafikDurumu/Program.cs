using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafikDurumu
{
    enum TrafficLight
    {
        Red,
        Yellow,
        Green
    }

    class TrafficLightController
    {
        public static string GetAction(TrafficLight light)
        {
            switch (light)
            {
                case TrafficLight.Red:
                    return "Dur!";
                case TrafficLight.Yellow:
                    return "Hazırlan!";
                case TrafficLight.Green:
                    return "Geç!";
                default:
                    throw new ArgumentOutOfRangeException(nameof(light), "Geçersiz trafik ışığı durumu.");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            TrafficLight currentLight = TrafficLight.Yellow;
            Console.WriteLine($"Trafik ışığı durumu: {currentLight}");
            Console.WriteLine($"Yapılacak işlem: {TrafficLightController.GetAction(currentLight)}");
            Console.ReadKey();
        }
    }
}
