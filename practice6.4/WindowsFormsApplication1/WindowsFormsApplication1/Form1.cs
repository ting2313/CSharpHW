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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
                float n;
            if (textBox1.Text == "") { return; }
                if (!float.TryParse(textBox1.Text,out n))
                {
                    MessageBox.Show("請輸入數字");
                    textBox1.Text = "";
                    return;
                }
                label3.Text = "可兌換：" + float.Parse(textBox1.Text) * 29 + "台幣";
            
        }
    }
}
