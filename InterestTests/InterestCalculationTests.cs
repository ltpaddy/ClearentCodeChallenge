using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClearentCodeChallenge;
using System.Collections.Generic;

namespace InterestTests
{
    [TestClass]
    public class InterestCalculationTests
    {
        Person person;
        Wallet wallet;

        [TestInitialize]
        public void Setup()
        {
            person = new Person();
            wallet = new Wallet();
        }

        [TestMethod]
        public void TestCase1()
        {
            var mc = new Mastercard(100m);
            var visa = new Visa(100m);
            var disc = new Discover(100m);

            wallet.Cards = new List<Card> { mc, visa, disc };
            person.Wallets = new List<Wallet> { wallet };

            Assert.AreEqual(16, person.CalculateInterest());

            Assert.AreEqual(10, visa.CalculateInterest());
            Assert.AreEqual(5, mc.CalculateInterest());
            Assert.AreEqual(1, disc.CalculateInterest());
        }
    }
}
