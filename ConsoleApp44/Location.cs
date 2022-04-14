using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Location
    {
        int _id;
        public int id
        { 
        set { _id = value;}
        get { return _id; }
        }
        string _name;
        public string name
        {
            set { _name = value; }
            get { return _name; }
        }
        public Location()
        {

        }
        public Location(int id,string name)
        {
            this._id = id;
            this._name = name;
        }
        public void display()
        {
            Console.WriteLine("Id= " + id);
            Console.WriteLine("Name= " + name);
        }

        public static Location operator-(Location l1, Location l2)
        {
            Location l3 = new Location();
            l3.id = l1.id;
            l3.name = l2.name;
            return l3;
        
        }

    }
    class Class20
    {
        static void Main()
        {
            Location loc = new Location();
            loc.id = 1;
            loc.name = "hyd";

            Location loc1=new Location(2,"Delhi");

            Location l4 = loc1;
            l4.display();

            Location l3= loc - loc1;
            l3.display();

            Location[] l = new Location[3];

            
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine("Enter id and name");
                l[i] = new Location();
                l[i].id = Convert.ToInt32(Console.ReadLine());
                l[i].name = Console.ReadLine();
            }
            //for(int i=0;i<3;i++)
            //{
            //    l[i].display();            
            //}

            foreach (Location l1 in l)
            {
                l1.display();
            }

        }
    }
}
