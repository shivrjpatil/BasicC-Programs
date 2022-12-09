using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("welcome to basic c# programs");
            Console.WriteLine("enter the option to run a program");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {


                case 1:
                     ReverseNumber reversenumber =new ReverseNumber();
                     reversenumber.Reverse(043);
                break;
                case 2:
                     Evenodd evenodd = new Evenodd();
                     evenodd.Even(1);
                break;
            }

        }
    }
}
