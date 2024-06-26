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
        string nombreJugador;
        char SeleccionJugador;
        char SeleccionCpu;
        int contarVictorias = 0;

        public formJugar(Jugadores jugador)
        {
            InitializeComponent();
            nombreJugador = jugador.Nombre;
        }

       
        private void formJugar_Load(object sender, EventArgs e)
        {
            lblBienvenidaNombre.Text = $"Bievenido {nombreJugador} - EMPECEMOS A JUGAR! ";
            lblContadorVictorias.Text = contarVictorias.ToString();
        }

        #region BOTONES
        private void btnPiedra_Click(object sender, EventArgs e)
        {
            SeleccionJugador = 'r';
            

            SeleccionCpu = OpcionRival();
            MostrarSeleccionCpu();
            DevolverGanador(SeleccionJugador, SeleccionCpu);
        }

        private void btnPapel_Click(object sender, EventArgs e)
        {
            SeleccionJugador = 'p';

            SeleccionCpu = OpcionRival();
            MostrarSeleccionCpu();
            DevolverGanador(SeleccionJugador, SeleccionCpu);

        }

        private void btnTijera_Click(object sender, EventArgs e)
        {
            SeleccionJugador = 's';
           
            SeleccionCpu = OpcionRival();
            MostrarSeleccionCpu();
            DevolverGanador(SeleccionJugador, SeleccionCpu);

        }

        #endregion



        /* Hay que guardar los datos del Usuario y su puntaje para que se vea en el grid del principio */


        #region METODOS
        private static char OpcionRival()
        {
            char[] opciones = new char[] { 'r', 'p', 's' };

            Random rnd = new Random();
            int randomIndex = rnd.Next(0, opciones.Length);

            return opciones[randomIndex];
        }
        private void MostrarSeleccionCpu()
        {
            switch (SeleccionCpu)
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
                default:
                    txbCpu.Text = "probando probando";
                    break;
            }
        }

        private void DevolverGanador(char seleccionUser, char seleccionRival)
        {
            if (seleccionUser == seleccionRival)
            {
                MessageBox.Show("Es un empate!");
            }
            else
            {
                switch (seleccionUser)
                {
                    case 'r':
                        if (seleccionRival == 'p')
                        {
                            MessageBox.Show("CPU GANA!");
                        }
                        else
                        {
                            MessageBox.Show($"{nombreJugador} GANA!");
                            contarVictorias++;
                            lblContadorVictorias.Text = contarVictorias.ToString();

                        }
                        break;
                    case 'p':
                        if (seleccionRival == 's')
                        {
                            MessageBox.Show("CPU GANA!");
                        }
                        else
                        {
                            MessageBox.Show($"{nombreJugador} GANA!");
                            contarVictorias++;
                            lblContadorVictorias.Text = contarVictorias.ToString();


                        }
                        break;
                    case 's':
                        if (seleccionRival == 'r')
                        {
                            MessageBox.Show("CPU GANA!");
                        }
                        else
                        {
                            MessageBox.Show($"{nombreJugador} GANA!");
                            contarVictorias++;
                            lblContadorVictorias.Text = contarVictorias.ToString();


                        }
                        break;
                }
            }


        }

        #endregion


    }



}
