using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Class21
    {
        static int Add(int a,int b)
        {
            return a + b;
        }
        static string Add(string a, string b)
        {
            return a + b;
        }
        static int Add(int a, int b, int c)
        {
            return a + b + c;
        }

        static void calculatearea(int length)
        {

        }
        static void calculatearea(int length,int breadth)
        {

        }
        static void Main()
        {
           Console.WriteLine(Add(3, 4));
            Console.WriteLine(Add(3, 4,6));
        }
    }
}
