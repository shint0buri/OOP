using System;
using System.Windows.Forms;

namespace Lab12_Var16_Corrected
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.MouseMove += Form1_MouseMove;

            // Подключаем обработчик TextChanged к txtF
            this.txtF.TextChanged += txtF_TextChanged;
            // Можно подключить и к txtT, если нужно
            this.txtT.TextChanged += txtT_TextChanged;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            double e_val = e.X;
            double w_val = e.Y;

            txtE.Text = e_val.ToString("F0");
            txtW.Text = w_val.ToString("F0");

            CalculateResult(); // Вызываем пересчет
        }

        private void txtF_TextChanged(object sender, EventArgs e)
        {
            CalculateResult(); // Вызываем пересчет
        }

        private void txtT_TextChanged(object sender, EventArgs e)
        {
            CalculateResult(); // Вызываем пересчет
        }

        private void CalculateResult()
        {
            if (!double.TryParse(txtF.Text, out double F_val) ||
                !double.TryParse(txtT.Text, out double t_val))
            {
                this.Text = "ERROR";
                return;
            }

            try
            {
                double e_val = double.Parse(txtE.Text); // Берем значение из поля
                double w_val = double.Parse(txtW.Text); // Берем значение из поля

                double cos_w = Math.Cos(w_val);
                double sin_w_t = Math.Sin(w_val / t_val);
                double sqrt_abs_e = Math.Sqrt(Math.Abs(e_val));

                if (Math.Abs(cos_w) < 1e-10 || Math.Abs(e_val) < 1e-10)
                {
                    throw new DivideByZeroException();
                }

                double res = F_val / cos_w - e_val + Math.Abs(sin_w_t + sqrt_abs_e) / e_val;

                this.Text = $"Результат: {res:F4}";
            }
            catch (Exception)
            {
                this.Text = "ERROR";
            }
        }
    }
}