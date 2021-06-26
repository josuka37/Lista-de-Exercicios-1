using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lista_de_Exercicios_1
{
    public partial class Form7 : Form
    {
        double num1, num2;
        public Form7()
        {
            InitializeComponent();
        }

        private void num2_Leave(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (num1 > num2)
            {
                MessageBox.Show($"O maior número informado é {num1} e o menor é {num2}.");
            }
            else if (num2 > num1)
            {
                MessageBox.Show($"O maior número informado é {num2} e o menor é {num1}. ");
            }
        }

        private void num1_Leave(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
        }
    }
}
