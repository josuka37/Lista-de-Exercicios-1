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
        int estoqueMinimo, estoqueMaximo;
        public Form2()
        {
            InitializeComponent();
        }

        private void txtBox_Leave2(object sender, EventArgs e)
        {
            estoqueMaximo =string.IsNullOrEmpty(textBox2.Text) ? 0 : int.Parse(textBox2.Text);
        }


        private void txtBox_Leave1(object sender, EventArgs e)
        {
            estoqueMinimo = string.IsNullOrEmpty(textBox1.Text) ? 0 : int.Parse(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var menuPrincipal = new Form1();
            menuPrincipal.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"O Estoque médio é {(estoqueMinimo + estoqueMaximo) / 2}");
        }
    }
}
