using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace IntersecCircles
{
    class Program
    {
        static void Main(string[] args)
        {
            Circle c1 = new Circle();
            Circle c2 = new Circle();

            c1.Center = new Point();
            c2.Center = new Point();

            c1.ReadCircle(Console.ReadLine());
            c2.ReadCircle(Console.ReadLine());

            if(Intersect(c1, c2))
                Console.WriteLine("Yes");
            else
                Console.WriteLine("No");

        }

        static bool Intersect(Circle cir1, Circle cir2)
        {
            double distance = cir1.Center.DistanceToPoint(cir2.Center);

            if (distance <= cir1.radius + cir2.radius)
                return true;
            else
                return false;
        }
    }

    class Circle
    {
        public Point Center { get; set; }
        public double radius;
        
        public void ReadCircle(string input)
        {
            double[] tmp = input.Split(' ').Select(double.Parse).ToArray();

            this.Center.X = tmp[0];
            this.Center.Y = tmp[1];
            this.radius = tmp[2];
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
