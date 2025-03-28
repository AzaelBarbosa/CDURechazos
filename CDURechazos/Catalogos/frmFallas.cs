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
    public partial class frmFallas: Form
    {
        DataTable dtFallas;
        int IdFalla;
        int intEditar;
        basFunctions basFunctions = new basFunctions();
        public frmFallas()
        {
            InitializeComponent();
        }

        private void frmFallas_Load(object sender, EventArgs e)
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

        private void btNewFalla_Click(object sender, EventArgs e)
        {
            intEditar = 0;
            Height = 422;
            gbFallas.Visible = true;
            txNombre.Text = "";
            chEstatus.Checked = true;
            btAceptar.Enabled = false;
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
            string sSQL;

            if (basConfiguracion.ModoConexion == 1)
            {
                if (intEditar == 0)
                {
                    sSQL = "INSERT INTO Fallas (Descripcion, Estatus, Codigo) VALUES('" + txNombre.Text + "'," + (chEstatus.Checked ? 1 : 0) + ", '" + txCodigo.Text + "')";
                    sqlServer.ExecSQL(sSQL);
                    dtFallas = sqlServer.ExecSQLReturnDT("SELECT * FROM Fallas", "Fallas");
                    dgvFallas.DataSource = dtFallas;
                    dgvFallas.Refresh();
                    this.Height = 255;
                    basFunctions.InsertarHistorial("Se ha creado la falla " + txNombre.Text);
                }
                else
                {
                    sSQL = "UPDATE Fallas SET Descripcion = '" + txNombre.Text + "', Estatus = " + (chEstatus.Checked ? 1 : 0) + ", Codigo = '" + txCodigo.Text + "'  WHERE idFalla = " + IdFalla;
                    sqlServer.ExecSQL(sSQL);
                    dtFallas = sqlServer.ExecSQLReturnDT("SELECT * FROM Fallas", "Fallas");
                    dgvFallas.DataSource = dtFallas;
                    dgvFallas.Refresh();
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
                    dtFallas = PgSQLHelper.ExecSQLReturnDT("SELECT * FROM public.\"Fallas\"", "Fallas");
                    dgvFallas.DataSource = dtFallas;
                    dgvFallas.Refresh();
                    this.Height = 255;
                    basFunctions.InsertarHistorial("Se ha creado la falla " + txNombre.Text);
                }
                else
                {
                    sSQL = "UPDATE public.\"Fallas\" SET \"Descripcion\" = '" + txNombre.Text + "', \"Estatus\" = " + (chEstatus.Checked ? "True" : "False") + ", \"Codigo\" = '" + txCodigo.Text + "'  WHERE \"idFalla\" = " + IdFalla;
                    PgSQLHelper.ExecSQL(sSQL);
                    dtFallas = PgSQLHelper.ExecSQLReturnDT("SELECT * FROM public.\"Fallas\"", "Fallas");
                    dgvFallas.DataSource = dtFallas;
                    dgvFallas.Refresh();
                    this.Height = 255;
                    basFunctions.InsertarHistorial("Se ha editado la falla " + txNombre.Text);
                }
            }
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Height = 255;
            intEditar = 0;
            gbFallas.Visible = false;
            txNombre.Text = "";
            chEstatus.Checked = true;
            btAceptar.Enabled = false;
        }

        private void txNombre_TextChanged(object sender, EventArgs e)
        {
            if (txCodigo.Text.Length > 0 && txNombre.Text.Length > 0)
            {
                btAceptar.Enabled = true;
            }
            else
            {
                btAceptar.Enabled = false;
            }
        }
    }
}
