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

        private void real_Leave1(object sender, EventArgs e)
        {
            cotacaoDolar = string.IsNullOrEmpty(textBox1.Text) ? 0 : double.Parse(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var menuPrincipal = new Form1();
            menuPrincipal.Show();
            this.Hide();
        }

        private void cotacaoDolar_Leave(object sender, EventArgs e)
        {
            cambio = string.IsNullOrEmpty(textBox2.Text) ? 0 : double.Parse(textBox2.Text);
        }

    }
}
