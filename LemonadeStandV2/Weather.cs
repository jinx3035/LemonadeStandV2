using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandV2
{
    class Weather
    {
        public int percipitation;
        public int temperature;
        public void CreateWeather()
        {
            Random rand = new Random();
            temperature = rand.Next(15, 105);
            DisplayForcast(temperature, percipitation);
        }

        public int ChanceOfRain()
        {
            Random rand = new Random();
            int rain = rand.Next(0, 80);
            return rain;
        }

        public void DisplayForcast(int temperature, int percipitation)
        {
            Console.Clear();
            ChanceOfRain();
            Console.WriteLine("Today's forecast is a high of " + temperature + " degrees outside " + percipitation);
            Console.WriteLine("");
            Console.WriteLine("Pay attention to the weather because it will directly affect how many customers come out to buy your product.");
            Console.WriteLine("So adjust your price accordingly and pay attention to your inventory as some of it may have experation dates. \n");
            Console.ReadLine();
        }
    }
}
