/*using System;
using System.Runtime.InteropServices;

namespace CS_Lab4_2_
{
    class Program
    {
        [DllImport(@"Dll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Add(int a, int b);

        [DllImport(@"Dll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Subtract(int a, int b);

        [DllImport(@"Dll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Multiply(int a, int b);

        [DllImport(@"Dll.dll", CallingConvention = CallingConvention.Cdecl)]
        static extern int Division(int a, int b);
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Input a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input b: ");
            b = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine($"a + b = {Add(a, b)}");
            Console.WriteLine($"a - b = {Subtract(a, b)}");
            Console.WriteLine($"a * b = {Multiply(a, b)}");
            Console.WriteLine($"a / b = {Division(a, b)}");
            Console.ReadKey();
            unsafe
            {
                int* x; // определение указателя
                int y = 10; // определяем переменную

                x = &y; // указатель x теперь указывает на адрес переменной y
                Console.WriteLine(*x); // 10

                y = y + 20;
                Console.WriteLine(*x);// 30

                *x = 50;
                Console.WriteLine(y); // переменная y=50
            }
        }
    }
}*/
using System;
using System.Runtime.InteropServices;

namespace CS_Lab4_2_
{
    class Program
    {
        [DllImport("MyDll.dll")]
        public static extern double mPow(double a, double n);
        static void Main(string[] args)
        {
            int a, n;
            Console.Write("Input a: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input n: ");
            n = Convert.ToInt32(Console.ReadLine());

            Console.Write("Result is: ");
            double result = MyDll.Calculations.mPow(a, n);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}