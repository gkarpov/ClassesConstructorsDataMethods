using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SalesReport
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            List<Sale> sales = new List<Sale>();



            for (int i = 0; i< num; i++)
            {
                Sale tmp = new Sale();
                tmp.ReadSale(Console.ReadLine());
                sales.Add(tmp);
            }

            PrintTowns(sales);
            
        }

        static void PrintTowns(List<Sale> list)
        {
            var dict = new SortedDictionary<string, double>();

            foreach (var obj in list)
            {
                if (!dict.ContainsKey(obj.town))
                {
                    dict[obj.town] = obj.price * obj.qnty;
                }
                else 
                {
                    dict[obj.town] += obj.price * obj.qnty;
                }
            }

            foreach (var twn in dict)
            {
                Console.WriteLine("{0} -> {1:0.00}", twn.Key, twn.Value);

            }
        }
    }

    class Sale
    {
        public string town {get; set;}
        public string product {get; set;}
        public double price { get; set; }
        public double qnty { get; set; }

        public void ReadSale(string salestring)
        {
            string[] values = salestring.Split(' ').ToArray();

            this.town = values[0];
            this.product = values[1];
            this.price = double.Parse(values[2]);
            this.qnty = double.Parse(values[3]);

        }


    }


}

