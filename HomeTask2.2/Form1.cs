using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask2._2
{
    public partial class Form1 : Form
    {
        Triangle TR;
        Quadrate QU;
        Rectangle RE;
        Rhombus RH;
        Circle CI;
        Figure FI;
        int flag; //1 to 5
        double A, B, C;
        public Form1()
        {
            InitializeComponent();
        }

        private void Visibility()
        {
            button7.Visible = true;
            button8.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
        }
        private void NoVisibility()
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button6.Visible = false;
            button7.Visible = false;
            button8.Visible = false;
        }


        private void button1_Click(object sender, EventArgs e)
        {
            NoVisibility();
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label2.Text = "A";
            label3.Text = "B";
            label4.Text = "C";
            label5.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button6.Visible = true;
            flag = 1;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            double S = FI.Square();
            label6.Text = S.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            double P = FI.Perimeter();
            label7.Text = P.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = true;
                    A = Convert.ToDouble(textBox1.Text);
                    B = Convert.ToDouble(textBox2.Text);
                    C = Convert.ToDouble(textBox3.Text);
                if (((A == 0 || B == 0 || C == 0) || (A + B <= C) || (B + C <= A) || (A + C <= B)) && flag == 1) check = false;
                if (A == 0 && flag != 1) check = false;
                if (B == 0 && flag == 3) check = false;
                if (B % 180 == 0 && flag == 5) check = false;

                if (check==false)
                    {
                        label5.Text = "Try again. Wrong format!";
                    }
                    else
                    {
                    switch (flag)
                    {
                        case 1:
                            FI = new Triangle(A, B, C);
                            break;
                        case 2:
                            FI = new Circle(A, B, C);
                            break;
                        case 3:
                            FI = new Rectangle(A, B, C);
                            break;
                        case 4:
                            FI = new Quadrate(A, B, C);
                            break;
                        case 5:
                            FI = new Rhombus(A, B, C);
                            break;
                    }
                        label5.Text = "Created successfully!";
                        Visibility();
                    }
            }
            catch (FormatException E)
            {
                label5.Text = "Try again. Wrong format!";
            }

        }
        

        private void button2_Click(object sender, EventArgs e)
        {
            NoVisibility();
            label2.Visible = true;
            label2.Text = "R";
            textBox1.Visible = true;
            label5.Visible = true;
            button6.Visible = true;
            flag = 2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            NoVisibility();
            label2.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            label2.Text = "A";
            label3.Text = "B";
            textBox1.Visible = true;
            textBox2.Visible = true;
            label5.Visible = true;
            button6.Visible = true;
            flag = 3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            NoVisibility();
            label2.Visible = true;
            label5.Visible = true;
            label2.Text = "A";
            textBox1.Visible = true;
            label5.Visible = true;
            button6.Visible = true;
            flag = 4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            NoVisibility();
            label2.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            label2.Text = "A";
            label3.Text = "Angle";
            textBox1.Visible = true;
            textBox2.Visible = true;
            label5.Visible = true;
            button6.Visible = true;
            flag = 5;
        }
    }
}
