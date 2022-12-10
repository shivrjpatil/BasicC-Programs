using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Array
    {
        public void NewArray()
        {
            Console.WriteLine("Please enter the size of the array");
            int size=Convert.ToInt32(Console.ReadLine());
            int[] num = new int[size];
            Console.WriteLine("enter the data");
            for (int i= 0; i < num.Length; i++)
            {
                num[i] = Convert.ToInt32(Console.ReadLine());
            }
            Console.WriteLine("array elements");
            for (int i= 0; i < num.Length; i++)
            {
                Console.WriteLine(num[i] + "");
                Console.ReadLine();
            }
        }
    }
}
