using System;
using System.Runtime.InteropServices;

namespace CS_Lab4_2_
{
    class Program
    {
        [DllImport("MyLibrary.dll")]
        public static extern double mPow(double a, double n);
        static void Main(string[] args)
        {
            int a, n;
            Console.Write("Input a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input n: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Result is: ");
            double result = MyLibrary.Calculations.mPow(a, n);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}