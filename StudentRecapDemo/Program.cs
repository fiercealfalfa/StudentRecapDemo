using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecapDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //    int foo = 3;
            //    int bar = 7;
            //    MathExample mathExample = new MathExample();
            //    int addedNumbers = mathExample.AddTwoNumbers(foo, bar);
            //    Console.WriteLine(addedNumbers);
            //    Console.WriteLine(mathExample.AddTwoNumbers(addedNumbers, addedNumbers));

            //    UserInput userinput = new UserInput();
            //    //Console.WriteLine("Andrew is great {0}", userinput.GetUserNumber());

            //    Console.WriteLine(mathExample.AddTwoNumbers(userinput.GetUserNumber(), userinput.GetUserNumber()));
            //    Console.ReadKey();
            Player playerOne = new Player("Andrew");
            Player playerTwo = new Player("Mike");
            //Console.WriteLine("p1" + playerOne.name);
            //Console.WriteLine("p2" + playerTwo.name);
            //playerOne.name = "Adam";
            //Console.WriteLine("p1" + playerOne.name);
            //Console.WriteLine("p2" + playerTwo.name);
            Console.WriteLine("{0:0.00}", playerOne.wallet.total);
       
            Console.WriteLine(playerOne.inventory.numberOfThings);
            Store store = new Store();
            store.BuyThings(playerOne, 5);
            Console.WriteLine("{0:0.00}", playerOne.wallet.total);

            Console.WriteLine(playerOne.inventory.numberOfThings);
            Console.WriteLine(playerTwo.wallet.total);
            Console.WriteLine(playerTwo.inventory.numberOfThings);
            store.BuyThings(playerTwo, 10000000);
            Console.WriteLine(playerTwo.wallet.total);
            Console.WriteLine(playerTwo.inventory.numberOfThings);
            Console.ReadKey();

        }
    }
}
