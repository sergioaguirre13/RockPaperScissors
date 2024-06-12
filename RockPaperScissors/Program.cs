using System.Security.Cryptography.X509Certificates;

namespace RockPaperScissors
{
    public class Program
    {
        static void Main(string[] args)
        {

            string nombreUser;
            bool continuar = true;
            bool nuevoUser = true;
            string opcionSeleccionada;
            char seleccionUser;
            char opcionrival;
            int contarVictorias = 0;
            List<Jugadores> listaJugadores = new List<Jugadores> ();


            while (nuevoUser) 
            {
              Console.Clear();
            Console.WriteLine("PIEDRA - PAPEL - TIJERA");
            Console.WriteLine("Escriba su nombre");
            nombreUser = Console.ReadLine();

                contarVictorias = 0;
                continuar = true;


            while (continuar)
            {
                opcionSeleccionada = OpcionSeleccionada();
                seleccionUser = Char.Parse(opcionSeleccionada);

                opcionrival = OpcionRival();


                Console.WriteLine($"Opcion seleccionada de usuario: {seleccionUser}");
                Console.WriteLine($"Opcion seleccionada de rival {opcionrival}");

                DevolverGanador(seleccionUser, opcionrival);

                Console.WriteLine("Seguir jugando?");
                if (Console.ReadLine() != "si")
                {
                    continuar = false;
                }

            }

            

            Jugadores nuevoJugador = new Jugadores(nombreUser, contarVictorias);

            listaJugadores.Add(nuevoJugador);

                Console.WriteLine("Nuevo usuario?");
                if (Console.ReadLine() != "si")
                {
                    nuevoUser = false;
                }

            }


            Console.Clear();


            ListaDePuntajes();

            






            string OpcionSeleccionada()
            {

                Console.WriteLine("Elegi Piedra (R) - papel (P) o tijera (S)");
                string seleccionUser = Console.ReadLine();

                if (seleccionUser?.ToLower() != "r" && seleccionUser?.ToLower() != "p" && seleccionUser?.ToLower() != "s")
                {
                    Console.WriteLine("Por favor ingresa solo las letras: R - P - S");
                    seleccionUser = OpcionSeleccionada();
                }

                return seleccionUser;
            }

            char OpcionRival()
            {
                char[] opciones = new char[] { 'r', 'p', 's' };

                Random rnd = new Random();
                int randomIndex = rnd.Next(0, opciones.Length);

                return opciones[randomIndex];
            }

            void DevolverGanador(char seleccionUser, char seleccionRival)
            {
                if (seleccionUser == seleccionRival)
                {
                    Console.WriteLine("Es un empate");
                }
                else
                {
                    switch (seleccionUser)
                    {
                        case 'r':
                            if (seleccionRival == 'p')
                            {
                                Console.WriteLine("Rival gana!");
                            }
                            else
                            {
                                Console.WriteLine("Usuario gana!");
                                contarVictorias++;
                            }
                            break;
                        case 'p':
                            if (seleccionRival == 's')
                            {
                                Console.WriteLine("Rival gana!");
                            }
                            else
                            {
                                Console.WriteLine("Usuario gana!");
                                contarVictorias++;

                            }
                            break;
                        case 's':
                            if (seleccionRival == 'r')
                            {
                                Console.WriteLine("Rival gana!");
                            }
                            else
                            {
                                Console.WriteLine("Usuario gana!");
                                contarVictorias++;

                            }
                            break;
                    }
                }

                
            }

            void ListaDePuntajes()
            {

                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;
                Console.WriteLine("    P U N T A J E S   ");
                foreach (Jugadores item in listaJugadores)
                {
                    Console.WriteLine(item.MostrarPuntajes());
                }
                Console.ResetColor();
            }

        }
    }
}
