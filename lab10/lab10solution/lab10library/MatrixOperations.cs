using System;
using System.IO;

public static class MatrixOperations
{
    // Чтение матрицы из файла
    public static double[,] ReadMatrixFromFile(string filePath)
    {
        string[] lines = File.ReadAllLines(filePath);
        string[] dims = lines[0].Split(' ');
        int rows = int.Parse(dims[0]);
        int cols = int.Parse(dims[1]);

        double[,] matrix = new double[rows, cols];
        for (int i = 0; i < rows; i++)
        {
            string[] values = lines[i + 1].Split(' ');
            for (int j = 0; j < cols; j++)
                matrix[i, j] = double.Parse(values[j]);
        }
        return matrix;
    }

    // Транспонирование матрицы
    public static double[,] Transpose(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);
        double[,] transposed = new double[cols, rows];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                transposed[j, i] = matrix[i, j];
        return transposed;
    }

    // Сложение двух матриц одинакового размера
    public static double[,] Add(double[,] a, double[,] b)
    {
        if (a.GetLength(0) != b.GetLength(0) || a.GetLength(1) != b.GetLength(1))
            throw new ArgumentException("Размеры матриц не совпадают для сложения.");

        int rows = a.GetLength(0);
        int cols = a.GetLength(1);
        double[,] result = new double[rows, cols];
        for (int i = 0; i < rows; i++)
            for (int j = 0; j < cols; j++)
                result[i, j] = a[i, j] + b[i, j];
        return result;
    }

    // Запись матрицы в файл
    public static void WriteMatrixToFile(string filePath, double[,] matrix)
    {
        using (StreamWriter sw = new StreamWriter(filePath))
        {
            int rows = matrix.GetLength(0);
            int cols = matrix.GetLength(1);
            sw.WriteLine($"{rows} {cols}");
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    if (j > 0) sw.Write(" ");
                    sw.Write(matrix[i, j]);
                }
                sw.WriteLine();
            }
        }
    }
}