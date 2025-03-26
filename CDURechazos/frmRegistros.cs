using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDURechazos.Clases;
using CDURechazos.Modulos;

namespace CDURechazos
{
    public partial class frmRegistros: Form
    {
        int IdRegistro;
        DataTable dtRegistros;
        public frmRegistros()
        {
            InitializeComponent();
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
                //dtRegistros = sqlServer.ExecSQLReturnDT("SELECT * FROM Fallas", "Fallas");
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

        private void btnuevo_Click(object sender, EventArgs e)
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
