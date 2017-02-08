using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandV2
{
    class Day
    {
        public Weather temperature;
        public Weather percipitation;
        public List<Customer> dailyCustomers;


        public Day()
            {
                temperature = new Weather();
                percipitation = new Weather();
                dailyCustomers = new List<Customer>();
            }

        public void CreateDay()
        {
            Weather weather = new Weather();
            weather.DisplayWeather();
            Customer population = new Customer();
            population.CustomerPopulation();
            population.CustomerType();
            population.DetermineBuyPercentage();
            population.BuyProbability(dailyCustomers);
        }
    }
}
