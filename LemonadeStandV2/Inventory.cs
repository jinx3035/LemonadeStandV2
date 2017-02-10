using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandV2
{
    class Inventory
    {
        public List<Cup> cups = new List<Cup>();
        public List<Lemon> lemons = new List<Lemon>();
        public List<SugarCube> sugarCubes = new List<SugarCube>();
        public List<IceCube> iceCubes = new List<IceCube>();
       


        public void AddCup(decimal buyCup)
        {
            for (int i = 0; i < buyCup; i++)
            {
                Cup cup = new Cup();
                cups.Add(cup);
            }
        }
    }
}
