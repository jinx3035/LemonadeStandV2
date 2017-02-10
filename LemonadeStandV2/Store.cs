using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandV2
{
    class Store
    {
        decimal cupPrice = .10m;
        decimal lemonPrice = .15m;
        decimal sugarCubePrice = .10m;
        decimal iceCubePrice = .05m;
        private string choice;
        decimal buyCupCost;


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
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("You currently have ${0} in your wallet.\n", player.money.WalletBalance);
                    Console.WriteLine("Cups are $.10 a piece. How many cups would you like to buy?");
                    decimal buyCups = Convert.ToDecimal(Console.ReadLine());
                    player.ingredient.AddCup(buyCups);
                    decimal cupCost = Decimal.Multiply(buyCups, cupPrice);
                    buyCupCost = cupCost;                    
                    if (player.money.CheckBalance(cupCost) == true)
                    {
                        ShowPurchasCost(player);
                        player.money.WalletBalance = Math.Round((player.money.WalletBalance - (cupCost)), 2);
                        Console.WriteLine("");
                        Console.WriteLine("You just purchased {0} cups and have {1} in your inventory.", buyCups, player.ingredient.cups.Count);
                        Console.WriteLine("You have ${0} left in your wallet.", player.money.WalletBalance);
                        Console.WriteLine("");
                        Console.WriteLine("Would like to purchase anything else ");
                        BuyMoreMenu();
                        BuyMoreChoice(player);
                        string buyMore = Console.ReadLine();
                    }
                    else
                    {
                        InsufficientFunds("cups", player);
                        BuyItems(player);
                    }
                    Console.WriteLine("");
                    break;
                case 5:
                    Console.WriteLine(" I said go to work!");
                    break;
                default:
                    BuyItems(player);
                    break;
            }
        }

        private void BuyMoreChoice(Player player)
        {
            if (!(choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5"))
            {
                Console.WriteLine("An invalid choice was entered. You will now be returned to the main store.");
                 BuyItems(player);               
            }
            else
            {
                Console.ReadLine();
            }         
        }

        private void InsufficientFunds(string item, Player player)
        {
            Console.WriteLine("Sorry, you do not have enough money to buy that many " + item);
            Console.ReadKey();           
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
            Console.WriteLine("Enter the number coorsponding to an ingredient you wish to buy?");
            Console.WriteLine("Or enter 5 to begin your day");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\t1: cups");
            Console.WriteLine("\t2: lemons");
            Console.WriteLine("\t3: sugar cubes");
            Console.WriteLine("\t4: ice cubes\n");
            Console.WriteLine("\t5: Go to work");
            Console.WriteLine("");
            choice = Console.ReadLine();           
            if (!(choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5"))
            {
                Console.WriteLine("You entered an invalid comand.\n\t Please type a number between 1 and 5.");
                return BuyItemMenu(player);
            }
            else
            {
                return choice;
            }
        }

        private string BuyMoreMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("\t1: cups");
            Console.WriteLine("\t2: lemons");
            Console.WriteLine("\t3: sugar cubes");
            Console.WriteLine("\t4: ice cubes\n");
            Console.WriteLine("\t5: Go to work");
            Console.WriteLine("");
            choice = Console.ReadLine();
            if (!(choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5"))
            {
                Console.WriteLine("You entered an invalid comand.\n\t Please type a number between 1 and 5.");
                return BuyMoreMenu();
            }
            else
            {
                return choice;
            }
        }

        public void ShowPurchasCost(Player player)
        {
            Console.WriteLine("This will cost you ${0} out of the ${1} in your wallet.", buyCupCost, player.money.WalletBalance);
            Console.WriteLine("Do you wish to complete this purchase?\n\t y or n");
            choice = Console.ReadLine();
            if (!(choice == "y" || choice == "n"))
                {
                Console.WriteLine("You entered an invalid comand.\n\t Please type y or n.");
                ShowPurchasCost(player);
                }
            else
            {
                this.choice = Console.ReadLine();
            }
        }
    }
}
