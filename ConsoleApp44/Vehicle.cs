using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    public class Vehicle
    {
        public int noofwheels { get; set; }
        public string color { get; set; }
        public string brandname { get; set; }
        public float price { get; set; }
        public Vehicle()
        {

        }
        public void Display()
        {
            Console.WriteLine("No of wheels " + noofwheels);
            Console.WriteLine("Color " + color);
            Console.WriteLine("Brandname" + brandname);
            Console.WriteLine("Price " + price);

        }

        public Vehicle(int noofwheels, string color, string brandname, float price)
        {
            this.noofwheels = noofwheels;
            this.color = color;
            this.brandname = brandname;
            this.price = price;
        }

    }

    

    class HeavyVehicle : Vehicle
    {
        
        public bool permit { get; set; }
        public string type { get; set; }

        public void show()
        {
            base.Display();
            Console.WriteLine("Permit" +permit);
            Console.WriteLine("type" + type);
        }

    }

    class Class22
    { 
        static void Main()
        {
            Vehicle v1 = new Vehicle(4, "Blue", "Honda", 1000000);
            v1.Display();

            Console.WriteLine("Heavy Vehicle Display");
            HeavyVehicle hv = new HeavyVehicle();
            hv.noofwheels = 8;
            hv.permit = true;
            hv.color = "red";
            hv.brandname = "Mercedes";
            hv.price = 12000000;
            hv.type = "Construction dumper";

            hv.show();
            

        }
    }
}
