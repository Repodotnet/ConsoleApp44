using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
 internal class User
    {
       private string password;

        public User()
        {
            password = "123";
        
        }

        public void display()
        {
            Console.WriteLine(password);        
        }
    
    }
  public  class Course
    {
        public int Id;
        public string Name;

        public void Display()
        {
            Console.WriteLine("Id= "+Id);
            Console.WriteLine("Name ="+ Name);

        }
    }
    class Class15
    {
        static void Main()
        {
            Course course1 = new Course();
            course1.Id = 20;
            course1.Name = "C#";

            course1.Display();

            Course course2 = new Course();
            course2.Id = 25;
            course2.Name = "Java";
            course2.Display();

            User user = new User();
            user.display();
        
        }
    
    }
}
namespace project2
{
    class Program {

        static void Main()
        {
            ConsoleApp44.Course c = new ConsoleApp44.Course();
        
        }
    }

}