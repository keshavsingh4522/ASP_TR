using System;

namespace Composable_Delegate
{
    // Delegate
    public delegate void MyDelegate(int arg1, int arg2);
    class Program
    {
        // Methods
        static void method1(int a1,int a2)
        {
            Console.WriteLine("The Number is {0}", a1 + a2);
        }
        static void method2(int a1,int a2)
        {
            Console.WriteLine("The Number is {0}",a1 * a2);
        }
        static void method3(int a1, int a2)
        {
            Console.WriteLine("The Number is {0}", a1 * a2 + a1);
        }

        static void Main(string[] args)
        {
            MyDelegate f1 = method1, f2 = method2, f3 = method3;
            MyDelegate all = f1 + f2;
            Console.WriteLine("\nAdd Composable");
            all(10, 20);
            all += f3;
            Console.WriteLine("\nBy adding f3");
            all(10, 20);
            all -= f2;
            Console.WriteLine("\nBy subtracting f2");
            all(10, 20);
        }
    }
}
