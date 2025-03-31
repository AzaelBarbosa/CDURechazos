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
    public partial class frmEditarRegistro: Form
    {
        public int intEditar;
        public int idRegistro;
        basFunctions basFunctions = new basFunctions();
        public frmEditarRegistro()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmEditarRegistro_Load(object sender, EventArgs e)
        {
            CargarComboFalla();
            if (idRegistro == 0)
            {
                intEditar = 0;
            }
            else
            {
                intEditar = 1;
                DataTable dtRegistro;
                if (basConfiguracion.ModoConexion == 1)
                {
                    dtRegistro = sqlServer.ExecSQLReturnDT("SELECT * FROM RegistroFallas WHERE id = " + idRegistro, "RegistroFallas");
                    txSerie.Text = dtRegistro.Rows[0]["Serie"].ToString();
                    txCodigo.Text = dtRegistro.Rows[0]["Codigo"].ToString();
                    txNombre.Text = dtRegistro.Rows[0]["Nombre"].ToString();
                    cboFalla.SelectedValue = dtRegistro.Rows[0]["idFalla"];
                    cboSubfalla.SelectedValue = dtRegistro.Rows[0]["idSubFalla"];
                }
                else
                {
                    dtRegistro = PgSQLHelper.ExecSQLReturnDT(@"SELECT * FROM public.""RegistroFallas"" WHERE ""id"" = " + idRegistro, "RegistroFallas");
                    txSerie.Text = dtRegistro.Rows[0]["Serie"].ToString();
                    txCodigo.Text = dtRegistro.Rows[0]["Codigo"].ToString();
                    txNombre.Text = dtRegistro.Rows[0]["Nombre"].ToString();
                    cboFalla.SelectedValue = dtRegistro.Rows[0]["idFalla"];
                    cboSubfalla.SelectedValue = dtRegistro.Rows[0]["idSubFalla"];
                }
            }
        }

        private void CargarComboFalla()
        {
            DataTable dtFalla;
            if (basConfiguracion.ModoConexion == 1)
            {
                dtFalla = sqlServer.ExecSQLReturnDT("SELECT * FROM Fallas", "Fallas");
                cboFalla.DataSource = dtFalla;
                cboFalla.DisplayMember = "Descripcion";
                cboFalla.ValueMember = "IdFalla";
            }
            else
            {
                dtFalla = PgSQLHelper.ExecSQLReturnDT(@"SELECT * FROM public.""Fallas""", "Fallas");
                cboFalla.DataSource = dtFalla;
                cboFalla.DisplayMember = "Descripcion";
                cboFalla.ValueMember = "IdFalla";
            }
        }

        private void CargarComboSubfalla()
        {
            DataTable dtSubFalla;
            if (basConfiguracion.ModoConexion == 1)
            {
                dtSubFalla = sqlServer.ExecSQLReturnDT("SELECT * FROM SubFallas WHERE idFalla = " + (cboFalla.ValueMember == "" ? 0 : cboFalla.SelectedValue), "SubFallas");
                cboSubfalla.DataSource = dtSubFalla;
                cboSubfalla.DisplayMember = "Descripcion";
                cboSubfalla.ValueMember = "IdSubFalla";
            }
            else
            {
                dtSubFalla = PgSQLHelper.ExecSQLReturnDT(@"SELECT * FROM public.""SubFallas"" WHERE ""idFalla"" = " + (cboFalla.ValueMember == "" ? 0 : cboFalla.SelectedValue), "SubFallas");
                cboSubfalla.DataSource = dtSubFalla;
                cboSubfalla.DisplayMember = "Descripcion";
                cboSubfalla.ValueMember = "IdSubFalla";
            }
        }

        private void cboFalla_SelectedIndexChanged(object sender, EventArgs e)
        {
            CargarComboSubfalla();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            string sSQL;

            if (basConfiguracion.ModoConexion == 1)
            {
                if (intEditar == 0)
                {
                    sSQL = "INSERT INTO RegistroFallas (Serie, Codigo, Nombre, idFalla, idSubFalla, Comentarios) VALUES('" + txSerie.Text + "','" + txCodigo.Text + "','" + txNombre.Text + "'," + cboFalla.SelectedValue + "," + cboSubfalla.SelectedValue + ", '" + txComentario.Text + "')";
                    sqlServer.ExecSQL(sSQL);
                    basFunctions.InsertarHistorial("Se ha insertado un nuevo registro de falla con Serie:" + txSerie.Text);
                }
                else
                {
                    sSQL = "UPDATE RegistroFallas SET Serie = '" + txSerie.Text + "', Codigo = '" + txCodigo.Text + "', Nombre = '" + txNombre.Text + "', idFalla = " + cboFalla.SelectedValue + ", idSubFalla = " + cboSubfalla.SelectedValue + ", Comentarios = '" + txComentario.Text + "' WHERE id = " + idRegistro;
                    sqlServer.ExecSQL(sSQL);
                    basFunctions.InsertarHistorial("Se ha actualizado un registro de falla con Serie:" + txSerie.Text);
                }
            }
            else
            {
                if (intEditar == 0)
                {
                    sSQL = "INSERT INTO public.\"RegistroFallas\" (\"Serie\", \"Codigo\", \"Nombre\", \"idFalla\", \"idSubFalla\") VALUES('" + txSerie.Text + "','" + txCodigo.Text + "','" + txNombre.Text + "'," + cboFalla.SelectedValue + "," + cboSubfalla.SelectedValue + ")";
                    PgSQLHelper.ExecSQL(sSQL);
                    basFunctions.InsertarHistorial("Se ha insertado un nuevo registro de falla con Serie:" + txSerie.Text);
                }
                else
                {
                    sSQL = "UPDATE public.\"RegistroFallas\" SET \"Serie\" = '" + txSerie.Text + "', \"Codigo\" = '" + txCodigo.Text + "', \"Nombre\" = '" + txNombre.Text + "', \"idFalla\" = " + cboFalla.SelectedValue + ", \"idSubFalla\" = " + cboSubfalla.SelectedValue + " WHERE \"id\" = " + idRegistro;
                    PgSQLHelper.ExecSQL(sSQL);
                    basFunctions.InsertarHistorial("Se ha actualizado un registro de falla con Serie:" + txSerie.Text);
                }
            }
            this.Close();
        }
    }
}
