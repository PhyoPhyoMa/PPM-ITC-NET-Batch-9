using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)       
        {
            //Decision Making
            //string input;
            //Console.Write("Enter a number : ");
            //input = Console.ReadLine();
            //int num;
            //if(!int.TryParse(input , out num))
            //{
            //    Console.WriteLine("Please Enter a number : ");
            //}
            //else
            //{
            //    int l = Convert.ToInt32(input);
            //    if (l % 2 == 0)
            //    {
            //        Console.WriteLine("This number is Even!");
            //    }
            //    else
            //    {
            //        Console.WriteLine("This number is Odd!");
            //    }
            //}
            Console.Write("Enter a start number : ");
            int s = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();
            Console.Write("Enter a end number : ");
            int e = Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            for(int i = s; i <= e;i++)
            {
                sum += i;
            }
            Console.WriteLine("Sum : " + sum);

        }
    }
}
