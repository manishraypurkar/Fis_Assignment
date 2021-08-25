using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
    Autor -manish anil raypurkar
    Date =25/08/2021
    Description -

 */
namespace XyzBankLtd
{
    public class Account
    {
        public int AccountNo { get; set; }
        public string CustomerName { get; set; }
        public int Balance { get; set; }

        public override string ToString()
        {
            return $"Account No- {this.AccountNo}, Customer Name- {this.CustomerName}, Balance- {this.Balance}";
        }

        public void Withdraw(int amount)
        {
            try
            {
                if(amount>this.Balance)
                {
                   Console.WriteLine("Insufficient Balance");


                }
                else
                {
                    Console.WriteLine("Current Balance: "+ this.Balance);
                    this.Balance = this.Balance - amount;
                    Console.WriteLine("Current Balance and details: " +ToString());
                }

            }
            catch(ArgumentException ex)
            {
                Console.WriteLine("Error: "+ex.Message);
            }
           

        }

        public void Deposite(int amount)
        {

            try
            {
                if (amount <= 0)
                {
                    throw new ArgumentException("Invalid value For Balance");

                }
                else
                {
                    Console.WriteLine("Current Balance: " + this.Balance);
                    this.Balance = this.Balance + amount;
                    Console.WriteLine("Updated Balance and details: " + ToString());


                }
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: "+ex.Message);

            }


        }


    }
    class Program
    {
        static void Main(string[] args)
        {
            var account = new Account();

           void  GetData()
            {
                Console.WriteLine("Enter your Account Number");
                account.AccountNo = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter your Name");
                account.CustomerName = Console.ReadLine();


            }

            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("*****Welcome To XyzBankLtd*****");
                Console.WriteLine("1.Deposite\n2.Withdraw\n3.Exit");
                Console.WriteLine("Enter your Choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch(choice)
                {
                    case 1:GetData();
                        Console.WriteLine("Enter Amount");
                        int amount =Convert.ToInt32(Console.ReadLine());
                        account.Deposite(amount);
                        break;
                    case 2:
                        Console.WriteLine("Enter Amount");
                        int amountn = Convert.ToInt32(Console.ReadLine());
                        account.Withdraw(amountn); 
                        break;
                    case 3:Environment.Exit(0);
                            break;
                    default:
                        Console.WriteLine("Invalid Choice");
                        break;
                }
            }

            
        }
    }
}
