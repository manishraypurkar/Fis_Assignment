using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace AdoNet
{
    class Program
    {
        static string ConnectionString = string.Empty;

        static Program()
        {
            ConnectionString = ConfigurationManager.ConnectionStrings["conn"].ConnectionString;
        }
        static void Main(string[] args)
        {
           

            int choice=-1;
            

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("*****MENU*****");
                Console.WriteLine("1.Add a Product\n2.Search a Product by ID\n3.Delete a Product\n4.Display All Product\n5.Exit");
                Console.WriteLine("Enter Your Choice");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1: Add(); break;
                    case 2: Search(); break;
                    case 3: Delete(); break;
                    case 4: Display(); break;
                    case 5: Environment.Exit(0); break;
                    default: Console.WriteLine("Invalid Choice"); break;
                }
            }
            




        }

        private static void Display() //display using disconnected architechture
        {
            try 
            {

                var ds = new DataSet("VirtualDB");
                SqlDataAdapter adapter = new SqlDataAdapter("select * from Product",ConnectionString);

                adapter.Fill(ds, "Product");
                Console.WriteLine("Name of Dataset Or Virtual Database is :"+ds.DataSetName);
                Console.WriteLine("Toatl Table Count is: "+ds.Tables.Count);

                DataTable dt = ds.Tables["Product"];
                Console.WriteLine("0th Table name: "+dt.TableName);

                foreach(DataColumn dc in dt.Columns)
                {
                    Console.Write(dc.ColumnName+ "\t");

                }
                
                    foreach (DataRow dr in dt.Rows)
                    {
                    Console.WriteLine();
                    for (int i = 0; i <dt.Columns.Count;i++)
                    {
                        Console.Write(dr[i]+ "\t");

                    }
                }

            }
            catch(SqlException ex)
            {
                Console.WriteLine("Error is :"+ex.Message);
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error is :" + ex.Message);
            }

        }

        private static void Delete()
        {

            using (var sqlConnection = new SqlConnection(ConnectionString))
            {
                try
                {
                    Console.WriteLine("Enter Product Id");
                    int id = Convert.ToInt32(Console.ReadLine());
                   
                    var q = $"delete from Product where id={id}";

                    var sqlCommand = new SqlCommand(q, sqlConnection);
                    sqlConnection.Open();
                    int res = sqlCommand.ExecuteNonQuery();

                    if (res >= 1)
                    {
                        Console.WriteLine($"{res} Row is Deleted Sccessfully");
                    }
                    else
                    {
                        Console.WriteLine("No Data is Deleted");
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error:" + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:" + ex.Message);

                }
                finally
                {
                    sqlConnection.Close();
                }


            }
        }

        private static void Search()
        {
            using (var sqlConnection = new SqlConnection(ConnectionString))
            {
                try
                {
                    Console.WriteLine("Enter Product Id");
                    int id = Convert.ToInt32(Console.ReadLine());

                    var q = $"select * from Product where id={id}";

                    var sqlCommand = new SqlCommand(q, sqlConnection);
                    sqlConnection.Open();
                     SqlDataReader reader = sqlCommand.ExecuteReader();

                    if (reader.HasRows)
                    {
                        int i=0;
                        string name;
                        string desc;
                        int price;
                        Console.WriteLine("\nData Found Successfully... ");

                        Console.WriteLine("ID\t\tName\t\tPrice\t\tDescription");

                        while (reader.Read())
                        {
                            i = reader.GetInt32(0);
                            name = reader.GetString(1);
                            price = reader.GetInt32(2);
                            desc = reader.GetString(3);
                            Console.WriteLine($"{i}\t\t{name}\t\t{price}\t\t{desc}");
                        }
                        
                    }
                    else
                    {
                        Console.WriteLine("No Data Found ");
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error:" + ex.Message);
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error:" + ex.Message);

                }
                finally
                {
                    sqlConnection.Close();
                }


            }
        }

        private static void Add()
        {
            using (var sqlConnection=new SqlConnection(ConnectionString))
            {
                try
                {
                    Console.WriteLine("Enter Product Id");
                    int id = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Product Name");
                    string  name =Console.ReadLine();
                    Console.WriteLine("Enter Product Price");
                    int price = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter Product Description");
                    string dis = Console.ReadLine();

                    var q =$"insert into Product values({id},'{name}',{price},'{dis}')";

                    var sqlCommand = new SqlCommand(q,sqlConnection);
                    sqlConnection.Open();
                   int res=sqlCommand.ExecuteNonQuery();

                    if(res>=1)
                    {
                        Console.WriteLine($"{res} Row is Inserted Sccessfully");
                    }
                    else
                    {
                        Console.WriteLine("No Data is Inserted");
                    }
                }
                catch (SqlException ex)
                {
                    Console.WriteLine("Error:"+ ex.Message);
                }
                catch(Exception ex)
                {
                    Console.WriteLine("Error:" + ex.Message);

                }
                finally
                {
                    sqlConnection.Close();
                }
               

            }
            Console.ReadKey();
        }
    }
}
