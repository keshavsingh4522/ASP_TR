using System;

namespace Events
{
    public delegate void Transformer(int x);
    class Program
    {
        static void Main(string[] args)
        {
            Transformer t;
            Console.Write("Please Enter a number: ");
            int x = int.Parse(Console.ReadLine());
            t = Square;
            t += Cube;
            t(x); //or t.Invoke(x); --> both are same

            // event handler
            NotificationHandler obj = new NotificationHandler();
            obj.TransformEvent += user1.Handler1;
            obj.TransformEvent += user2.Handler2;
            obj.NotififyOnCall(x);
            obj.TransformEvent -= user2.Handler2;
            obj.NotififyOnCall(x);
        }

        static void Square(int x)
        {
            Console.WriteLine($"Square of {x} is {x * x}");
        }
        static void Cube(int x)
        {
            Console.WriteLine($"Cube of {x} is {x * x * x}");
        }
    }
    class NotificationHandler
    {
        public event Transformer TransformEvent;
        public void NotififyOnCall(int x)
        {
            if(TransformEvent != null)
            {
                TransformEvent(x);
            }
        }
    }
    class user1
    {
        public static void Handler1(int x)
        {
            Console.WriteLine("Event Received by Object 1");
        }
    }
    class user2
    {
        public static void Handler2(int x)
        {
            Console.WriteLine("Event Received by Object 2");
        }
    }
}
