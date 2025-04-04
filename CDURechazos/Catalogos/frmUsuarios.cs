﻿using System;
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
    public partial class frmUsuarios: frmCatalogos
    {
        DataTable dtUsuarios;
        int idUsuario;
        int intEditar;
        basFunctions basFunctions = new basFunctions();
        public frmUsuarios()
        {
            InitializeComponent();
        }

        protected override void Nuevo()
        {
            intEditar = 0;
            Height = 478;
            gbUsuarios.Visible = true;
            txNombre.Text = "";
            chResetear.Enabled = false;
            txUsuario.Text = "";
            chEstatus.Checked = true;
            gbUsuarios.Text = "Nuevo Usuario";
            this.Text = "Nuevo Usuario";
            gbUsuarios.Height = 139;
        }

        protected override void Guardar()
        {
            string sSQL;

            if (txNombre.Text == "")
            {
                MessageBox.Show("El nombre de usuario es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txNombre.Focus();
                return;
            }
            if (txUsuario.Text == "")
            {
                MessageBox.Show("El usuario es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txUsuario.Focus();
                return;
            }
            if (cboPerfil.SelectedIndex == -1)
            {
                MessageBox.Show("El perfil es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cboPerfil.Focus();
                return;
            }


            if (basConfiguracion.ModoConexion == 1)
            {
                if (intEditar == 0)
                {
                    sSQL = "INSERT INTO Usuarios (NombreUsuario, Estatus, Usuario, IdPerfil) VALUES('" + txNombre.Text + "'," + (chEstatus.Checked ? 1 : 0) + ", '" + txUsuario.Text + "'," + cboPerfil.SelectedValue + ")";
                    sqlServer.ExecSQL(sSQL);
                    CargarDatos();
                    this.Height = 322;
                    basFunctions.InsertarHistorial("Se ha creado el usuario " + txUsuario.Text);
                }
                else
                {
                    sSQL = "UPDATE Usuarios SET NombreUsuario = '" + txNombre.Text + "', Estatus = " + (chEstatus.Checked ? 1 : 0) + ", Usuario = '" + txUsuario.Text + "', IdPerfil = " + cboPerfil.SelectedValue + ", ChangePass = " + (chResetear.Checked ? 1 : 0) + " WHERE IdUsuario = " + idUsuario;
                    sqlServer.ExecSQL(sSQL);
                    CargarDatos();
                    this.Height = 322;
                    basFunctions.InsertarHistorial("Se ha modificado el usuario " + txUsuario.Text);
                }
            }
            else
            {
                if (intEditar == 0)
                {
                    sSQL = "INSERT INTO public.\"Usuarios\" (\"NombreUsuario\", \"Estatus\", \"Usuario\", \"IdPerfil\") VALUES('" + txNombre.Text + "'," + (chEstatus.Checked ? "True" : "False") + ", '" + txUsuario.Text + "'," + cboPerfil.SelectedValue + ")";
                    PgSQLHelper.ExecSQL(sSQL);
                    CargarDatos();
                    this.Height = 322;
                    basFunctions.InsertarHistorial("Se ha creado el usuario " + txUsuario.Text);
                }
                else
                {
                    sSQL = "UPDATE public.\"Usuarios\" SET \"NombreUsuario\" = '" + txNombre.Text + "', \"Estatus\" = " + (chEstatus.Checked ? "True" : "False") + ", \"Usuario\" = '" + txUsuario.Text + "', \"IdPerfil\" = " + cboPerfil.SelectedValue + ", \"ChangePass\" = " + (chResetear.Checked ? "True" : "False") + "  WHERE \"IdUsuario\" = " + idUsuario;
                    PgSQLHelper.ExecSQL(sSQL);
                    CargarDatos();
                    this.Height = 322;
                    basFunctions.InsertarHistorial("Se ha modificado el usuario " + txUsuario.Text);
                }
            }
        }

        private void CargarDatos()
        {
            if (basConfiguracion.ModoConexion == 1)
            {
                dtUsuarios = sqlServer.ExecSQLReturnDT("SELECT U.IdUsuario,U.Usuario,U.Correo,U.NombreUsuario AS [Nombre Usuario], U.Estatus, P.Descripcion AS Perfil FROM dbo.Usuarios U INNER JOIN dbo.Perfiles P ON P.IdPerfil = U.IdPerfil WHERE U.Estatus = 1", "Usuarios");
                dgvUsuarios.DataSource = dtUsuarios;
                dgvUsuarios.Refresh();
            }
            else
            {
                dtUsuarios = PgSQLHelper.ExecSQLReturnDT(@"SELECT U.""IdUsuario"",U.""Usuario"",U.""Correo"",U.""NombreUsuario"" AS ""Nombre Usuario"",U.""Estatus"", P.""Descripcion"" AS ""Perfil"" FROM public.""Usuarios"" U INNER JOIN public.""Perfiles"" P ON P.""IdPerfil"" = U.""IdPerfil"" WHERE U.""Estatus"" = true;", "Usuarios");
                dgvUsuarios.DataSource = dtUsuarios;
                dgvUsuarios.Refresh();
            }
        }
        protected override void Eliminar()
        {
            if (dgvUsuarios.CurrentRow == null)
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
            int id = Convert.ToInt32(dgvUsuarios.CurrentRow.Cells["IdUsuario"].Value);

            try
            {
                string query = $"DELETE FROM Usuarios WHERE IdUsuario = {id}";
                sqlServer.ExecSQL(query); // Usa tu clase helper para ejecutar

                MessageBox.Show("Registro eliminado correctamente.");
                CargarDatos(); // Método tuyo para recargar el grid
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: " + ex.Message);
            }
        }


        private void frmUsuarios_Load(object sender, EventArgs e)
        {
            CargarComboPerfiles();
            CargarDatos();
        }

        private void btnuevo_Click(object sender, EventArgs e)
        {
         
        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            Height = 322;
            intEditar = 0;
            gbUsuarios.Visible = false;
            txNombre.Text = "";
            txUsuario.Text = "";
            chEstatus.Checked = true;
        }

        private void CargarComboPerfiles()
        {
            DataTable dtPerfiles;
            if (basConfiguracion.ModoConexion == 1)
            {
                dtPerfiles = sqlServer.ExecSQLReturnDT("SELECT * FROM Perfiles", "Perfiles");
                cboPerfil.DataSource = dtPerfiles;
                cboPerfil.DisplayMember = "Descripcion";
                cboPerfil.ValueMember = "IdPerfil";
            }
            else
            {
                dtPerfiles = PgSQLHelper.ExecSQLReturnDT(@"SELECT * FROM public.""Perfiles""", "Perfiles");
                cboPerfil.DataSource = dtPerfiles;
                cboPerfil.DisplayMember = "Descripcion";
                cboPerfil.ValueMember = "IdPerfil";
            }
        }
        private void dgvUsuarios_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            string passwordEn;
            if (e.RowIndex >= 0)
            {
                this.Height = 478;
                intEditar = 1;
                gbUsuarios.Visible = true;
                gbUsuarios.Text = "Editar Usuario";
                this.Text = "Editar Usuario";

                DataGridViewRow filaSeleccionada = dgvUsuarios.Rows[e.RowIndex];
                txNombre.Text = filaSeleccionada.Cells["Nombre Usuario"].Value?.ToString();
                txUsuario.Text = filaSeleccionada.Cells["Usuario"].Value?.ToString();
                chEstatus.Checked = Convert.ToBoolean(filaSeleccionada.Cells["Estatus"].Value);
                idUsuario = Convert.ToInt32(filaSeleccionada.Cells["IdUsuario"].Value);
            }
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {
       
        }
    }
}
