using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace ConsoleApp44
{
    class Class29
    {
        static void Main()
        {

            //1 2 3 4 5
            //0 1 2 3 4
            //2 3 4 5

            //11 13 15 


            //List<int> li = new List<int>();
            //li.Add(2);
            //li.Add(3);
            //li.Add(1);
            //li.Add(6);
            //li.Add(5);

            
            //var t = 10;
            //var g = "Hello";
            //var x = (from i in li where i % 3 == 0 select i);//query syntax
            //var f = li.Where(x => x % 3 == 0);//lambda expression
            
            //foreach (int i in f)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine(x.Min());

            //Dictionary<int, string> d = new Dictionary<int, string>();
            //d.Add(1, "Chennai");
            //d.Add(2, "Goa");
            //d.Add(3, "Pune");
            //d.Add(4, "Bangalore");
            //d.Add(5, "Hyderabad");

            //foreach (int j in d.Keys)
            //{
            //    Console.WriteLine(j + " " + d[j]);            
            //}


            //int[] A = new int[] { 1, 2, 3, 4, 1, 2, 1, 2, 1, 3, 4 };

            //Dictionary<int, int> d1 = new Dictionary<int, int>();

            //foreach (int i in A)
            //{
            //    if (d1.ContainsKey(i))
            //    {
            //        d1[i]++;
            //    }
            //    else
            //    {
            //        d1.Add(i, 1);
            //    }
            //}

            //foreach (int u in d1.Keys)
            //{
            //    Console.WriteLine(u + " " + d1[u]);
            
            //}

            //string Message= "Hemmo";

            //var result = from c in Message group c by c into y orderby y.Count() descending select y ;
            //var result1 = Message.GroupBy(x => x);
            //foreach (var j in result1)
            //{
            //    Console.WriteLine(j.Key + " " + j.Count());
            //}
            List<string> li = new List<string>() { "apple", "amaron", "bat", "cat" };

            var t = li.Where(x => !x.StartsWith('a')).ToList();
          
            foreach (string u in t)
                Console.WriteLine(u);

        }
    }
}
