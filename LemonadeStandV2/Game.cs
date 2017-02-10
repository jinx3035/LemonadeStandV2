using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandV2
{
    class Game
    {
        public Player player;
        public Day day;
        private string decision;

        //public Game()
        //{

        //}

        public void StartGame()
        {
            ShowGameMenu();
            player = new Player();
            player.GreetPlayer();
            day = new Day();
            day.CreateDay();
            for (int i = 0; i < 7; i++) { BuyOrPlay(); }
        }

        public void BuyOrPlay()
        {
            try { decision = player.AskDecision(); }
            catch
            {
                Console.WriteLine("Please choose 1, 2, 3 or 4");
                player.AskDecision();
            }
            switch (decision)
            {
                case "1":
                    Store goShopping = new Store();
                    goShopping.BuyItems(player);
                    BuyOrPlay();

                    break;
                case "2":
                    player.recipe.RecipeMenu(player);
                    //Console.WriteLine("set lemonade price and recipe");
                    //Console.ReadLine();

                    break;
                case "3":
                    //Run the days calculations

                    break;
                case "4":
                    Console.WriteLine("The game will be restarted");
                    Console.ReadKey();
                    StartGame();

                    break;
            }
        }

        public void ShowGameMenu()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Congratulations on choosing a lemonade stand to gain your riches. ");
            Console.WriteLine("Pay attention now. There are decisions to be made that will decide your success or failure.\n");
            Console.WriteLine("You must aquire supplies consisting of cups, lemons, sugar cubes, and ice.");
            Console.WriteLine("Then you must set a recipe and price for your lemonade.\n");
            Console.WriteLine("I have provided you my last $20 to help you establish an inventory so don't let me down.\n");
            Console.WriteLine("Pay attention to the weather because it will directly affect how many customers come out to buy your product.");
            Console.WriteLine("So adjust your price accordingly and pay attention to your inventory as some of it may have experation dates. \n");
        }

        //private void ReturnGameMenu()
        //{
        //    //structure menu to account for returning from the store.
        //}
          
    }
}
