namespace RockPaperScissors
{
    public class Program
    {
        static void Main(string[] args)
        {
            bool seguirJugando = true;
            int seleccionUser = 0;
            Random rnd = new Random();
            int seleccionCpu = 0;
            int contadorVictorias = 0;


            Console.WriteLine("Bienvenido a: Piedra, papel o tijera ");
            


            while(seguirJugando)
            {

                Console.WriteLine("(1) Piedra - (2) Papel - (3) Tijera");
                seleccionUser = int.Parse(Console.ReadLine());
                seleccionCpu = rnd.Next(1, 3);

                if (TurnoUser(seleccionUser, seleccionCpu))
                {
                    Console.WriteLine("User ha ganado");
                    contadorVictorias++;
                }
                else
                {
                    Console.WriteLine("User ha empatado o perdido");
                }
               





                Console.WriteLine("Seguir jugando?");
                if (Console.ReadLine() == "no")
                {
                    seguirJugando = false;
                }
            }

        }

        public static bool TurnoUser(int eleccionUser,int eleccionCpu)
        {
            bool ganador = true;

            switch (eleccionUser)
            {
                case 1:
                    if (eleccionCpu == 1)
                    {
                        
                        ganador = false;
                        
                    }
                    else if (eleccionCpu == 2)
                    {
                        
                        ganador = false;
                    }
                    else
                    {
                        ganador = true;
                    }
                    break;
                case 2:
                    if (eleccionCpu == 1)
                    {
                        ganador = true;
                    }
                    else if (eleccionCpu == 2)
                    {
                        ganador = false;
                    }
                    else
                    {
                        ganador = false;
                    }
                    break;
                case 3:
                    if (eleccionCpu == 1)
                    {
                        ganador = false;
                    }
                    else if (eleccionCpu == 2)
                    {
                        ganador = true;
                    }
                    else
                    {
                        ganador = false;
                    }
                    break;
            }

            return ganador;

        }
    }
}
