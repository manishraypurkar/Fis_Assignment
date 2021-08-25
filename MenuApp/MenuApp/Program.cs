using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 Author -manish anil raypurkar
 Date -23/08/21
Description - Menu app for calculator using switch case
 */
namespace MenuApp
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;
            Console.WriteLine("1.add\n2.sub\n3.multiply\n4.divide\n5.exit");
            Console.WriteLine("Enter your choice");
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the values of x and y");
            int x=Convert.ToInt32(Console.ReadLine());
            int y=Convert.ToInt32(Console.ReadLine());
            int r;

            switch(choice)
            {
                case 1: r = x + y;
                    Console.WriteLine("Addition is "+ r);
                    break;
                case 2: r = x - y;
                    Console.WriteLine("Substraction is "+r);
                    break;
                case 3:
                    r = x * y;
                    Console.WriteLine("Multipication is "+ r);
                    break;
                case 4:
                    r = x/y;
                    Console.WriteLine("Dividation/Quotient is "+ r);
                    break;
                case 5:
                    Console.WriteLine("exiting..");
                    Environment.Exit(0);
                    break;
                default:
                    Console.WriteLine("invalid choice");
                    break;
            }
            Console.ReadKey();
        }
    }
}
