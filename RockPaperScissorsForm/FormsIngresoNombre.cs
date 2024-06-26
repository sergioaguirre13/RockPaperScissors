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
        Jugadores nuevoJugador;
        string nombreJugador = string.Empty;
        public FormsIngresoNombre()
        {
            InitializeComponent();
        }

        private void FormsIngresoNombre_Load(object sender, EventArgs e)
        {
        }

        private void btnCargarNombre_Click(object sender, EventArgs e)
        {
            nombreJugador = tbxNombre.Text;
            nuevoJugador = new Jugadores(nombreJugador);



            formJugar formJugar = new formJugar(nuevoJugador);
            formJugar.ShowDialog();
        }
    }
}
