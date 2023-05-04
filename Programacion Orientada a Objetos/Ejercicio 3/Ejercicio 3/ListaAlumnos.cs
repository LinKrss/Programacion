using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_3
{
    internal class ListaAlumnos
    {
        private List<Alumno> listaAlumnos;                   //Atributo

        public ListaAlumnos()                           //Constructor
        {
            listaAlumnos = new List<Alumno>();               //Instanciar alumnos
        }

        public string AgregarAlumno(Alumno alumno)
        {
            var alumnoExiste = listaAlumnos.FirstOrDefault(alumnoExistente => alumnoExistente.NumeroLegajo == alumno.NumeroLegajo);
            if (alumnoExiste != null)
            {
                return "El numero de legajo " + alumno.NumeroLegajo + " ya existe.";
            }
            else
            {
                listaAlumnos.Add(alumno);
                return "El alumno " + alumno.Nombre + " " + alumno.Apellido + " ha sido registrado correctamente";
            }
        }
        public IReadOnlyCollection<Alumno> ListarAlumnos()
        {
            return listaAlumnos.AsReadOnly();
        }
        public string RemoverAlumno(Alumno alumno)
        {
            var alumnoRemovido = listaAlumnos.Remove(alumno);
            if (alumnoRemovido)
            {
                return "El alumno: " + alumno.Nombre + " " + alumno.Apellido + " Fue removido de la lista de alumnos.";
            }
            else
            {
                return "El alumno ingresado no pertenece al listado de alumnos";
            }
        }
        public string RemoverAlumno(int numeroLegajo)
        {
            var alumnoExiste = listaAlumnos.FirstOrDefault(alumnoExistente => alumnoExistente.NumeroLegajo == numeroLegajo);
            if (alumnoExiste != null)
            {
                listaAlumnos.Remove(alumnoExiste);
                return "El alumno " + alumnoExiste.Nombre + " " + alumnoExiste.Apellido + " ha sido removido correctamente";
            }
            else
            {
                return "Numero de legajo inexistente";
            }
        }
    }
}

