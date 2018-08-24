using System;
using System.Collections.Generic;
using System.Text;

namespace ClearentCodeChallenge
{
    public class Wallet : IInterestCalc
    {
        public List<Card> Cards;

        public decimal CalculateInterest()
        {
            decimal totalInterest = 0m;
            foreach(var card in Cards)
            {
                totalInterest += card.CalculateInterest();
            }
            return totalInterest;
        }
    }
}
