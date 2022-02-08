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
        }
    }
}
