using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02._1
{
    public class Titular
    {
        private string _nombre;
        private string _apellido;
        private DateTime _fechaNacimiento;
        private int _dni;
        private Genero _genero;
        private string _telefono;
        private int _edad;
        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value;}
        }

        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }

        public DateTime FechaNacimiento
        {
            get { return _fechaNacimiento; }
            set { _fechaNacimiento = value; }
        }
        public int Dni
        {
            get { return _dni; }
            set { _dni = value; }
        }

        public string Telefono
        {
            get { return _telefono; }
            set { _telefono = value; }
        }

        public int Edad
        {
            get
            {
                TimeSpan fechaNacimiento = DateTime.Now.Subtract(_fechaNacimiento);
                return Convert.ToInt32(Math.Truncate(fechaNacimiento.TotalDays/365.25));
            }
        }
        
        public Genero Sexo
        {
            get { return _genero; }
            set { _genero = value;}
        }


    }
}
