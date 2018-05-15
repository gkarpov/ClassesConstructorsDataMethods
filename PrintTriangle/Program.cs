using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PrintTriangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int h = int.Parse(Console.ReadLine());

            PrintTriangle(h);
        }

        static void PrintLine(int st, int en)
        {
            for (int i = st; i <= en; i++)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }

        static void PrintTriangle(int height)
        {
            for (int i = 1; i < height; i++)
                PrintLine(1, i);
            PrintLine(1, height);
            for (int i = height-1; i >0; i--)
                PrintLine(1, i);
        }
    }
}
