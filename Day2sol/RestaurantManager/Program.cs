using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Author - manish anil raypurkar
    Date - 24/08/2021
    Description - Create a Resturant Manger console App.
 */
namespace RestaurantManager
{
    
    public interface IOrder
    {
        int Id { get; set; }
        string Status { get; set; }
        void Confirm();

    }
    public interface ICancellable
    {
        void Cancel();

    }

    public class Order:IOrder ,ICancellable
    {
        public void OrderDetails()
        {
            Console.WriteLine($"Order Details are: Customer Name-{CustomerName}, Order date-{OrderDate}, Order Amout is-{OrderAmount}, Order Status-{Status}");

        }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public int OrderAmount { get; set; }
        public int Id { get; set; }
        public string Status { get; set ; }

        public void Confirm()
        {
           Status = "Confirmed";
        }
        public void Cancel()
        {
            Status ="Cancelled";
        }
    }
    class Program
    {
       
        static void Main(string[] args)
        {
            var ord = new Order();

            Console.WriteLine("**********MENU**********");
            Console.WriteLine("1.Confirm\n2.Cancel\n3.Exit");
            Console.WriteLine("Enter your Choice");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Name");
            ord.CustomerName = Console.ReadLine();
            Console.WriteLine("Enter The Date and Time");
            ord.OrderDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter amount");
            ord.OrderAmount = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:
                    ord.Confirm();
                    ord.OrderDetails();
                    break;
                case 2:
                    ord.Cancel();
                    ord.OrderDetails();
                    break;
                case 3:
                    Environment.Exit(0);
                    break;
                case 4:
                    Console.WriteLine("Invalid case");
                    break;

            }

            Console.ReadKey();
        }
    }
}
