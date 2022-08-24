using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class sujith
    
    {
        public static void Main(string[] args)
        {
            Console.Write("Input a first number(<10): ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input a second number(>20): ");
            int n = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine((m < 10 && n > 20));
        }
    }

}





