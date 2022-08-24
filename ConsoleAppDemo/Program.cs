// See https://aka.ms/new-console-template for more information
class myclass
{
    enum grade { pass = 60, distniction = 85 };
    public static void Main()
    {

        int empid;
        int mark;
        Console.WriteLine("whats your empid?");
        empid = int.Parse(Console.ReadLine());
        Console.WriteLine("Hello World");
        Console.WriteLine($"thanks for giving ");

        Console.WriteLine("enter your tsql mark");
        mark = Convert.ToInt32(Console.ReadLine());
        if (mark >= (int)grade.distniction)
        {
            Console.WriteLine("your distniction");
        }
        else if (mark >= (int)grade.pass)
        {
            Console.WriteLine("you are pass");

        }
        else
        {
            Console.WriteLine("you are fail");
        } } }

namespace consoleappdemo
{
    internal class valreftypes
    {
        public static void main()
        {
            int i = 100;
            int j;
            j = i;
            Console.WriteLine(j);
            i++;
            Console.WriteLine(j);

            int[] arr1 = { 1, 2, 3 };
            int[] arr2;
            arr2 = arr1;

            arr1[0]++;
            Console.WriteLine(arr2[0]);
            Console.WriteLine(arr2[1]);
        }
    }
}