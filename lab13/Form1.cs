using System;
using System.Linq;
using System.Windows.Forms;

namespace Lab13_Var16
{
    public partial class MainForm
    {
        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Подключение обработчиков событий
            btnCalculate.Click += (s, ev) => Calculate();
            btnClear.Click += (s, ev) => ClearAll();
        }

        private void Calculate()
        {
            try
            {
                double x = ParseDouble(txtX.Text, "X");

                if (radioSeries.Checked)
                {
                    double result = CalculateSeries(x);
                    lblResult.Text = $"Результат (ряд): {result:F6}";
                }
                else if (radioDoubleSum.Checked)
                {
                    int N = ParseInt(txtN.Text, "N");
                    int R = ParseInt(txtR.Text, "R");

                    double[] a = ParseArray(txtA.Text, "a_i", N);
                    double[] b = ParseArray(txtB.Text, "b_j", R);

                    double result = CalculateDoubleSum(x, a, b, N, R);
                    lblResult.Text = $"Результат (сумма): {result:F6}";
                }
                else
                {
                    throw new InvalidOperationException("Выберите метод расчёта.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private double CalculateSeries(double x)
        {
            // -1 + X²/2 - X³/24 + X⁴/6 - X⁵/4
            return -1
                   + Math.Pow(x, 2) / 2.0
                   - Math.Pow(x, 3) / 24.0
                   + Math.Pow(x, 4) / 6.0
                   - Math.Pow(x, 5) / 4.0;
        }

        private double CalculateDoubleSum(double x, double[] a, double[] b, int N, int R)
        {
            double denominator = 0.0;
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < R; j++)
                {
                    denominator += a[i] * Math.Pow(x, 3) + b[j] * Math.Pow(x, 2);
                }
            }

            if (Math.Abs(denominator) < 1e-12)
                throw new DivideByZeroException("Знаменатель равен нулю.");

            return (x + 1) / denominator;
        }

        private void ClearAll()
        {
            txtX.Clear();
            txtA.Text = "1,2,3";
            txtB.Text = "1,1";
            txtN.Text = "3";
            txtR.Text = "2";
            lblResult.Text = "";
            radioSeries.Checked = true;
        }

        // Вспомогательные методы парсинга с проверками
        private double ParseDouble(string input, string paramName)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new FormatException($"Поле '{paramName}' не заполнено.");
            if (!double.TryParse(input, out double value))
                throw new FormatException($"Некорректное значение для '{paramName}'.");
            return value;
        }

        private int ParseInt(string input, string paramName)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new FormatException($"Поле '{paramName}' не заполнено.");
            if (!int.TryParse(input, out int value) || value <= 0)
                throw new ArgumentException($"'{paramName}' должно быть натуральным числом.");
            return value;
        }

        private double[] ParseArray(string input, string paramName, int expectedCount)
        {
            if (string.IsNullOrWhiteSpace(input))
                throw new FormatException($"Поле '{paramName}' не заполнено.");

            var parts = input.Split(new char[] { ',', ';', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            if (parts.Length < expectedCount)
                throw new ArgumentException($"Недостаточно элементов в '{paramName}'. Требуется не менее {expectedCount}.");

            double[] arr = new double[expectedCount];
            for (int i = 0; i < expectedCount; i++)
            {
                if (!double.TryParse(parts[i].Trim(), out arr[i]))
                    throw new FormatException($"Некорректное значение в '{paramName}' (элемент {i + 1}).");
            }
            return arr;
        }
    }
}