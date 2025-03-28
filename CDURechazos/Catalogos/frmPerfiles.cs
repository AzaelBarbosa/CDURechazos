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

namespace CDURechazos.Catalogos
{
    public partial class frmPerfiles: Form
    {
        DataTable dtPerfiles;
        int IdPerfil;
        int intEditar;
        basFunctions basFunctions = new basFunctions();
        public frmPerfiles()
        {
            InitializeComponent();
        }

        private void frmPerfiles_Load(object sender, EventArgs e)
        {
            if (basConfiguracion.ModoConexion == 1)
            {
                dtPerfiles = sqlServer.ExecSQLReturnDT("SELECT * FROM Perfiles", "Perfiles");
                dgvPerfil.DataSource = dtPerfiles;
                dgvPerfil.Refresh();
            }
            else
            {
                dtPerfiles = PgSQLHelper.ExecSQLReturnDT(@"SELECT * FROM public.""Perfiles""", "Perfiles");
                dgvPerfil.DataSource = dtPerfiles;
                dgvPerfil.Refresh();
            }
        }

        private void btNewPerfil_Click(object sender, EventArgs e)
        {
            intEditar = 0;
            Height = 392;
            gbPerfil.Visible = true;
            txCodigo.Text = "";
            chEstatus.Checked = true;
            gbPerfil.Text = "Nueva Falla";
            this.Text = "Nuevo Perfil";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Height = 255;
            intEditar = 0;
            gbPerfil.Visible = false;
            txCodigo.Text = "";
            chEstatus.Checked = true;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            string sSQL;

            if (txCodigo.Text == "")
            {
                MessageBox.Show("Debe ingresar una Descripcion", "Perfiles", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            if (basConfiguracion.ModoConexion == 1)
            {
                if (intEditar == 0)
                {
                    sSQL = "INSERT INTO Perfiles (Descripcion, Estatus) VALUES('" + txCodigo.Text + "'," + (chEstatus.Checked ? 1 : 0) + ")";
                    sqlServer.ExecSQL(sSQL);
                    dtPerfiles = sqlServer.ExecSQLReturnDT("SELECT * FROM Perfiles", "Perfiles");
                    dgvPerfil.DataSource = dtPerfiles;
                    dgvPerfil.Refresh();
                    this.Height = 255;
                    basFunctions.InsertarHistorial("Se ha creado el perfil " + txCodigo.Text);
                }
                else
                {
                    sSQL = "UPDATE Perfiles SET Descripcion = '" + txCodigo.Text + "', Estatus = " + (chEstatus.Checked ? 1 : 0) + " WHERE IdPerfil = " + IdPerfil;
                    sqlServer.ExecSQL(sSQL);
                    dtPerfiles = sqlServer.ExecSQLReturnDT("SELECT * FROM Perfiles", "Perfiles");
                    dgvPerfil.DataSource = dtPerfiles;
                    dgvPerfil.Refresh();
                    this.Height = 255;
                    basFunctions.InsertarHistorial("Se ha editado el perfil " + txCodigo.Text);
                }
            }
            else
            {
                if (intEditar == 0)
                {
                    sSQL = "INSERT INTO public.\"Perfiles\" (\"Descripcion\", \"Estatus\") VALUES('" + txCodigo.Text + "'," + (chEstatus.Checked ? "True" : "False") + ")";
                    PgSQLHelper.ExecSQL(sSQL);
                    dtPerfiles = PgSQLHelper.ExecSQLReturnDT("SELECT * FROM public.\"Perfiles\"", "Perfiles");
                    dgvPerfil.DataSource = dtPerfiles;
                    dgvPerfil.Refresh();
                    this.Height = 255;
                    basFunctions.InsertarHistorial("Se ha creado el perfil " + txCodigo.Text);
                }
                else
                {
                    sSQL = "UPDATE public.\"Perfiles\" SET \"Descripcion\" = '" + txCodigo.Text + "', \"Estatus\" = " + (chEstatus.Checked ? "True" : "False") + " WHERE \"IdPerfil\" = " + IdPerfil;
                    PgSQLHelper.ExecSQL(sSQL);
                    dtPerfiles = PgSQLHelper.ExecSQLReturnDT("SELECT * FROM public.\"Perfiles\"", "Perfiles");
                    dgvPerfil.DataSource = dtPerfiles;
                    dgvPerfil.Refresh();
                    this.Height = 255;
                    basFunctions.InsertarHistorial("Se ha editado el perfil " + txCodigo.Text);
                }
            }
        }

        private void dgvPerfil_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.Height = 392;
                intEditar = 1;
                gbPerfil.Visible = true;
                gbPerfil.Text = "Editar Perfil";
                this.Text = "Editar Perfil";

                DataGridViewRow filaSeleccionada = dgvPerfil.Rows[e.RowIndex];

                txCodigo.Text = filaSeleccionada.Cells["Descripcion"].Value?.ToString();
                //chEstatus.Checked = Convert.ToBoolean(filaSeleccionada.Cells["Estatus"].Value);
                IdPerfil = Convert.ToInt32(filaSeleccionada.Cells["IdPerfil"].Value);
            }
        }
    }
}
