using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            Library mybooks = new Library();
            mybooks.ReadAllBooks(num);

            DateTime after = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", CultureInfo.InvariantCulture);
                        
            mybooks.TitleDate(after);

        }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public void ReadAllBooks(int num)
        {
            List<Book> tmp = new List<Book>();
            for (int i = 0; i < num; i++)
            {
                var book = new Book();
                book.getBook(Console.ReadLine());
                tmp.Add(book);
            }
            this.Books = tmp;
        }


        public Dictionary<string, DateTime> AfterDateBooks(DateTime after)
        {
            Dictionary<string, DateTime> FoundBooks = new Dictionary<string, DateTime>();

            foreach (var a in this.Books)
            {
                if (a.rdate > after)
                    FoundBooks[a.title] = a.rdate;

            }

            return FoundBooks;
        }


        public void TitleDate(DateTime after)
        {
            Dictionary<string, DateTime> dict = this.AfterDateBooks(after);

            foreach (var item in dict.OrderBy(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine("{0} -> {1:dd.MM.yyyy}", item.Key, item.Value);
            }
        }
    }

    class Book
    {

        public string title { get; set; }
        public string author { get; set; }
        public string publisher { get; set; }
        public DateTime rdate { get; set; }
        public string ISBN { get; set; }
        public double price { get; set; }

        public void getBook(string input)
        {
            string[] inp = input.Split(' ').ToArray();

            this.title = inp[0];
            this.author = inp[1];
            this.publisher = inp[2];
            this.rdate = DateTime.ParseExact(inp[3], "dd.MM.yyyy", CultureInfo.InvariantCulture);
            this.ISBN = inp[4];
            this.price = double.Parse(inp[5]);
        }


    }
}
