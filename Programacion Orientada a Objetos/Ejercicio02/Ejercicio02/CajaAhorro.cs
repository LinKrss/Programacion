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

        public int Numero
        {
            get { return _numero; }
            set { _numero = value; }
        }
        public string TipoMoneda
        {
            get { return _tipoMoneda; }
            set { _tipoMoneda = value; }
        }
        public int Saldo
        {
            get { return _saldo; }
        }
        public string Titular
        {
            get { return _titular; }
            set { _titular = value; }
        }

        public string Depositar(int deposito)
        {
            if (deposito < 0)
            {
                return "El monto: " + deposito + "debe ser mayor que cero";
            }
            else
            {
                _saldo += deposito;
                return $"Se ha depositado {deposito} {_tipoMoneda}";
            }
        }

        public string Extraer(int extraccion)
        {
            if (extraccion <= _saldo)
            {
                _saldo -= extraccion;
                return "Operacion Correcta";
            }

            else
            {
                return "Saldo insuficiente";
            }
        }

        public string ConsultarSaldo()
        {
            return $"El saldo en {_tipoMoneda} es de {_saldo}";

        }
    }
}
