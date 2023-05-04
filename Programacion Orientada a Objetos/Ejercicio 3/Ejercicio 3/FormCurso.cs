using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio_3
{
    public partial class FormCurso : Form
    {
        private ListaAlumnos curso;
        public FormCurso()
        {
            InitializeComponent();
            curso = new ListaAlumnos();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Alumno alumno = new Alumno();

            alumno.Nombre = tbxNombre.Text;
            alumno.Apellido = tbxApellido.Text;
            var conversionOk = int.TryParse(tbxLegajo.Text,out int Legajo);
            if (conversionOk)
            {
                alumno.NumeroLegajo = Legajo;
            }

            curso.AgregarAlumno(alumno);

            tbxNombre.Focus();
            tbxApellido.Focus();
            tbxLegajo.Focus();


        }
    }
}
