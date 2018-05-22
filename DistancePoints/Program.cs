using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DistancePoints
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point();
            Point p2 = new Point();

            p1 = p1.ReadPoint(Console.ReadLine());
            p2 = p2.ReadPoint(Console.ReadLine());

            Console.WriteLine("{0:0.00}", p1.DistanceToPoint(p2));
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

        public Point ReadPoint(string pointXY)
        {
            int[] pointxy = pointXY.Split().Select(int.Parse).ToArray();
            this.X = pointxy[0];
            this.Y = pointxy[1];
            return this;
        }

        public int DifferenceOnX(Point point2)
        {
            return Math.Abs(this.X - point2.X);
        }

        
        public int DifferenceOnY(Point point2)
        {
            return Math.Abs(this.Y - point2.Y);
        }

        public double DistanceToPoint(Point point2)
        {
            return Math.Sqrt(Math.Pow(this.DifferenceOnX(point2), 2) + Math.Pow(this.DifferenceOnY(point2), 2));
        }
    }

       
}
