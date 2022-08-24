using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppDemo
{
    internal class sujith1
    {
        public static void multiply(int firstnumber,int secondnumber,int thirdnumber)
        {
            //int firstnumber;
            //int secondnumber;
            //int thirdnumber;
            //int multiplication;
            Console.WriteLine("ENTER FIRST NUMBER");
            firstnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER SECOND NUMBER");
            secondnumber = int.Parse(Console.ReadLine());
            Console.WriteLine("ENTER THIRD NUMBER");
            thirdnumber = int.Parse(Console.ReadLine());
            int multiplication = firstnumber * secondnumber * thirdnumber;
            Console.WriteLine("multiplication of numbers is" + multiply);
        }
    }
}
