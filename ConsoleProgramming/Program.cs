using System;

namespace ConsoleProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book1 = new Book();
            book1.title = "I Love You";
            book1.author = "Keshav Singh";
            book1.pages = 123;

            Book book2 = new Book();
            book2.title = "PK";
            book2.author = "Pr";
            book2.pages = 321;

            book1.Display();
            book2.Display();
        }
    }
}
