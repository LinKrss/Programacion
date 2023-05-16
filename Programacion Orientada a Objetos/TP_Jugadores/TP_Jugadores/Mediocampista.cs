using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Jugadores
{
    internal class Mediocampista : Jugador
    {
        private int asistencias;

        public int Asistencias
        {
            get { return asistencias; }
            set { asistencias = value; }
        }

        public override string ToString()
        {
            return $"---------------------------\r\n Mediocampista:\r\n Nombre y Apellido: {base.Nombre}{base.Apellido}\r\n Fecha de Nacimiento: {base.FechaNacimiento}\r\n Edad: {base.Edad}\r\n Asistencias: {asistencias}\r\n";  
        }
    }
}
