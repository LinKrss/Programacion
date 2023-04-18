using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CajaAhorro cajaahorro = new CajaAhorro();

            Console.WriteLine("Ingrese el nombre del titular");
            string _titular = Console.ReadLine();

            Console.WriteLine("Ingrese el numero de cuenta");
            string _nroCuenta = Console.ReadLine();

            Console.WriteLine("Ingrese el tipo de moneda");
            string _tipoMoneda = Console.ReadLine();

            cajaahorro.Numero = Convert.ToInt32(_nroCuenta);
            cajaahorro.Titular = _titular;
            cajaahorro.TipoMoneda = _tipoMoneda;

            Console.WriteLine("Bienvenido Sr/Sra" + _titular);
            Console.WriteLine("Que operacion en" + _tipoMoneda + " realizara en su cuenta n° " + _nroCuenta);

            int op = 1;
            while(op != 9)
            {
                do
                {
                    Console.WriteLine("Ingrese el numero de transaccion que desea realizar" +
                        "\n \t 1- Consultar Saldo \n \t 2- Depositar \n \t 3- Retirar efectivo \n \t 4- Consultar datos de la cuenta" + "\n \t 9- Salir");
                    op = int.Parse(Console.ReadLine());
                }

                while (op == 1 && op == 2 && op == 3 && op == 4 && op == 9);

                switch (op)
                {
                    case 1:
                        Console.WriteLine("El saldo de su caja de ahorro es $" + cajaahorro.Depositar(monto) + ".");

                        break;
                        

                       
                }
            }

            
        

            
        }
    }
}
