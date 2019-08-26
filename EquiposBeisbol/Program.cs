
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

            Equipo equipo1 = new Equipo("Equipo 1", "Mexico");
            Equipo equipo2 = new Equipo("Equipo 2", "Estados Unidos");

            equipos.Add(equipo1);
            equipos.Add(equipo2);

            Jugador Jeiv = new Jugador("Jeiv", "Brazil");
            Jugador Homero = new Jugador("Homero", "Inglaterra");
            Jugador Omar = new Jugador("Omar", "Mexico");
            Jugador Pedro = new Jugador("Pedro", "Estados Unidos");
            Jugador Alberto = new Jugador("Alberto", "Portugal");
            Jugador Alexis = new Jugador("Alexis", "Inglaterra");
            Jugador Luis = new Jugador("Luis", "Mexico");
            Jugador Wilfredo = new Jugador("Wilfredo", "Estados Unidos");
            Jugador Max = new Jugador("Max", "Portugal");
            Jugador Victor = new Jugador("Victor", "Mexico");
            Jugador Bryant = new Jugador("Bryant", "Colombia");
            Jugador Fernando= new Jugador("Fernando", "España");
            Jugador Ivan = new Jugador("Ivan", "Estados Unidos");
            Jugador Carlos = new Jugador("Carlos", "Portugal");
            Jugador Olguins = new Jugador("Olguins", "Estados Unidos");
            Jugador Peter = new Jugador("Peter", "Estados Unidos");
            Jugador Cesar = new Jugador("Cesar", "España");
            Jugador Eddy = new Jugador("Eddy", "Inglaterra");

            equipo1.Jugadores.Add(Homero);
            equipo1.Jugadores.Add(Pedro);
            equipo1.Jugadores.Add(Omar);
            equipo1.Jugadores.Add(Cesar);
            equipo1.Jugadores.Add(Olguins);
            equipo1.Jugadores.Add(Peter);
            equipo1.Jugadores.Add(Fernando);
            equipo1.Jugadores.Add(Eddy);
            equipo1.Jugadores.Add(Carlos);

            equipo2.Jugadores.Add(Jeiv);
            equipo2.Jugadores.Add(Alberto);
            equipo2.Jugadores.Add(Alexis);
            equipo2.Jugadores.Add(Luis);
            equipo2.Jugadores.Add(Wilfredo);
            equipo2.Jugadores.Add(Max);
            equipo2.Jugadores.Add(Victor);
            equipo2.Jugadores.Add(Bryant);
            equipo2.Jugadores.Add(Ivan);

            foreach (Equipo grupo in equipos)
            {
                Console.WriteLine("Equipo: " + grupo.Equipos);
                Console.WriteLine("Nombre: " + grupo.Nombre);
                Console.WriteLine("Entrenador: " + grupo.Entrenador);
                Console.WriteLine("Lista de jugadores: " + grupo.Jugadores);

                foreach (Jugador alumno in grupo.Jugadores)
                {
                    Console.WriteLine("*" + Equipo.Nombre);
                }
            }

            Console.Read();

        }
    }
}
