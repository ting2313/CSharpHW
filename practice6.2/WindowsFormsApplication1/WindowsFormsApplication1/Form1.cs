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
        public Form1()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.Brown;
            pictureBox1.BackColor = Color.Blue;
            label1.Font = new Font("新細明體",18,FontStyle.Underline);
            label2.Font = new Font("新細明體", 14, FontStyle.Italic);
            button3.TextAlign = ContentAlignment.MiddleRight;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.BackColor = Color.White;
            pictureBox1.BackColor = Color.White;
            label1.BackColor = Color.Yellow;
            label1.Font = new Font("微軟正黑體", 18, FontStyle.Bold);
            label1.Font = new Font("微軟正黑體", 14, FontStyle.Bold);
            button3.TextAlign = ContentAlignment.BottomRight;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
