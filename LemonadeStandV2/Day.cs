using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandV2
{
    class Day
    {
        
        public void CreateDay()
        {
            Weather weather = new Weather();
            weather.CreateWeather();
            weather.ChanceOfRain();
            weather.DisplayForcast(temperature, percipitation);
            //Customer population = new Customer();
            //population.CustomerPopulation();
            //population.CustomerType();
            //population.DetermineBuyPercentage();
            //population.BuyProbability(dailyCustomers);
        }
    }
}
