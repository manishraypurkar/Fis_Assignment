using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/*
    Author - manish anil raypurkar
    Date - 24/08/2021
    Description -Create Saving Account App for Deposite and Withdraw Money.
 */
namespace AbstractClass
{
    public abstract class Account
    {
        public int AccountNO { get; set; }
        public int Balance { get; set; }
        public string CustomerName { get; set; }



        public void Deposite(int amount)
        {
            Console.WriteLine("Current Balance is " + this.Balance);
            this.Balance = this.Balance + amount;
            Console.WriteLine("Updated Balance is "+this.Balance);
        }

        public abstract void Withdraw(int amount);

    }

    public class SavingAccount : Account
    {
        public SavingAccount()
        {
            this.Balance = 2000;
        }

        public override void Withdraw(int amount)
        {
            int temp = this.Balance - amount;
            if (temp>500)
            {
                Console.WriteLine("Current Balance is " + this.Balance);
                this.Balance = this.Balance - amount;
                Console.WriteLine("Updated Balance is " + this.Balance);
            }
            else
            {
                Console.WriteLine("Operation Not Suppoerted Minimum Balacne must be Maintained");

            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            var saving = new SavingAccount();
            Console.WriteLine("**********MENU**********");
            Console.WriteLine("1.Deposite\n2.Withdraw\n3.Exit");
            Console.WriteLine("Enter your Choice");
            int choice;
            choice = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your Account number");
            saving.AccountNO = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your  Name");
            saving.CustomerName = Console.ReadLine();
            Console.WriteLine("Enter amount");
            int amount;
            amount = Convert.ToInt32(Console.ReadLine());

            switch(choice)
            {
                case 1: saving.Deposite(amount);
                    break;
                case 2:
                    saving.Withdraw(amount);
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


            