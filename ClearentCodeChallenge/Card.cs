using System;

namespace ClearentCodeChallenge
{
    public class Card : IInterestCalc
    {
        public virtual float InterestRate {  get { return 0; } }

        private decimal balance;

        public Card(decimal balance)
        {
            this.balance = balance;
        }

        public decimal CalculateInterest()
        {
            return ((decimal)InterestRate) * balance;
        }
    }
}


