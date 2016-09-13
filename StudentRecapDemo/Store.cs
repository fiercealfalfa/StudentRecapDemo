using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecapDemo
{
    class Store
    {
        public void BuyThings(Player player, int numberOfThingsToBuy)
        {
            //Console.WriteLine(player.wallet.total); 
            bool transactionResult = player.wallet.SubtractFromWallet(numberOfThingsToBuy * 20);
            if (transactionResult)
            {
                Console.WriteLine("Thank you, Come Again");
                player.inventory.numberOfThings += numberOfThingsToBuy;
            }
            else
            {
                Console.WriteLine("Get a job hippie");
            }
            
        }
    }
}
