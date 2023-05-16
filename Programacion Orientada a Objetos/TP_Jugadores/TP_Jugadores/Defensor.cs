using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_Jugadores
{
    internal class Defensor : Jugador
    {
        private int tarAmarillas;
        private int tarRojas;

        public int TarAmalillas
        {
            get { return tarAmarillas; }
            set { tarAmarillas = value; }
        }

        public int TarRojas
        {
            get { return tarRojas; }
            set { tarRojas = value; }
        }

        public override string ToString()
        {
            return $"---------------------------\r\n Defensor:\r\n Nombre y Apellido: {base.Nombre}{base.Apellido}\r\n Fecha de Nacimiento: {base.FechaNacimiento}\r\n Edad: {base.Edad}\r\n Tarjetas amarillas: {tarAmarillas}\r\n Trjetas Rojas: {tarRojas}\r\n";
        }
    }
}
