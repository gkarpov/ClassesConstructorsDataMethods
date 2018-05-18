using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Factorial
{
    class Program
    {
        static void Main(string[] args)
        {
            BigInteger factorial = 1;

            int num = int.Parse(Console.ReadLine());

            for (; num > 1; num--)
                factorial *= num;

            num = TrailZeros(factorial);
            Console.WriteLine(num);
        }

        static int TrailZeros(BigInteger fact)
        {
            string number = fact.ToString();

            int zeros = 0;
            int maxzeros = 0;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == '0')
                {
                    zeros++;
                }
                else
                {
                    if(zeros>maxzeros)
                        maxzeros = zeros;
                    zeros = 0;
                }
            }
            if (zeros > maxzeros)
                maxzeros = zeros;
            
            return maxzeros;
        }
    }
}
