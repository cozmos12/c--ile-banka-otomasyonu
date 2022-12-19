using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int hak_sayısı = 3;


            while (true)
            {
                Console.WriteLine("lütfen kullanıcı adınızı giriniz");
                string kullaniciadi = Console.ReadLine();
                Console.WriteLine("lütfen şifrenizi giriniz");
                string şifre = Console.ReadLine();


                if (textBox1.Text == "zeus" && textBox2.Text == "12419")

                {
                    Form2 yeni = new Form2();
                    yeni.Show();
                    this.Hide();
                    break;

                }


                else
                {


                    if (hak_sayısı > 0)
                    {
                        hak_sayısı -= 1;


                    }
                    if (hak_sayısı == 0)
                    {


                        break;
                    }



                }
            }   }
    }
}
