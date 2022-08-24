using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class outparameter
    {
        public static void smallno(int a,int b,out int small)
            {
            if(a<b)
            {
                small = a;
            }
            else
                small=b;
        }
        public static void Main()
        {
            int a, b, small;
            Console.WriteLine("enter a");
            a=int.Parse(Console.ReadLine());
            Console.WriteLine("enter b");
            b= int.Parse(Console.ReadLine());
            smallno(a,b,out small);
            Console.WriteLine($"THE SMALLEST IS {small}");
        }
    }
}
