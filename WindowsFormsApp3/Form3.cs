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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int delkaposunu = (int)numericUpDown1.Value;
            string text = textBox1.Text;
            int i = 0;
            char[] vystup = new char[text.Length];

            foreach (char pismeno in text)
            {

                if ((pismeno >= 'a' && pismeno <= 'z') || (pismeno >= 'A' && pismeno <= 'Z'))
                {
                    if ((pismeno + delkaposunu <= 'z' && pismeno + delkaposunu >= 'a' && pismeno >= 'a' && pismeno <= 'z') || (pismeno + delkaposunu <= 'Z' && pismeno + delkaposunu >= 'A' && pismeno >= 'A' && pismeno <= 'Z'))
                    {
                        vystup[i] = (char)(pismeno + delkaposunu);
                    }
                    else
                        vystup[i] = (char)(pismeno + (delkaposunu - 26));
                }
                else
                    vystup[i] = pismeno;

                i++;
            }

            textBox2.Text = new string(vystup);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int delkaposunu = (int)numericUpDown1.Value;
            string text = textBox1.Text;
            int i = 0;
            char[] vystup = new char[text.Length];

            foreach (char pismeno in text)
            {

                if ((pismeno >= 'a' && pismeno <= 'z') || (pismeno >= 'A' && pismeno <= 'Z'))
                {
                    if ((pismeno + delkaposunu <= 'z' && pismeno + delkaposunu >= 'a' && pismeno >= 'a' && pismeno <= 'z') || (pismeno + delkaposunu <= 'Z' && pismeno + delkaposunu >= 'A' && pismeno >= 'A' && pismeno <= 'Z'))
                    {
                        vystup[i] = (char)(pismeno - delkaposunu);
                    }
                    else vystup[i] = (char)(pismeno - (delkaposunu - 26));
                }
                else
                    vystup[i] = pismeno;

                i++;
            }

            textBox2.Text = new string(vystup);
        }
    }
}
