using System;

namespace ClearentCodeChallenge
{
    public abstract class Card : IInterestCalc
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

    public class Mastercard : Card
    {
        public Mastercard(decimal balance) : base(balance) { }

        public override float InterestRate
        {
            get { return 0.05f;  }
        }        
    }

    public class Visa : Card
    {
        public Visa(decimal balance) : base(balance) { }

        public override float InterestRate
        {
            get { return 0.1f; }
        }                
    }

    public class Discover : Card
    {
        public Discover(decimal balance) : base(balance) { }

        public override float InterestRate
        {
            get { return 0.01f; }
        }        
    }
}


