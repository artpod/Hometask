using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask2._1
{
    public partial class Form1 : Form
    {
        public double square;
        double A, B, C;
        Triangle TR;
        EquilTriangle ETR;
        bool type;
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
          
            try
            {
                
                A = Convert.ToDouble(textBox6.Text) != 0 ? Convert.ToDouble(textBox6.Text) : 0;
                B = Convert.ToDouble(textBox2.Text) != 0 ? Convert.ToDouble(textBox2.Text) : 0;
                C = Convert.ToDouble(textBox3.Text) != 0 ? Convert.ToDouble(textBox3.Text) : 0;

                if ((A == 0 || B == 0 || C == 0) || (A + B <= C) || (B + C <= A) || (A + C <= B))
                {
                    label9.Text = "Wrong size. Try again!";
                    button2.Visible = false;
                    button3.Visible = false;
                   // button4.Visible = false;
                    button5.Visible = false;
                    label1.Text = "";
                    label4.Text = "";
                    label6.Text = "";
                    label13.Text = "";

                }
                else
                {
                    label9.Text = "Triangle created.";
                    button2.Visible = true;
                    button3.Visible = true;
                  //  button4.Visible = true;
                    button5.Visible = true;
                    if (A == B && B == C) { ETR = new EquilTriangle(A); type = true; TR = ETR; }
                    else { TR = new Triangle(A, B, C); type = false; }
                }
            }
            catch (FormatException E)
            {
                label9.Text = "Wrong size. Try again!";
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            square = ETR.Square();
            if (type == true) label1.Text = square.ToString();
            else label1.Text = "Triangle is equilateral";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            square = TR.Perimeter();
            label6.Text = square.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string side = textBox1.Text;
            if (Convert.ToDouble(side) == 0) label4.Text = "Try again! (A,B or C)";
            else
            {
                square = Math.Round(TR.Angle(side), 3);
                label4.Text = square.ToString();
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            square = Math.Round(TR.Perimeter(), 3);
            label6.Text = square.ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            string side = textBox1.Text;
            square = Math.Round(TR.Angle(side) * 180 / Math.PI, 3);

            if (square != 0) label4.Text = square.ToString();
            else label4.Text = "Wrong parameters. Try again!";
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            try
            {
                string side = textBox4.Text;
                double value = Convert.ToDouble(textBox5.Text);
                bool flag = TR.ChangeSide(side, value);
                if (flag == false) label13.Text = "Wrong parameters. Try again!";
                else
                {
                    switch (side)
                    {
                        case "A":
                            textBox6.Text = value.ToString();
                            break;
                        case "B":
                            textBox2.Text = value.ToString();
                            break;
                        case "C":
                            textBox3.Text = value.ToString();
                            break;
                        default:
                            break;
                    }
                    label13.Text = "Changed successfully!";
                    // if (textBox2.Text == textBox3.Text && textBox3.Text == textBox6.Text) type = true;
                    // else type = false;
                    button1_Click(sender, e);
                }
            }
            catch(FormatException E)
            {
                label13.Text = "Wrong parameters. Try again!";
            }
        }
    }
}
