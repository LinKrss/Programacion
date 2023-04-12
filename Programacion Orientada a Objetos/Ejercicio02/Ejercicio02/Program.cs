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

            int monto = 5;

            cajaahorro.Depositar (monto) ;
            
            cajaahorro.Extraer (monto) ;
        }
    }
}
