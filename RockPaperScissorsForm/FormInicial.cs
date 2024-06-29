using RockPaperScissors;

namespace RockPaperScissorsForm
{
    public partial class FormInicial : Form
    {
        private List<Jugadores> listaJugadores;

        public FormInicial()
        {
            InitializeComponent();
            listaJugadores = new List<Jugadores>();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            dtvListaJugadores.DataSource = null;
            dtvListaJugadores.DataSource = listaJugadores;
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            FormsIngresoNombre formIngreso = new FormsIngresoNombre();
            if (formIngreso.ShowDialog() == DialogResult.OK)
            {
                Jugadores nuevoJugador = formIngreso.NuevoJugador;
                listaJugadores.Add(nuevoJugador);

                dtvListaJugadores.DataSource = null;
                dtvListaJugadores.DataSource = listaJugadores;
            }
        }
    }
}

