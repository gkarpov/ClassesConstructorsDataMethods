using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClosestPoint
{
    class Program
    {
        static void Main(string[] args)
        {

            int num = int.Parse(Console.ReadLine());

            Point[] points = ReadAllPoints(num);
            Point[] pair = new Point[2];

            pair = FindClosestPoints(points);
            
            Console.WriteLine("{0:0.000}", pair[0].DistanceToPoint(pair[1]));
            Console.WriteLine("({0}, {1})", pair[0].X, pair[0].Y);
            Console.WriteLine("({0}, {1})", pair[1].X, pair[1].Y);


        }

        static Point[] ReadAllPoints(int num)
        {
            Point[] tmp = new Point[num];
            for (int i = 0; i < num; i++ )
            {
                tmp[i] = new Point();
                tmp[i].ReadPoint(Console.ReadLine());
                
            } 

            return tmp;
        }

        static Point[] FindClosestPoints(Point[] inpoints)
        {
            double dist = double.MaxValue;
            Point[] pair = new Point[2];

            for(int i = 0; i<inpoints.Count()-1; i++)
            {
                for (int k = i + 1; k < inpoints.Count(); k++)
                {
                    if (inpoints[i].DistanceToPoint(inpoints[k]) < dist)
                    {
                        dist = inpoints[i].DistanceToPoint(inpoints[k]);
                        pair[0] = inpoints[i];
                        pair[1] = inpoints[k];
                    }
                }
            }

            return pair;
        }


    }

    class Point
    {
        public double X { get; set; }
        public double Y { get; set; }

        public void ReadPoint(string input)
        {
            double[] tmp = input.Split(' ').Select(double.Parse).ToArray();

            this.X = tmp[0];
            this.Y = tmp[1];
        }

        public double DifferenceOnX(Point point2)
        {
            return Math.Abs(this.X - point2.X);
        }


        public double DifferenceOnY(Point point2)
        {
            return Math.Abs(this.Y - point2.Y);
        }

        public double DistanceToPoint(Point point2)
        {
            return Math.Sqrt(Math.Pow(this.DifferenceOnX(point2), 2) + Math.Pow(this.DifferenceOnY(point2), 2));
        }

    }
}

