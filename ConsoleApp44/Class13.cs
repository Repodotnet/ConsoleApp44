using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Class13
    {
        enum abcd { red=8,green,blue=32,yellow};
        enum xyz { a='P',b,c}
        enum Gender { female=1,male=2}
        static void Main()
        {
            const int a = 20;
            
            Console.WriteLine((int)abcd.green);
            Console.WriteLine((char)xyz.a);

           // {1,2,3,4,5,6 };//4,5,6,1,2,3

        }
    }
}
