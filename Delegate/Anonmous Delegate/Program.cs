using System;

namespace Anonmous_Delegate
{
    class Program
    {
        public delegate int MyDelegate(int arg1, int arg2);
        static void Main(string[] args)
        {
            MyDelegate f = delegate (int a1, int a2)
            {
                return a1 * a2;
            };
            Console.WriteLine("The Number is {0}",f(20,19));
        }
    }
}
