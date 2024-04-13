using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form2 : Form
    {
        public int op;
        public Form2()
        {
            InitializeComponent();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
            textBox1.Text = monthCalendar1.SelectionRange.Start.ToLongDateString();
        }

        private void d01_Click(object sender, EventArgs e)
        {
            op = 1;
        }

        private void d02_Click(object sender, EventArgs e)
        {
            op = 2;
        }

        private void d03_Click(object sender, EventArgs e)
        {
            op = 3;
        }

        private void d04_Click(object sender, EventArgs e)
        {
            op = 4;
        }

        private void d05_Click(object sender, EventArgs e)
        {
            op = 5;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (op == 1)
            {
                d01.Text = textBox2.Text;
            }
            else if (op == 2)
            {
                d02.Text = textBox2.Text;
            }
            else if (op == 3)
            {
                d03.Text = textBox2.Text;
            }
            else if (op == 4)
            {
                d04.Text = textBox2.Text;
            }
            else if (op == 5)
            {
                d05.Text = textBox2.Text;
            }
            else
                MessageBox.Show("Escolha um horário");
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string nome_arq = monthCalendar1.SelectionRange.Start.ToLongDateString();
            StreamWriter arquivo;

            if (System.IO.File.Exists(@"C:\Users\aluno\Desktop\" + nome_arq + ".txt"))
                File.Delete(@"C:\Users\aluno\Desktop\" + nome_arq + ".txt");
            arquivo = new StreamWriter(@"C:\Users\aluno\Desktop\" + nome_arq + ".txt");
            
            foreach (Label controle in tableLayoutPanel1.Controls)
            {
                arquivo.WriteLine(controle.Text);
            }
            arquivo.Close();

            MessageBox.Show("Arquivo Gravado com Sucesso!", "Finalização", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
