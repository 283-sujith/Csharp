using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class parameters
    {

        public static int multiply(int firstnumber, int secondnumber, int thirdnumber)
        {
            return firstnumber * secondnumber * thirdnumber;
        }
        public static void Main()
        {
            int firstnumber, secondnumber, thirdnumber, multiplication;
            Console.WriteLine("ENTER FIRST NUMBER");
           firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER SECOND NUMBER");
            secondnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THIRD NUMBER");
           thirdnumber = int.Parse(Console.ReadLine());
            multiplication = multiply(firstnumber, secondnumber,  thirdnumber);
        Console.WriteLine($"multiplication of numbers is {multiplication}");
        }
    }
}
