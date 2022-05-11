using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tres_en_linea
{

    class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        
        public List<string> posiciones = new List<string>()
            {
                "E",
                "E",
                "E",
                "E",
                "E",
                "E",
                "E",
                "E",
                "E"
            };

        public string TurnoActual = "X";
        public string ValidarGanador = "";
        private int CantidadJugadores;
        private string Dificultad;
        private Dictionary<string, int> Puntos = new Dictionary<string, int>() {
            {"Empate", 0}
        };

        public string SeleccionTurno(string actual)
        {
            if (actual == "X")
                return "O";
            else
                return "X";
        }

        public string JugadaGanadora()
        {
            List<string> GanaX = new List<string>() { "X", "X", "X" };
            List<string> GanaO = new List<string>() { "O", "O", "O" };
            List<string> Jugada = new List<string>();
            Boolean empate = true;
            for (var x = 0; x < 3; x++)
                Jugada.Add(posiciones[x]);         
            if (GanaX.SequenceEqual(Jugada))
                return "X";
            else if (GanaO.SequenceEqual(Jugada))
                return "O";
            Jugada.Clear();
            for (var x = 3; x < 6; x++)
                Jugada.Add(posiciones[x]);
            if (GanaX.SequenceEqual(Jugada))
                return "X";
            else if (GanaO.SequenceEqual(Jugada))
                return "O";
            Jugada.Clear();
            for (var x = 6; x < 9; x++)
                Jugada.Add(posiciones[x]);
            if (GanaX.SequenceEqual(Jugada))
                return "X";
            else if (GanaO.SequenceEqual(Jugada))
                return "O";
            Jugada.Clear();
            for (var x = 0; x < 7; x += 3)
                Jugada.Add(posiciones[x]);
            if (GanaX.SequenceEqual(Jugada))
                return "X";
            else if (GanaO.SequenceEqual(Jugada))
                return "O";
            Jugada.Clear();
            for (var x = 1; x < 8; x += 3)
                Jugada.Add(posiciones[x]);
            if (GanaX.SequenceEqual(Jugada))
                return "X";
            else if (GanaO.SequenceEqual(Jugada))
                return "O";
            Jugada.Clear();
            for (var x = 2; x < 9; x += 3)
                Jugada.Add(posiciones[x]);
            if (GanaX.SequenceEqual(Jugada))
                return "X";
            else if (GanaO.SequenceEqual(Jugada))
                return "O";
            Jugada.Clear();
            for (var x = 0; x < 9; x += 4)
                Jugada.Add(posiciones[x]);
            if (GanaX.SequenceEqual(Jugada))
                return "X";
            else if (GanaO.SequenceEqual(Jugada))
                return "O";
            Jugada.Clear();
            for (var x = 2; x < 7; x += 2)
                Jugada.Add(posiciones[x]);
            if (GanaX.SequenceEqual(Jugada))
                return "X";
            else if (GanaO.SequenceEqual(Jugada))
                return "O";
            foreach (string val in posiciones)
            {
                if (val == "E")
                {
                    empate = false;
                    break;
                }
                    
            }
            if (empate == true)
                return "E";
            return "SG";
        }

        public void Victoria(string validar, Label ganador, string Nombre1, string Nombre2)
        {
            if (validar == "X")
                ganador.Text = "Gana el jugador " + Nombre1;
            else if (validar == "O")
                ganador.Text = "Gana el jugador " + Nombre2;
            else if (validar == "E")
                ganador.Text = "Nadie Gana";
        }

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form2());
            
        }
    }

}
