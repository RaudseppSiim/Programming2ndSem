using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace RaudseppSiim_2_konspekt_22_01_2018
{
    public partial class RaS_Form_19_03_2018 : Form
    {
        Graphics g;
        private List<PointF> Points;
        Pen pen = new Pen(Color.Black,1);
        private Matrix Transform;
        private int AtomPoint = 0;
        Bitmap backGround = new Bitmap(556, 556);
        Bitmap bm;
        public RaS_Form_19_03_2018()
        {
            InitializeComponent();
            g = Graphics.FromImage(backGround);
        }

        private void RaS_Lines_Click(object sender, EventArgs e)
        {
            g.DrawLine(pen, RaS_Canvas.Width / 2, 0, RaS_Canvas.Width / 2, RaS_Canvas.Height);
            g.DrawLine(pen, 0, RaS_Canvas.Height/2, RaS_Canvas.Width, RaS_Canvas.Height/2);
            int circSize = 100;
            pen.DashStyle = DashStyle.Dash;
            for (int i = 0; i < 5; i++)
            {
                Size size = new Size(RaS_Canvas.Width - (i*circSize)*2, RaS_Canvas.Height - (i*circSize)*2);
                Point point = new Point(0+(i*circSize), 0+(i*circSize));
                Rectangle rect = new Rectangle(point,size);
                g.DrawEllipse(pen,rect);
            }
            pen.DashStyle = DashStyle.Solid;
            RaS_Canvas.Image = backGround;
        }

        private void RaS_Graph_Click(object sender, EventArgs e)
        {
            RectangleF rect = new RectangleF(-2f, -2f, 4f, 4f);
            PointF[] pts =
                {
                        new PointF(0, RaS_Canvas.Height),
                        new PointF(RaS_Canvas.Width, RaS_Canvas.Height),
                        new PointF(0, 0),
                    };
            Transform = new Matrix(rect, pts);
            g.Transform = Transform;
            
            if (RaS_ButterFly.Checked == true)
                functionButter();
            if (RaS_Kardioid.Checked == true)
                functionKard();

            if(RaS_EsmaneRoos.Checked == true)
                function();

            RaS_Canvas.Image = backGround;
            RaS_atomTimer.Enabled = true;
        }
        private void function()
        {

            double t = 0;
            const double dt = Math.PI / 100.0;
            const double two_pi = Math.PI*74;
            Points = new List<PointF>();
            while (t <= two_pi)
            {
                double r = 2*Math.Sin(7 * t/4);
                float x = (float)(r * Math.Cos(t));
                float y = (float)(r * Math.Sin(t));
                Points.Add(new PointF(x, y));
                t += dt;
            }

            // Draw the curve.
            using (Pen thin_pen = new Pen(Color.Red, 0))
            {
                g.DrawPolygon(thin_pen, Points.ToArray());
            }
        }

        private void RaS_atomTimer_Tick(object sender, EventArgs e)
        {
            bm = (Bitmap)backGround.Clone();
            using (Graphics gr = Graphics.FromImage(bm))
            {
                gr.Transform = Transform;
                gr.SmoothingMode = SmoothingMode.AntiAlias;
                gr.FillEllipse(Brushes.Green,
                    Points[AtomPoint].X - 0.075f,
                    Points[AtomPoint].Y - 0.075f,
                    0.15f, 0.15f);
            }


            // Display the result.
            RaS_Canvas.Image = bm;

            // Move the atom.
            AtomPoint = (AtomPoint + 1) % Points.Count;
        }
        private void functionButter()
        {
            double t = 0;
            const double dt = Math.PI / 100.0;
            const double two_pi = Math.PI*100;
            Points = new List<PointF>();
            while (t <= two_pi)
            {
                double r = (Math.Exp(Math.Sin(t))-2*Math.Cos(4*t)+Math.Pow(Math.Sin((2*t-Math.PI)/24),5))/2;
                float x = (float)(r * Math.Cos(t));
                float y = (float)(r * Math.Sin(t));
                Points.Add(new PointF(x, y));
                t += dt;
            }

            // Draw the curve.
            using (Pen thin_pen = new Pen(Color.Red, 0))
            {
                g.DrawPolygon(thin_pen, Points.ToArray());
            }
        }
        private void functionKard()
        {

            double t = 0;
            const double dt = Math.PI / 100.0;
            const double two_pi = Math.PI*74;
            Points = new List<PointF>();
            while (t <= two_pi)
            {
                double r = 1-Math.Sin(t);
                float x = (float)(r * Math.Cos(t));
                float y = (float)(r * Math.Sin(t));
                Points.Add(new PointF(x, y));
                t += dt;
            }

            // Draw the curve.
            using (Pen thin_pen = new Pen(Color.Red, 0))
            {
                g.DrawPolygon(thin_pen, Points.ToArray());
            }

        }
    }
}
