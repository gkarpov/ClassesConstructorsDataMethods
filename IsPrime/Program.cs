using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IsPrime
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPrime(long.Parse(Console.ReadLine())));
        }

        static bool IsPrime(long num)
        {
            if (num == 0 || num == 1)
                return false;
            for (long i = 2; i <= (int)Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                    return false;
            }
            return true;
        }
    }
}
