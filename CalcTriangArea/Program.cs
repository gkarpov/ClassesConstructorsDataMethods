using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalcTriangArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double w = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double ar;
            ar = CalcTrArea(w, h);
            Console.WriteLine(ar);
        }
        static double CalcTrArea(double w, double h)
        {
            return w*h/2;
        }
    }
}
