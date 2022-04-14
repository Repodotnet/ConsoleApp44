using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Class8
    {
        static void Main()
        {
            string h = "hello";
            //for (int i = 0; i < h.Length; i++)
            //{
            //    if (h[i] == 'l')
            //        h[i] = '$';
            //}

            string j=h.Replace('l', '$');
            Console.WriteLine(j);
            string h1 = "World";
            char[] h2 = h1.ToCharArray();
            for (int i = 0; i < h2.Length; i++)
            {
                if (h2[i] == 'l')
                    h2[i] = '$';
            }

            foreach (char v in h2)
                Console.WriteLine(v);
            //string k = new string(h2);

            //Console.WriteLine(k);
           
            string s = Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < sb.Length; i++)
            {
                if (sb[i] == 'l')
                    sb[i] = '$';
            }

            Console.WriteLine(sb);
        }
    }
}
