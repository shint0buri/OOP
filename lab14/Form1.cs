using System;
using System.Drawing;
using System.Windows.Forms;

namespace lab14
{
    public partial class Form1 : Form
    {
        private string currentMode = "sum"; 

        public Form1()
        {
            InitializeComponent();

           
            cbA.DropDownStyle = ComboBoxStyle.DropDownList;
            cbB.DropDownStyle = ComboBoxStyle.DropDownList;
            var values = new[] { "1", "2", "3", "4", "5" };
            cbA.Items.AddRange(values);
            cbB.Items.AddRange(values);
            cbA.SelectedIndex = 0;
            cbB.SelectedIndex = 0;
        }

        private void mnuCalc_Click(object sender, EventArgs e)
        {
            CalculateZ();
        }

        private void ctxCalc_Click(object sender, EventArgs e)
        {
            CalculateZ();
        }

        private void CalculateZ()
        {
            if (double.TryParse(txtX.Text, out double x) &&
                double.TryParse(txtY.Text, out double y) &&
                double.TryParse(txtZ.Text, out double z) &&
                double.TryParse(cbA.SelectedItem.ToString(), out double a) &&
                double.TryParse(cbB.SelectedItem.ToString(), out double b))
            {
                double result = a * x + b * y + Math.Sin(z);
                this.Text = $"Результат: Z = {result:F3}";
            }
            else
            {
                MessageBox.Show("Пожалуйста, введите корректные числовые значения.");
            }
        }

        private void mnuExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ctxExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tmiSum_Click(object sender, EventArgs e)
        {
            currentMode = "sum";
            UpdateStatus(MousePosition);
        }

        private void tmiDist_Click(object sender, EventArgs e)
        {
            currentMode = "dist";
            UpdateStatus(MousePosition);
        }

        private void UpdateStatus(Point screenPoint)
        {
            
            Point clientPoint = this.PointToClient(screenPoint);

            double x = clientPoint.X;
            double y = clientPoint.Y;

            string resultText;
            if (currentMode == "sum")
            {
                resultText = $"x + y = {x + y:F1}";
            }
            else
            {
                double dist = Math.Sqrt(x * x + y * y);
                resultText = $"√(x² + y²) = {dist:F2}";
            }

            statusLabel.Text = resultText;
        }

        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            UpdateStatus(e.Location);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}