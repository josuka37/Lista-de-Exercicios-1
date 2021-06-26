using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Lista_de_Exercicios_1
{
    public partial class Form6 : Form
    {
        string nomeAluno;
        double nota1, nota2, nota3, nota4, media;

        private void nota2_Leave(object sender, EventArgs e)
        {
            nota2 = double.Parse(textBox3.Text);
        }

        private void nota3_Leave(object sender, EventArgs e)
        {
            nota3 = double.Parse(textBox4.Text);
        }

        private void nota4_Leave(object sender, EventArgs e)
        {
            nota4 = double.Parse(textBox5.Text);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            media = (nota1 + nota2 + nota3 + nota4) / 4;
            if (media >= 7)
            {
                MessageBox.Show($"{nomeAluno} foi aprovado com média {media}.");
            }
            else if (media < 7)
            {
                MessageBox.Show($"{nomeAluno} foi reprovado com média {media}.");
            }
        }

        private void nota1_Leave(object sender, EventArgs e)
        {
            nota1 = double.Parse(textBox2.Text);
        }

        public Form6()
        {
            InitializeComponent();
        }

        private void nomeAluno_Leave(object sender, EventArgs e)
        {
            nomeAluno = textBox1.Text;
        }
    }
}
