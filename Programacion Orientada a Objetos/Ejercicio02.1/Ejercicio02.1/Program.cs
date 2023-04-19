using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Titular titular = new Titular();

            Console.WriteLine("Ingrese el nombre del titular de la cuenta");
            titular.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del titular de la cuenta");
            titular.Apellido = Console.ReadLine();

            Console.WriteLine("Ingrese el Dni del titular de la cuenta");
            titular.Dni = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la fecha de nacimiento del titular de la cuenta (dd/mm/aaaa)");
            titular.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("La edad es: " + titular.Edad);

            Console.ReadKey();


        }
    }
}
