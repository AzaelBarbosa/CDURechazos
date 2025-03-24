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
using System.IO;

namespace CDURechazos
{
    public partial class frmLogin : Form
    {
        DataSet dtPaso;
        DataRow[] drPaso;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

            string filePath = @"C:\CDU\Configuracion.txt";
            if (!File.Exists(filePath))
            {
                MessageBox.Show("El archivo de configuración no existe.\nSe procederá a abrir el asistente para crear y configurar la conexión.",
               "Copeland",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information
                );
                frmConfiguracion formCrear = new frmConfiguracion();
                formCrear.ShowDialog();
            }

                basFunctions basFunc = new basFunctions();
            basFunc.ConectaBD();



            if (basConfiguracion.ModoConexion == 1)
            {
          //      dtPaso = sqlServer.ExecSQLReturnDS(
          //          @"SELECT U.*, P.TipoPermiso 
          //FROM Usuarios U 
          //INNER JOIN Perfiles P ON P.IdPerfil = U.IdPerfil",
          //          "Usuarios");
            }
            else
            {
                dtPaso = PgSQLHelper.ExecSQLReturnDS(
                    @"SELECT U.*, P.""TipoPermiso"" 
          FROM public.""Usuarios"" U 
          INNER JOIN public.""Perfiles"" P ON P.""IdPerfil"" = U.""IdPerfil""",
                    "Usuarios");
            }

            // Llenar ComboBox
            foreach (DataRow dr in dtPaso.Tables[0].Rows)
            {
                cboUsuarios.Items.Add(dr["Usuario"].ToString());
            }
        }

        private void cboUsuarios_SelectedIndexChanged(object sender, EventArgs e)
        {
            drPaso = dtPaso.Tables[0].Select($"Usuario = '{cboUsuarios.Text}'");

            if (drPaso.Length == 0)
            {
                MessageBox.Show("El Usuario que ha seleccionado no fue encontrado.", "Copeland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btEntrar.Enabled = false;
                cboUsuarios.Focus();
            }
            else
            {
                if (Convert.ToInt32(drPaso[0]["ChangePass"]) == 1)
                {
                    MessageBox.Show("El Usuario ah solocitado resetar su contraseña", "Copeland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmChangePassword frmCP = new frmChangePassword(Convert.ToInt32(drPaso[0]["IdUsuario"]));
                    frmCP.ShowDialog();
                }
                else
                {
                    btEntrar.Enabled = true;
                }
            }
        }

        private void btEntrar_Click(object sender, EventArgs e)
        {
            string strPassword = basFunctions.HashPassword(txPassword.Text);
            if (drPaso[0]["Contrasena"].ToString() == strPassword)
            {
                frmMain frmM = new frmMain(drPaso[0]);
                basConfiguracion.TipoPermiso = Convert.ToInt32(drPaso[0]["TipoPermiso"]);

                MessageBox.Show("Bienvenido " + drPaso[0]["NombreUsuario"], "Copeland", MessageBoxButtons.OK, MessageBoxIcon.Information);


                basConfiguracion basConfig = new basConfiguracion();
                basConfig.SetUserSession(
                   Convert.ToInt32(drPaso[0]["IdUsuario"]),
                    "",
                    drPaso[0]["NombreUsuario"].ToString()
                );

                this.Hide();
                frmM.Show();
            }
            else
            {
                MessageBox.Show("Contraseña incorrecta", "Copeland", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                txPassword.Focus();
            }
        }
    }
}
