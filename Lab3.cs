using System;
using System.IO;
namespace Test
{
    class Program
    {
        public static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);


            int t = 0, N = 1;
            double X = 0, Y = 0, s = 0;
            t = Convert.ToInt32(Console.ReadLine());
            N = Convert.ToInt32(Console.ReadLine());
            X = Convert.ToInt32(Console.ReadLine());
            Y = Convert.ToInt32(Console.ReadLine());

            int i = 1, step = 2;
            double znam = 1, chisl;

            if (t == 0)
            {
                for (i = 1; i <= N; i++)
                {
                    znam = i * (i + 2);
                    if (i % 2 == 0)
                        chisl = X * Math.Cos(Math.Pow(Y, i + 1));
                    else
                        chisl = -(Math.Sin(Y) * Math.Pow(X, i + 1));
                    s += chisl / znam;
                }
            }

            if (t == 1)
            {
                while (i <= N)
                {
                    znam = i * (i + 2);
                    if (i % 2 == 0)
                        chisl = X * Math.Cos(Math.Pow(Y, i + 1));
                    else
                        chisl = -(Math.Sin(Y) * Math.Pow(X, i + 1));
                    s += chisl / znam;
                    i++;
                }
            }

            if (t == 2)
            {
                i = 1;
                do
                {
                    znam = i * (i + 2);
                    if (i % 2 == 0)
                        chisl = X * Math.Cos(Math.Pow(Y, i + 1));
                    else
                        chisl = -(Math.Sin(Y) * Math.Pow(X, i + 1));
                    s += chisl / znam;
                    i++;
                } while (i <= N);
            }
            Console.WriteLine(String.Format("{0:0.0000000}", s));

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}