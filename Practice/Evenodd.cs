using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class Evenodd
    {
        public void Even(int num)
        {
            if (num % 2 == 0)
            {
                Console.WriteLine("the number is even");
               Console.ReadLine();  


            }
            else
                Console.WriteLine("the number is odd");
            Console.ReadLine();
            
        }
    }
}
