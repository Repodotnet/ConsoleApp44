using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Class2
    {
        static void Main()
        {
            Console.WriteLine("Enter the grade ");
            char g = Convert.ToChar(Console.ReadLine());

            int x, y;//2 3
            char op;//+

            switch(g)
            {
                case 'A':
                case 'a':
                    Console.WriteLine("Excellent");
                    break;

                case 'B':
                case 'b':
                    Console.WriteLine("Very Good");
                    break;

                case 'C':
                case 'c':
                    Console.WriteLine("Good");
                    break;

                default:
                    Console.WriteLine("Invalid");
                    break;
            }
        }
    }
}
