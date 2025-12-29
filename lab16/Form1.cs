using System;
using System.Windows.Forms;

namespace lab16
{
    public partial class Form1 : Form
    {
        private DataStorage _dataStorage;

        public Form1()
        {
            InitializeComponent();
          
            openFileDlg.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
            openFileDlg.Title = "Выберите файл данных";
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            if (openFileDlg.ShowDialog() == DialogResult.OK)
            {
                _dataStorage = new DataStorage();
                if (_dataStorage.InitData(openFileDlg.FileName))
                {
                    _dataStorage.BuildSummary();
                    dgvRaw.DataSource = _dataStorage.GetRawData();
                    dgvSummary.DataSource = _dataStorage.GetSummaryData();

                    dgvRaw.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                    dgvSummary.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
                }
                else
                {
                    MessageBox.Show("Не удалось загрузить данные. Проверьте формат файла.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}