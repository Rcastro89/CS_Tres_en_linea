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
    public partial class Form1 : Form
    {
        Program programa = new Program();
        private string Nombre1;
        private string Nombre2;

        public Form1(string Jugador1, string Jugador2)
        {
            InitializeComponent();
            this.Nombre1 = Jugador1;
            this.Nombre2 = Jugador2;
        }

        private void accion_Botones(int x)
        {
            programa.posiciones[x] = programa.TurnoActual;
            programa.TurnoActual = programa.SeleccionTurno(programa.TurnoActual);
            programa.ValidarGanador = programa.JugadaGanadora();
            if (programa.ValidarGanador != "SG")
            {
                programa.Victoria(programa.ValidarGanador, this.label1, this.Nombre1, this.Nombre2);
                if (programa.ValidarGanador.Equals("X"))
                {
                    programa.Puntos[this.Nombre1] = programa.Puntos[this.Nombre1] + 1;
                    this.label5.Text = Convert.ToString(programa.Puntos[this.Nombre1]);
                }
                /*DialogResult resultado;
                resultado = MessageBox.Show(this, "Gano x jugador", "Fin del juego", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    this.Close();
                    Form1 form1 = new Form1(this.Nombre1, this.Nombre2);
                    form1.Show();
                }
                else
                {
                    this.Close();
                }*/
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (programa.posiciones[0] == "E")
            {
                button1.Text = programa.TurnoActual;
                accion_Botones(0);
            }
            label1.Focus(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (programa.posiciones[1] == "E")
            {
                button2.Text = programa.TurnoActual;
                accion_Botones(1);
            }
            label1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (programa.posiciones[2] == "E")
            {
                button3.Text = programa.TurnoActual;
                accion_Botones(2);
            }
            label1.Focus();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (programa.posiciones[3] == "E")
            {
                button4.Text = programa.TurnoActual;
                accion_Botones(3);
            }
            label1.Focus();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (programa.posiciones[4] == "E")
            {
                button5.Text = programa.TurnoActual;
                accion_Botones(4);
            }
            label1.Focus();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (programa.posiciones[5] == "E")
            {
                button6.Text = programa.TurnoActual;
                accion_Botones(5);
            }
            label1.Focus();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (programa.posiciones[6] == "E")
            {
                button7.Text = programa.TurnoActual;
                accion_Botones(6);
            }
            label1.Focus();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (programa.posiciones[7] == "E")
            {
                button8.Text = programa.TurnoActual;
                accion_Botones(7);
            }
            label1.Focus();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (programa.posiciones[8] == "E")
            {
                button9.Text = programa.TurnoActual;
                accion_Botones(8);
            }
            label1.Focus();
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            label1.Focus();
            label2.Text = this.Nombre1 + ": X";
            label3.Text = "O: " + this.Nombre2;
        }
    }
}
