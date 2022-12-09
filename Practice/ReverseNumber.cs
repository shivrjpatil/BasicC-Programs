using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    internal class ReverseNumber
    {
        public  void Reverse(int num)
        {
            //Console.WriteLine("enter the number ");
            //int num =Convert.ToInt32(Console.ReadLine());
            
            int  remainder=0,reverse=0; 
            while (num != 0)
            {
                remainder = num % 10;
                reverse = (reverse * 10) + remainder;
                num = num / 10;
            }

                Console.WriteLine("the reverse number is:" + reverse);
                Console.ReadLine();
                
            
        }
    }
}
