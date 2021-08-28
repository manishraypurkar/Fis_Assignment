using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductLinq
{
    class Program
    {
        static void Main(string[] args)
        {
            //var product = new Product();
            
            List<Product> GetProducts()
           {
                var products = new List<Product>()
                {
                    new Product(101,"Pendrive",1100,"Electronics",new DateTime(2021,01,01)),
                    new Product(102,"Wireless Keyboard",3000,"Electronics",new DateTime(2020,12,12)),
                    new Product(103,"Wireless Mouse",1500,"Electronics",new DateTime(2021,02,12)),
                    new Product(104,"Formal Shoes",3000,"Footwear",new DateTime(2021,01,10)),
                    new Product(105,"Formal Shirt",2200,"Clothing",new DateTime(2020,12,01))
                };
                return products;
            }


            var DataSource = GetProducts(); //first step create datasource
            
     
            Console.WriteLine("MENU");
            Console.WriteLine("1.Task 1\n2.Task 2\n3.Task 3\n4.Exit");

            Console.WriteLine("Enter Your Choice");
            int choice = Convert.ToInt32(Console.ReadLine());

            
                switch (choice)
                {
                    case 1:
                        var q1 = from prod in DataSource
                                 orderby prod.Name
                                 select prod;

                        Console.WriteLine("Task 1 Result is..");


                        foreach (var data in q1)
                        {
                            Console.WriteLine(data);
                        }
                        break;
                    case 2:
                        Console.WriteLine("\nTask 2 Result is..");


                    var q2 = from prod2 in DataSource
                             where prod2.Category == "Electonics" && (prod2.Price >= 1000 && prod2.Price <= 2000)
                                 select prod2;
                        foreach (var data in q2)
                        {
                            Console.WriteLine(data);
                        }
                        break;
                    case 3:
                        var q3 = from prod3 in DataSource
                                 where prod3.CreatedOn.Year == 2021
                                 select prod3;
                        Console.WriteLine("\nTask 3 Result is..");

                        foreach (var data in q3)
                        {
                            Console.WriteLine(data);
                        }
                        break;
                    case 4:
                        Environment.Exit(0);
                        break;
                    default: Console.WriteLine("Invalid Choice"); break;

                }
            

            Console.ReadLine();




        }
    }
}
