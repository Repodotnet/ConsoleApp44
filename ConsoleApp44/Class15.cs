using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Company
    {
        int CompanyId;

        public int companyid
        {
            set { CompanyId = value; }
            get { return CompanyId; }

        }
        string CompanyName;

        public string companyname
        {
            set { CompanyName = value; }
            get { return CompanyName; }
        }
        
        public string location { set; get; }
        public void Display()
        {
            Console.WriteLine("Id= " + CompanyId);
            Console.WriteLine("Name =" + CompanyName);
        }
    
    }
    class Class18
    {

        static void Main()
        {
            Company c = new Company();
            c.companyid = 1;//set
            Console.WriteLine(c.companyid);//get
            c.companyname = "Cts";
            c.Display();
      

        }
    }
}
