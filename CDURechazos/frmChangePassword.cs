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
    public partial class frmChangePassword: Form
    {
        int idUsuarioGlobal;
        public frmChangePassword()
        {
            InitializeComponent();
        }

        public frmChangePassword(int idUsuario)
        {
            idUsuarioGlobal = idUsuario;
            InitializeComponent();
        }

        private void frmChangePassword_Load(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
            if (txContrasena.Text != txContrasena2.Text)
            {
                MessageBox.Show("Las contraseñas no coinciden", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                if (basConfiguracion.ModoConexion == 1)
                {
                    string strPassword = basFunctions.HashPassword(txContrasena.Text);
                    string sSQL = "UPDATE Usuarios SET Contrasena = '" + strPassword + "', ChangePass = 0 WHERE IdUsuario = " + idUsuarioGlobal;
                    sqlServer.ExecSQL(sSQL);
                }
                else
                {
                    string strPassword = basFunctions.HashPassword(txContrasena.Text);
                    string sSQL = "UPDATE public.\"Usuarios\" SET \"Contrasena\" = '" + strPassword + "', \"ChangePass\" = false WHERE \"IdUsuario\" = " + idUsuarioGlobal;
                    PgSQLHelper.ExecSQL(sSQL);
                }
                MessageBox.Show("Contraseña cambiada correctamente", "CDU Rechazos", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
