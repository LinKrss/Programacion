using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercitacion01
{
    internal class Avion
    {
        private string _compañia;
        private string _modelo;
        private int _velocidad;
        private int _altura;

        public void Acelerar()
        {
            _velocidad += 5;
        }

        public void Acelerar(int velocidad)
        {
            _velocidad += velocidad;
        }

        public void Desacelerar()
        {
            _velocidad -= 5;
        }

        public void Desacelerar(int velocidad)
        {
            _velocidad -= velocidad;
        }

        public void Subir()
        {
            _altura += 1;
        }

        public void Subir(int altura)
        {
            _altura += altura;
        }

        public void Bajar()
        {
            _altura -= 1;
        }

        public void Bajar(int altura)
        {
            _altura -= altura;
        }
    }
   
}
