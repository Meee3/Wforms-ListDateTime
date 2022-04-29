using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFAula19
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        DateTime dateTime = new DateTime();
        DateTime atual = DateTime.Now;

        string[] vetorNomes = { "Computer", "Pc", "Notebook", "Etc..." };
        private void label3_Click(object sender, EventArgs e)
        {
            string mes = atual.ToString().Substring(3, 2);
            lblMes.Text = $"Mês: {mes}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach(string vetor in vetorNomes)
            {
                // listBox1.Text = vetor;
                listBox1.Items.Add(vetor);

            }
        }

        private void btnComboBox_Click(object sender, EventArgs e)
        {
            foreach (string vetor in vetorNomes)
            {
            
                comboBox1.Items.Add(vetor);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            checkBox1.Checked = true;
            if (checkBox1.Checked == true)
            {
                checkBox1.Checked = true;
            }
            else
            {
                checkBox1.Checked = false;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
            DateTime atual = DateTime.Now;
            lblDataAtual.Focus();
            lblDataAtual.Text = $"{atual}";
        }

        private void label2_Click(object sender, EventArgs e)
        {
            string dia = atual.ToString().Substring(0,2);
            lblDia.Text = $"Dia: {dia}";
        }

        private void label1_Click_1(object sender, EventArgs e)
        {
            string ano = atual.ToString().Substring(6, 4);
            lblAno.Text = $"Ano: {ano}";
            //dateTime.Year(2);
            //lblAno.Text = $"Mês: {}";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void checkedListBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
          
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked == true)
            {
                MessageBox.Show("OK");
            }
            else
            {
                MessageBox.Show("Off");

            }
        }

        private void lblDia_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
