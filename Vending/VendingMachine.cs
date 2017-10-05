namespace Vending
{
    public class VendingMachine
    {
        private int _totalValueInserted = 0;
        private readonly ICoinAppraiser _coinAppraiser;

        public VendingMachine(ICoinAppraiser coinAppraiser)
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
