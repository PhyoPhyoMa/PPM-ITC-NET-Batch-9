using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             *****
             ****
             ***
             **
             *
                             
             */
            Console.WriteLine("*****");
            Console.WriteLine("****");
            Console.WriteLine("***");
            Console.WriteLine("**");
            Console.WriteLine("*");
            Console.WriteLine("////////////");
            for(int i=0; i < 5; i++)
            {
                for(int j=0; j < 5-i; j++)
                {
                    Console.Write("* ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("Homework");
            for(int i=0; i< 4; i++)
            {
                for(int j=1;j<= 4 - i; j++)
                {
                    Console.Write(" ");
                }
                for(int j = 1; j<= 2 * i -1; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            Calculation.Addition(10, 20);
        }
    }
    class Calculation
    {
        public static void Addition(int i, int j)
        {
            Console.WriteLine(i + j);
        }
    }
}
