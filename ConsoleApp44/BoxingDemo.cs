using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class BoxingDemo
    {
        static void Main()
        {
            int a = 10;
            object o;
            o = a;//Boxing(Converting value type to ref type)

            Console.WriteLine(o);

            bool b = true;
            object y = b; //Boxing(Converting value type to ref type)
            Console.WriteLine(y);


            object o1 = 20;
            int x = (int)o1;//Unboxing Converting ref type to value type 

            Console.WriteLine("Hi");
        
        }
    }
}
