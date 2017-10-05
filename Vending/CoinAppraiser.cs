using System;

namespace Vending
{
    public class CoinAppraiser
    {
        public int Appraise(Coin coin)
        {
            switch (coin)
            {
                case Coin.Dime:
                    return 10;
                case Coin.Nickel:
                    return 5;
                default:
                    throw new ArgumentOutOfRangeException(nameof(coin), coin, null);
            }
        }
    }
}
