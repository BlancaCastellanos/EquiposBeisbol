
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBeisbol
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Equipo> equipos = new List<Equipo>();

            Equipo equipo1 = new Equipo("Equipo 1");
			equipo1.Entrenador = "Hector";
			equipo1.CiudadOrigen = "Ciudad Obregon";

			equipo1.Jugadores.Add(new Jugador("Homero",64));
			equipo1.Jugadores.Add(new Jugador("Pedro",65 ));
			equipo1.Jugadores.Add(new Jugador("Omar",78 ));
			equipo1.Jugadores.Add(new Jugador("Cesar",10 ));
			equipo1.Jugadores.Add(new Jugador("Olguins",26 ));
			equipo1.Jugadores.Add(new Jugador("Peter",25));
			equipo1.Jugadores.Add(new Jugador("Fernando",7 ));
			equipo1.Jugadores.Add(new Jugador("Eddy",11 ));
			equipo1.Jugadores.Add(new Jugador("Carlos",1 ));

			Equipo equipo2 = new Equipo("Equipo 2 ");
			equipo2.Entrenador = "Mauricio";
			equipo2.CiudadOrigen = "Ciudad de México";

			equipo2.Jugadores.Add(new Jugador("Jeiv", 19));
			equipo2.Jugadores.Add(new Jugador("Alberto", 3));
			equipo2.Jugadores.Add(new Jugador("Alexis", 55));
			equipo2.Jugadores.Add(new Jugador("Luis", 42));
			equipo2.Jugadores.Add(new Jugador("Wilfredo", 32));
			equipo2.Jugadores.Add(new Jugador("Max", 13));
			equipo2.Jugadores.Add(new Jugador("Victor", 47));
			equipo2.Jugadores.Add(new Jugador("Bryant", 61));
			equipo2.Jugadores.Add(new Jugador("Ivan", 30));

			equipos.Add(equipo1);
			equipos.Add(equipo2);

            foreach (Equipo equipo in equipos)
            {
                Console.WriteLine("Equipo: " + equipo.Nombre + " de " + equipo.CiudadOrigen);
                Console.WriteLine("Lista de jugadores: ");

                foreach (Jugador jugador in equipo.Jugadores)
                {
                    Console.WriteLine("*" + jugador.Nombre + " " + jugador.Numero);
                }
            }

            Console.Read();

        }
    }
}
