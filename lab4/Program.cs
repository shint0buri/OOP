using System;
using System.ComponentModel.Design;
using System.IO;

namespace Test
{

    class Program
    {

        static void Main(string[] args)
        {
            int N;
            String Filename;

            Console.Write("Inter N > ");
            N = Convert.ToInt32(Console.ReadLine());

            TextWriter save_out = Console.Out;
            var new_out = new StreamWriter(@"massive.txt");
            Console.SetOut(new_out);

            Console.WriteLine(N);

            Random r = new Random(DateTime.Now.Millisecond);
            int x = 0;
            for (int i = 0; i < N; i++)
            {
                x = r.Next(-100000, 100000);
                Console.Write(x + " ");
            }

            Console.SetOut(save_out); new_out.Close();
            Console.WriteLine("File was created.");
            Run();
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
            String str_all = Console.ReadLine();
            string[] str_elem = str_all.Split(' ');

            int[] mas = new int[N];
            for (int i = 0; i < N; i++)
            {
                mas[i] = Convert.ToInt32(str_elem[i]);
            }

            //Среднее арифметическое положительных элементов:
            int s = 0; 
            float sa = 0;
            for (int i = 0; i < N; i++)
            {
                if (mas[i] > 0)
                    s += mas[i];
            } 
                    sa = 1.0f * s / N;

            Console.WriteLine(sa);


            //Максимальный среди отрицательных элементов:
            int maxminus = -100000;
            for (int i = 0; i < N; i++)
            {
                if (mas[i] < 0 && mas[i] > maxminus)
                {
                    maxminus = mas[i];
                }
            }

            Console.WriteLine(maxminus);

            //Преобразование массива:
            string[] masstr = new string[N];
            for (int i = 0; i < N; i++)
            {
                if (mas[i] < 0)
                    masstr[i] = "-";
                else
                    masstr[i] = "+";
            }
            for (int i = 0; i < masstr.Length; i++)
            {
                Console.Write(masstr[i]);
            }

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(new_in); new_in.Close();
        }
    }
}