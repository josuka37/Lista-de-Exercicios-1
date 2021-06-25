using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lista_de_Exercicios_1
{
    public partial class Form2 : Form
    {
        int calculaMedia, estoqueMinimo, estoqueMaximo;
        public Form2()
        {
            InitializeComponent();
        }

        private void txtBox_Leave2(object sender, EventArgs e)
        {
            estoqueMaximo = int.Parse(textBox2.Text);
        }


        private void txtBox_Leave1(object sender, EventArgs e)
        {
            estoqueMinimo = int.Parse(textBox1.Text);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"O Estoque médio é {(estoqueMinimo + estoqueMaximo) / 2}");
        }
    }
}
