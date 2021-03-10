using System;

namespace Constructor
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book("I Love You","Keshav Singh",123);
            Book book2 = new Book("PK","PR",321);

            book1.Display();
            book2.Display();
        }
    }
}
