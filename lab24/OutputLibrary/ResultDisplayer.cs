using GeometryLibrary; 
using System;

namespace OutputLibrary
{
    public static class ResultDisplayer
    {
        public static void Display(Rectangle rect)
        {
            Console.WriteLine("Результаты расчёта прямоугольника:");
            Console.WriteLine($"Стороны: a = {rect.A:F2}, b = {rect.B:F2}");
            Console.WriteLine($"Периметр: {rect.Perimeter:F2}");
            Console.WriteLine($"Площадь: {rect.Area:F2}");
            Console.WriteLine($"Диагональ: {rect.Diagonal:F2}");
        }
    }
}