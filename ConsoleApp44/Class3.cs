using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Class3
    {
        static void Main()
        {
            for (int i = 1; i <= 10; i++)
            {
                if (i == 5)
                    goto y;
                Console.Write(i + " ");

            }
        y:
            Console.WriteLine("Loop Exit");
            Console.WriteLine();

            //int j = 10;
            //while(j> 0)
            //{
            //    Console.WriteLine(j);
            //    j--;
            //}

            //int k = 1;
            //do
            //{
            //    Console.WriteLine(k);
            //    k++;
            //} while (k < 10);


        }
    }
}
