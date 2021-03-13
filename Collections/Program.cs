using System;
using System.Collections;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1.
            ArrayList arr = new ArrayList();
            Console.WriteLine(arr.Capacity);
            arr.Add(200);
            Console.WriteLine(arr.Capacity);
            arr.Add(123); arr.Add(3); arr.Add(34);
            Console.WriteLine(arr.Capacity);
            arr.Add(123);
            Console.WriteLine(arr.Capacity);
            Console.WriteLine("----------------------------------------");

            // 2
            ArrayList ar = new ArrayList(2);
            Console.WriteLine(ar.Capacity);
            ar.Add(200);
            Console.WriteLine(ar.Capacity);
            ar.Add(123); ar.Add(3); ar.Add(34);
            Console.WriteLine(ar.Capacity);
            ar.Add(123);
            Console.WriteLine(ar.Capacity);

            // 3
            foreach (object obj in ar)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();


            // remove by value
            // ar.Remove(1230); this will not give error when value is not present
            ar.Remove(123);
            foreach (object obj in ar)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            // remove by index
            // it will give error if index is not present or out of range/bound
            ar.RemoveAt(1);
            foreach (object obj in ar)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
