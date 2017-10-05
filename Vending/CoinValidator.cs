namespace Vending
{
    public class CoinValidator
    {
        public bool Validate(Coin coin)
        {
            return coin != Coin.Penny;
        }
    }
}