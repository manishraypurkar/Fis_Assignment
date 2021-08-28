using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeesList
{

    public class Employee : IComparable<Employee>
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int salary { get; set; }
        public string Location { get; set; }

        public override string ToString()
        {
            //return "nope";
           return $"{this.Id}\t\t{this.Name}\t\t{this.Email}\t\t{this.salary}\t\t{this.Location}";
        }
        
        public int CompareTo(Employee other)
        {
            return this.Id.CompareTo(other.Id);
        }
    }
    class Program
    {
        static List<Employee> elist = new List<Employee>();

        static void AddEmployee()
        {
            var emp = new Employee();


            Console.WriteLine("Enter Id");
            emp.Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Name");
            emp.Name =Console.ReadLine();
            Console.WriteLine("Enter Your Email");
            emp.Email = Console.ReadLine();
            Console.WriteLine("Enter Your salary");
            emp.salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Your Location");
            emp.Location = Console.ReadLine();

            elist.Add(emp);


        }
        static void DisplayEmployee()
        {
            

            Console.WriteLine("Details Are: ");
            //Console.WriteLine("Id\t\tName\t\tEmail\t\tSalary\t\tLocation");

            foreach(var e in elist )
            {
                //Console.WriteLine($"{e.Id}\\t{e.Name}\\t{e.Email}\\t{e.salary}\\t{e.Location}");//not a good programming practices
                Console.WriteLine(e.ToString());
            }


        }
        static void DeleteEmployee()
        {
            var emp = new Employee();

            Console.WriteLine("Enter Id to Delete data");
            emp.Id = Convert.ToInt32(Console.ReadLine());

            int index = elist.BinarySearch(emp);
            if(index>=0)
            {
                Console.WriteLine("Deleting Employee data..");
                var empDelete = elist[index];
                Console.Write(empDelete.ToString());

                elist.Remove(empDelete);
                Console.WriteLine("Data Deleted..!");

            }
            else
            {
                Console.WriteLine("Employee Data Not Found To Delete");

            }

        }
        static void UpdateEmployee()
        {
            var emp = new Employee();
            Console.WriteLine("Enter the Employee Id to Update data");
            emp.Id = Convert.ToInt32(Console.ReadLine());

            int index = elist.BinarySearch(emp);
            if(index>=0)
            {
                Console.WriteLine("Data is Found..!");
                var empUpdate = elist[index];
                Console.WriteLine(empUpdate.ToString());
                Console.WriteLine("Data is going to be updated..!");

                Console.WriteLine("Enter Your Name");
                empUpdate.Name = Console.ReadLine();
                Console.WriteLine("Enter Your Email");
                empUpdate.Email = Console.ReadLine();
                Console.WriteLine("Enter Your salary");
                empUpdate.salary = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Your Location");
                empUpdate.Location = Console.ReadLine();
                Console.WriteLine("Data is Updated U can se..!");
                Console.WriteLine(empUpdate.ToString());


            }
            else
            {
                Console.WriteLine("Sorry No data Found to Update..!");
            }

        }
        static void SearchEmployee()
        {

            var emp = new Employee();

            Console.WriteLine("Enter the Employee Id to search");
            emp.Id = Convert.ToInt32(Console.ReadLine());


            int index = elist.BinarySearch(emp);
            if (index >= 0)
            {
                Console.WriteLine("Data is Found and Found at Location "+index);
               
                Console.WriteLine(elist[index].ToString());
              
            }
            else
            {
                Console.WriteLine("Sorry No data Found ..!");

            }




        }
            static void Main(string[] args)
        {
            var emp = new Employee();
            while (true)
            {
                Console.WriteLine("\n");
                Console.WriteLine("*****Welcome To Employee System*****");
                Console.WriteLine("1.Add an Employees\n2.List aLL Amployees\n3.Delete an Employees\n4.Update an Employee\n5.Search an Employee by id\n6.Exit");
                Console.WriteLine("Enter your Choice");
                int choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        AddEmployee();
                        
                        break;
                    case 2:DisplayEmployee();
                        
                        break;
                    case 3: DeleteEmployee();
                        break;
                    case 4: UpdateEmployee();
                        break;
                       
                    case 5: SearchEmployee();
                        
                        break;
                    case 6:
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
