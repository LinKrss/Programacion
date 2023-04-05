using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio01
{
    internal class Auto
    {
        private string _marca;
        private string _modelo;
        private int _velocidad;

        public void Acelerar()
        {
            _velocidad += 5;
        }

        public void Acelerar(int velocidad)
        {
            _velocidad += _velocidad;
        }

        public void Frenar()
        {
            _velocidad -= 5;
        }

        public void Frenar(int velocidad)
        {
            _velocidad -= _velocidad;
        }
    }
}
