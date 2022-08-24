using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class refparameters
    {
        public static void swap(ref int a,ref int b)
        {
            a= a * b;
            b= a / b;
            a= a / b;
        }
        public static void Main(string[] args)
        {
            int a = 520, b = 560;
            Console.WriteLine($"before swap a={a} b={b}");
            swap(ref a,ref b);
            Console.WriteLine($"after swap a={a} b={b}");
        }
    }
}
