using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HomeTask2._3
{
    public partial class Form1 : Form
    {
        int flag;
        double A, B, C;
        Triangle TR;
        public Form1()
        {
            InitializeComponent();
        }

        void Visible()
        {
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
          //  label6.Visible = true;
          //  label7.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            button4.Visible = true;
          //  button5.Visible = true;
          //  button6.Visible = true;
        }

        void NoVisible()
        {
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            button4.Visible = false;
                label6.Visible = false;
                label7.Visible = false;
            label5.Text = "";
            label6.Text = "";
            label7.Text = "";
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
        }

 
        

        private void button2_Click_1(object sender, EventArgs e)
        {
            NoVisible();
            label2.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            button4.Visible = true;
            flag = 1;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            label6.Text = TR.Square().ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            label7.Text = TR.Perimeter().ToString();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            NoVisible();
            label4.Visible = true;
            label3.Visible = true;
            label5.Visible = true;
            textBox3.Visible = true;
            textBox2.Visible = true;
            button4.Visible = true;
            flag = 2;
        }



        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                bool check = false;
                A = Convert.ToDouble(textBox1.Text) != 0 ? Convert.ToDouble(textBox1.Text) : 0;
                B = Convert.ToDouble(textBox2.Text) != 0 ? Convert.ToDouble(textBox2.Text) : 0;
                C = Convert.ToDouble(textBox3.Text) != 0 ? Convert.ToDouble(textBox3.Text) : 0;


                if ((C % 180 == 0||B==0) && flag == 2) check = true;
                if ((A == 0 || B == 0) && flag == 1) check = true;
                if (check == true)
                {
                    label5.Text = "Try again. Wrong format!";
                    button5.Visible = false;
                    button6.Visible = false;
                    label6.Visible = false;
                    label7.Visible = false;
                }
                else
                {
                    switch (flag)
                    {
                        case 1:
                            TR = new RectTriangle(A, B, C);
                            break;
                        case 2:
                            TR = new IsoTriangle(A, B, C);
                            break;
                    }
                    label5.Text = "Created successfully!";
                    label6.Text = "";
                    label7.Text = "";
                    button5.Visible = true;
                    button6.Visible = true;
                    label6.Visible = true;
                    label7.Visible = true;
                }
            }
            catch (FormatException E)
            {
                label5.Text = "Try again. Wrong format!";
                button5.Visible = false;
                button6.Visible = false;
                label6.Visible = false;
                label7.Visible = false;

            }
        }
    }
}
