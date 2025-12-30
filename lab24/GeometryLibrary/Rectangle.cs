using System;

namespace GeometryLibrary
{
    public class Rectangle
    {
        public double A { get; set; }
        public double B { get; set; }

        public double Perimeter => 2 * (A + B);
        public double Area => A * B;
        public double Diagonal => Math.Sqrt(A * A + B * B);
    }
}