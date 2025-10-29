using System;
using System.IO;


namespace lab5
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, M;

            Console.Write("Inter N > ");
            N = Convert.ToInt32(Console.ReadLine());
            Console.Write("Inter M > ");
            M = Convert.ToInt32(Console.ReadLine());

            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter(@"massive.txt");
            Console.SetOut(new_out);

            Console.WriteLine(N);
            Console.WriteLine(M);

            Random r = new Random();
            int x = 0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    x = r.Next(-1000, 1000);
                    Console.Write(x + " ");
                }
                Console.WriteLine();
            }

            Console.SetOut(save_out); new_out.Close();
            Console.WriteLine("A {0} Х {1} file named massive.txt was created", N, M);
            Run();
            Console.WriteLine("Check result in the file named output.txt");
            Console.ReadKey();
        }

        static void Run()
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"massive.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);

            int N = Convert.ToInt32(Console.ReadLine());
            int M = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("*** Исходная матрица ***");

            int[,] mas = new int[N,M];
            for (int i = 0; i < N; i++)
            {
                String str_all = Console.ReadLine();
                string[] str_elem = str_all.Split(' ');
                for (int j = 0; j < M; j++)
                {
                    mas[i, j] = Convert.ToInt32(str_elem[j]);
                    Console.Write(mas[i, j] + " ");
                }
                Console.WriteLine();
            }

            Console.WriteLine();
            Console.WriteLine("Среднее арифметическое нечётных элементов для каждого столбца:"); 
            for (int j = 0; j < M; j++)
            {
                int s = 0;
                float sa = 0;
                int count = 0;

                for (int i = 0; i < N; i++)
                {
                    if (mas[i, j] % 2 != 0)
                    {
                        s += mas[i, j];
                        count++;
                    }
                }

                if (count > 0)
                {
                    sa = 1.0f * s / count;
                    Console.WriteLine(sa);
                }
                else
                {
                    Console.WriteLine($"В столбце {j + 1} нет нечётных элементов");
                }
            }
            Console.WriteLine();
            Console.WriteLine("Преобразование массива:");
            int[,] mas37 = new int[N,M];
            for (int i = 0; i < N; i++)
            {   for (int j = 0; j < M; ++j)
                {
                    if (mas[i, j] % 3 == 0)
                        mas37[i, j] = 3;

                    else if (mas[i, j] % 7 == 0)
                        mas37[i, j] = 7;
                    
                    else
                        mas37[i, j] = 0;   
                }
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(mas37[i, j] + " ");
                }
                Console.WriteLine();
            }


            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(new_in); new_in.Close();
        }
    }
}