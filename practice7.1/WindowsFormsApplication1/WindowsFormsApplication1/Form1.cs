using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        Image p1 = Image.FromFile(@"p1.png");
        Image p2 = Image.FromFile(@"p2.png");
        Image p3 = Image.FromFile(@"p3.png");
        Image p4 = Image.FromFile(@"p4.png");
        Image p5 = Image.FromFile(@"p5.png");
        Image p6 = Image.FromFile(@"p6.png");
        int stage = 1;
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
            pictureBox1.Image = p1;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //radioButton1.AutoCheck = false;
            //radioButton2.AutoCheck = true;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //radioButton1.AutoCheck = true;
            //radioButton2.AutoCheck = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked == true) {
                if (stage == 6) return;
                else stage++;
            }
            else
            {
                if (stage == 1) return;
                else stage--;
            }
            switch (stage)
            {
                case 1: pictureBox1.Image = p1;
                    break;
                case 2:
                    pictureBox1.Image = p2;
                    break;
                case 3:
                    pictureBox1.Image = p3;
                    break;
                case 4:
                    pictureBox1.Image = p4;
                    break;
                case 5:
                    pictureBox1.Image = p5;
                    break;
                case 6:
                    pictureBox1.Image = p6;
                    break;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
