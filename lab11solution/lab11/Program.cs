using lab11;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace lab11
{
    class Program
    {
        static void Main()
        {

            var lines = File.ReadAllLines("input.txt");

            var employees = lines.Skip(1).Select(Employee.Parse).ToList();

            var salaryByCategory = employees
                .GroupBy(e => e.Category)
                .ToDictionary(g => g.Key, g => g.Sum(e => e.Salary));

          
            var withDiploma = employees.Count(e => e.HasDiploma);
            var withoutDiploma = employees.Count - withDiploma;

            
            var salaryBelow50k = employees.Count(e => e.Salary < 50000);

         
            var maxWithoutDiploma = employees
                .Where(e => !e.HasDiploma)
                .Max(e => e.Salary);

            var minWithDiploma = employees
                .Where(e => e.HasDiploma)
                .Min(e => e.Salary);

     
            using (var writer = new StreamWriter("output.txt"))
            {
                writer.WriteLine("1. Сумма фонда заработной платы по категориям:");
                foreach (var kvp in salaryByCategory)
                    writer.WriteLine($"   {kvp.Key}: {kvp.Value:F2}");

                writer.WriteLine("\n2. Количество сотрудников:");
                writer.WriteLine($"   С дипломом: {withDiploma}");
                writer.WriteLine($"   Без диплома: {withoutDiploma}");

                writer.WriteLine($"\n3. Сотрудников с зарплатой менее $50,000: {salaryBelow50k}");

                writer.WriteLine($"\n4. Макс. зарплата без диплома: {maxWithoutDiploma:F2}");
                writer.WriteLine($"   Мин. зарплата с дипломом: {minWithDiploma:F2}");
            }

            Console.WriteLine("Обработка завершена. Результат сохранён в output.txt");
            Console.ReadKey(); 
        }
    }
}