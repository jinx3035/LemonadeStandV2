using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandV2
{
    class Lemon : Ingredients
    {
        private decimal lemonPrice = 15m;
        public decimal LemonPrice
        {
            get
            {
                return lemonPrice;
            }
        }
    }
}