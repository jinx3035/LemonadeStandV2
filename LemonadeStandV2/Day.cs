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
        public decimal numberOfCustomers;
        public decimal buyProbability;
        public int type;


        public Day()
            {
                temperature = new Weather();
                percipitation = new Weather();
                dailyCustomers = new List<Customer>();
            }

        public void MakeCustomers()
        {
            //next line is a problem.
            decimal totalBuyers = CustomerPopulation();
            for (int i = 0; i < totalBuyers; i++)
            {
                Customer customer = new Customer();
                dailyCustomers.Add(customer);
            }
        }

        public void CreateDay()
        {
            Weather weather = new Weather();
            weather.DisplayWeather();
            Customer population = new Customer();
            CustomerPopulation();
            CustomerType();
            DetermineBuyPercentage();
            BuyProbability();
        }
        public decimal CustomerPopulation()
        {
            Random rand = new Random();
            decimal temp = 0;
            if (temp >= 30 && temp <= 70) { numberOfCustomers = rand.Next(126, 200); }
            else if (temp > 70 && temp < 90) { numberOfCustomers = rand.Next(201, 300); }
            else { numberOfCustomers = rand.Next(50, 125); }
            return numberOfCustomers;
        }

        public void BuyProbability()
        {
            // Need different customer types
            if (numberOfCustomers >= 126 && numberOfCustomers <= 200) { CustomerType(); }
            else if (numberOfCustomers >= 201 && numberOfCustomers <= 300)
            {
                CustomerType();
            }
            else
            {
                CustomerType();
            }         
        }

        public void CustomerType()
        {
            Random rand = new Random();
            type = rand.Next(1, 6);
            switch (type)
            {
                case 1:
                    Random randBuy1 = new Random();
                    buyProbability = rand.Next(80, 100);
                    break;
                case 2:
                    Random randBuy2 = new Random();
                    buyProbability = rand.Next(60, 85);
                    break;
                case 3:
                    Random randBuy3 = new Random();
                    buyProbability = rand.Next(40, 65);
                    break;
                case 4:
                    Random randBuy4 = new Random();
                    buyProbability = rand.Next(20, 45);
                    break;
                case 5:
                    Random randBuy5 = new Random();
                    buyProbability = rand.Next(15, 30);
                    break;
            }
        }

        public decimal DetermineBuyPercentage()
        {
            decimal multipliedResult = numberOfCustomers * (buyProbability / 100);
            decimal roundedResult = Math.Round(multipliedResult, 0);
            decimal endResult = Decimal.ToInt32(roundedResult);
            return endResult;
        }
    }
}
