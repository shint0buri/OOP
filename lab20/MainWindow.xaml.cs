using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Media;

namespace lab20
{
    
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        private string _dynamicText = "Динамическая привязка работает!";
        public string DynamicText
        {
            get => _dynamicText;
            set
            {
                _dynamicText = value;
                OnPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string? propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public MainWindow()
        {
            InitializeComponent();
           
            DataContext = this;
        }

        private void BtnDynamic_Click(object sender, RoutedEventArgs e)
        {
          
            Binding binding = new Binding("DynamicText")
            {
                Mode = BindingMode.OneWay,
                Source = this
            };
            lblDynamic.SetBinding(TextBlock.TextProperty, binding);
        }

        private void BtnSetFont_Click(object sender, RoutedEventArgs e)
        {
         
            cmbFonts.SelectedItem = new ComboBoxItem { Content = "Courier New" };
        }
    }
}