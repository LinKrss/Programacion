using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class Alumno
    {
        private string _Legajo;
        private string _Nombre;
        private string _Apellido;
        private DateTime _Fecha_Nacimiento;
        private DateTime _Fecha_Ingreso;
        private bool _Activo;
        private int _Cant_Materia_Aprobadas;

        public string NumeroLegajo
        {
            get { return _Legajo; }
            set { _Legajo = value; }
        }

        public string Nombre
        { 
            get { return _Nombre; }
            set { _Nombre = value; }
        }
        
        public string Apellido
        { 
            get { return _Apellido; }
            set { _Apellido  = value; }        
        }

        public DateTime FechaNacimiento
        {
            get { return _Fecha_Nacimiento; }
            set { _Fecha_Nacimiento = value; }
        }

        public DateTime FechaIngreso
        {
            get { return _Fecha_Ingreso; }
        }

        public bool Activo
        {
            get { return _Activo; }
            set { _Activo = value; }
        }

        public int CantidadMateriasAprobadas
        {
            get { return _Cant_Materia_Aprobadas; }
        }
    }
}
