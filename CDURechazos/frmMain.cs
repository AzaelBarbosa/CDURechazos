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
using CDURechazos.Modulos;

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

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistros frmRegistros = new frmRegistros();
            frmRegistros.MdiParent = this;
            frmRegistros.Show();
        }

        private void exportarExcelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (basFunctions.dtExportar == null) return;

            SaveFileDialog saveFile = new SaveFileDialog
            {
                Filter = "Archivo Excel (*.xlsx)|*.xlsx",
                FileName = "Exportacion.xlsx"
            };

            if (saveFile.ShowDialog() == DialogResult.OK)
            {
                basFunctions basFunctions = new basFunctions();
                basFunctions.ExportarDataTableAExcel(basFunctions.dtExportar, saveFile.FileName);
                MessageBox.Show("Archivo exportado correctamente.", "Excel", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Abrir el Explorador de Archivos con el archivo seleccionado
                var psi = new System.Diagnostics.ProcessStartInfo
                {
                    FileName = "explorer.exe",
                    Arguments = $"/select,\"{saveFile.FileName}\""
                };

                System.Diagnostics.Process.Start(psi);
            }
        }

        private void logToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogs frmLog = new frmLogs();
            frmLog.MdiParent = this;
            frmLog.Show();
        }
    }
}
