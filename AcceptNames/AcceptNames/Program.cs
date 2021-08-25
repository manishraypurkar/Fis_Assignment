using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Author -manish anil raypurkar
 Date -23/08/21
Description - Accepts names from user and searching given name using arrays and loop.
 */

namespace AcceptNames
{
    class Program
    {
        static void Main(string[] args)
        {
            String[] names = new string[10];

            Console.WriteLine("Enter the 10 Names");
            for(int i=0;i<names.Length;i++)
            {
               names[i]=Console.ReadLine();
            }
            Console.WriteLine("Enter the Name that u want to search");
            String given=Console.ReadLine();
            int temp = 0; 
            for(int i=0;i<names.Length;i++)
            {
                if(given==names[i])
                {
                    Console.WriteLine("Given name is "+given+" and found at "+ i +" position");
                    temp = 1;
                    break;
                }
               
            }
            if (temp<=0)
            {
                Console.WriteLine("Element Not Found..!");
            }

            Console.ReadKey();


        }
    }
}
