using System;
using GeometryLibrary;
using OutputLibrary;

namespace MainApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("=== Расчёт характеристик прямоугольника ===");

         
            Console.Write("Введите длину стороны a: ");
            if (!double.TryParse(Console.ReadLine(), out double a) || a <= 0)
            {
                Console.WriteLine("Ошибка: сторона a должна быть положительным числом.");
                return;
            }

     
            Console.Write("Введите длину стороны b: ");
            if (!double.TryParse(Console.ReadLine(), out double b) || b <= 0)
            {
                Console.WriteLine("Ошибка: сторона b должна быть положительным числом.");
                return;
            }

 
            var rect = new Rectangle { A = a, B = b };


            ResultDisplayer.Display(rect);

            Console.WriteLine("\nНажмите любую клавишу для выхода...");
            Console.ReadKey();
        }
    }
}