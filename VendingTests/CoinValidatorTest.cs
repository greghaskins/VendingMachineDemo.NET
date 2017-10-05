using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework.Internal;
using NUnit.Framework;
using Vending;

namespace VendingTests
{
    [TestFixture]
    class CoinValidatorTest
    {
        [Test]
        public void ShouldAcceptADime()
        {
            var validator = new CoinValidator();

            var result = validator.Validate(Coin.Dime);

            Assert.AreEqual(true, result);
        }

        [Test]
        public void ShouldRejectAPenny()
        {
            var validator = new CoinValidator();

            var result = validator.Validate(Coin.Penny);

            Assert.AreEqual(false, result);
        }
    }
}
