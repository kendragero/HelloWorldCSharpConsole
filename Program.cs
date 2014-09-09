using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using System.Collections;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main()
        {
            string userName;

            /*Priming input to get the first person's name (required)*/
            Console.WriteLine("Enter your name.");
            userName = Console.ReadLine();
            Console.WriteLine("Hello, " + userName + "!");

            /*While loop to get additional names (optional)*/
            while (userName != "X" && userName != "x")
            {
                Console.WriteLine("Enter another name.  Enter X to stop.");
                userName = Console.ReadLine();
                if (userName != "X" && userName != "x") //don't print the x
                {
                    Console.WriteLine("Hello, " + userName + "!");
                }
            }
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
