using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class ListaAlumnos
    {
        private List<Alumno> alumnos;                   //Atributo

        public ListaAlumnos()                           //Constructor
        {
            alumnos = new List<Alumno>();               //Instanciar alumnos
        }

        public void AgregarAlumno(Alumno alumno)
        {
            alumnos.Add(alumno);
        }
    }
}
