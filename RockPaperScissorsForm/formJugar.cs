using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RockPaperScissors;

namespace RockPaperScissorsForm
{
    public partial class formJugar : Form
    {
        private Jugadores nuevoJugador;
        private int contarVictorias = 0;

        public formJugar(Jugadores jugador)
        {
            InitializeComponent();
            nuevoJugador = jugador;
        }

        private void formJugar_Load(object sender, EventArgs e)
        {
            lblBienvenidaNombre.Text = $"Bievenido {nuevoJugador.Nombre} - EMPECEMOS A JUGAR! ";
            lblContadorVictorias.Text = contarVictorias.ToString();
        }

        #region BOTONES
        private void btnPiedra_Click(object sender, EventArgs e)
        {
            Jugar('r');
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            Jugar('p');
        }

        private void btnTijera_Click(object sender, EventArgs e)
        {
            Jugar('s');
        }

        #endregion

        #region METODOS
        private void Jugar(char seleccionJugador)
        {
            char seleccionCpu = OpcionRival();
            MostrarSeleccionCpu(seleccionCpu);
            DevolverGanador(seleccionJugador, seleccionCpu);
        }

        private static char OpcionRival()
        {
            char[] opciones = { 'r', 'p', 's' };
            Random rnd = new Random();
            return opciones[rnd.Next(opciones.Length)];
        }

        private void MostrarSeleccionCpu(char seleccionCpu)
        {
            switch (seleccionCpu)
            {
                case 'r':
                    txbCpu.Text = "CPU HA ELEGIDO PIEDRA";
                    break;
                case 'p':
                    txbCpu.Text = "CPU HA ELEGIDO PAPEL";
                    break;
                case 's':
                    txbCpu.Text = "CPU HA ELEGIDO TIJERA";
                    break;
            }
        }

        private void DevolverGanador(char seleccionUser, char seleccionCpu)
        {
            if (seleccionUser == seleccionCpu)
            {
                MessageBox.Show("Es un empate!");
            }
            else
            {
                bool userWins = (seleccionUser == 'r' && seleccionCpu == 's') ||
                                (seleccionUser == 'p' && seleccionCpu == 'r') ||
                                (seleccionUser == 's' && seleccionCpu == 'p');

                if (userWins)
                {
                    MessageBox.Show($"{nuevoJugador.Nombre} GANA!");
                    contarVictorias++;
                    lblContadorVictorias.Text = contarVictorias.ToString();
                }
                else
                {
                    MessageBox.Show("CPU GANA!");
                }
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            nuevoJugador.Puntaje = contarVictorias;
            DialogResult = DialogResult.OK;
            this.Close();
        }

        #endregion
    }
}