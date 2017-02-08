﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandV2
{
    class Player
    {
        public string name;
        public string choice;

        public Wallet money;

        public Player()
        {
            money = new Wallet();
            // ingredient = new Inventory();
        }

        public string SetPlayerName()
        {
            Console.WriteLine("Please enter your name so the IRS knows who to tax for this operation.");
            Console.WriteLine("");
            name = Console.ReadLine();
            return name;
        }

        public void GreetPlayer()
        {
            Console.WriteLine("");
            Console.WriteLine("Hello " + name + " and good luck running your Lemonade Stand.");
            Console.WriteLine("Remember to keep in mind that the weather affects customer turn out so make sure not to order too much.");
            Console.WriteLine("");
            name = Console.ReadLine();
        }

        public string AskDecision()
        {
            AskDecisionMenu();
            if (!(choice == "1" || choice == "2" || choice == "3" || choice == "4"))
            {
                return FailedAskDecisionResponse();
            }
            else
            {
                return choice;
            }
        }

        internal string AskDecisionMenu()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Ok " +name+ ". Now its time to actually make things happen.");
            Console.WriteLine("Please choose from the menu below. \n");
            Console.WriteLine("1 Purchase supplies to stock up for the day.");
            Console.WriteLine("2 Set your lemonade recipe and price.");
            Console.WriteLine("3 Go to work.");
            Console.WriteLine("4 Restart");
            Console.WriteLine("");
            choice = Console.ReadLine();
            return choice;
        }

        internal string FailedAskDecisionResponse()
        {
            Console.Clear();
            Console.WriteLine("");
            Console.WriteLine("Perdaps that was an error in typing "+name+ ".\n");
            Console.WriteLine("You must choose between the numbers 1, 2, 3 or 4 to continue. \n\n ");
            Console.WriteLine("Please choose from the menu below. \n");
            Console.WriteLine("1 Purchase supplies to stock up for the day.");
            Console.WriteLine("2 Set your lemonade recipe and price.");
            Console.WriteLine("3 Go to work.");
            Console.WriteLine("4 Restart");
            Console.WriteLine("");
            choice = Console.ReadLine();
            return choice;
        }
    }
}
