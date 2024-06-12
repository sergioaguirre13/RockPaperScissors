using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    public class Jugadores
    {
        string nombre;
        int puntaje;

        public Jugadores(string nombre, int puntaje)
        {
            this.Nombre = nombre;
            this.Puntaje = puntaje;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }
    }
}
