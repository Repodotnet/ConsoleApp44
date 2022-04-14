using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp44
{
    class Class7
    {
        static void Main()
        {
            string s = "Hello";
            s = "Abcd";

            Console.WriteLine(s);
            for (int i = 0; i < s.Length; i++)
            {
                if(s[i]=='a' ||s[i]=='e' ||s[i]=='i' || s[i]=='o' || s[i]=='u')
                Console.WriteLine(s[i]);
            }

            foreach (char c in s)
            {
                if(char.IsUpper(c))
                Console.WriteLine(c);
            }
        }
    }
}
