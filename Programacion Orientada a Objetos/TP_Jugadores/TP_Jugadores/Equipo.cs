using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Jugadores
{
    internal class Equipo
    {
        List<Jugador> listaEquipo;

        public Equipo()
        {
            listaEquipo = new List<Jugador>();
        }

        public string AgregarJugador(Jugador jugador)
        {
            listaEquipo.Add(jugador);
            return "Se ha añadido correctamente";
        }
    }
}
