using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using Vending;

namespace VendingTests
{
    [TestFixture]
    public class VendingMachineTest
    {
        [Test]
        public void DisplaysTheValueOfAnInsertedCoin()
        {
            var machine = new VendingMachine(new FaceValueCoinAppraiser());

            machine.InsertCoin(Coin.Dime);

            Assert.AreEqual("$0.10", machine.DisplayText);
        }

        [Test]
        public void DisplaysTheValueOfTwoInsertedCoins()
        {
            var machine = new VendingMachine(new FaceValueCoinAppraiser());

            machine.InsertCoin(Coin.Quarter);
            machine.InsertCoin(Coin.Quarter);

            Assert.AreEqual("$0.50", machine.DisplayText);
        }
        [Test]
        public void DisplaysValuesGreaterThanOneDollar()
        {
            var machine = new VendingMachine(new FaceValueCoinAppraiser());

            machine.InsertCoin(Coin.Quarter);
            machine.InsertCoin(Coin.Quarter);
            machine.InsertCoin(Coin.Quarter);
            machine.InsertCoin(Coin.Quarter);
            machine.InsertCoin(Coin.Nickel);

            Assert.AreEqual("$1.05", machine.DisplayText);
        }
    }
}
