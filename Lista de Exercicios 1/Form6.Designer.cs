
namespace Lista_de_Exercicios_1
{
    partial class Form6
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(75, 47);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Nome do Aluno";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Leave += new System.EventHandler(this.nomeAluno_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(75, 76);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "1ª nota";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.Leave += new System.EventHandler(this.nota1_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(75, 105);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "2ª nota";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 2;
            this.textBox3.Leave += new System.EventHandler(this.nota2_Leave);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(75, 134);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "3ª nota";
            this.textBox4.Size = new System.Drawing.Size(100, 23);
            this.textBox4.TabIndex = 3;
            this.textBox4.Leave += new System.EventHandler(this.nota3_Leave);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(75, 163);
            this.textBox5.Name = "textBox5";
            this.textBox5.PlaceholderText = "4ª nota";
            this.textBox5.Size = new System.Drawing.Size(100, 23);
            this.textBox5.TabIndex = 4;
            this.textBox5.Leave += new System.EventHandler(this.nota4_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(85, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "Calcular";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form6
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form6";
            this.Text = "Form6";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button button1;
    }
}