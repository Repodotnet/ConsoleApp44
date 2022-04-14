using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace ConsoleApp44
{
    class Class28
    {

        static void Main()
        {
            //int[] A = new int[5] { 1, 2, 3, 4, 5 };

            //ArrayList al = new ArrayList();
            //al.Add(1);
            //al.Add(4);
            //al.Add("Hi");
            //al.Add(3.4f);
            //al.Add('c');


            //foreach(object o in al)
            //Console.WriteLine(o);


            //ArrayList al1 = new ArrayList();
            //al1.Add(1);
            //al1.Add(4);
            //al1.Add(5);           

            //al1.Sort();
            //al1.Reverse();
            //al1.AddRange(A);
            //Console.WriteLine("Index ="+ al1.IndexOf(4));
            ////int sum = 0;
            ////foreach (object o in al1)
            ////{
            ////    sum +=(int)o;
            ////}


            //Stack st = new Stack();
            //st.Push(2);
            //st.Push(3);
            //st.Push(4);
            //st.Push(5);


            //st.Pop();

            //foreach(object o in st)
            // {
            //    Console.WriteLine(o);
            
            //}

            //Console.WriteLine(st.Peek());

            //ArrayList al2 = new ArrayList();
            //al2.Add('h');
            //al2.Add('e');
            //al2.Add('l');
            //al2.Add('l');
            //al2.Add('o');

            //al2.Sort();

            //foreach (char i in al2)
            //    Console.Write(i);

            //Console.WriteLine();
            //Queue q = new Queue();
            //q.Enqueue(1);
            //q.Enqueue(3);
            //q.Enqueue(4);
            //q.Enqueue(2);
            //q.Enqueue(8);

            //q.Dequeue();
            //q.Dequeue();

            //foreach(object o in q)
            //{
            //    Console.WriteLine(o);
            //}

            Hashtable ht = new Hashtable();
            ht.Add(11, "Red");
            ht.Add(23, "Blue");
            ht.Add(17, "Yellow");
            ht.Add(12, "Red");
            ht.Add(19, "Green");

            ht.Remove(23);
           
            

            foreach (int o in ht.Keys)
            {
                Console.WriteLine(o + " " + ht[o]);
            
            }


            int[] p = new int[] { 2, 5, 1, 7, 9, 6 };
            int max = 0;

            for (int i = 0; i < p.Length; i++)
            { 
                if(p[i]>max)
                {
                    max = p[i];
                }
            }
            Console.WriteLine(max);
        }
    }
}
