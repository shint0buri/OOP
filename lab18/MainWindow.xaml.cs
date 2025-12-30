using System;
using System.Windows;
using System.Windows.Controls;

namespace lab18 // Убедитесь, что здесь указано правильное имя вашего проекта
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void txtN_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateArrayInputs(spX, txtN.Text);
        }

        private void txtK_TextChanged(object sender, TextChangedEventArgs e)
        {
            UpdateArrayInputs(spY, txtK.Text);
        }

        // Метод для создания полей ввода массива
        private void UpdateArrayInputs(StackPanel panel, string countText)
        {
            panel.Children.Clear(); // Очищаем старые поля

            if (int.TryParse(countText, out int count) && count > 0)
            {
                for (int i = 0; i < count; i++)
                {
                    var label = new Label { Content = $"Элемент {i + 1}:", Margin = new Thickness(0, 0, 10, 0) };
                    var textBox = new TextBox { Name = $"tb_{panel.Name}_{i}", Width = 80, Margin = new Thickness(0, 5, 0, 5) };

                    var sp = new StackPanel { Orientation = Orientation.Horizontal, Margin = new Thickness(0, 2, 0, 2) };
                    sp.Children.Add(label);
                    sp.Children.Add(textBox);

                    panel.Children.Add(sp);
                }
            }
        }

        // Метод для получения массива из StackPanel
        private double[] GetArrayFromPanel(StackPanel panel, int expectedCount)
        {
            var result = new double[expectedCount];
            for (int i = 0; i < expectedCount; i++)
            {
                var sp = panel.Children[i] as StackPanel;
                var textBox = sp.Children[1] as TextBox;

                if (!double.TryParse(textBox.Text, out result[i]))
                {
                    throw new FormatException($"Неверный формат числа в элементе {i + 1}.");
                }
            }
            return result;
        }

        private void btnCalculate_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                // Считываем параметры
                if (!double.TryParse(txtA.Text, out double a))
                    throw new FormatException("Параметр 'a' должен быть числом.");
                if (!double.TryParse(txtF.Text, out double f))
                    throw new FormatException("Параметр 'f' должен быть числом.");
                if (!int.TryParse(txtN.Text, out int N) || N <= 0)
                    throw new FormatException("N должно быть положительным целым числом.");
                if (!int.TryParse(txtK.Text, out int K) || K <= 0)
                    throw new FormatException("K должно быть положительным целым числом.");

                // Проверяем, что количество полей соответствует N и K
                if (spX.Children.Count != N || spY.Children.Count != K)
                    throw new InvalidOperationException("Количество полей ввода не соответствует заданным N и K.");

                // Получаем массивы x и y
                double[] x = GetArrayFromPanel(spX, N);
                double[] y = GetArrayFromPanel(spY, K);

                // Вычисляем Z по формуле
                double Z = 0.0;
                for (int i = 1; i <= N; i++)
                {
                    for (int j = 1; j <= K; j++)
                    {
                        double numerator = Math.Pow(a, i - 1) * x[i - 1] + f * y[j - 1];
                        double denominator = (i + 1) * j;
                        if (denominator == 0)
                            throw new DivideByZeroException("Деление на ноль в формуле.");
                        Z += numerator / denominator;
                    }
                }

                // Выводим результат в заголовок окна
                this.Title = $"Результат Z = {Z:F6}";

                // Дополнительно выводим сообщение
                MessageBox.Show($"Вычисление завершено!\n\nZ = {Z:F6}", "Успех", MessageBoxButton.OK, MessageBoxImage.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}