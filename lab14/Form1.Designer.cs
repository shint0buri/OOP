namespace lab14
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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.вычисленияToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cbA = new System.Windows.Forms.ToolStripComboBox();
            this.cbB = new System.Windows.Forms.ToolStripComboBox();
            this.txtX = new System.Windows.Forms.ToolStripTextBox();
            this.txtY = new System.Windows.Forms.ToolStripTextBox();
            this.txtZ = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.mnuCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuExit = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.ctxCalc = new System.Windows.Forms.ToolStripMenuItem();
            this.ctxExit = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ddExpr = new System.Windows.Forms.ToolStripDropDownButton();
            this.tmiSum = new System.Windows.Forms.ToolStripMenuItem();
            this.tmiDist = new System.Windows.Forms.ToolStripMenuItem();
            this.statusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.вычисленияToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // вычисленияToolStripMenuItem
            // 
            this.вычисленияToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cbA,
            this.cbB,
            this.txtX,
            this.txtY,
            this.txtZ,
            this.toolStripSeparator1,
            this.mnuCalc,
            this.mnuExit});
            this.вычисленияToolStripMenuItem.Name = "вычисленияToolStripMenuItem";
            this.вычисленияToolStripMenuItem.Size = new System.Drawing.Size(88, 20);
            this.вычисленияToolStripMenuItem.Text = "Вычисления";
            // 
            // cbA
            // 
            this.cbA.Name = "cbA";
            this.cbA.Size = new System.Drawing.Size(121, 23);
            // 
            // cbB
            // 
            this.cbB.Name = "cbB";
            this.cbB.Size = new System.Drawing.Size(121, 23);
            // 
            // txtX
            // 
            this.txtX.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtX.Name = "txtX";
            this.txtX.Size = new System.Drawing.Size(100, 23);
            this.txtX.Text = "0";
            // 
            // txtY
            // 
            this.txtY.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtY.Name = "txtY";
            this.txtY.Size = new System.Drawing.Size(100, 23);
            this.txtY.Text = "0";
            // 
            // txtZ
            // 
            this.txtZ.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtZ.Name = "txtZ";
            this.txtZ.Size = new System.Drawing.Size(100, 23);
            this.txtZ.Text = "0";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(178, 6);
            // 
            // mnuCalc
            // 
            this.mnuCalc.Name = "mnuCalc";
            this.mnuCalc.Size = new System.Drawing.Size(181, 22);
            this.mnuCalc.Text = "Рассчитать Z";
            this.mnuCalc.Click += new System.EventHandler(this.mnuCalc_Click);
            // 
            // mnuExit
            // 
            this.mnuExit.Name = "mnuExit";
            this.mnuExit.Size = new System.Drawing.Size(181, 22);
            this.mnuExit.Text = "Выход";
            this.mnuExit.Click += new System.EventHandler(this.mnuExit_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxCalc,
            this.ctxExit});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(146, 48);
            // 
            // ctxCalc
            // 
            this.ctxCalc.Name = "ctxCalc";
            this.ctxCalc.Size = new System.Drawing.Size(145, 22);
            this.ctxCalc.Text = "Рассчитать Z";
            this.ctxCalc.Click += new System.EventHandler(this.ctxCalc_Click);
            // 
            // ctxExit
            // 
            this.ctxExit.Name = "ctxExit";
            this.ctxExit.Size = new System.Drawing.Size(145, 22);
            this.ctxExit.Text = "Выход";
            this.ctxExit.Click += new System.EventHandler(this.ctxExit_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ddExpr,
            this.statusLabel});
            this.statusStrip1.Location = new System.Drawing.Point(0, 330);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(600, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ddExpr
            // 
            this.ddExpr.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ddExpr.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmiSum,
            this.tmiDist});
            this.ddExpr.Name = "ddExpr";
            this.ddExpr.Size = new System.Drawing.Size(123, 20);
            this.ddExpr.Text = "Выбор выражения";
            // 
            // tmiSum
            // 
            this.tmiSum.Name = "tmiSum";
            this.tmiSum.Size = new System.Drawing.Size(124, 22);
            this.tmiSum.Text = "x + y";
            this.tmiSum.Click += new System.EventHandler(this.tmiSum_Click);
            // 
            // tmiDist
            // 
            this.tmiDist.Name = "tmiDist";
            this.tmiDist.Size = new System.Drawing.Size(124, 22);
            this.tmiDist.Text = "√(x² + y²)";
            this.tmiDist.Click += new System.EventHandler(this.tmiDist_Click);
            // 
            // statusLabel
            // 
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(462, 17);
            this.statusLabel.Spring = true;
            this.statusLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 352);
            this.ContextMenuStrip = this.contextMenuStrip1;
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Лабораторная работа №14 — Вариант 16";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem вычисленияToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox cbA;
        private System.Windows.Forms.ToolStripComboBox cbB;
        private System.Windows.Forms.ToolStripTextBox txtX;
        private System.Windows.Forms.ToolStripTextBox txtY;
        private System.Windows.Forms.ToolStripTextBox txtZ;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem mnuCalc;
        private System.Windows.Forms.ToolStripMenuItem mnuExit;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ctxCalc;
        private System.Windows.Forms.ToolStripMenuItem ctxExit;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripDropDownButton ddExpr;
        private System.Windows.Forms.ToolStripMenuItem tmiSum;
        private System.Windows.Forms.ToolStripMenuItem tmiDist;
        private System.Windows.Forms.ToolStripStatusLabel statusLabel;
    }
}