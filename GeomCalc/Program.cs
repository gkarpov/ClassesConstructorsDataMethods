using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GeomCalc
{
    class Program
    {
        static void Main(string[] args)
        {
            var Func = Console.ReadLine();
            FuncChooser(Func);
            
        }

        static void FuncChooser(string figure)
        {
            switch (figure)
            {
                case "triangle":
                    Console.WriteLine("{0:0.00}", TriArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
                    break;
                case "square":
                    Console.WriteLine("{0:0.00}", SquareArea(double.Parse(Console.ReadLine())));
                    break;
                case "rectangle":
                    Console.WriteLine("{0:0.00}", RectangleArea(double.Parse(Console.ReadLine()), double.Parse(Console.ReadLine())));
                    break;
                case "circle":
                    Console.WriteLine("{0:0.00}", CircleArea(double.Parse(Console.ReadLine())));
                    break;
                default:
                    break;

            }
        }

        static double TriArea(double side, double height)
        {
            return side * height / 2;
        }

        static double SquareArea(double side)
        {
            return side * side;
        }

        static double RectangleArea(double side, double height)
        {
            return side * height;
        }

        static double CircleArea(double side)
        {
            return Math.PI* Math.Pow(side, 2);
        }
    }
}
