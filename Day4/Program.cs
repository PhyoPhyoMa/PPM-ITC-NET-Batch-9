using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escape Character
            string directory = @"C:\Windows\Users\newFolder";
            //String Concatenate
            Console.WriteLine("Link : " + directory);
            Console.WriteLine("Link : {0}", directory);
            Console.WriteLine($"Link : {directory}");

            int i = 0;
            while(i < 10)
            {
                Console.WriteLine("WhileLoop");
                i++;
            }

            int j = 4;
            do
            {
                Console.WriteLine(j + 1);
                j++;
            } while (j <= 10);


            //skip
            j = 4;
            do
            {
                if(j == 9)
                {
                    j = j + 1;
                }
                Console.WriteLine(j);
                j++;
            } while (j <= 10);
        }
    }
}
