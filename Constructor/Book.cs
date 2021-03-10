using System;
using System.Collections.Generic;
using System.Text;

namespace Constructor
{
    class Book
    {
        public string author;
        public string title;
        public int pages;
        
        //constructor
        public Book(string book_name,string book_author,int book_page)
        {
            title = book_name;
            author = book_author;
            pages = book_page;
        }
        public void Display()
        {
            Console.WriteLine($"Book title : {title}");
            Console.WriteLine($"Book author : {author}");
            Console.WriteLine($"Book page : {pages}\n");
        }
    }
}
}
