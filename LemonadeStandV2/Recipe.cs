using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandV2
{
    class Recipe
    {
        //Player player;

        public void RecipeMenu(Player player)
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Ok {0} it's time to set the recipe for your lemonade.", player.name);
            Console.WriteLine("----------------------------------------------------------\n");
            Console.WriteLine("");
            Console.ReadLine();

        }
    }
}
