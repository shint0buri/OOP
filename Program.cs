using System;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
            double a, b, c, d, e;
            double s, k;
            
            a = Convert.ToDouble(Console.ReadLine());
            b = Convert.ToDouble(Console.ReadLine());
            c = Convert.ToDouble(Console.ReadLine());
            d = Convert.ToDouble(Console.ReadLine());
            e = Convert.ToDouble(Console.ReadLine());

            if ((a - e) < 0 || (b - a == -100))
                Console.WriteLine("ERROR");
            else
            {
                s = Math.Sqrt(a - e) / Math.Sqrt(b - a + 100);
                Console.WriteLine(String.Format("{0:0.00}", s));
            }

            if (c - e < 0)
                Console.WriteLine("ERROR");
            else
            {
                k = (Math.Sqrt(c - e) / Math.Abs(b - 2 * d));
                Console.WriteLine(String.Format("{0:0.00}", k));
            }

            Console.SetOut(save_out); new_out.Close();
            Console.SetIn(save_in); new_in.Close();
        }
    }
}