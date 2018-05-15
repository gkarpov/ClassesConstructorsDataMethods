using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SignOfNum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            PrintSign(n);
        }

        static void PrintSign(int num)
        {
            if (num > 0)
            {
                Console.WriteLine("The number {0} is positive.", num);
            }
            else if (num < 0)
            {
                Console.WriteLine("The number {0} is negative.", num);
            }else if(num == 0)
                Console.WriteLine("The number 0 is zero.");
        }
    }
}
