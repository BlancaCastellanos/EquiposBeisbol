using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBeisbol
{
    class Equipo
    {
        public string Nombre { get; set; }
        public string CiudadOrigen { get; set; }
        public List<Jugador> Equipos { get; set; }
        public string Entrenador { get; set; }
        public string Jugadores { get; set; }

        public Equipo(string materia, string codigo)
        {
            Nombre = materia;
            CiudadOrigen = codigo;
            Entrenador = entrenador;
            Jugadores = new List<Jugador>();

        }
    }
}
