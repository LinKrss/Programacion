using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace TP_Jugadores
{
    internal abstract class Jugador
    {
        private string nombre;
        private string apellido;
        private DateTime fechaNacimiento;
        private int edad;
        
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }
        }

        public int Edad
        {
            get
            {
                TimeSpan _fechaNacimiento = DateTime.Now.Subtract(fechaNacimiento);
                return Convert.ToInt32(Math.Truncate(_fechaNacimiento.TotalDays / 365.25));
            }
        }
    }
}
