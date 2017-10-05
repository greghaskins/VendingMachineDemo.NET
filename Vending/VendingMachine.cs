using System;

namespace Vending
{
    public class VendingMachine
    {
        private int _totalValueInserted = 0;
        private readonly CoinAppraiser _coinAppraiser;

        public VendingMachine(CoinAppraiser coinAppraiser)
        {
            _coinAppraiser = coinAppraiser;
        }

        public string DisplayText { get; private set; }

        public void InsertCoin(Coin coin)
        {   
            _totalValueInserted += _coinAppraiser.Appraise(coin);
            DisplayText = $"{_totalValueInserted/100.0:C}";
        }


    }
}
