using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandV2
{
    class IceCube: Ingredients
    {
        private decimal iceCubePrice = 20m;
        public decimal IceCubePrice
        {
            get
            {
                return iceCubePrice;
            }
        }
    }
}
