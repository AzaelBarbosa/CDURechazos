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

namespace CDURechazos.Catalogos
{
    public partial class frmPerfiles: frmCatalogos
    {
        DataTable dtPerfiles;
        int IdPerfil;
        int intEditar;
        basFunctions basFunctions = new basFunctions();
        public frmPerfiles()
        {
            InitializeComponent();
        }

        protected override void Nuevo()
        {
            intEditar = 0;
            Height = 392;
            gbPerfil.Visible = true;
            txCodigo.Text = "";
            chEstatus.Checked = true;
            gbPerfil.Text = "Nueva Falla";
            this.Text = "Nuevo Perfil";
        }

        protected override void Guardar()
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

        private void CargarDatos()
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
        protected override void Eliminar()
        {
            if (dgvPerfil.CurrentRow == null)
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
            int id = Convert.ToInt32(dgvPerfil.CurrentRow.Cells["IdPerfil"].Value);

            try
            {
                string query = $"DELETE FROM Perfiles WHERE IdPerfil = {id}";
                sqlServer.ExecSQL(query); // Usa tu clase helper para ejecutar

                MessageBox.Show("Registro eliminado correctamente.");
                CargarDatos(); // Método tuyo para recargar el grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }


        private void frmPerfiles_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btNewPerfil_Click(object sender, EventArgs e)
        {
          
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
