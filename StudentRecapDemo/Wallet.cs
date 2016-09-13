namespace StudentRecapDemo
{
    public class Wallet
    {
        public double total;

        public Wallet()
        {
            total = 500.00;
        }
        public bool SubtractFromWallet(double amountToSubtract)
        {
            if (total - amountToSubtract >= 0)
            {
                total -= amountToSubtract;
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}