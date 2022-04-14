using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Bank
    {
        public Bank()
        { 
        
        }
        int AccountNumber;
        public int _accountnumber
        {
            set { AccountNumber = value; }//write
            //get { return AccountNumber; }//read
        
        }
        public string AccountName { set; get; }
        public float Balance { set; get; }
         float tds;
        int i;

        public void caluculateBalance()
        {
            tds = 10 * Balance / 100;
            Balance = Balance - tds;

        }
        public void Display()
        {
            Console.WriteLine("Id= " + AccountNumber);
            Console.WriteLine("Name =" + AccountName);
            Console.WriteLine("Balance =" + Balance);

        }
    
    }

    class Class19
    {
        static void Main()
        {
            Bank b1 = new Bank();
            b1._accountnumber = 11102920;
            b1.AccountName = "John";
            b1.Balance = 222300;
            b1.caluculateBalance();
            b1.Display();

            Bank[] b = new Bank[3];
            
        
        }
    }
}
