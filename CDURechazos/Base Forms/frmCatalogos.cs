using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static CDURechazos.Modulos.basFunctions;

namespace CDURechazos.Base_Forms
{
    public partial class frmCatalogos: Form
    {

        // Métodos virtuales que los hijos pueden sobreescribir
        protected virtual void Nuevo() { }
        protected virtual void Guardar() { }
        protected virtual void Eliminar() { }

        public frmCatalogos()
        {
            InitializeComponent();
        }

        private void tbNuevo_Click(object sender, EventArgs e)
        {
            Nuevo();
        }

        private void frmCatalogos_Load(object sender, EventArgs e)
        {

        }

        private void tbGuardar_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void tbEliminar_Click(object sender, EventArgs e)
        {
            Eliminar();
        }
    }
}
