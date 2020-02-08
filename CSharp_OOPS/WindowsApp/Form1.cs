using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SampleWindowsAPP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show("Good Morning Everyone,Have a Great Day","Greatings");
            if ((textFirst.Text == "") || (textSecond.Text == ""))
            {
                MessageBox.Show("Fields cannot be blank, Enter Data", "Input Data");
            }
            else
            {
                double n1, n2;
                n1 = double.Parse(textFirst.Text);
                n2 = double.Parse(textSecond.Text);

                double Res = 0;

                if (radioButton1.Checked)
                {
                    Res = (n1 + n2);
                    Result.Text = "Sum: " + Res;
                }
                else if (radioButton2.Checked)
                {
                    Res = (n1 - n2);
                    Result.Text = "Difference: " + Res;
                }
                else if (radioButton3.Checked)
                {
                    Res = (n1 / n2);
                    Result.Text = "Division: " + Res;
                }
                else
                {
                    MessageBox.Show("Select your Choice");
                }
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {

        }
    }
}
