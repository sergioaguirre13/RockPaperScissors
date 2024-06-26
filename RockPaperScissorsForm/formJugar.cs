﻿using System;
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
      //  Jugadores nuevoJugador;
        char SeleccionJugador;
        char SeleccionCpu;
        int contarVictorias = 0;

        public formJugar()
        {
            InitializeComponent();
        }

        public formJugar(Jugadores jugador)
        {
            //FALTARIA AGREGAR UNA INSTANCIA ACA ?

        }
        private void formJugar_Load(object sender, EventArgs e)
        {
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



        //falta agregar usuario --> adherirle cantidad de puntos (contarVictorias)
      //  resolucion del partido


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
                            MessageBox.Show("USUARIO GANA!");
                            contarVictorias++;
                        }
                        break;
                    case 'p':
                        if (seleccionRival == 's')
                        {
                            MessageBox.Show("CPU GANA!");
                        }
                        else
                        {
                            MessageBox.Show("USUARIO GANA!");
                            contarVictorias++;

                        }
                        break;
                    case 's':
                        if (seleccionRival == 'r')
                        {
                            MessageBox.Show("CPU GANA!");
                        }
                        else
                        {
                            MessageBox.Show("USUARIO GANA!");
                            contarVictorias++;

                        }
                        break;
                }
            }


        }

        #endregion


    }



}
