using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Jugadores
{
    internal class Arquero : Jugador
    {
        private double altura;

        public double Altura
        { 
            get { return altura; } 
            set { altura = value; }
        }

        public override string ToString()
        {
            return $"---------------------------\r\n Arquero:\r\n Nombre y Apellido: {base.Nombre}{base.Apellido}\r\n Fecha de Nacimiento: {base.FechaNacimiento}\r\n Edad: {base.Edad}\r\n Altura: {altura}\r\n";
        }
    }
}
