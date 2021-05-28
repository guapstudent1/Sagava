using System;

using System.Drawing;
using System.Windows.Forms;

namespace SagavaVisual
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Graphics graphics = pictureBox1.CreateGraphics();

            Pen pen = new Pen(Color.BlueViolet, 2);

            // В случае задания матрицы комплексными числами 
            // Их удобно отображать в виде роторов
            graphics.DrawLine(pen, 30, 30, 40, 50);
            graphics.DrawEllipse(pen, 20,  20, 20, 20);


            graphics.DrawEllipse(pen, 60,  20, 20, 20);
            graphics.DrawEllipse(pen, 100, 20, 20, 20);
            graphics.DrawEllipse(pen, 140, 20, 20, 20);

            graphics.DrawEllipse(pen, 20,  60, 20, 20);
            graphics.DrawEllipse(pen, 60,  60, 20, 20);
            graphics.DrawEllipse(pen, 100, 60, 20, 20);
            graphics.DrawEllipse(pen, 140, 60, 20, 20);

            graphics.DrawEllipse(pen, 20,  100, 20, 20);
            graphics.DrawEllipse(pen, 60,  100, 20, 20);
            graphics.DrawEllipse(pen, 100, 100, 20, 20);
            graphics.DrawEllipse(pen, 140, 100, 20, 20);

            graphics.DrawEllipse(pen, 20,  140, 20, 20);
            graphics.DrawEllipse(pen, 60,  140, 20, 20);
            graphics.DrawEllipse(pen, 100, 140, 20, 20);
            graphics.DrawEllipse(pen, 140, 140, 20, 20);
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            int[,] _matrix = new int[4, 4] {
                { 1, 2, 3, 4},
                { 2, 3, 4, 1},
                { 3, 4, 1, 2},
                { 4, 1, 2, 3}
            };
            String row1 = _matrix[0, 0].ToString();
            row1 += " " + _matrix[0, 1].ToString();
            row1 += " " + _matrix[0, 2].ToString();
            row1 += " " + _matrix[0, 3].ToString();
            label1.Text = row1;

            String row2 = _matrix[1, 0].ToString();
            row2 += " " + _matrix[1, 1].ToString();
            row2 += " " + _matrix[1, 2].ToString();
            row2 += " " + _matrix[1, 3].ToString();
            label2.Text = row2;

            String row3 = _matrix[2, 0].ToString();
            row3 += " " + _matrix[2, 1].ToString();
            row3 += " " + _matrix[2, 2].ToString();
            row3 += " " + _matrix[2, 3].ToString();
            label3.Text = row3;

            String row4 = _matrix[3, 0].ToString();
            row4 += " " + _matrix[3, 1].ToString();
            row4 += " " + _matrix[3, 2].ToString();
            row4 += " " + _matrix[3, 3].ToString();
            label4.Text = row4;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Подсчет собственных чисел рациональной матрицы предлагаю сделать самостоятельно
        }
    }
}
