using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EquiposBeisbol
{
    class Jugador
    {
        public string Nombre { get; set; }
        public string Numero { get; set; }
        public Jugador(string nombre, string numero)
        {
            Nombre = nombre;
            Numero = numero;
        }
    }
}
