using System;

namespace Vending
{
    public class VendingMachine
    {
        private int _totalValueInserted = 0;

        public string DisplayText { get; private set; }

        public void InsertCoin(Coin coin)
        {
            _totalValueInserted += new CoinAppraiser().Appraise(coin);
            DisplayText = $"{_totalValueInserted/100.0:C}";
        }


    }
}
