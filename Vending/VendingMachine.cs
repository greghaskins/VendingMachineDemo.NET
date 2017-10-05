namespace Vending
{
    public class VendingMachine
    {
        public void InsertCoin(Coin coin)
        {
            var value = new CoinAppraiser().Appraise(coin);
            DisplayText = "$0." + value;
        }

        public string DisplayText { get; private set; }
    }
}
