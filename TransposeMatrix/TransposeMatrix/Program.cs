using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 Author -manish anil raypurkar
 Date -23/08/21
Description - Accepts 2*2 matrix from user and display transpose matrix.
 */
namespace TransposeMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[2,2];
            int[,] tmatrix = new int[2, 2];


            Console.WriteLine("Enter the 2*2 matrix");
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for(int j=0;j<matrix.GetLength(1);j++)
                {
                    matrix[i,j] = Convert.ToInt32(Console.ReadLine());

                }
            }

            for(int i=0;i<tmatrix.GetLength(0);i++)
            {
                for(int j=0;j<tmatrix.GetLength(1); j++)
                {
                    tmatrix[i, j] = matrix[j,i];
                }
            }
            Console.WriteLine("Transpose Matrix is");

            for (int i = 0; i < tmatrix.GetLength(0); i++)
            {
                for (int j = 0; j < tmatrix.GetLength(1); j++)
                {
                   Console.Write(tmatrix[i, j]);
                    Console.Write("\t");
                }

                Console.WriteLine();
            }

            Console.ReadKey();

        }
    }
}
