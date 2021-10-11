using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask2._1
{

    class Triangle
    {
        protected double a;
        protected double b;
        protected double c;
        public Triangle(double a, double b, double c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }
        public Triangle(double a)
        {
            this.a = a;
            this.b = a;
            this.c = a;
        }
        internal bool ChangeSide(string name, double m)
        {
            switch (name)
            {
                case "A":
                    a = m;
                    return true;
                case "B":
                    b = m;
                    return true;
                case "C":
                    c = m;
                    return true;
                default:
                    return false;
            }
        }

        public double Perimeter()
        {
            return a + b + c;
        }

        internal double Angle(string side)
        {
            switch (side)
            {
                case "A":
                    return Math.Acos((b * b + c * c - a * a) / (2 * b * c));
                case "B":
                    return Math.Acos((a * a + c * c - b * b) / (2 * a * c));
                case "C":
                    return Math.Acos((a * a + b * b - c * c) / (2 * a * b));
                default:
                    Console.WriteLine("Try again - A,B or C");
                    return 0;
            }
        }


    }

    class EquilTriangle : Triangle
    {

        //private double side;

        private double S;
        public EquilTriangle(double side) : base(side)
        {
            a = side;
            b = side;
            c = side;
        }

        public double Square()
        {
            return (a * a * Math.Sqrt(3) / 4);
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
