using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ej_01
{
    internal class ListaInventario
    {
        private List<Producto> listaInventarios;

        public ListaInventario()
        {
            listaInventarios = new List<Producto>();
        }

        public void AgregarProducto(Producto producto)
        {
            listaInventarios.Add(producto);

        }

    }
}
