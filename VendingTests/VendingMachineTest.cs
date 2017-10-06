using System.Collections.Generic;
using Moq;
using NUnit.Framework;
using Vending;

namespace VendingTests
{
    [TestFixture]
    public class VendingMachineTest
    {
        private VendingMachine _vendingMachine;
        private IDisplay _mockDisplay = null;

        [SetUp]
        public void SetUp()
        {
            _vendingMachine = new VendingMachine(new FaceValueCoinAppraiser(), _mockDisplay);
        }

        [Test]
        public void StartsWithZeroCentsCredit()
        {
            Assert.AreEqual(0, _vendingMachine.CurrentTotalDeposited);
        }
        
        [Test]
        public void CreditGoesUpByTenCentsWhenYouInsertADime()
        {
            _vendingMachine.InsertCoin(Coin.Dime);
            Assert.AreEqual(10, _vendingMachine.CurrentTotalDeposited);
        }

        [Test]
        public void CreditAccumulatesAsYouInsertMoreCoins()
        {
            _vendingMachine.InsertCoin(Coin.Nickel);
            _vendingMachine.InsertCoin(Coin.Nickel);
            _vendingMachine.InsertCoin(Coin.Quarter);
            _vendingMachine.InsertCoin(Coin.Dime);
            Assert.AreEqual(45, _vendingMachine.CurrentTotalDeposited);
        }
    }
}
