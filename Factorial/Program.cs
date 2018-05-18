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

            Console.WriteLine(factorial);
        }
    }
}
