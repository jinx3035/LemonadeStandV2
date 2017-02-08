using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStandV2
{
    class Wallet
    {
        private decimal walletBalance = 20.00m;

        public Wallet()
        {

        }

        public decimal WalletBalance
        {
            get
            {
                return walletBalance;
            }
            set
            {
                walletBalance = value;
            }
        }

 
        

        public void ShowWalletBalance()
        {
            Console.WriteLine(walletBalance);
        }

        public bool CheckBalance(decimal amount)
        {
            if (amount <= walletBalance)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
