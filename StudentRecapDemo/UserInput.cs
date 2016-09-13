using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentRecapDemo
{
    class UserInput
    {

        public int GetUserNumber()
        {
            Console.WriteLine("Please Enter a whole number");
            string input = Console.ReadLine();
           
            switch (input)
            {
                case "4":
                case "2":
                case "5":
                    Console.WriteLine("You entered five");
                    break;
                case "7":
                    Console.WriteLine("You entered seven");
                    break;
                default:
                    Console.WriteLine("Pick Something");
                    return GetUserNumber();

                    
            }
            return Convert.ToInt32(input);
        }
    }
}
