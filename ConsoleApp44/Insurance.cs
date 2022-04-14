using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Insurance
    {
        int Id;
        string Name;

        public Insurance()
        {
            this.Id = 10;
            this.Name = "Health";
        }
        public Insurance(int Id,string Name)
        {
            this.Id = Id;
            this.Name = Name;
        }
        public void Display()
        {
            Console.WriteLine("Id= " + Id);
            Console.WriteLine("Name =" + Name);
           
        }
    }
    class Class17
    {
        static void Main()
        {
            Insurance i = new Insurance();
            i.Display();

            Insurance i1 = new Insurance();
            i1.Display();

            Insurance i2 = new Insurance(3, "Life");
            i2.Display();

            Insurance i3 = new Insurance(4, "Vehicle");
            i3.Display();

        }
    }
}
