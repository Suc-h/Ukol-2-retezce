using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            foreach (char c in text)
            {
                if (c >= 'A' && c <= 'Z')
                {
                    text= text.Replace(c.ToString(), "");
                }
            }
            textBox2.Text = text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string text = textBox1.Text;
            text = text.Replace("*", "");
            textBox2.Text = text;
        }
    }
}
