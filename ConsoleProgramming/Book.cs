using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleProgramming
{
    class Book
    {
        public string author;
        public string title;
        public int pages;

        public void Display()
        {
            Console.WriteLine($"Book title : {title}");
            Console.WriteLine($"Book author : {author}");
            Console.WriteLine($"Book page : {pages}\n");
        }
    }
}
