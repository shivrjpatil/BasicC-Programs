using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class ReverseString
    {
        public static void Word(string word)
        {
            string reverse = "";
            char[] chars = word.ToCharArray();
            Console.WriteLine("dispalying each character");
            for (int i = 0; i < chars.Length; i++)
            {
                Console.WriteLine(chars[i]);
            }
            for (int i=0; i < chars.Length; i++)
            {
                reverse=  chars[i] + reverse;    
            }
            Console.WriteLine(reverse);
            Console.ReadLine();
        }
    }
}
