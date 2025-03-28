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
    public partial class frmSubFallas: Form
    {
        DataTable dtFallas;
        DataTable dtSubFallas;
        int IdSubFalla;
        int intEditar;
        DataSet dtRespon;
        public frmSubFallas()
        {
            InitializeComponent();
        }

        private void frmSubFallas_Load(object sender, EventArgs e)
        {
            CargaCombos();

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
            intEditar = 0;
            Height = 500;
            gbSubFalla.Visible = true;
            txNombre.Text = "";
            chEstatus.Checked = true;
            btAceptar.Enabled = false;
            gbSubFalla.Text = "Nueva Falla";
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Height = 300;
            intEditar = 0;
            gbSubFalla.Visible = false;
            txNombre.Text = "";
            chEstatus.Checked = true;
            btAceptar.Enabled = false;
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            string sSQL;

            if (basConfiguracion.ModoConexion == 1)
            {
                if (intEditar == 0)
                {
                    sSQL = "INSERT INTO SubFallas (Descripcion, Estatus, idFalla) VALUES('" + txNombre.Text + "'," + (chEstatus.Checked ? 1 : 0) + ", " + cboFallas.SelectedValue + ")";
                    sqlServer.ExecSQL(sSQL);
                    dtSubFallas = sqlServer.ExecSQLReturnDT("SELECT * FROM Fallas", "Fallas");
                    dgvFallas.DataSource = dtSubFallas;
                    dgvFallas.Refresh();
                    this.Height = 300;
                }
                else
                {
                    sSQL = "UPDATE SubFallas SET Descripcion = '" + txNombre.Text + "', Estatus = " + (chEstatus.Checked ? 1 : 0) + ", idFalla = " + cboFallas.SelectedValue + " WHERE IdSubFalla = " + IdSubFalla;
                    sqlServer.ExecSQL(sSQL);
                    dtSubFallas = sqlServer.ExecSQLReturnDT("SELECT * FROM Fallas", "Fallas");
                    dgvFallas.DataSource = dtSubFallas;
                    dgvFallas.Refresh();
                    this.Height = 300;
                }
            }
            else
            {
                if (intEditar == 0)
                {
                    sSQL = "INSERT INTO public.\"SubFallas\" (\"Descripcion\", \"Estatus\", \"idFalla\") VALUES('" + txNombre.Text + "'," + (chEstatus.Checked ? "True" : "False") + ", " + cboFallas.SelectedValue + ")";
                    PgSQLHelper.ExecSQL(sSQL);
                    dtSubFallas = PgSQLHelper.ExecSQLReturnDT("SELECT * FROM public.\"SubFallas\"", "SubFallas");
                    dgvFallas.DataSource = dtSubFallas;
                    dgvFallas.Refresh();
                    this.Height = 300;
                }
                else
                {
                    sSQL = "UPDATE public.\"SubFallas\" SET \"Descripcion\" = '" + txNombre.Text + "', \"Estatus\" = " + (chEstatus.Checked ? "True" : "False") + ", \"idFalla\" = " + cboFallas.SelectedValue + " WHERE \"IdSubFalla\" = " + IdSubFalla;
                    PgSQLHelper.ExecSQL(sSQL);
                    dtSubFallas = PgSQLHelper.ExecSQLReturnDT("SELECT * FROM public.\"SubFallas\"", "SubFallas");
                    dgvFallas.DataSource = dtSubFallas;
                    dgvFallas.Refresh();
                    this.Height = 300;
                }
            }
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
            if ( txNombre.Text.Length > 0)
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
