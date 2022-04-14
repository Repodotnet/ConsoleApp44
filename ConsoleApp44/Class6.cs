using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Class6
    {
        static void Main()
        {
            //int[,] A = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };

            //foreach (int y in A)
            //    Console.WriteLine(y);

            //for (int i = 0; i < 2; i++)
            //{
            //    for(int j=0;j< 3; j++)
            //    {
            //        Console.Write(A[i, j]);
            //    }
            //    Console.WriteLine();
            //}

            int row, col;

            Console.WriteLine("Enter the row and column");
            row = Convert.ToInt32(Console.ReadLine());
            col = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(row);
            int[,] p = new int[row, col];


        }
    }
}
