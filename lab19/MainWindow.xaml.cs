using System;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;

namespace lab19
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGenerate_Click(object sender, RoutedEventArgs e)
        {
            // очистка холста
            DrawingCanvas.Children.Clear();

            // Чтение количества фигур
            if (!int.TryParse(txtCount.Text, out int n) || n <= 0)
            {
                MessageBox.Show("Введите корректное положительное число.", "Ошибка", MessageBoxButton.OK, MessageBoxImage.Warning);
                return;
            }

            Random rand = new Random();
            string[] styleKeys = { "BlueGradientStyle", "RedShadow стиль", "YellowDashedStyle", "GreenSolidStyle" };
            styleKeys = new[] { "BlueGradientStyle", "RedShadowStyle", "YellowDashedStyle", "GreenSolidStyle" };

            for (int i = 0; i < n; i++)
            {
                // Случайный выбор фигуры
                Shape shape = rand.Next(2) == 0 ? (Shape)new Ellipse() : new Rectangle();

                // Случайные размеры
                double width = rand.Next(30, 100);
                double height = rand.Next(30, 100);

                // Случайная позиция на холсте
                double x = rand.Next(0, (int)(DrawingCanvas.ActualWidth - width));
                double y = rand.Next(0, (int)(DrawingCanvas.ActualHeight - height));

                shape.Width = width;
                shape.Height = height;
                Canvas.SetLeft(shape, x);
                Canvas.SetTop(shape, y);

                // Применение случайного стиля
                string styleKey = styleKeys[rand.Next(styleKeys.Length)];
                shape.Style = (Style)FindResource(styleKey);

                // Добавление на холст
                DrawingCanvas.Children.Add(shape);
            }
        }
    }
}