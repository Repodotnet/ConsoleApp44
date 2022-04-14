using System;

namespace ConsoleApp44
{
    class Program
    {
        void Add(int a,int b)
        {
            Console.WriteLine(a + b);
        }
        static void Main(string[] args)
        {
            Program p1 = new Program();
            p1.Add(2, 3);

        }
    }
}
