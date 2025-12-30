using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace lab17
{
    public partial class Form1 : Form
    {
        private Color fillColor = Color.LightBlue;
        private bool isDraggingLabel = false;
        private Point dragOffset;
        private PointF labelPositionX = new PointF(200, 450); // Подпись оси X
        private PointF labelPositionY = new PointF(50, 200);   // Подпись оси Y
        private float fontSize = 12f;
        private bool animate = false;

        // Координаты центра окружностей (лежит на оси X)
        private Point origin = new Point(300, 300); // Центр окружностей на оси X

        public Form1()
        {
            InitializeComponent();
            // Включаем двойную буферизацию
            SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }

        private void canvasPanel_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.SmoothingMode = SmoothingMode.AntiAlias;

            // Рисуем координатные оси
            using (Pen axisPen = new Pen(Color.Black, 2))
            {
                // Ось X (проходит через центр окружностей)
                g.DrawLine(axisPen, 0, origin.Y, canvasPanel.Width, origin.Y);
                // Ось Y (проходит через центр самой большой окружности)
                g.DrawLine(axisPen, origin.X, 0, origin.X, canvasPanel.Height);
            }

            // Рисуем стрелки на осях
            using (Pen arrowPen = new Pen(Color.Black, 2))
            {
                // Стрелка на оси X (правая)
                Point[] arrowX = {
                    new Point(canvasPanel.Width - 10, origin.Y - 5),
                    new Point(canvasPanel.Width, origin.Y),
                    new Point(canvasPanel.Width - 10, origin.Y + 5)
                };
                g.DrawPolygon(arrowPen, arrowX);

                // Стрелка на оси Y (верхняя)
                Point[] arrowY = {
                    new Point(origin.X - 5, 10),
                    new Point(origin.X, 0),
                    new Point(origin.X + 5, 10)
                };
                g.DrawPolygon(arrowPen, arrowY);
            }

            // Рисуем три концентрические окружности (радиусы 1, 2, 3)
            int scale = 50; // Масштаб: 1 единица = 50 пикселей
            int radius1 = 1 * scale;
            int radius2 = 2 * scale;
            int radius3 = 3 * scale;

            using (Pen circlePen = new Pen(Color.Gray, 1))
            {
                g.DrawEllipse(circlePen, origin.X - radius1, origin.Y - radius1, 2 * radius1, 2 * radius1);
                g.DrawEllipse(circlePen, origin.X - radius2, origin.Y - radius2, 2 * radius2, 2 * radius2);
                g.DrawEllipse(circlePen, origin.X - radius3, origin.Y - radius3, 2 * radius3, 2 * radius3);
            }

            // Заливаем область между радиусами 1 и 2 в первом квадранте
            using (GraphicsPath path = new GraphicsPath())
            {
                // Начинаем в точке (1, 0) -> (radius1, 0)
                path.AddLine(
                    origin.X + radius1, origin.Y,
                    origin.X + radius2, origin.Y
                );

                // Добавляем дугу от 0 до 90 градусов (четверть окружности)
                path.AddArc(
                    origin.X - radius2, origin.Y - radius2,
                    2 * radius2, 2 * radius2,
                    0, 90
                );

                // Возвращаемся к началу по радиусу 1
                path.AddLine(
                    origin.X, origin.Y - radius2,
                    origin.X, origin.Y - radius1
                );

                // Добавляем дугу обратно по радиусу 1
                path.AddArc(
                    origin.X - radius1, origin.Y - radius1,
                    2 * radius1, 2 * radius1,
                    90, -90
                );

                // Замыкаем путь
                path.CloseFigure();

                // Заливаем путь
                using (Brush brush = new SolidBrush(fillColor))
                {
                    g.FillPath(brush, path);
                }
            }

            // Рисуем подписи осей
            using (Font labelFont = new Font("Arial", fontSize, FontStyle.Bold))
            {
                g.DrawString("x", labelFont, Brushes.Black, labelPositionX);
                g.DrawString("y", labelFont, Brushes.Black, labelPositionY);
            }

            // Рисуем метки на осях
            using (Font tickFont = new Font("Arial", 8, FontStyle.Regular))
            {
                // Метки на оси X
                for (int i = 1; i <= 3; i++)
                {
                    int x = origin.X + i * scale;
                    g.DrawLine(Pens.Black, x, origin.Y - 5, x, origin.Y + 5);
                    g.DrawString(i.ToString(), tickFont, Brushes.Black, x - 5, origin.Y + 10);
                }

                // Метки на оси Y
                for (int i = 1; i <= 3; i++)
                {
                    int y = origin.Y - i * scale;
                    g.DrawLine(Pens.Black, origin.X - 5, y, origin.X + 5, y);
                    g.DrawString(i.ToString(), tickFont, Brushes.Black, origin.X + 10, y - 5);
                }
            }
        }

        private void canvasPanel_MouseMove(object sender, MouseEventArgs e)
        {
            // Проверяем, находится ли курсор в заштрихованной области
            int scale = 50;
            int radius1 = 1 * scale;
            int radius2 = 2 * scale;

            // Преобразуем координаты мыши в систему координат с центром в `origin`
            int dx = e.X - origin.X;
            int dy = e.Y - origin.Y;

            // Условие: точка должна быть в первом квадранте (dx > 0, dy < 0) и между радиусами 1 и 2
            bool inRegion = (dx > 0 && dy < 0) &&
                            (dx * dx + dy * dy >= radius1 * radius1) &&
                            (dx * dx + dy * dy <= radius2 * radius2);

            fillColor = inRegion ? Color.Orange : Color.LightBlue;

            canvasPanel.Invalidate();
        }

        private void btnSelectColor_Click(object sender, EventArgs e)
        {
            using (ColorDialog cd = new ColorDialog())
            {
                if (cd.ShowDialog() == DialogResult.OK)
                    fillColor = cd.Color;
            }
            canvasPanel.Invalidate();
        }

        private void canvasPanel_MouseDown(object sender, MouseEventArgs e)
        {
            // Проверяем, попал ли курсор в область подписи оси X
            using (Font font = new Font("Arial", fontSize, FontStyle.Bold))
            {
                SizeF sizeX = TextRenderer.MeasureText("x", font);
                RectangleF labelRectX = new RectangleF(labelPositionX, sizeX);
                if (labelRectX.Contains(e.Location))
                {
                    isDraggingLabel = true;
                    dragOffset = new Point(e.X - (int)labelPositionX.X, e.Y - (int)labelPositionX.Y);
                    return;
                }

                // Проверяем, попал ли курсор в область подписи оси Y
                SizeF sizeY = TextRenderer.MeasureText("y", font);
                RectangleF labelRectY = new RectangleF(labelPositionY, sizeY);
                if (labelRectY.Contains(e.Location))
                {
                    isDraggingLabel = true;
                    dragOffset = new Point(e.X - (int)labelPositionY.X, e.Y - (int)labelPositionY.Y);
                    return;
                }
            }
        }

        private void canvasPanel_MouseUp(object sender, MouseEventArgs e)
        {
            isDraggingLabel = false;
        }

        private void canvasPanel_MouseMoveDragging(object sender, MouseEventArgs e)
        {
            if (isDraggingLabel)
            {
                // Определяем, какую подпись перетаскиваем
                using (Font font = new Font("Arial", fontSize, FontStyle.Bold))
                {
                    SizeF sizeX = TextRenderer.MeasureText("x", font);
                    RectangleF labelRectX = new RectangleF(labelPositionX, sizeX);
                    if (labelRectX.Contains(new PointF(e.X - dragOffset.X, e.Y - dragOffset.Y)))
                    {
                        labelPositionX = new PointF(e.X - dragOffset.X, e.Y - dragOffset.Y);
                    }

                    SizeF sizeY = TextRenderer.MeasureText("y", font);
                    RectangleF labelRectY = new RectangleF(labelPositionY, sizeY);
                    if (labelRectY.Contains(new PointF(e.X - dragOffset.X, e.Y - dragOffset.Y)))
                    {
                        labelPositionY = new PointF(e.X - dragOffset.X, e.Y - dragOffset.Y);
                    }
                }

                canvasPanel.Invalidate();
            }
        }

        private void chkAnimate_CheckedChanged(object sender, EventArgs e)
        {
            animate = chkAnimate.Checked;
            animationTimer.Enabled = animate;
        }

        private void animationTimer_Tick(object sender, EventArgs e)
        {
            if (animate)
            {
                fontSize = 10f + 4f * (float)Math.Sin(DateTime.Now.Millisecond / 100.0);
                canvasPanel.Invalidate();
            }
        }
    }
}