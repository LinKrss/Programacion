using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace TP_Jugadores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Jugador jugador = new Jugador();
            Arquero arquero = new Arquero();
            Defensor defensor = new Defensor();
            Mediocampista mediocampista = new Mediocampista();
            Delantero delantero = new Delantero();


        }

        private void LeerDatos(Jugador jugador)
        {
            Console.WriteLine("Ingrese el nombre del jugador");
            jugador.Nombre = Console.ReadLine();
            Console.WriteLine("Ingrese el apellido del jugador");
            jugador.Apellido = Console.ReadLine();
            Console.WriteLine("Ingrese la fecha de nacimiento (dd/mm/aaaa)");
            jugador.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());

            Jugador jugador = new Jugador(Nombre, Apellido, FechaNacimiento);
            return jugador;
        }
    }
}