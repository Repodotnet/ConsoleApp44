using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Class12
    {
        static void Main()
        {
            int x = 10, y = 20;
            Console.WriteLine("x= " + x);
            Console.WriteLine("y= " + y);

            Swap(ref x,ref y);

            Console.WriteLine("x= " + x);
            Console.WriteLine("y= " + y);

            int side = 10;
            int area, perimeter;
            Square(10, out area, out perimeter);

            Console.WriteLine("Area= "+ area);
            Console.WriteLine("Perimeter= " + perimeter);

          //  Console.WriteLine(Add1(2));
            Console.WriteLine(Add1(2,3));
            int a, b;
            a = 10;b = 20;
            Add1(a, b);
        }
        static void Swap(ref int a,ref int b)
        {
            int t;
            t = a;
            a = b;
            b = t;

            Console.WriteLine("A= " + a);
            Console.WriteLine("B= " + b);
        }

        static void Square(int side,out int area,out int perimeter)
        {
             area = side * side;
             perimeter = 4 * side;
                   
        }

        static int Add1(int x, int y)
        {
            x++;
            return x + y;
        }
       

    }
}
