using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Vending;

namespace VendingTests
{
    [TestFixture]
    class CoinAppraiserTest
    {
        [Test]
        public void ANickelIsWorthFiveCents()
        {
            Assert.AreEqual(5, new CoinAppraiser().Appraise(Coin.Nickel));
        }

        [Test]
        public void ADimeIsWorthTenCents()
        {
            Assert.AreEqual(10, new CoinAppraiser().Appraise(Coin.Dime));
        }



    }
}
