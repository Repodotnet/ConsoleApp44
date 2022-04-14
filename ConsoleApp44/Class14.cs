using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Square 
    {
       public int length;
        public int CalculateArea()
        { 
        return length*length;
        }
        public int CalculatePerimeter()
        {
            return 4* length;
        }

    }
    class Class14
    {
        static void Main()
        {
            Square s1 = new Square();
            s1.length = 20;
            Console.WriteLine("Area =" + s1.CalculateArea());
            Console.WriteLine("Perimeter =" + s1.CalculatePerimeter());

            Square s2 = new Square();
            s2.length = 5;
            Console.WriteLine("Area =" + s2.CalculateArea());
            Console.WriteLine("Perimeter =" + s2.CalculatePerimeter());

        }


    }
}
