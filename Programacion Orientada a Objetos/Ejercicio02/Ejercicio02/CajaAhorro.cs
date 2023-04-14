using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio02
{
    internal class CajaAhorro
    {
        private int _numero;
        private string _tipoMoneda;
        private int _saldo;
        private string _titular;

        public int Numero { get { return _numero; } set { _numero = value; } }
        public string TipoMoneda { get { return _tipoMoneda; } set { _tipoMoneda = value; } }
        public int Saldo { get { return _saldo; } }
        public string Titular { get { return _titular; } set { _titular = value; } }

        public void Depositar(int monto)
        {
            _saldo += monto;
        }

        public string Extraer(int monto)
        {
            if (monto <= _saldo)
            { 
                _saldo -= monto;
                return "Operacion Correcta";
            }
            
            else
            {
                return "Saldo insuficiente";
            }
        }
    }
}
