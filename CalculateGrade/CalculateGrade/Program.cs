using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 * Author -Manish Anil Raypurkar
 * Date -23/08/21
 * Description - calculation of grades based on students marks
 
 */

namespace CalculateGrade
{
    class Program
    {
        static void Main(string[] args)
        {
            int maths, physics, chemistry;
            Console.WriteLine("Enter the marks of Maths");
            maths=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of Physics");
            physics = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the marks of Chemistry");
            chemistry = Convert.ToInt32(Console.ReadLine());

            int total = maths + physics + chemistry;
                Console.WriteLine("Total marks is " + total);
            int avg = total / 3;
            Console.WriteLine("Average is "+avg);

            if (avg>90 && avg<=100)
            {
                Console.WriteLine("Grade is A");
            }
            else if(avg<90 && avg>80)
            {
                Console.WriteLine("Grade is B");

            }
            else if(avg<80 && avg>70)
            {
                Console.WriteLine("Grade is C");

            }
            else
            {
                Console.WriteLine("Grade is F");

            }
            Console.ReadKey();
        }
    }
}
