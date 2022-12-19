using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace banka
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            int bakiye = 10000;
            label9.Text = bakiye.ToString();
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
           
            label12.Visible = false;
            panel1.Visible = true;
            label5.Visible = true;
            label9.Visible = true;

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            panel1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {



            

           
          
            label6.Visible = true;
            label7.Visible = false;
            label8.Visible = false;
            
            label12.Visible = false;
            panel1.Visible = true;
            label5.Visible = false;
            label9.Visible = false;

            panel2.Visible = false;
           

          
           
            
            









        }

        private void button5_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            int a;
            int b;
            int c;
            a = Convert.ToInt32(textBox1);
            b = Convert.ToInt32(label9.Text);

            c = b - a;
            label11.Text = c.ToString();



        }
    }
}
