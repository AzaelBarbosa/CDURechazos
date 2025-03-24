using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDURechazos.Catalogos;

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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUsuarios frmUsuarios = new frmUsuarios();
            frmUsuarios.MdiParent = this;
            frmUsuarios.Height = 322;
            frmUsuarios.Show();
        }

        private void fallasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFallas frmFallas = new frmFallas();
            frmFallas.MdiParent = this;
            frmFallas.Height = 255;
            frmFallas.Show();
        }

        private void subfallaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSubFallas frmSubFallas = new frmSubFallas();
            frmSubFallas.MdiParent = this;
            frmSubFallas.Height = 255;
            frmSubFallas.Show();
        }

        private void cerrarSesionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Close();
            frmLogin frmLogin2 = new frmLogin();
            frmLogin2.Show();
        }

        private void configuracionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmConfiguracion frmConfiguracion = new frmConfiguracion();
            frmConfiguracion.MdiParent = this;
            frmConfiguracion.Show();
        }

        private void perfilesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPerfiles frmPerfiles = new frmPerfiles();
            frmPerfiles.Height = 255;
            frmPerfiles.MdiParent = this;
            frmPerfiles.Show();
        }
    }
}
