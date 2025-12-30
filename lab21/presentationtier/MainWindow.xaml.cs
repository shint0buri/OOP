using System.Windows;
using System.IO;

namespace presentationtier
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // Имя вашего файла — data1.txt!
            string dataPath = "data1.txt";

            // Проверяем, существует ли файл
            if (!File.Exists(dataPath))
            {
                MessageBox.Show(
                    $"Файл '{dataPath}' не найден в папке приложения.\n" +
                    $"Путь: {Path.GetFullPath(dataPath)}",
                    "Ошибка",
                    MessageBoxButton.OK,
                    MessageBoxImage.Error);
                return;
            }

            DataContext = new LogicTier.ShopService(dataPath);
        }
    }
}