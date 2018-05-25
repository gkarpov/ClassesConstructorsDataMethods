using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BookLibrary
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            Library mybooks = new Library();
            mybooks.ReadAllBooks(num);

            mybooks.AuthorPrice();

        }
    }

    class Library
    {
        public string Name { get; set; }
        public List<Book> Books { get; set; }
        public List<string> Authors{get{return GetAuthors(this);}}
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

        public List<string> GetAuthors(Library lib)
        {
            List<string> auths = new List<string>();
            for (int i = 0; i < lib.Books.Count; i++)
            {
                if (!auths.Contains(lib.Books[i].author))
                    auths.Add(lib.Books[i].author);
            }
            return auths;
        }
        
        public Dictionary<string, double> AvgPrice()
        {
            double avgprice = 0;
            int n=0;

            Dictionary<string, double> AutPrices = new Dictionary<string, double>();
            
            foreach(var a in this.GetAuthors(this))
            {    
                for (int i = 0; i < this.Books.Count; i++)
                {

                    if (this.Books[i].author == a)
                    {
                        avgprice+=this.Books[i].price;
                        n++;
                    }
                }
                AutPrices[a]=avgprice;
                avgprice = 0;
                n=0;
            }

            return AutPrices;
    }

        
    public void AuthorPrice()
    {
        Dictionary<string, double> dict = this.AvgPrice();

        foreach (var item in dict.OrderByDescending(x => x.Value).ThenBy(x => x.Key))

        {
            Console.WriteLine("{0} -> {1:0.00}", item.Key, item.Value);
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
            this.rdate = DateTime.Parse(inp[3]);
            this.ISBN = inp[4];
            this.price = double.Parse(inp[5]);
        }


    }
}
