using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SagavaFilm
{
    
    public partial class SagavaFilm : Form
    {
        private int frames = 0;
        private double[,] _matrixReal = new double[4, 4] {
                { 1,  2, -3,  4 },
                { 2,  3,  4, -1 },
                { -3, 4,  1,  2 },
                { 4, -1,  2, -3 }
            };
        private double[,] _matrixImage = new double[4, 4]
        {
                { -1,  2,  3,  4 },
                {  2,  3, -4,  1 },
                {  3, -4,  1, -2 },
                { -4,  1, -2,  3 }
        };
        public SagavaFilm()
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
        private Complex rotate_Element(Complex a, Complex b)
        {
            Complex res = new Complex();
            res.Re = (a.Re * b.Re - a.Im * b.Im);
            res.Im = (a.Re * b.Im + a.Im * b.Re);
            return res;
        }
        private Point[,] init_MatrixPoint(Complex[,] m)
        {
            Point[,] res = new Point[4, 4];
            double k = 10;
            res[0, 0] = new Point((int)(m[0, 0].Re*k), (int)(m[0, 0].Im * k));
            res[0, 1] = new Point((int)(m[0, 1].Re * k), (int)(m[0, 1].Im * k));
            res[0, 2] = new Point((int)(m[0, 2].Re * k), (int)(m[0, 2].Im * k));
            res[0, 3] = new Point((int)(m[0, 3].Re * k), (int)(m[0, 3].Im * k));

            res[1, 0] = new Point((int)(m[1, 0].Re *k), (int)(m[1, 0].Im * k));
            res[1, 1] = new Point((int)(m[1, 1].Re * k), (int)(m[1, 1].Im * k));
            res[1, 2] = new Point((int)(m[1, 2].Re * k), (int)(m[1, 2].Im * k));
            res[1, 3] = new Point((int)(m[1, 3].Re * k), (int)(m[1, 3].Im * k));

            res[2, 0] = new Point((int)(m[2, 0].Re * k), (int)(m[2, 0].Im * k));
            res[2, 1] = new Point((int)(m[2, 1].Re *k), (int)(m[2, 1].Im * k));
            res[2, 2] = new Point((int)(m[2, 2].Re * k), (int)(m[2, 2].Im * k));
            res[2, 3] = new Point((int)(m[2, 3].Re * k), (int)(m[2, 3].Im * k));

            res[3, 0] = new Point((int)(m[3, 0].Re * k), (int)(m[3, 0].Im * k));
            res[3, 1] = new Point((int)(m[3, 1].Re * k), (int)(m[3, 1].Im * k));
            res[3, 2] = new Point((int)(m[3, 2].Re * k), (int)(m[3, 2].Im * k));
            res[3, 3] = new Point((int)(m[3, 3].Re * k), (int)(m[3, 3].Im * k));
            return res;
        }
        private void draw_Matrix(Complex[,] m)
        {
            Point[,] _matrixPoint = new Point[4, 4];
            // Инициализировать матрицу точек комплексных
            _matrixPoint = init_MatrixPoint(m);
            Graphics graphics = pictureBox1.CreateGraphics();
            graphics.Clear(BackColor);
            Pen pen = new Pen(Color.BlueViolet, 2);
            // В случае задания матрицы комплексными числами 
            // Их удобно отображать в виде роторов
            Point n = _matrixPoint[0, 0];
            graphics.DrawLine(pen, 30, 30, 30 + n.X, 30 + n.Y);
            graphics.DrawEllipse(pen, 20, 20, 20, 20);
            n = _matrixPoint[0, 1];
            graphics.DrawLine(pen, 70, 30, 70 + n.X, 30 + n.Y);
            graphics.DrawEllipse(pen, 60, 20, 20, 20);
            n = _matrixPoint[0, 2];
            graphics.DrawLine(pen, 110, 30, 110 + n.X, 30 + n.Y);
            graphics.DrawEllipse(pen, 100, 20, 20, 20);
            n = _matrixPoint[0, 3];
            graphics.DrawLine(pen, 150, 30, 150 + n.X, 30 + n.Y);
            graphics.DrawEllipse(pen, 140, 20, 20, 20);


            n = _matrixPoint[1, 0];
            graphics.DrawLine(pen, 30, 70, 30 + n.X, 70 + n.Y);
            graphics.DrawEllipse(pen, 20, 60, 20, 20);
            n = _matrixPoint[1, 1];
            graphics.DrawLine(pen, 70, 70, 70 + n.X, 70 + n.Y);
            graphics.DrawEllipse(pen, 60, 60, 20, 20);
            n = _matrixPoint[1, 2];
            graphics.DrawLine(pen, 110, 70, 110 + n.X, 70 + n.Y);
            graphics.DrawEllipse(pen, 100, 60, 20, 20);
            n = _matrixPoint[1, 3];
            graphics.DrawLine(pen, 150, 70, 150 + n.X, 70 + n.Y);
            graphics.DrawEllipse(pen, 140, 60, 20, 20);


            n = _matrixPoint[2, 0];
            graphics.DrawLine(pen, 30, 110, 30 + n.X, 110 + n.Y);
            graphics.DrawEllipse(pen, 20, 100, 20, 20);
            n = _matrixPoint[2, 1];
            graphics.DrawLine(pen, 70, 110, 70 + n.X, 110 + n.Y);
            graphics.DrawEllipse(pen, 60, 100, 20, 20);
            n = _matrixPoint[2, 2];
            graphics.DrawLine(pen, 110, 110, 110 + n.X, 110 + n.Y);
            graphics.DrawEllipse(pen, 100, 100, 20, 20);
            n = _matrixPoint[2, 3];
            graphics.DrawLine(pen, 150, 110, 150 + n.X, 110 + n.Y);
            graphics.DrawEllipse(pen, 140, 100, 20, 20);

            n = _matrixPoint[3, 0];
            graphics.DrawLine(pen, 30, 150, 30 + n.X, 150 + n.Y);
            graphics.DrawEllipse(pen, 20, 140, 20, 20);
            n = _matrixPoint[3, 1];
            graphics.DrawLine(pen, 70, 150, 70 + n.X, 150 + n.Y);
            graphics.DrawEllipse(pen, 60, 140, 20, 20);
            n = _matrixPoint[3, 2];
            graphics.DrawLine(pen, 110, 150, 110 + n.X, 150 + n.Y);
            graphics.DrawEllipse(pen, 100, 140, 20, 20);
            n = _matrixPoint[3, 3];
            graphics.DrawLine(pen, 150, 150, 150 + n.X, 150 + n.Y);
            graphics.DrawEllipse(pen, 140, 140, 20, 20);
        }
        private void change_Matrix()
        {
            
            Random rnd = new Random();
            
           
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    double m = (rnd.NextDouble() * 2-1) * Math.PI;
                    Complex a = new Complex();
                    Complex b = new Complex();

                    a.Re = _matrixReal[i, j];
                    a.Im = _matrixImage[i, j];
                    b.Re = Math.Cos(m);
                    b.Im = Math.Sin(m);
                    Complex c = rotate_Element(a, b);
                    _matrixReal[i, j] = c.Re;
                    _matrixImage[i, j] = c.Im;
                }
            }
        }
        private void play_Click(object sender, EventArgs e)
        {
            Complex[,] m = new Complex[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    m[i, j] = new Complex();
                    m[i, j].Re = _matrixReal[i, j];
                    m[i, j].Im = _matrixImage[i, j];

                }
            }
            draw_Matrix(m);
            frames = 0;
            timer1.Interval = 100;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (frames == 100) timer1.Stop();
            
            change_Matrix();
            Complex[,] m = new Complex[4, 4];
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    m[i, j] = new Complex();
                    m[i, j].Re = _matrixReal[i, j];
                    m[i, j].Im = _matrixImage[i, j];

                }
            }
            draw_Matrix(m);

        }

        private void pause_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }
    }
    public class Complex
    {
        public double Re;
        public double Im;
    }
}
