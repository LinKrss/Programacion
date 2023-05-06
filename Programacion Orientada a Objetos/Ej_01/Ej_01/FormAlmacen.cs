using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ej_01
{
    public partial class FormAlmacen : Form
    {
        private ListaInventario almacen;
        public FormAlmacen()
        {
            InitializeComponent();
            almacen = new ListaInventario();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Producto producto = new Producto();

            producto.Nombre = tbxNombre.Text;
            var conversionOk = int.TryParse(tbxCantidad.Text, out int cantidad);
            if (conversionOk)
            {
                producto.Cantidad = cantidad;
            }

            var conversionOK = int.TryParse(tbxPrecio.Text, out int precio);
            if (conversionOK) 
            {
                producto.Precio = precio;
            }

            almacen.AgregarProducto(producto);

            tbxNombre.Focus();
            tbxPrecio.Focus();
            tbxCantidad.Focus();

        }
    }
}
