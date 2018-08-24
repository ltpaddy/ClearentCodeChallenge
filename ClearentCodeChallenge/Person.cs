using System;
using System.Collections.Generic;
using System.Text;

namespace ClearentCodeChallenge
{
    public class Person : IInterestCalc
    {
        public List<Wallet> Wallets;

        public decimal CalculateInterest()
        {
            decimal totalInterest = 0m;
            foreach(var wallet in Wallets)
            {
                totalInterest += wallet.CalculateInterest();
            }
            return totalInterest;
        }
        
    }
}

