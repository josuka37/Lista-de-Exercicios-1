using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lista_de_Exercicios_1
{
    public partial class Form5 : Form
    {
        double num1, num2;

        public Form5()
        {
            InitializeComponent();
            calculo();
        }

        private void num2_Leave(object sender, EventArgs e)
        {
            num2 = double.Parse(textBox2.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            calculo();
        }

        private void num1_Leave(object sender, EventArgs e)
        {
            num1 = double.Parse(textBox1.Text);
        }

        private void calculo()
        {
            if(num1 > num2)
            {
                MessageBox.Show($"A diferença do maior para o menor é {num1 - num2}");
            }
            else if(num2 > num1)
            {
                MessageBox.Show($"A diferença do maior para o menor é {num2 - num1}");
            }
        }
    }
}
