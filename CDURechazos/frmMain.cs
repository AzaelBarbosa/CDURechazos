using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CDURechazos
{
    public partial class frmMain: Form
    {

        public frmMain(DataRow drUsuario)
        {
            // Esta llamada es requerida por el diseñador
            InitializeComponent();

            // Inicialización personalizada
            tlUsuario.Text = drUsuario["NombreUsuario"].ToString();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}
