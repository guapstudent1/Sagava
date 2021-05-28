using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SagavaAnime
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private int[,] matrix_Mul(int[,] a, int[,] b)
        {
            // перемножение двух матриц
            int[,] res = new int[4, 4]{
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 },
                { 0, 0, 0, 0 }
            }; 
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    res[i, j] = 0;
                    for (int k = 0; k < 4; k++)
                    {
                        res[i, j] += a[i, k] * b[k, j];
                    }
                }
            }
            return res;
        }
        private void matrix_Draw(int[,] m)
        {
            Graphics graphics = pictureBox1.CreateGraphics();

            Pen pen = new Pen(Color.BlueViolet, 2);

            // Рациональную матрицу удобно отображать в виде
            // окружностей разного диаметра
            
            int k = 2;
            int r = m[0,0] * k;
            graphics.DrawEllipse(pen, 20 - r, 20 - r, 40 + 2 * r, 40 + 2 * r);
            r = m[0,1] * k;
            graphics.DrawEllipse(pen, 100 - r, 20 - r, 40 + 2 * r, 40 + 2 * r);
            r = m[0,2] * k;
            graphics.DrawEllipse(pen, 180 - r, 20 - r, 40 + 2 * r, 40 + 2 * r);
            r = m[0,3] * k;
            graphics.DrawEllipse(pen, 260 - r, 20 - r, 40 + 2 * r, 40 + 2 * r);


            r = m[1,0] * k;
            graphics.DrawEllipse(pen, 20 - r, 100 - r, 40 + 2 * r, 40 + 2 * r);
            r = m[1,1] * k;
            graphics.DrawEllipse(pen, 100 - r, 100 - r, 40 + 2 * r, 40 + 2 * r);
            r = m[1,2] * k;
            graphics.DrawEllipse(pen, 180 - r, 100 - r, 40 + 2 * r, 40 + 2 * r);
            r = m[1,3] * k;
            graphics.DrawEllipse(pen, 260 - r, 100 - r, 40 + 2 * r, 40 + 2 * r);


            r = m[2,0] * k;
            graphics.DrawEllipse(pen, 20 - r, 180 - r, 40 + 2 * r, 40 + 2 * r);
            r = m[2,1] * k;
            graphics.DrawEllipse(pen, 100 - r, 180 - r, 40 + 2 * r, 40 + 2 * r);
            r = m[2,2] * k;
            graphics.DrawEllipse(pen, 180 - r, 180 - r, 40 + 2 * r, 40 + 2 * r);
            r = m[2,3] * k;
            graphics.DrawEllipse(pen, 260 - r, 180 - r, 40 + 2 * r, 40 + 2 * r);

            r = m[3,0] * k;
            graphics.DrawEllipse(pen, 20 - r, 260 - r, 40 + 2 * r, 40 + 2 * r);
            r = m[3,1] * k;
            graphics.DrawEllipse(pen, 100 - r, 260 - r, 40 + 2 * r, 40 + 2 * r);
            r = m[3,2] * k;
            graphics.DrawEllipse(pen, 180 - r, 260 - r, 40 + 2 * r, 40 + 2 * r);
            r = m[3,3] * k;
            graphics.DrawEllipse(pen, 260 - r, 260 - r, 40 + 2 * r, 40 + 2 * r);

            Brush brush = new SolidBrush(Color.BlueViolet);
            
            r = m[0,0]*k;
            graphics.FillEllipse(brush, 20 - r, 20 - r, 40 + 2 * r, 40 + 2 * r);
            r = m[1,1] * k;
            graphics.FillEllipse(brush, 100 - r, 100 - r, 40 + 2 * r, 40 + 2 * r);
            r = m[2,2] * k;
            graphics.FillEllipse(brush, 180 - r, 180 - r, 40 + 2 * r, 40 + 2 * r);
            r = m[3,3] * k;
            graphics.FillEllipse(brush, 260 - r, 260 - r, 40 + 2 * r, 40 + 2 * r);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            int[,] _matrix = new int[4, 4] {
                { 1, 2, 3, 4},
                { 2, 3, 4, 1},
                { 3, 4, 1, 2},
                { 4, 1, 2, 3}
            };
            matrix_Draw(_matrix);
        }
    }
}
