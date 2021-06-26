using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lista_de_Exercicios_1
{
    public partial class Form4 : Form
    {
        string nome, codPeca;
        double precoUnit;
        double qtdVendida;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(nome);
            listView1.Items.Add(codPeca);
            listView1.Items.Add($"{(precoUnit * qtdVendida) * 0.05 }");
            listView1.Items.Add("\n");
            
        }

        private void nome_Leave(object sender, EventArgs e)
        {
            nome = textBox1.Text;
        }

        private void precoUnit_Leave(object sender, EventArgs e)
        {
            precoUnit = double.Parse(textBox3.Text);
        }

        private void qtdVendida_Leave(object sender, EventArgs e)
        {
            qtdVendida = double.Parse(textBox4.Text);
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void CodPeca_Leave(object sender, EventArgs e)
        {
            codPeca = textBox2.Text;
        }
    }
}
