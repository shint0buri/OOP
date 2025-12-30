using lab23;
using System;
using System.Threading;

namespace lab23 
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            string[] testStrings = { "яблоко", "ананас", "киви", "грейпфрут", "манго" };

            
            var data = new StringArrayData { Strings = testStrings };

           
            Thread thread = new Thread(new ParameterizedThreadStart(ThreadWorker.FindLongestString));
            thread.Start(data);

            
            thread.Join();

            
            Console.WriteLine($"Исходный массив: [{string.Join(", ", testStrings)}]");
            Console.WriteLine($"Самая длинная строка: \"{data.LongestString}\"");
            Console.WriteLine("\nНажмите любую клавишу для завершения...");
            Console.ReadKey();
        }
    }
}