//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace ConsoleApp1
//{
//    internal class Merged
//    {
//        public static void Main()
//        {
//            int i = 0;
//            int j = 0;

//            int[] arr1 = new int[5] { 2, 6, 8, 15, 45};

//            int[] arr2 = new int[5] { 55, 66, 78, 88, 100 };

//            int[] merged = new int[10];

//            for (i = 0, j = 0; i < 5; i++)
//            {
//                merged[j++] = arr1[i];
//            }
//            for (i = 0; i < 5; i++)
//            {
//                merged[j++] = arr2[i];
//            }
//            Console.WriteLine("Elements of merged array = ");
//            for (i = 0; i < 10; i++)
//            {
//                Console.WriteLine("merged[" + (i) + "]: " + merged[i]);
//            }
//            Console.WriteLine();
//        }
//}
