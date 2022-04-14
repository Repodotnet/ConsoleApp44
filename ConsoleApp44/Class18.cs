using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
   abstract class Employee
    {
        public int id;
        public string name;
        private float bsalary;
        public Employee()
        {

        }
        public Employee(int id, string name,float salary)
        {
            this.id = id;
            this.name = name;
            this.bsalary = salary;
        }


        public float BSalary { get => bsalary; set => bsalary = value; }

        public abstract void CalculateSalary();

        public void Display()
        { 
        
        }
    }
    class Temployee:Employee
    {
        int noofhrs;
        int costperhr;

        public Temployee()
        {

        }

        public Temployee(int id,string name,float bsalary,int noofhrs,int costperhr):base(id,name,bsalary)
        {
            //this.id = id;
            //this.name = name;
            this.noofhrs = noofhrs;
            this.costperhr = costperhr;
        }



        public void Display()
        {
            Console.WriteLine(name);
        
        }
        public override void CalculateSalary()
        {
            BSalary = noofhrs*costperhr;

        }

    }
    
    class ClassA
    {
        static void Main()
        {
           // Employee e = new Employee(1, "john",10000);

            Temployee te = new Temployee(1,"Mary",1,12,2000);

            Employee e1 = new Temployee();
            e1.CalculateSalary();

        
        }
    }
}

