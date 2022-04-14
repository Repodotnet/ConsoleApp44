using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Class9
    {
        static void Main()
        {
            string j = "Welcome";
            Console.WriteLine(j.ToUpper());
            Console.WriteLine(j);

            Console.WriteLine(j.Substring(3));
            Console.WriteLine(j.Substring(3,2));
            string email = "John@rediffmail.com";
            Console.WriteLine(email.LastIndexOf('@'));
            Console.WriteLine(email.Substring(email.IndexOf('@')+1, email.IndexOf('.')-email.IndexOf('@')-1));

            String y = "my$email$is$email.com";
            Console.WriteLine(y.Replace("email", "gmail"));

            string[] p = y.Split('$');

            foreach (string k in p)
            {
                Console.WriteLine(k);
            }
           

            Console.WriteLine(String.Join('@', p));

            string s1 = "  Hi   All ";

            Console.Write(s1.Trim());

            string a = "Hello";

            //H 1 
            //e 1 
            //l 2 
            //o 1

            int[] u = { 1, 1, 2, 1, 2, 3, 1, 4 };



        }
    }
}
