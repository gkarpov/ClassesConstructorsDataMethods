using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AndeyBilliard
{
    class Program
    {
        static void Main(string[] args)
        {
            shop Myshop = new shop();
            int num = int.Parse(Console.ReadLine());

            Myshop.addprod(num);

            Costumers mycostumers = new Costumers();

            mycostumers.fillcart(Myshop);

            mycostumers.Bill(Myshop);


        }

        class shop
        {
            public Dictionary<string, decimal> products { get; set; }

            public void addprod(int num)
            {
                string[] product = new string[2];
                products = new Dictionary<string, decimal>();

                for (int i = 0; i < num; i++)
                {
                    product = Console.ReadLine().Split('-').ToArray();
                    //if(products.ContainsKey(product[0]))

                    products[product[0]] = decimal.Parse(product[1]);

                }
            }

        }

        class Costumers
        {

            SortedDictionary<string, Dictionary<string, int>> shoplist = new SortedDictionary<string, Dictionary<string, int>>();

            public void fillcart(shop myshop)
            {
                string[] buy = new string[2];
                string[] tmp = new string[2];

                while (true)
                {
                    buy = Console.ReadLine().Split('-').ToArray();
                    if (buy[0] == "end of clients")
                        break;

                    tmp = buy[1].Split(',').ToArray();
                    if (myshop.products.ContainsKey(tmp[0]))
                    {
                        Dictionary<string, int> tmpdict = new Dictionary<string, int>();
                        tmpdict[tmp[0]] = int.Parse(tmp[1]); 
                        if (shoplist.ContainsKey(buy[0]))
                        {
                            if(shoplist[buy[0]].ContainsKey(tmp[0]))
                                shoplist[buy[0]][tmp[0]] += int.Parse(tmp[1]); 
                            else
                                shoplist[buy[0]].Add(tmp[0], int.Parse(tmp[1]));
                        }
                        else
                           shoplist[buy[0]] = tmpdict;
                    }
                }
            }

            public void Bill(shop myshop)
            {
                decimal totbil = 0;

                foreach (var nam in this.shoplist.Keys)
                {
                    Console.WriteLine("{0}", nam);
                    decimal tmpbil = 0;

                    foreach (var prod in this.shoplist[nam])
                    {
                        
                        
                        Console.WriteLine("-- {0} - {1}", prod.Key, prod.Value);
                        tmpbil += prod.Value * myshop.products[prod.Key];
                        totbil += prod.Value * myshop.products[prod.Key];
                        
                    }
                    Console.WriteLine("Bill: {0:F2}", tmpbil);
                }
                Console.WriteLine("Total bill: {0:F2}", totbil);
            }
        }

    }
}
