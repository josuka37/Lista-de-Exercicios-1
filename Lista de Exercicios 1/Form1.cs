using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lista_de_Exercicios_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var exercico1 = new Form2();
            exercico1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var exercicio2 = new Form3();
            exercicio2.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            var exercicio3 = new Form4();
            exercicio3.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            var lista2Exerc_4 = new Form5();
            lista2Exerc_4.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var lista2Exerc_5 = new Form6();
            lista2Exerc_5.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            var lista2Exerc_6 = new Form7();
            lista2Exerc_6.Show();
        }
    }
}
