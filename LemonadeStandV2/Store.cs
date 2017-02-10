using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandV2
{
    class Store
    {
        string choice;
        decimal cupPrice = .10m;
        decimal lemonPrice = .15m;
        decimal sugarCubePrice = .10m;
        decimal iceCubePrice = .05m;
        decimal buyCupCost;
        decimal buyLemonCost;
        decimal buySugarCubeCost;
        decimal buyIceCubeCost;
        int buy;
        //public Store()
        //{

        //}
        
        public void BuyItems(Player player)
        {
            try { buy = int.Parse(BuyItemMenu(player)); }
            catch
            {
                Console.WriteLine("Please choose 1, 2, 3 or 4");
                BuyItemMenu(player);
            }
            switch (buy)
            {
                case 1:
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
                        ShowBuyCupCost(player);
                        player.money.WalletBalance = Math.Round((player.money.WalletBalance - (cupCost)), 2);
                        Console.WriteLine("");
                        Console.WriteLine("You just purchased {0} cups and have {1} in your inventory.", buyCups, player.ingredient.cups.Count);
                        Console.WriteLine("You have ${0} left in your wallet.", player.money.WalletBalance);
                        Console.WriteLine("");
                        Console.WriteLine("Would like to purchase anything else ");
                        BuyMoreMenu();
                        try { BuyMoreChoice(player); }
                        catch
                        {
                            Console.WriteLine("Please pick a valid number.");
                            BuyMoreChoice(player);
                        }
                        string buyMore = Console.ReadLine();
                    }
                    else
                    {
                        InsufficientFunds("cups", player);
                        BuyItems(player);
                    }
                    Console.WriteLine("");
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("You currently have ${0} in your wallet.\n", player.money.WalletBalance);
                    Console.WriteLine("Cups are $.10 a piece. How many cups would you like to buy?");
                    decimal buyLemons = Convert.ToDecimal(Console.ReadLine());
                    player.ingredient.AddLemon(buyLemons);
                    decimal lemonCost = Decimal.Multiply(buyLemons, lemonPrice);
                    buyLemonCost = lemonCost;
                    if (player.money.CheckBalance(lemonCost) == true)
                    {
                        ShowBuyLemonCost(player);
                        player.money.WalletBalance = Math.Round((player.money.WalletBalance - (lemonCost)), 2);
                        Console.WriteLine("");
                        Console.WriteLine("You just purchased {0} cups and have {1} in your inventory.", buyLemons, player.ingredient.lemons.Count);
                        Console.WriteLine("You have ${0} left in your wallet.", player.money.WalletBalance);
                        Console.WriteLine("");
                        Console.WriteLine("Would like to purchase anything else ");
                        BuyMoreMenu();
                        try { BuyMoreChoice(player); }
                        catch
                        {
                            Console.WriteLine("Please pick a valid number.");
                            BuyMoreChoice(player);
                        }
                        string buyMore = Console.ReadLine();
                    }
                    else
                    {
                        InsufficientFunds("lemons", player);
                        BuyItems(player);
                    }
                    Console.WriteLine("");
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("You currently have ${0} in your wallet.\n", player.money.WalletBalance);
                    Console.WriteLine("Cups are $.10 a piece. How many cups would you like to buy?");
                    decimal buySugarCubes = Convert.ToDecimal(Console.ReadLine());
                    player.ingredient.AddCup(buySugarCubes);
                    decimal sugarCubeCost = Decimal.Multiply(buySugarCubes, sugarCubePrice);
                    buySugarCubeCost = sugarCubeCost;
                    if (player.money.CheckBalance(sugarCubeCost) == true)
                    {
                        ShowBuySugarCubeCost(player);
                        player.money.WalletBalance = Math.Round((player.money.WalletBalance - (sugarCubeCost)), 2);
                        Console.WriteLine("");
                        Console.WriteLine("You just purchased {0} cups and have {1} in your inventory.", buySugarCubes, player.ingredient.sugarCubes.Count);
                        Console.WriteLine("You have ${0} left in your wallet.", player.money.WalletBalance);
                        Console.WriteLine("");
                        Console.WriteLine("Would like to purchase anything else ");
                        BuyMoreMenu();
                        try { BuyMoreChoice(player); }
                        catch
                        {
                            Console.WriteLine("Please pick a valid number.");
                            BuyMoreChoice(player);
                        }
                        string buyMore = Console.ReadLine();
                    }
                    else
                    {
                        InsufficientFunds("sugarCubes", player);
                        BuyItems(player);
                    }
                    Console.WriteLine("");
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("");
                    Console.WriteLine("You currently have ${0} in your wallet.\n", player.money.WalletBalance);
                    Console.WriteLine("Cups are $.10 a piece. How many cups would you like to buy?");
                    decimal buyIceCubes = Convert.ToDecimal(Console.ReadLine());
                    player.ingredient.AddCup(buyIceCubes);
                    decimal iceCubeCost = Decimal.Multiply(buyIceCubes, iceCubePrice);
                    buyIceCubeCost = iceCubeCost;
                    if (player.money.CheckBalance(iceCubeCost) == true)
                    {
                        ShowBuyIceCubeCost(player);
                        player.money.WalletBalance = Math.Round((player.money.WalletBalance - (iceCubeCost)), 2);
                        Console.WriteLine("");
                        Console.WriteLine("You just purchased {0} cups and have {1} in your inventory.", buyIceCubes, player.ingredient.iceCubes.Count);
                        Console.WriteLine("You have ${0} left in your wallet.", player.money.WalletBalance);
                        Console.WriteLine("");
                        Console.WriteLine("Would like to purchase anything else ");
                        BuyMoreMenu();
                        try { BuyMoreChoice(player); }
                        catch
                        {
                            Console.WriteLine("Please pick a valid number.");
                            BuyMoreChoice(player);
                        }
                        string buyMore = Console.ReadLine();
                    }
                    else
                    {
                        InsufficientFunds("iceCubes", player);
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
            if (!(choice == "1" || choice == "2" || choice == "3" || choice == "4" || choice == "5")) {throw new KeyNotFoundException();}
            else { Console.ReadLine();}         
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
                throw new KeyNotFoundException();
            }
            else
            {
                return choice;
            }
        }

        private void BuyMoreMenu()
        {
            Console.WriteLine("");
            Console.WriteLine("\t1: cups");
            Console.WriteLine("\t2: lemons");
            Console.WriteLine("\t3: sugar cubes");
            Console.WriteLine("\t4: ice cubes\n");
            Console.WriteLine("\t5: Go to work");
            Console.WriteLine("");
            choice = Console.ReadLine();
        }

        public void ShowBuyCupCost(Player player)
        {
            Console.WriteLine("This will cost you ${0} out of the ${1} in your wallet.", buyCupCost, player.money.WalletBalance);
            Console.WriteLine("Do you wish to complete this purchase?\n\t y or n");
            choice = Console.ReadLine();
            if (!(choice == "y" || choice == "n"))
                {
                Console.WriteLine("You entered an invalid comand.\n\t Please type y or n.");
                ShowBuyCupCost(player);
                }
            else
            {
                this.choice = Console.ReadLine();
            }
        }
        public void ShowBuyLemonCost(Player player)
        {
            Console.WriteLine("This will cost you ${0} out of the ${1} in your wallet.", buyLemonCost, player.money.WalletBalance);
            Console.WriteLine("Do you wish to complete this purchase?\n\t y or n");
            choice = Console.ReadLine();
            if (!(choice == "y" || choice == "n"))
                {
                Console.WriteLine("You entered an invalid comand.\n\t Please type y or n.");
                ShowBuyLemonCost(player);
                }
            else
            {
                this.choice = Console.ReadLine();
            }
        }
        public void ShowBuySugarCubeCost(Player player)
        {
            Console.WriteLine("This will cost you ${0} out of the ${1} in your wallet.", buySugarCubeCost, player.money.WalletBalance);
            Console.WriteLine("Do you wish to complete this purchase?\n\t y or n");
            choice = Console.ReadLine();
            if (!(choice == "y" || choice == "n"))
            {
                Console.WriteLine("You entered an invalid comand.\n\t Please type y or n.");
                ShowBuySugarCubeCost(player);
            }
            else
            {
                this.choice = Console.ReadLine();
            }
        }
        public void ShowBuyIceCubeCost(Player player)
        {
            Console.WriteLine("This will cost you ${0} out of the ${1} in your wallet.", buyIceCubeCost, player.money.WalletBalance);
            Console.WriteLine("Do you wish to complete this purchase?\n\t y or n");
            choice = Console.ReadLine();
            if (!(choice == "y" || choice == "n"))
            {
                Console.WriteLine("You entered an invalid comand.\n\t Please type y or n.");
                ShowBuyIceCubeCost(player);
            }
            else
            {
                this.choice = Console.ReadLine();
            }
        }

    }
}
