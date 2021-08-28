using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorDelegate
{
    public class Calculator
    {
        public int Num1 { get; set; }
        public int Num2 { get; set; }

        public delegate int Calculation(int num, int num2);

        public void Add(int num1,int num2)
        {
            
            Console.WriteLine($"Addition of {num1} and {num2} is {num1+num2}");
        }
        public void Multiply(int num1, int num2)
        {
            Console.WriteLine($"Multipicaton of {num1} and {num2} is {num1*num2}");
        }
    public void Substract(int num1, int num2)
        {
            Console.WriteLine($"Substraction of {num1} and {num2} is {num1-num2}");
        }
        public void Divide(int num1, int num2)
        {
            Console.WriteLine($"Quotient of {num1} and {num2} is {num1/num2}");
        }
    }
    class Program
    {
        public delegate void Calculation(int num1,int num2);
        static void Main(string[] args)
        {
            var cal = new Calculator();

            Console.WriteLine("Enter number 1");
            cal.Num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter number 2");
            cal.Num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n********Result of Calculation is*******");

            var dl = new Calculation(cal.Add);
            dl = dl + cal.Multiply;
            dl = dl + cal.Substract;
            dl = dl + cal.Divide;

            dl(cal.Num1,cal.Num2);

            Console.ReadKey();

        }
    }
}
