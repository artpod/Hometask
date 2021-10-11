using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask2._2
{
    


        abstract class Figure
        {
            public abstract double Square();
            public abstract double Perimeter();
        }

        class Triangle : Figure
        {

            double A, B, C;

            public Triangle(double A, double B, double C) : base()
            {
                this.A = A;
                this.B = B;
                this.C = C;
            }

            public override double Square()
            {
                double P = (A + B + C) / 2;
                return Math.Sqrt(P * (P - A) * (P - B) * (P - C));
            }
            public override double Perimeter()
            {
                return A + B + C;
            }
        }

        class Circle : Figure
        {
            double R;
            public Circle(double R, double A, double C) : base()
            {
                this.R = R;
            }
            public override double Square()
            {
                return Math.PI*R*R;
            }
            public override double Perimeter()
            {
                return 2 * Math.PI * R;
            }
        }

        class Rectangle : Figure
        {
            double A, B;
            public Rectangle(double A, double B, double C) : base()
            {
                this.A = A;
                this.B = B;
            }
            public override double Square()
            {
                return A*B;
            }
            public override double Perimeter()
            {
                return 2 * (A + B);
            }
        }

        class Quadrate : Figure
        {
            double A;
            public Quadrate(double A, double B, double C) : base()
            {
                this.A = A;
            }
            public override double Square()
            {
                return A * A;
            }
            public override double Perimeter()
            {
                return 4 * A;
            }
        }

        class Rhombus : Figure
        {
            double A;
            double Angle;
            public Rhombus(double A, double Angle, double C) : base()
            {
                this.A = A;
                this.Angle = Angle;
            }
            public override double Square()
            {
                return A * A * Math.Abs(Math.Sin(Angle*Math.PI/180));
            }
            public override double Perimeter()
            {
                return 4 * A;
            }
        }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
