using RockPaperScissors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissorsForm
{
   
        public partial class FormsIngresoNombre : Form
        {
            public Jugadores NuevoJugador { get; private set; }

            public FormsIngresoNombre()
            {
                InitializeComponent();
            }

            private void btnCargarNombre_Click(object sender, EventArgs e)
            {
                string nombreJugador = tbxNombre.Text;
                NuevoJugador = new Jugadores(nombreJugador);

                formJugar formJugar = new formJugar(NuevoJugador);
                formJugar.ShowDialog();

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }


