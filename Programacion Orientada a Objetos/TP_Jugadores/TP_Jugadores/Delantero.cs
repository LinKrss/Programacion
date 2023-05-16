using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Jugadores
{
    internal class Delantero : Jugador
    {
        private int goles;

        public int Goles
        {
            get { return goles; }
            set { goles = value; }
        }

        public override string ToString()
        {
            return $"---------------------------\r\n Delantero:\r\n Nombre y Apellido: {base.Nombre}{base.Apellido}\r\n Fecha de Nacimiento: {base.FechaNacimiento}\r\n Edad: {base.Edad}\r\n Goles: {goles}\r\n";
        }
    }
}
