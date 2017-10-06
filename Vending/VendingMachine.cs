namespace Vending
{
    public class VendingMachine
    {
        public int CurrentTotalDeposited { get; private set; } = 0;
        private readonly IAppraiser<Coin> _coinAppraiser;

        public VendingMachine(IAppraiser<Coin> coinAppraiser)
        {
            _coinAppraiser = coinAppraiser;
        }

        public void InsertCoin(Coin coin)
        {   
            CurrentTotalDeposited += _coinAppraiser.Appraise(coin);
        }


    }
}
