using RockPaperScissors;

namespace RockPaperScissorsForm
{
    public partial class FormInicial : Form
    {
        List<Jugadores> listaJugadores;
        public FormInicial()
        {
            InitializeComponent();
        }

        private void FormInicial_Load(object sender, EventArgs e)
        {
            listaJugadores = new List<Jugadores>();
            dtvListaJugadores.DataSource = null;
            dtvListaJugadores.DataSource = listaJugadores;
        }

        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            formJugar formJugar = new formJugar();
            formJugar.ShowDialog();
            //update 13/06
        }
    }
}
