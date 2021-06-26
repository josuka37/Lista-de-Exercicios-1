using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lista_de_Exercicios_1
{
    public partial class Form3 : Form
    {
        double cotacaoDolar, cambio;
        public Form3()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"O valor em dólares é U${cambio * cotacaoDolar}");
        }



        private void Real_Leave(object sender, EventArgs e)
        {
             maskedTextBox1.Text.Replace("R$", "");
            cotacaoDolar = string.IsNullOrEmpty(maskedTextBox1.Text) ? 0 : double.Parse(maskedTextBox1.Text);
            // maskedTextBox1.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
           // cotacaoDolar = string.IsNullOrEmpty(maskedTextBox1.Text) ? 0 : (double.Parse(maskedTextBox1.Text);
           // maskedTextBox1.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

        private void dolar_Leave(object sender, EventArgs e)
        {
            maskedTextBox1.Text.Replace("$", "");
            cambio = String.IsNullOrEmpty(maskedTextBox2.Text) ? 0 : double.Parse(maskedTextBox2.Text);
            //maskedTextBox2.TextMaskFormat = MaskFormat.ExcludePromptAndLiterals;
            //cambio = String.IsNullOrEmpty(maskedTextBox2.Text) ? 0 : double.Parse(maskedTextBox2.Text);
            //maskedTextBox2.TextMaskFormat = MaskFormat.IncludePromptAndLiterals;
        }

    }
}
