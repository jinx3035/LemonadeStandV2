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

        public void AddLemon(decimal buyLemon)
        {
            for (int i = 0; i < buyLemon; i++)
            {
                Lemon lemon = new Lemon();
                lemons.Add(lemon);
            }
        }

        public void AddSugarCube(decimal buySugarCube)
        {
            for (int i = 0; i < buySugarCube; i++)
            {
                SugarCube sugarCube = new SugarCube();
                sugarCubes.Add(sugarCube);
            }
        }

        public void AddIceCube(decimal buyIceCube)
        {
            for (int i = 0; i < buyIceCube; i++)
            {
                IceCube iceCube = new IceCube();
                iceCubes.Add(iceCube);
            }
        }
    }
}
