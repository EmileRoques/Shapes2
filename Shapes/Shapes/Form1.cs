using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Shapes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string angle;
        string side1;
        string side2;
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            angle = textBox3.Text;
            side1 = textBox2.Text;
            side2 = textBox1.Text;
            if (angle == "60" | angle == "120")
            {
                textBox4.Text = "Hexagon";
            }
            else if (side1 == side2)
            {
                textBox4.Text = "Rhombic";
            }
            else
            {
                textBox4.Text = "Parallelogram";
            }
            if (angle == "90")
            {
                if (side1 == side2)
                {
                    textBox4.Text = "Square";
                }
                else
                {
                    textBox4.Text = "Rectangle";
                }
            }


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
