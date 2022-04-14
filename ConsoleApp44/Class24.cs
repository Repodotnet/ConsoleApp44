using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class NameLengthException:Exception
    {
        public NameLengthException(string message):base(message)
        {

        }
    
    }
    class Class27
    {
        static void Main()
        {

            try
            {
                string name;
                name = Console.ReadLine();

                if (name.Length < 3 || !char.IsUpper(name[0]))
                    throw new NameLengthException("Name should be atleast 3 characters");
                Console.WriteLine(name);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

            

        
        }
    }
}
