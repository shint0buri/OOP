

using System;
using System.Threading.Tasks;

namespace lab22
{
   
    public delegate (int max1, int max2) MaxFinderDelegate(int size1, int size2);

    class Program
    {
       
        static (int max1, int max2) FindMaxInArrays(int size1, int size2)
        {
            if (size1 <= 0 || size2 <= 0)
                throw new ArgumentException("Размеры массивов должны быть положительными.");

            Random rnd = new Random();
            int[] arr1 = new int[size1];
            int[] arr2 = new int[size2];

            for (int i = 0; i < size1; i++)
                arr1[i] = rnd.Next(1, 1001); 

            for (int i = 0; i < size2; i++)
                arr2[i] = rnd.Next(1, 1001);

            int max1 = arr1[0];
            foreach (int val in arr1)
                if (val > max1) max1 = val;

            int max2 = arr2[0];
            foreach (int val in arr2)
                if (val > max2) max2 = val;

            return (max1, max2);
        }

        //вход
        static async Task Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            Console.WriteLine("Лабораторная работа №22 (вариант 16)");
            Console.WriteLine("Поиск максимальных элементов в двух массивах случайных чисел...\n");

            int size1 = 10;
            int size2 = 15;

            
            MaxFinderDelegate finder = new MaxFinderDelegate(FindMaxInArrays);

         
            Task<(int max1, int max2)> task = Task.Run(() => finder(size1, size2));

            Console.WriteLine($"Выполняется поиск максимумов в массивах размером {size1} и {size2}...");

       
            while (!task.IsCompleted)
            {
                Console.Write(".");
                await Task.Delay(200); 
            }

            Console.WriteLine("\n\nОперация завершена!");

            
            var (max1, max2) = await task;

            Console.WriteLine($"Максимум в первом массиве: {max1}");
            Console.WriteLine($"Максимум во втором массиве: {max2}");

            Console.WriteLine("\nНажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}