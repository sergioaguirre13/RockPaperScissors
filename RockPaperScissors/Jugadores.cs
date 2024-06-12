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

        

        public Jugadores(string nombre) 
        {
            this.Nombre = nombre;
        }

        public Jugadores(string nombre,int puntaje) : this(nombre)
        {
        this.puntaje = puntaje;
        }

        public string Nombre { get => nombre; set => nombre = value; }
        public int Puntaje { get => puntaje; set => puntaje = value; }

        public  string MostrarPuntajes()
        {
 
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("");
            sb.Append($"nombre: {Nombre}");
            sb.Append(" || ");
            sb.Append($"puntaje: {Puntaje}");
            return sb.ToString();
 
        }
    }

}
