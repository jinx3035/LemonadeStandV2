using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandV2
{
    class Store
    {

        public Store()
        {

        }
        
        public void BuyItems(Player player)
        {
            int buy = int.Parse(BuyItemMenu(player));
            switch (buy)
            {
                case 1:

                    break;
                case 2:

                    break;
                case 3:

                    break;
                case 4:

                    break;


            }
        }


        private string BuyItemMenu(Player player)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("WELCOME TO THE STORE");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Let's buy some supplies...");
            Console.WriteLine("");
            Console.WriteLine("You have ${0} in cash.", player.money.WalletBalance);
            Console.WriteLine("");
            Console.WriteLine("What would you like to buy?");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("1: cups");
            Console.WriteLine("2: lemons");
            Console.WriteLine("3: sugar cubes");
            Console.WriteLine("4: ice cubes");
            string menu = Console.ReadLine();
            return menu;
        }
    }
}
