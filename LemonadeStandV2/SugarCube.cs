using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandV2
{
    class SugarCube : Ingredients
    {
        private decimal sugarCubePrice = 20m;
        public decimal SugarCubePrice
        {
            get
            {
                return sugarCubePrice;
            }
        }
    }
}
