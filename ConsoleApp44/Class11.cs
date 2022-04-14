using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Class11
    {
        static void Greet()
        {
            Console.WriteLine("Hi");
        }

        static void Greet(string name)
        {
            Console.WriteLine("Hi " + name);
        }

        static void Add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
        static void multiply(int num1, int num2,int num3)
        {
            Console.WriteLine(num1 * num2 * num3);
        }

        static float Getpi()
        {
            return 3.14f;
        }

        static int Difference(int x, int y)
        {
            
            return x - y;
        }
        static void Main()
        {
            Greet();
            Greet("Peter");
            Add(3, 4);
            int a = 10;
            int b = 20;
            Add(a, b);
            Console.WriteLine("Hello");

            int result = Difference(6, 3);
            Console.WriteLine(result);

            float v = Getpi();
            Console.WriteLine(v);
            Console.WriteLine(Getpi());
        }
    }
}
