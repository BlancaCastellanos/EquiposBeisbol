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
        public string Entrenador { get; set; }
		public List<Jugador> Jugadores { get; set; }

        public Equipo()
        {
            Nombre = "Equipo nuevo";
            CiudadOrigen = "Sin Ciudad";
            Entrenador = "Sin entrenador";
            Jugadores = new List<Jugador>();
        }

		public Equipo(string nombre)
		{
			Nombre = nombre;
			CiudadOrigen = "Sin ciudad";
			Entrenador = "Sin entrenador";
			Jugadores = new List<Jugador>();
		}

	}
}
