using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RtoApp
{
    class Program
    {
       static Dictionary<string, string> rtoInfo = new Dictionary<string, string>();

        public static string RtoCode { get; set; }
        public static string District { get; set; }

       public static void Register()
        {
            Console.WriteLine("Enter RTO code");
            RtoCode = Console.ReadLine();

            Console.WriteLine("Enter District Name");
            District = Console.ReadLine();
            rtoInfo.Add(RtoCode,District);

        }
        public static void Display()
        {
            Console.WriteLine("RTO Code and District Names are-");
            Console.WriteLine("Total Enteries is: "+rtoInfo.Count);

            foreach (KeyValuePair<string,string> index in rtoInfo)
            {
                Console.WriteLine($"RTO Code {index.Key}, Distict {index.Value}");
            }


        }
        public static void RemoveDist()
        {
            Console.WriteLine("Enter the RTO Code to Delete District");
            RtoCode = Console.ReadLine();
            if (rtoInfo.ContainsKey(RtoCode))
            {
                rtoInfo.Remove(RtoCode);
                Console.WriteLine("Deleted, Total Enteries after deleting is: " + rtoInfo.Count);
            }
            else
            {
                Console.WriteLine("Sorry RTO Code is not Found");
            }

        }
        //public static void RemoveDistCode()
        //{
        //    Console.WriteLine("Enter the RTO Code to Delete ");
        //    RtoCode = Console.ReadLine();
        //    Console.WriteLine("Enter the District name to Delete ");
        //    District = Console.ReadLine();
        //    rtoInfo.Remove(RtoCode);
        //    Console.WriteLine("Deleted Total Enteries after deleting is: " + rtoInfo.Count);

        //}

        static void Main(string[] args)
        {
           


            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("*****Welcome To RTO System*****");
                Console.WriteLine("1.Register/Adding\n2.Remove District\n3.Display Data\n4.Remove All\n5.Exit");
                Console.WriteLine("Enter your Choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        Register();

                        break;
                    case 2:
                        RemoveDist();

                        break;
                    case 3:
                        Display();
                        break;
                    case 4:
                        rtoInfo.Clear();
                        Console.WriteLine("All Data is Deleted");
                        break;
                    case 5:
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }

            }
            }
    }
}
