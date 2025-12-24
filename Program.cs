using System;
using System.Diagnostics;


public class Point2D
{
  
    public double X { get; set; }

    
    public double Y { get; set; }

  
    public Point2D()
    {
        X = 0.0;
        Y = 0.0;
#if DEBUG
        Console.WriteLine("[DEBUG] Создана точка по умолчанию: (0, 0)");
#endif
    }


    public Point2D(double value)
    {
        X = value;
        Y = value;
#if DEBUG
        Console.WriteLine($"[DEBUG] Создана точка с одинаковыми координатами: ({value}, {value})");
#endif
    }


    public Point2D(double x, double y)
    {
        X = x;
        Y = y;
#if DEBUG
        Console.WriteLine($"[DEBUG] Создана точка: ({x}, {y})");
#endif
    }

    public void Display()
    {
        Console.WriteLine($"Точка: ({X:F2}, {Y:F2})");
    }


    public double DistanceToOrigin()
    {
        return Math.Sqrt(X * X + Y * Y);
    }


    public double DistanceTo(Point2D other)
    {
        if (other == null)
            throw new ArgumentNullException(nameof(other));

        double dx = X - other.X;
        double dy = Y - other.Y;
        return Math.Sqrt(dx * dx + dy * dy);
    }


    public double DistanceTo(double x, double y)
    {
        double dx = X - x;
        double dy = Y - y;
        return Math.Sqrt(dx * dx + dy * dy);
    }

  
    public static Point2D InputPoint()
    {
        Console.Write("Введите координату X: ");
        if (!double.TryParse(Console.ReadLine(), out double x))
        {
            throw new FormatException("Некорректный ввод координаты X.");
        }

        Console.Write("Введите координату Y: ");
        if (!double.TryParse(Console.ReadLine(), out double y))
        {
            throw new FormatException("Некорректный ввод координаты Y.");
        }

        return new Point2D(x, y);
    }
}


public class Program
{
    public static void Main()
    {
#if DEBUG
        Console.WriteLine("=== Режим отладки (DEBUG) ===");
#else
        Console.WriteLine("=== Режим выпуска (RELEASE) ===");
#endif

        try
        {
            var p1 = Point2D.InputPoint();
            var p2 = new Point2D(3.0, 4.0);

            p1.Display();
            p2.Display();

            Console.WriteLine($"Расстояние от p1 до начала координат: {p1.DistanceToOrigin():F2}");
            Console.WriteLine($"Расстояние между p1 и p2: {p1.DistanceTo(p2):F2}");
            Console.WriteLine($"Расстояние от p1 до (1,1): {p1.DistanceTo(1.0, 1.0):F2}");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ошибка: {ex.Message}");
        }
    }
}