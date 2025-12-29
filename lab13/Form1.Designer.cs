using System;
using System.Drawing;
using System.Windows.Forms;

namespace Lab13_Var16
{
    public partial class MainForm : Form
    {
        // Элементы управления
        private GroupBox groupBox1;
        private RadioButton radioSeries;
        private RadioButton radioDoubleSum;
        private Label label1;
        private TextBox txtX;
        private Label label2;
        private TextBox txtA;
        private Label label3;
        private TextBox txtB;
        private Label label4;
        private TextBox txtN;
        private Label label5;
        private TextBox txtR;
        private Button btnCalculate;
        private Button btnClear;
        private Label lblResult;

        public MainForm()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.groupBox1 = new GroupBox();
            this.radioSeries = new RadioButton();
            this.radioDoubleSum = new RadioButton();
            this.label1 = new Label();
            this.txtX = new TextBox();
            this.label2 = new Label();
            this.txtA = new TextBox();
            this.label3 = new Label();
            this.txtB = new TextBox();
            this.label4 = new Label();
            this.txtN = new TextBox();
            this.label5 = new Label();
            this.txtR = new TextBox();
            this.btnCalculate = new Button();
            this.btnClear = new Button();
            this.lblResult = new Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();


            this.groupBox1.Controls.Add(this.radioSeries);
            this.groupBox1.Controls.Add(this.radioDoubleSum);
            this.groupBox1.Location = new Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new Size(200, 80);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Выбор формулы";

           
            this.radioSeries.AutoSize = true;
            this.radioSeries.Location = new Point(6, 22);
            this.radioSeries.Name = "radioSeries";
            this.radioSeries.Size = new Size(54, 19);
            this.radioSeries.TabIndex = 0;
            this.radioSeries.Text = "Ряд";
            this.radioSeries.UseVisualStyleBackColor = true;
            this.radioSeries.Checked = true;

           
            this.radioDoubleSum.AutoSize = true;
            this.radioDoubleSum.Location = new Point(6, 47);
            this.radioDoubleSum.Name = "radioDoubleSum";
            this.radioDoubleSum.Size = new Size(112, 19);
            this.radioDoubleSum.TabIndex = 1;
            this.radioDoubleSum.Text = "Двойная сумма";
            this.radioDoubleSum.UseVisualStyleBackColor = true;

           
            this.label1.AutoSize = true;
            this.label1.Location = new Point(12, 100);
            this.label1.Name = "label1";
            this.label1.Size = new Size(20, 15);
            this.label1.Text = "X:";

            
            this.txtX.Location = new Point(100, 97);
            this.txtX.Name = "txtX";
            this.txtX.Size = new Size(100, 23);
            this.txtX.TabIndex = 2;

          
            this.label2.AutoSize = true;
            this.label2.Location = new Point(12, 130);
            this.label2.Name = "label2";
            this.label2.Size = new Size(120, 15);
            this.label2.Text = "a_i (через запятую):";

            
            this.txtA.Location = new Point(100, 127);
            this.txtA.Name = "txtA";
            this.txtA.Size = new Size(200, 23);
            this.txtA.Text = "1,2,3";
            this.txtA.TabIndex = 3;

          
            this.label3.AutoSize = true;
            this.label3.Location = new Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new Size(120, 15);
            this.label3.Text = "b_j (через запятую):";

            
            this.txtB.Location = new Point(100, 157);
            this.txtB.Name = "txtB";
            this.txtB.Size = new Size(200, 23);
            this.txtB.Text = "1,1";
            this.txtB.TabIndex = 4;

            
            this.label4.AutoSize = true;
            this.label4.Location = new Point(12, 190);
            this.label4.Name = "label4";
            this.label4.Size = new Size(21, 15);
            this.label4.Text = "N:";

            
            this.txtN.Location = new Point(100, 187);
            this.txtN.Name = "txtN";
            this.txtN.Size = new Size(50, 23);
            this.txtN.Text = "3";
            this.txtN.TabIndex = 5;


            this.label5.AutoSize = true;
            this.label5.Location = new Point(12, 220);
            this.label5.Name = "label5";
            this.label5.Size = new Size(20, 15);
            this.label5.Text = "R:";

            
            this.txtR.Location = new Point(100, 217);
            this.txtR.Name = "txtR";
            this.txtR.Size = new Size(50, 23);
            this.txtR.Text = "2";
            this.txtR.TabIndex = 6;

         
            this.btnCalculate.Location = new Point(12, 250);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new Size(100, 30);
            this.btnCalculate.TabIndex = 7;
            this.btnCalculate.Text = "Рассчитать";
            this.btnCalculate.UseVisualStyleBackColor = true;

          
            this.btnClear.Location = new Point(120, 250);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new Size(100, 30);
            this.btnClear.TabIndex = 8;
            this.btnClear.Text = "Очистить";
            this.btnClear.UseVisualStyleBackColor = true;

          
            this.lblResult.AutoSize = true;
            this.lblResult.Font = new Font("Segoe UI", 10, FontStyle.Bold);
            this.lblResult.Location = new Point(12, 290);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new Size(0, 19);
            this.lblResult.TabIndex = 9;

            
            this.ClientSize = new Size(320, 330);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtA);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Лабораторная работа №13 — Вариант 16";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}