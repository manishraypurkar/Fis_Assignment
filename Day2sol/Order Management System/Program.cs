using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    Author - manish anil raypurkar
    Date - 24/08/2021
    Description - Create Order Management System Console App for Making Bill.
 */

namespace Order_Management_System
{

    public class Order
    {
        public int orderId=101;
        public int OrderId
        {
            get;set;
        }
        public string CustomerName { get; set; }
        public DateTime OrderDate { get; set; }
        public string ProductName { get; set; }
        public int Price { get; set; }
        public int Quantity { get; set; }
        public int orderAmount;
        public int OrderAmount
        {
            get
            {
                return orderAmount;
            }
        }

        public void CalculateOrderAmount()
        {
            int res = this.Quantity * this.Price;
            orderAmount = res;
            Console.WriteLine("Total Order Amount is "+res);

        }
        public void PrintOrderDetails()
        {
            Console.WriteLine($"Order Details are OrderId {orderId}, Customer name {CustomerName}, Order Date {OrderDate}, Product name {ProductName}, Price {Price}, Quantity {Quantity}, Order Amount {OrderAmount}");

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var ord = new Order();
            Console.WriteLine("Enter Your Name");
            ord.CustomerName = Console.ReadLine();
            Console.WriteLine("Enter The date");
            ord.OrderDate = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Enter The Product Name");
            ord.ProductName = Console.ReadLine();
            Console.WriteLine("Enter Price");
            ord.Price = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("How many Quantity");
            ord.Quantity =Convert.ToInt32( Console.ReadLine());

            ord.CalculateOrderAmount();

           ord.PrintOrderDetails();

            Console.ReadKey();
        }
    }
}
