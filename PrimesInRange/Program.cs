using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrimesInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());

            List<int> primes = FindPrimesInRange(a, b);
            
            if(primes.Count == 0)
                Console.WriteLine("(empty list)");
            else
                Console.WriteLine(string.Join(", ",  primes));
        }

        static List<int> FindPrimesInRange(int stN, int enN)
        {
            List<int> primes = new List<int>();
            
            if(enN<=stN)
                return primes;
            
            for (int i = stN; i<=enN; i++){
                if (IsPrime(i))
                    primes.Add(i);
            }
            return primes;
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
