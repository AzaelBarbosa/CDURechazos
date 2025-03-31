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
    public partial class frmSubFallas: frmCatalogos
    {
        DataTable dtFallas;
        DataTable dtSubFallas;
        int IdSubFalla;
        int intEditar;
        DataSet dtRespon;
        basFunctions basFunctions = new basFunctions();
        public frmSubFallas()
        {
            InitializeComponent();
        }

        protected override void Nuevo()
        {
            intEditar = 0;
            Height = 500;
            gbSubFalla.Visible = true;
            txNombre.Text = "";
            chEstatus.Checked = true;
            gbSubFalla.Text = "Nueva Falla";
        }

        protected override void Guardar()
        {
            string sSQL;

            if (txNombre.Text.Length == 0)
            {
                MessageBox.Show("Debe ingresar un nombre para la subfalla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (cboFallas.SelectedIndex == 0)
            {
                MessageBox.Show("Debe seleccionar una falla", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (basConfiguracion.ModoConexion == 1)
            {
                if (intEditar == 0)
                {
                    sSQL = "INSERT INTO SubFallas (Descripcion, Estatus, idFalla) VALUES('" + txNombre.Text + "'," + (chEstatus.Checked ? 1 : 0) + ", " + cboFallas.SelectedValue + ")";
                    sqlServer.ExecSQL(sSQL);
                    CargarDatos();
                    this.Height = 300;
                    basFunctions.InsertarHistorial("Se ha creado la subfalla " + txNombre.Text);
                }
                else
                {
                    sSQL = "UPDATE SubFallas SET Descripcion = '" + txNombre.Text + "', Estatus = " + (chEstatus.Checked ? 1 : 0) + ", idFalla = " + cboFallas.SelectedValue + " WHERE IdSubFalla = " + IdSubFalla;
                    sqlServer.ExecSQL(sSQL);
                    CargarDatos();
                    this.Height = 300;
                    basFunctions.InsertarHistorial("Se ha editado la subfalla " + txNombre.Text);
                }
            }
            else
            {
                if (intEditar == 0)
                {
                    sSQL = "INSERT INTO public.\"SubFallas\" (\"Descripcion\", \"Estatus\", \"idFalla\") VALUES('" + txNombre.Text + "'," + (chEstatus.Checked ? "True" : "False") + ", " + cboFallas.SelectedValue + ")";
                    PgSQLHelper.ExecSQL(sSQL);
                    CargarDatos();
                    this.Height = 300;
                    basFunctions.InsertarHistorial("Se ha creado la subfalla " + txNombre.Text);
                }
                else
                {
                    sSQL = "UPDATE public.\"SubFallas\" SET \"Descripcion\" = '" + txNombre.Text + "', \"Estatus\" = " + (chEstatus.Checked ? "True" : "False") + ", \"idFalla\" = " + cboFallas.SelectedValue + " WHERE \"IdSubFalla\" = " + IdSubFalla;
                    PgSQLHelper.ExecSQL(sSQL);
                    CargarDatos();
                    this.Height = 300;
                    basFunctions.InsertarHistorial("Se ha editado la subfalla " + txNombre.Text);
                }
            }
        }

        private void CargarDatos()
        {
            if (basConfiguracion.ModoConexion == 1)
            {
                dtSubFallas = sqlServer.ExecSQLReturnDT("SELECT * FROM SubFallas", "SubFallas");
                dgvFallas.DataSource = dtSubFallas;
                dgvFallas.Refresh();
            }
            else
            {
                dtSubFallas = PgSQLHelper.ExecSQLReturnDT(@"SELECT * FROM public.""SubFallas""", "Fallas");
                dgvFallas.DataSource = dtSubFallas;
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
            int id = Convert.ToInt32(dgvFallas.CurrentRow.Cells["IdSubFalla"].Value);

            try
            {
                string query = $"DELETE FROM SubFallas WHERE IdSubFalla = {id}";
                sqlServer.ExecSQL(query); // Usa tu clase helper para ejecutar

                MessageBox.Show("Registro eliminado correctamente.");
                CargarDatos(); // Método tuyo para recargar el grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }


        private void frmSubFallas_Load(object sender, EventArgs e)
        {
            CargaCombos();
            CargarDatos();
        }

        private void CargaCombos()
        {
        

            if (basConfiguracion.ModoConexion == 1)
            {
                dtRespon = sqlServer.ExecSQLReturnDS("SELECT * FROM Fallas", "Fallas");
            }
            else
            {
                dtRespon = PgSQLHelper.ExecSQLReturnDS(@"SELECT * FROM public.""Fallas""", "Fallas");
            }

            DataRow filaVacia = dtRespon.Tables[0].NewRow();
            filaVacia["idFalla"] = 0;
            filaVacia["Descripcion"] = "[Seleccione]";
            dtRespon.Tables[0].Rows.InsertAt(filaVacia, 0);

            cboFallas.DataSource = dtRespon.Tables[0];
            cboFallas.DisplayMember = "Descripcion";
            cboFallas.ValueMember = "idFalla";

            cboFallasFiltro.DataSource = dtRespon.Tables[0];
            cboFallasFiltro.DisplayMember = "Descripcion";
            cboFallasFiltro.ValueMember = "idFalla";
        }

        private void btNewSubFalla_Click(object sender, EventArgs e)
        {
          
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Height = 300;
            intEditar = 0;
            gbSubFalla.Visible = false;
            txNombre.Text = "";
            chEstatus.Checked = true;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvSubFallas_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.Height = 500;
                intEditar = 1;
                gbSubFalla.Visible = true;
                gbSubFalla.Text = "Editar SubFalla";

                DataGridViewRow filaSeleccionada = dgvFallas.Rows[e.RowIndex];

                txNombre.Text = filaSeleccionada.Cells["Descripcion"].Value?.ToString();
                chEstatus.Checked = Convert.ToBoolean(filaSeleccionada.Cells["Estatus"].Value);
                cboFallas.SelectedIndex = Convert.ToInt32(filaSeleccionada.Cells["idFalla"].Value);
                IdSubFalla = Convert.ToInt32(filaSeleccionada.Cells["idSubFalla"].Value);
            }
        }

        private void txNombre_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
