namespace Lab12_Var16_Corrected
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

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtF = new System.Windows.Forms.TextBox();
            this.txtT = new System.Windows.Forms.TextBox();
            this.txtE = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "F:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "t:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "e (X):";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "w (Y):";
            // 
            // txtF
            // 
            this.txtF.Location = new System.Drawing.Point(69, 15);
            this.txtF.Name = "txtF";
            this.txtF.Size = new System.Drawing.Size(86, 20);
            this.txtF.TabIndex = 0;

            // 
            // txtT
            // 
            this.txtT.Location = new System.Drawing.Point(69, 41);
            this.txtT.Name = "txtT";
            this.txtT.Size = new System.Drawing.Size(86, 20);
            this.txtT.TabIndex = 1;
            // 
            // txtE
            // 
            this.txtE.Location = new System.Drawing.Point(69, 67);
            this.txtE.Name = "txtE";
            this.txtE.ReadOnly = true;
            this.txtE.Size = new System.Drawing.Size(86, 20);
            this.txtE.TabIndex = 2;
            // 
            // txtW
            // 
            this.txtW.Location = new System.Drawing.Point(69, 93);
            this.txtW.Name = "txtW";
            this.txtW.ReadOnly = true;
            this.txtW.Size = new System.Drawing.Size(86, 20);
            this.txtW.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(171, 130);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.txtE);
            this.Controls.Add(this.txtT);
            this.Controls.Add(this.txtF);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Лабораторная работа №12 — Вариант 16 (Исправлено)";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtF;
        private System.Windows.Forms.TextBox txtT;
        private System.Windows.Forms.TextBox txtE;
        private System.Windows.Forms.TextBox txtW;
    }
}