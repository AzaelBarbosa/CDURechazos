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
using ClosedXML.Excel;

namespace CDURechazos.Catalogos
{
    public partial class frmFallas: frmCatalogos
    {
        DataTable dtFallas;
        int IdFalla;
        int intEditar;
        basFunctions basFunctions = new basFunctions();
        public frmFallas()
        {
            InitializeComponent();
        }

        protected override void Nuevo()
        {
            intEditar = 0;
            Height = 422;
            gbFallas.Visible = true;
            txNombre.Text = "";
            chEstatus.Checked = true;
            gbFallas.Text = "Nueva Falla";
        }

        protected override void Guardar()
        {
            string sSQL;

            if (txNombre.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un nombre para la falla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txCodigo.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un código para la falla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (basConfiguracion.ModoConexion == 1)
            {
                if (intEditar == 0)
                {
                    sSQL = "INSERT INTO Fallas (Descripcion, Estatus, Codigo) VALUES('" + txNombre.Text + "'," + (chEstatus.Checked ? 1 : 0) + ", '" + txCodigo.Text + "')";
                    sqlServer.ExecSQL(sSQL);
                    CargarDatos();
                    this.Height = 255;
                    basFunctions.InsertarHistorial("Se ha creado la falla " + txNombre.Text);
                }
                else
                {
                    sSQL = "UPDATE Fallas SET Descripcion = '" + txNombre.Text + "', Estatus = " + (chEstatus.Checked ? 1 : 0) + ", Codigo = '" + txCodigo.Text + "'  WHERE idFalla = " + IdFalla;
                    sqlServer.ExecSQL(sSQL);
                    CargarDatos();
                    this.Height = 255;
                    basFunctions.InsertarHistorial("Se ha editado la falla " + txNombre.Text);
                }
            }
            else
            {
                if (intEditar == 0)
                {
                    sSQL = "INSERT INTO public.\"Fallas\" (\"Descripcion\", \"Estatus\", \"Codigo\") VALUES('" + txNombre.Text + "'," + (chEstatus.Checked ? "True" : "False") + ", '" + txCodigo.Text + "')";
                    PgSQLHelper.ExecSQL(sSQL);
                    CargarDatos();
                    this.Height = 255;
                    basFunctions.InsertarHistorial("Se ha creado la falla " + txNombre.Text);
                }
                else
                {
                    sSQL = "UPDATE public.\"Fallas\" SET \"Descripcion\" = '" + txNombre.Text + "', \"Estatus\" = " + (chEstatus.Checked ? "True" : "False") + ", \"Codigo\" = '" + txCodigo.Text + "'  WHERE \"idFalla\" = " + IdFalla;
                    PgSQLHelper.ExecSQL(sSQL);
                    CargarDatos();
                    this.Height = 255;
                    basFunctions.InsertarHistorial("Se ha editado la falla " + txNombre.Text);
                }
            }
        }

        private void CargarDatos()
        {
            if (basConfiguracion.ModoConexion == 1)
            {
                dtFallas = sqlServer.ExecSQLReturnDT("SELECT * FROM Fallas", "Fallas");
                dgvFallas.DataSource = dtFallas;
                dgvFallas.Refresh();
            }
            else
            {
                dtFallas = PgSQLHelper.ExecSQLReturnDT(@"SELECT * FROM public.""Fallas""", "Fallas");
                dgvFallas.DataSource = dtFallas;
                dgvFallas.Refresh();
            }
        }
        protected override void Eliminar()
        {
            if (dgvFallas.CurrentRow == null)
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
            int id = Convert.ToInt32(dgvFallas.CurrentRow.Cells["idFalla"].Value);

            try
            {
                string query = $"DELETE FROM Fallas WHERE idFalla = {id}";
                sqlServer.ExecSQL(query); // Usa tu clase helper para ejecutar

                MessageBox.Show("Registro eliminado correctamente.");
                CargarDatos(); // Método tuyo para recargar el grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }

        private void frmFallas_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void btNewFalla_Click(object sender, EventArgs e)
        {
            intEditar = 0;
            Height = 422;
            gbFallas.Visible = true;
            txNombre.Text = "";
            chEstatus.Checked = true;
            gbFallas.Text = "Nueva Falla";
        }

        private void dgvFallas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvFallas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.Height = 422;
                intEditar = 1;
                gbFallas.Visible = true;
                gbFallas.Text = "Editar Falla";

                DataGridViewRow filaSeleccionada = dgvFallas.Rows[e.RowIndex];

                txNombre.Text = filaSeleccionada.Cells["Descripcion"].Value?.ToString();
                txCodigo.Text = filaSeleccionada.Cells["Codigo"].Value?.ToString();
                chEstatus.Checked = Convert.ToBoolean(filaSeleccionada.Cells["Estatus"].Value);
                IdFalla = Convert.ToInt32(filaSeleccionada.Cells["idFalla"].Value);
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Height = 255;
            intEditar = 0;
            gbFallas.Visible = false;
            txNombre.Text = "";
            chEstatus.Checked = true;
        }

        private void txNombre_TextChanged(object sender, EventArgs e)
        {
            
        }
    }
}
