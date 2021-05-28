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
        
        private void matrix_Draw(int[,] m)
        {
            Graphics graphics = pictureBox1.CreateGraphics();

            Pen pen = new Pen(Color.BlueViolet, 2);

            // Рациональную матрицу удобно отображать в виде
            // окружностей разного диаметра
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    int k = 2;
                    int r = m[i, j] * k;
                    graphics.DrawEllipse(pen, 20 + 80 * i - r, 20 + 80 * j - r, 40 + 2 * r, 40 + 2 * r);
                }
            }
            Brush brush = new SolidBrush(Color.DarkRed);
            for (int i = 0; i < 4; i++)
            {
                int k = 2;
                int r = m[i, i] * k;
                graphics.FillEllipse(brush, 20 + 80 * i - r, 20 + 80 * i - r, 40 + 2 * r, 40 + 2 * r);
            }
            
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
