using System;
using System.IO;

class Program
{
    static void Main()
    {
        try
        {
            Console.WriteLine("=== Лабораторная работа 10. Вариант 16 ===");
            Console.WriteLine("Программа складывает первую матрицу со второй транспонированной.\n");

            string input1 = "matrix1.txt";
            string input2 = "matrix2.txt";
            string output = "result.txt";

            // Чтение матриц
            double[,] mat1 = MatrixOperations.ReadMatrixFromFile(input1);
            double[,] mat2 = MatrixOperations.ReadMatrixFromFile(input2);

            // Транспонирование второй матрицы
            double[,] mat2T = MatrixOperations.Transpose(mat2);

            // Сложение
            double[,] result = MatrixOperations.Add(mat1, mat2T);

            // Запись результата
            MatrixOperations.WriteMatrixToFile(output, result);

            Console.WriteLine("Результат записан в файл: " + output);
        }
        catch (Exception ex)
        {
            Console.WriteLine("Ошибка: " + ex.Message);
        }
    }
}