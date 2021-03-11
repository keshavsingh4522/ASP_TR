using System;

namespace Delegate
{
	// Basic Delegate
	public delegate string MyDelegate(int arg1, int arg2);
	class Program
	{
		//methods
		static string func1(int a1, int a2)
		{
			return (a1 + a2).ToString();
		}
		static string func2(int a1, int a2)
		{
			return (a1 * a2).ToString();
		}

		//class instance
		class MyClass
		{
			public string m1(int a1, int a2)
			{
				return ((a1 + a2) * a1).ToString();
			}
		}

		static void Main(string[] args)
		{
			MyDelegate f = func1;
			Console.WriteLine("The Number is " + f(10, 20));
			f = func2;
			Console.WriteLine("The Number is " + f(10, 20));

			MyClass mc = new MyClass();
			f = mc.m1;
			Console.WriteLine("The Number is " + f(10, 20));
		}
	}
}
