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
            Console.WriteLine("1.reverse number \n 2.evenodd \n 3.Array \n 4.Reversestring");
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
                case 3:
                    Array array = new Array();
                    array.NewArray();
                    break;
                case 4:
                    // ReverseString reversestring=new ReverseString();
                    //reversestring.Word();
                    Console.WriteLine("enter the word");
                    ReverseString.Word(Console.ReadLine());
                    break;
                default:
                    Console.WriteLine("entered wrong option");
                    break;
            }

        }
    }
}
