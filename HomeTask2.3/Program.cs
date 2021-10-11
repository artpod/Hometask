using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask2._3
{
    abstract class Triangle
    {
        protected double A, B;
        protected double Angle;
        public Triangle(double A, double B, double Angle)
        {
            this.A = A;
            this.B = B;
            this.Angle = Angle;
        }

        protected Triangle() { }

        public virtual double Square()
        {
            return A * B * Math.Sin(Angle) / 2;
        }
        public virtual double Perimeter()
        {
            return A + B + Math.Sqrt(A * A + B * B - 2 * A * B * Math.Cos(Angle));
        }
    }

    class RectTriangle : Triangle
    {
        public RectTriangle(double A, double B, double Angle):base(A,B,Angle)
        {
            this.Angle = 90;
        }
        public override double Square()
        {
            return A * B / 2;
        }
        public override double Perimeter()
        {
            return A + B + Math.Sqrt(A * A + B * B);
        }
    }

    class IsoTriangle : Triangle
    {
        public IsoTriangle(double A, double B,double Angle):base(A,B,Angle)
        {
            this.A = B;
            this.B = B;
            this.Angle = Angle;
        }
        public override double Square()
        {
            return A * A * Math.Sin(Angle * Math.PI / 180) / 2;
        }
        public override double Perimeter()
        {
            return 2 * A + Math.Sqrt(2 * A * A * (1 - Math.Cos(Angle * Math.PI/180)));
        }
    } 
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
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
