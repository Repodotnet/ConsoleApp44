using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Class1
    {
        static void Main()
        {
           

            int a ,b;

            a =int.Parse(Console.ReadLine());//2
            b = int.Parse(Console.ReadLine());//3

            int c;
            if (a > b)
                c = a;
            else
                c = b;

            c = (a > b) ? a : b;



            //int c = (a++) + (++a);

            //Console.WriteLine(c);
            //Console.WriteLine("The sum of {0} and {1} is {2}", a,b,(a+b));
            //Console.WriteLine("The Diff of numbers is {0}", a - b);
            //Console.WriteLine("The Product of numbers is {0}", a * b);
            //Console.WriteLine("The Quotient of numbers is {0}", (float) a / b);
            //Console.WriteLine("The Reminder of numbers is {0}", a % b);

            Console.WriteLine(a == b);

            if (a > b)
                Console.WriteLine("a is greater");
            else
                Console.WriteLine("b is greater");

            //int c;
            //c = (a > b) ? a : b;

        }
    }
}
