﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandV2
{
    class Lemon: Ingredients
    {
        public override void IngredientName()
        {
            Console.WriteLine("cup");
        }
    }
}
