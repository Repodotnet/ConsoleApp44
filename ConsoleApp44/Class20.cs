using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    interface Istudent
    {
        void show();        
    
    }
    interface Iemployee
    {
        static string IName { get; set; }
        static void display() { }     

    }

    class P1:Istudent,Iemployee
    {
        
        public string IName { get; set; }

        public void show()
        {
            Console.WriteLine("P1 show");
        }
        public void display()
        {
            Console.WriteLine("P1 display");
        }
    }
    class Class23
    {
        static void Main()
        {
            //Istudent s1 = new Istudent();


            P1 s2 = new P1();
            s2.display();

            Istudent s3 = new P1();
            s3.show();
                Iemployee.display();   
        }
    }
}
