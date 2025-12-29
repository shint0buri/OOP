using System.Windows.Forms;

namespace lab15
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        private void InitializeComponent()
        {
            this.lblX = new System.Windows.Forms.Label();
            this.txtX = new System.Windows.Forms.TextBox();
            this.lblY = new System.Windows.Forms.Label();
            this.txtY = new System.Windows.Forms.TextBox();
            this.lblN = new System.Windows.Forms.Label();
            this.txtN = new System.Windows.Forms.TextBox();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.btnLoad = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnChooseColor = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();

            // lblX
            this.lblX.AutoSize = true;
            this.lblX.Location = new System.Drawing.Point(12, 15);
            this.lblX.Name = "lblX";
            this.lblX.Size = new System.Drawing.Size(20, 15);
            this.lblX.Text = "X =";

            // txtX
            this.txtX.Location = new System.Drawing.Point(40, 12);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 23);
            this.txtX.TabIndex = 0;

            // lblY
            this.lblY.AutoSize = true;
            this.lblY.Location = new System.Drawing.Point(150, 15);
            this.lblY.Name = "lblY";
            this.lblY.Size = new System.Drawing.Size(20, 15);
            this.lblY.Text = "Y =";

            // txtY
            this.txtY.Location = new System.Drawing.Point(180, 12);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 23);
            this.txtY.TabIndex = 1;

            // lblN
            this.lblN.AutoSize = true;
            this.lblN.Location = new System.Drawing.Point(290, 15);
            this.lblN.Name = "lblN";
            this.lblN.Size = new System.Drawing.Size(135, 15);
            this.lblN.Text = "Количество слагаемых:";

            // txtN
            this.txtN.Location = new System.Drawing.Point(430, 12);
            this.txtN.Name = "txtN";
            this.txtN.Size = new System.Drawing.Size(60, 23);
            this.txtN.TabIndex = 2;

            // btnCalculate
            this.btnCalculate.Location = new System.Drawing.Point(12, 50);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(100, 30);
            this.btnCalculate.TabIndex = 3;
            this.btnCalculate.Text = "Вычислить";
            this.btnCalculate.UseVisualStyleBackColor = true;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);

            // lblResult
            this.lblResult.AutoSize = true;
            this.lblResult.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblResult.Location = new System.Drawing.Point(12, 90);
            this.lblResult.MinimumSize = new System.Drawing.Size(480, 30);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(480, 30);
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

            // btnLoad
            this.btnLoad.Location = new System.Drawing.Point(120, 50);
            this.btnLoad.Name = "btnLoad";
            this.btnLoad.Size = new System.Drawing.Size(140, 30);
            this.btnLoad.TabIndex = 4;
            this.btnLoad.Text = "Загрузить из файла...";
            this.btnLoad.UseVisualStyleBackColor = true;
            this.btnLoad.Click += new System.EventHandler(this.btnLoad_Click);

            // btnSave
            this.btnSave.Location = new System.Drawing.Point(270, 50);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(140, 30);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Сохранить результат...";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);

            // btnChooseColor
            this.btnChooseColor.Location = new System.Drawing.Point(420, 50);
            this.btnChooseColor.Name = "btnChooseColor";
            this.btnChooseColor.Size = new System.Drawing.Size(160, 30);
            this.btnChooseColor.TabIndex = 6;
            this.btnChooseColor.Text = "Выбрать цвет результата";
            this.btnChooseColor.UseVisualStyleBackColor = true;
            this.btnChooseColor.Click += new System.EventHandler(this.btnChooseColor_Click);

            // errorProvider
            this.errorProvider.ContainerControl = this;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(590, 130);
            this.Controls.Add(this.btnChooseColor);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnLoad);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.txtN);
            this.Controls.Add(this.lblN);
            this.Controls.Add(this.txtY);
            this.Controls.Add(this.lblY);
            this.Controls.Add(this.txtX);
            this.Controls.Add(this.lblX);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №15 — Вариант 16";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private Label lblX;
        private TextBox txtX;
        private Label lblY;
        private TextBox txtY;
        private Label lblN;
        private TextBox txtN;
        private Button btnCalculate;
        private Label lblResult;
        private Button btnLoad;
        private Button btnSave;
        private Button btnChooseColor;
        private ErrorProvider errorProvider;
    }
}