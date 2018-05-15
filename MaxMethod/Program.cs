using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MaxMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            int max = int.MinValue;
            for (int i = 0; i < 3; i++)
                max = GetMax(max, int.Parse(Console.ReadLine()));
            Console.WriteLine(max);
        }

        static int GetMax(int a, int b)
        {
            if (a >= b)
                return a;
            else
                return b;
        }
    }
}
