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
    public partial class frmLogs: Form
    {
        DataTable dtHistorial;
        public frmLogs()
        {
            InitializeComponent();
        }

        private void CargarComboUsuarios()
        {
            DataTable dtUsuarios;
            if (basConfiguracion.ModoConexion == 1)
            {
                dtUsuarios = sqlServer.ExecSQLReturnDT("SELECT * FROM Usuarios", "Usuarios");
                cboUsuario.DataSource = dtUsuarios;
                cboUsuario.DisplayMember = "Usuario";
                cboUsuario.ValueMember = "IdUsuario";
            }
            else
            {
                dtUsuarios = PgSQLHelper.ExecSQLReturnDT(@"SELECT * FROM public.""Usuarios""", "Usuarios");
                cboUsuario.DataSource = dtUsuarios;
                cboUsuario.DisplayMember = "Usuario";
                cboUsuario.ValueMember = "IdUsuario";
            }
        }

        private void FiltrarPorFechas()
        {
            if (dtHistorial == null) return;

            DateTime desde = dtDesde.Value.Date;
            DateTime hasta = dtHasta.Value.Date;

            if (desde < hasta)
            {
                MessageBox.Show("La fecha de inicio no puede ser mayor a la fecha final.");
                return;
            }

            if (hasta > desde) {
                MessageBox.Show("La fecha final no puede ser menor a la fecha inicial.");
                return;
            }
                
                // Filtro considerando solo la parte de fecha (sin hora)
                string filtro = $"Fecha >= #{desde:MM/dd/yyyy}# AND Fecha <= #{hasta:MM/dd/yyyy}#";
                DataView dv = new DataView(dtHistorial);
                dv.RowFilter = filtro;
                dgvLogs.DataSource = dv;
                return;
            
        }

        private void frmLogs_Load(object sender, EventArgs e)
        {
            if (basConfiguracion.ModoConexion == 1)
            {
                dtHistorial = sqlServer.ExecSQLReturnDT("SELECT U.Usuario, U.NombreUsuario AS [Nombre Usuario], LF.Descripcion, LF.FechaAlta AS Fecha FROM LogFallas LF INNER JOIN Usuarios U ON LF.idUsuario = U.IdUsuario", "Usuarios");
                dgvLogs.DataSource = dtHistorial;
                dgvLogs.Refresh();
            }
            else
            {
                dtHistorial = PgSQLHelper.ExecSQLReturnDT(@"SELECT U.Usuario, U.NombreUsuario AS [Nombre Usuario], LF.Descripcion, LF.FechaAlta AS Fecha FROM LogFallas LF INNER JOIN Usuarios U ON LF.idUsuario = U.IdUsuario", "Usuarios");
                dgvLogs.DataSource = dtHistorial;
                dgvLogs.Refresh();
            }
            CargarComboUsuarios();
        }

        private void dtDesde_ValueChanged(object sender, EventArgs e)
        {
            FiltrarPorFechas();
        }

        private void dtHasta_ValueChanged(object sender, EventArgs e)
        {
            FiltrarPorFechas();
        }

        private void cboUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filtro = cboUsuario.Text.Replace("'", "''");
            DataView dv = new DataView(dtHistorial);
            dv.RowFilter = $"Usuario LIKE '%{filtro}%'";
            dgvLogs.DataSource = dv;
        }
    }
}
