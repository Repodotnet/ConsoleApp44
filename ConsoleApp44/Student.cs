using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Person
    {
        public int Id;
        public string Name;
        public DateTime DOB;
        public static string countryName;

        static Person()
        {
            countryName = "India";
        }
        public Person()
        {
           
          
           // Console.WriteLine("Person constrctor");
        }


        public void Display()
        {
            Console.WriteLine("Id= " + Id);
            Console.WriteLine("Name =" + Name);
            Console.WriteLine("DOB= " + DOB);
            Console.WriteLine("Country Name =" + countryName);
        }
    }

    class Class16
    {
        static void Main()
        {
            Person.countryName = "India";

            Person p = new Person();
            p.Id = 120;
            p.Name = "John";
            p.DOB = DateTime.Parse("04-04-2000");
           

            p.Display();

            Person p1 = new Person();
            p1.Id = 200;
            p1.Name = "Mark";
            p1.DOB = DateTime.Parse("04-10-2000");
            p1.Display();
        }
    
    }

    // class Insurance 
    //properties Id ,Name
    //Display
    //Default Constr- id=1 ,Name="health"


}
