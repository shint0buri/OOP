using System;
using System.IO;
using System.Windows.Forms;

namespace lab15
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private double CalculateSeries(double x, double y, int n)
        {
            if (n <= 0)
                throw new ArgumentException("Количество слагаемых должно быть > 0");

            double result = 0.0;
            for (int i = 2; i <= n + 1; i++)
            {
                double power = Math.Pow(i % 2 == 0 ? x : y, i);
                double denom = i * (i + 1);
                double term = power / denom;

                if (i % 2 == 0)
                    result -= term; 
                else
                    result += term; 
            }
            return result;
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            try
            {
                double x = double.Parse(txtX.Text);
                double y = double.Parse(txtY.Text);
                int n = int.Parse(txtN.Text);

                double f = CalculateSeries(x, y, n);
                lblResult.Text = $"Результат: {f:F6}";
                lblResult.ForeColor = System.Drawing.Color.Black;
            }
            catch (FormatException)
            {
                errorProvider.SetError(txtX, "Введите число");
                errorProvider.SetError(txtY, "Введите число");
                errorProvider.SetError(txtN, "Введите целое число");
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show(ex.Message, "Ошибка ввода", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Произошла ошибка:\n" + ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        string[] lines = File.ReadAllLines(ofd.FileName);
                        if (lines.Length < 3)
                            throw new Exception("Файл должен содержать минимум 3 строки: x, y, n");

                        txtX.Text = lines[0].Trim();
                        txtY.Text = lines[1].Trim();
                        txtN.Text = lines[2].Trim();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка чтения файла:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog())
            {
                sfd.Filter = "Текстовые файлы (*.txt)|*.txt|Все файлы (*.*)|*.*";
                sfd.FileName = "result.txt";

                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        double x = double.Parse(txtX.Text);
                        double y = double.Parse(txtY.Text);
                        int n = int.Parse(txtN.Text);
                        double f = CalculateSeries(x, y, n);

                        string content = $"x = {x}\ny = {y}\nN = {n}\nF = {f:F6}";
                        File.WriteAllText(sfd.FileName, content);
                        MessageBox.Show("Результат сохранён!", "Успех", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Ошибка сохранения:\n{ex.Message}", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void btnChooseColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                {
                    lblResult.BackColor = cd.Color;
                }
            }
        }
    }
}