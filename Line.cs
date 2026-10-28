using Lessons11;
using System;
using System.Numerics;

namespace Lessons11
{
    public class Line<T> where T : struct, INumber<T>
    {
        public Point<T> StartPoint { get; set; }
        public Point<T> EndPoint { get; set; }

        public Line(T x1, T y1, T x2, T y2)
        {
            StartPoint = new Point<T>(x1, y1);
            EndPoint = new Point<T>(x2, y2);
        }

        public Line(Point<T> point1, Point<T> point2)
        {
            StartPoint = point1;
            EndPoint = point2;
        }

        public double GetLength()
        {
            double x1 = Convert.ToDouble(StartPoint.X);
            double y1 = Convert.ToDouble(StartPoint.Y);
            double x2 = Convert.ToDouble(EndPoint.X);
            double y2 = Convert.ToDouble(EndPoint.Y);

            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public bool ContainsPoint(Point<T> point)
        {
            double x1 = Convert.ToDouble(StartPoint.X);
            double y1 = Convert.ToDouble(StartPoint.Y);
            double x2 = Convert.ToDouble(EndPoint.X);
            double y2 = Convert.ToDouble(EndPoint.Y);
            double x3 = Convert.ToDouble(point.X);
            double y3 = Convert.ToDouble(point.Y);

            double crossProduct = (x3 - x1) * (y2 - y1) - (y3 - y1) * (x2 - x1);
            return Math.Abs(crossProduct) < 1e-9;
        }

        public override string ToString()
        {
            return $"Пряма проходить від точки {StartPoint} до точки {EndPoint}";
        }
    }
}