using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Class10
    {
        static void Main()
        {
            string j = null;
            int? k = null;
            int i = 10;
           

            int p = k ?? i;

            Console.WriteLine(p);

        
        }
    }
}
