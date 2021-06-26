
namespace Lista_de_Exercicios_1
{
    partial class Form4
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
            this.button1 = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(29, 51);
            this.textBox1.Name = "textBox1";
            this.textBox1.PlaceholderText = "Nome";
            this.textBox1.Size = new System.Drawing.Size(131, 23);
            this.textBox1.TabIndex = 0;
            this.textBox1.Leave += new System.EventHandler(this.nome_Leave);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(29, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.PlaceholderText = "Cód. da Peça";
            this.textBox2.Size = new System.Drawing.Size(131, 23);
            this.textBox2.TabIndex = 1;
            this.textBox2.Leave += new System.EventHandler(this.CodPeca_Leave);
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(29, 109);
            this.textBox3.Name = "textBox3";
            this.textBox3.PlaceholderText = "Preço Unit. Peça";
            this.textBox3.Size = new System.Drawing.Size(131, 23);
            this.textBox3.TabIndex = 2;
            this.textBox3.Leave += new System.EventHandler(this.precoUnit_Leave);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(29, 138);
            this.textBox4.Name = "textBox4";
            this.textBox4.PlaceholderText = "Qtd. Vendida";
            this.textBox4.Size = new System.Drawing.Size(131, 23);
            this.textBox4.TabIndex = 3;
            this.textBox4.Leave += new System.EventHandler(this.qtdVendida_Leave);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(48, 167);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Comissão";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(230, 51);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(225, 127);
            this.listView1.TabIndex = 5;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // Form4
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Name = "Form4";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ListView listView1;
    }
}