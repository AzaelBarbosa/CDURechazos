using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDURechazos.Base_Forms;
using CDURechazos.Clases;
using CDURechazos.Modulos;

namespace CDURechazos
{
    public partial class frmRegistros: frmCatalogos
    {
        int IdRegistro;
        DataTable dtRegistros;
        public frmRegistros()
        {
            InitializeComponent();
        }

        protected override void Nuevo()
        {
            frmEditarRegistro frmEditarRegistro = new frmEditarRegistro();
            frmEditarRegistro.Text = "Nuevo Registro";
            frmEditarRegistro.ShowDialog();
            CargarDatos();
        }

        protected override void Guardar()
        {


        }

        private void CargarDatos()
        {
            if (basConfiguracion.ModoConexion == 1)
            {
                dtRegistros = sqlServer.ExecSQLReturnDT("SELECT RF.id, RF.Codigo, RF.Serie, RF.Nombre, F.Codigo AS [Codigo Falla], F.Descripcion AS Falla, SF.Descripcion AS [Sub Falla], RF.FechaAlta AS [Fecha Alta]  FROM RegistroFallas RF INNER JOIN Fallas F ON F.idFalla = RF.idFalla INNER JOIN SubFallas SF ON SF.idSubFalla = RF.idSubFalla", "Fallas");
                dgvRegistros.DataSource = dtRegistros;
                dgvRegistros.Refresh();
                basFunctions.dtExportar = dtRegistros;
            }
            else
            {
                dtRegistros = PgSQLHelper.ExecSQLReturnDT(@"SELECT RF.id, RF.""Codigo"", RF.""Serie"", RF.""Nombre"", F.""Codigo"" AS ""Codigo Falla"", F.""Descripcion"" AS ""Falla"", SF.""Descripcion"" AS ""Sub Falla"", RF.""FechaAlta"" AS ""Fecha Alta""  FROM public.""RegistroFallas"" RF
                                                            INNER JOIN public.""Fallas"" F ON F.""idFalla"" = RF.""idFalla""
                                                            INNER JOIN public.""SubFallas"" SF ON SF.""idSubFalla"" = RF.""idSubFalla""", "Registros");
                dgvRegistros.DataSource = dtRegistros;
                dgvRegistros.Refresh();
                basFunctions.dtExportar = dtRegistros;
            }
        }
        protected override void Eliminar()
        {
            if (dgvRegistros.CurrentRow == null)
            {
                MessageBox.Show("Por favor selecciona un registro para eliminar.");
                return;
            }

            // Confirmación
            DialogResult result = MessageBox.Show("¿Estás seguro de que deseas eliminar este registro?",
                                                  "Confirmar eliminación",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result != DialogResult.Yes)
                return;

            // Suponiendo que tu columna clave se llama "IdUsuario"
            int id = Convert.ToInt32(dgvRegistros.CurrentRow.Cells["id"].Value);

            try
            {
                string query = $"DELETE FROM RegistroFallas WHERE id = {id}";
                sqlServer.ExecSQL(query); // Usa tu clase helper para ejecutar

                MessageBox.Show("Registro eliminado correctamente.");
                CargarDatos(); // Método tuyo para recargar el grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);
            tbGuardar.Visible = false;
        }

        private void tlNuevo_Click(object sender, EventArgs e)
        {
            frmEditarRegistro frmEditarRegistro = new frmEditarRegistro();
            frmEditarRegistro.Text = "Nuevo Registro";
            frmEditarRegistro.ShowDialog();
            if (basConfiguracion.ModoConexion == 1)
            {
                //dtRegistros = sqlServer.ExecSQLReturnDT("SELECT * FROM Fallas", "Fallas");
                dgvRegistros.DataSource = dtRegistros;
                dgvRegistros.Refresh();
                basFunctions.dtExportar = dtRegistros;
            }
            else
            {
                dtRegistros = PgSQLHelper.ExecSQLReturnDT(@"SELECT RF.id, RF.""Codigo"", RF.""Serie"", RF.""Nombre"", F.""Codigo"" AS ""Codigo Falla"", F.""Descripcion"" AS ""Falla"", SF.""Descripcion"" AS ""Sub Falla"", RF.""FechaAlta"" AS ""Fecha Alta""  FROM public.""RegistroFallas"" RF
                                                            INNER JOIN public.""Fallas"" F ON F.""idFalla"" = RF.""idFalla"" 
                                                            INNER JOIN public.""SubFallas"" SF ON SF.""idSubFalla"" = RF.""idSubFalla""", "Registros");
                dgvRegistros.DataSource = dtRegistros;
                dgvRegistros.Refresh();
                basFunctions.dtExportar = dtRegistros;
            }
        }

        private void dgvRegistros_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow filaSeleccionada = dgvRegistros.Rows[e.RowIndex];
                IdRegistro = Convert.ToInt32(filaSeleccionada.Cells["id"].Value);
                frmEditarRegistro frmEditarRegistro = new frmEditarRegistro();
                frmEditarRegistro.Text = "Editar Registro";
                frmEditarRegistro.intEditar = 1;
                frmEditarRegistro.idRegistro = IdRegistro;
                frmEditarRegistro.ShowDialog();
            }
            if (basConfiguracion.ModoConexion == 1)
            {
                dtRegistros = sqlServer.ExecSQLReturnDT("SELECT RF.id, RF.Codigo, RF.Serie, RF.Nombre, F.Codigo AS Codigo Falla, F.Descripcion AS Falla, SF.Descripcion AS Sub Falla, RF.FechaAlta AS Fecha Alta  FROM public.RegistroFallas RF" +
                    " INNER JOIN Fallas F ON F.idFalla = RF.idFalla " +
                    " INNER JOIN SubFallas SF ON SF.idSubFalla = RF.idSubFalla", "Registros");
                dgvRegistros.DataSource = dtRegistros;
                dgvRegistros.Refresh();
            }
            else
            {
                dtRegistros = PgSQLHelper.ExecSQLReturnDT(@"SELECT RF.id, RF.""Codigo"", RF.""Serie"", RF.""Nombre"", F.""Codigo"" AS ""Codigo Falla"", F.""Descripcion"" AS ""Falla"", SF.""Descripcion"" AS ""Sub Falla"", RF.""FechaAlta"" AS ""Fecha Alta""  FROM public.""RegistroFallas"" RF
                                                            INNER JOIN public.""Fallas"" F ON F.""idFalla"" = RF.""idFalla"" 
                                                            INNER JOIN public.""SubFallas"" SF ON SF.""idSubFalla"" = RF.""idSubFalla""", "Registros");
                dgvRegistros.DataSource = dtRegistros;
                dgvRegistros.Refresh();
                basFunctions.dtExportar = dtRegistros;
            }
        }

        private void frmRegistros_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
            
        }

        private void txSerie_TextChanged(object sender, EventArgs e)
        {
            string filtro = txSerie.Text.Replace("'", "''");
            DataView dv = new DataView(dtRegistros);
            dv.RowFilter = $"Serie LIKE '%{filtro}%'";
            dgvRegistros.DataSource = dv;
           basFunctions.dtExportar = dv.ToTable();
        }

        private void FiltrarPorFechas()
        {
            if (dtRegistros == null) return;

            if (rbFecha.Checked)
            {
                DataView dv2 = new DataView(dtRegistros);
                dv2.RowFilter = $"[Fecha Alta] = #{dtFechaInicial.Value.Date:MM/dd/yyyy}#";
                dgvRegistros.DataSource = dv2;
                basFunctions.dtExportar = dv2.ToTable();
                return;
            }
            if (rbRango.Checked)
            {
                DateTime desde = dtFechaInicial.Value.Date;
                DateTime hasta = dtFechaFinal.Value.Date;
                // Filtro considerando solo la parte de fecha (sin hora)
                string filtro = $"[Fecha Alta] >= #{desde:MM/dd/yyyy}# AND [Fecha Alta] <= #{hasta:MM/dd/yyyy}#";
                DataView dv = new DataView(dtRegistros);
                dv.RowFilter = filtro;
                dgvRegistros.DataSource = dv;
                basFunctions.dtExportar = dv.ToTable();
                return;
            }
        }

        private void dtFechaInicial_ValueChanged(object sender, EventArgs e)
        {
            FiltrarPorFechas();
        }

        private void dtFechaFinal_ValueChanged(object sender, EventArgs e)
        {
            FiltrarPorFechas();
        }

        private void rbFecha_CheckedChanged(object sender, EventArgs e)
        {
            if (rbFecha.Checked)
            {
                lbFechaFinal.Visible = false;
                dtFechaFinal.Visible = false;
            }
        }

        private void rbRango_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRango.Checked)
            {
                lbFechaFinal.Visible = true;
                dtFechaFinal.Visible = true;
            }
        }
    }
}
