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
            Titular miTitular = new Titular();

            Console.WriteLine("Ingrese el nombre del titular: ");
            miTitular.Nombre = Console.ReadLine();

            Console.WriteLine("Ingrese el apellido del titular: ");
            miTitular.Apellido = Console.ReadLine();

            Console.WriteLine("Ingrese el DNI del titular: ");
            miTitular.Dni = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Ingrese la fecha de nacimiento del titular de la cuenta (dd/mm/aaaa): ");
            miTitular.FechaNacimiento = Convert.ToDateTime(Console.ReadLine());

            Console.WriteLine("La edad es: " + miTitular.Edad);

            Console.ReadKey();


        }
    }
}
