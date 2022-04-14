using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Class25
    {
        static void Main()
        {
            int x,y;
            try
            {
                x = Convert.ToInt32(Console.ReadLine());
                y = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("The output is " + x / y);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine(e.Message);
            }
            catch (Exception a)
            {
                Console.WriteLine(a.Message);
            }
            finally
            {
                Console.WriteLine("Finally block");

            }
            Console.WriteLine("Rest of the code");
        }
    }
}
