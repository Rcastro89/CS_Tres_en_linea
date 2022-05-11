using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tres_en_linea
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Jugador 2:";
            comboBox1.Visible = false;
            textBox2.Visible = true;
            textBox2.Text = "";
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            label3.Text = "Dificultad IA:";
            comboBox1.Visible = true;
            textBox2.Visible = false;
            textBox2.Text = "IA " + comboBox1.SelectedItem.ToString();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = 0;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string jugador1;
            string jugador2;
            if (textBox1.Text == "" || textBox2.Text == "")
            {
                Form3 form3 = new Form3();
                form3.ShowDialog(this);
            }  
            else
            {
                jugador1 = textBox1.Text;
                jugador2 = textBox2.Text;
                Form1 form1 = new Form1(jugador1, jugador2);
                this.Hide();
                form1.Show();
            }    
                
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBox2.Text = "IA " + comboBox1.SelectedItem.ToString();
        }
    }
}
