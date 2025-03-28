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
using static CDURechazos.Modulos.basConfiguracion;

namespace CDURechazos
{
    public partial class frmConfiguracion: Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            try
            {
                string filePath = @"C:\CDU\configSecure.dll";

                if (!File.Exists(filePath))
                {
                 return;
                }

                ConfigInfo config = basConfiguracion.LeerConfig(@"C:\CDU\configSecure.dll");

                txServidor.Text = config.Servidor;
                txBasseDatos.Text = config.BaseDatos;
                txUsuario.Text = config.Usuario;
                txContra.Text = config.Contrasena;
                txConexionPG.Text = config.pgUrl;
                if (config.ModoConexion == 1)
                {
                    rbSQL.Checked = true;
                }
                else
                {
                    rbPG.Checked = true;
                }

                //// Leer todas las líneas del archivo
                //string[] lines = File.ReadAllLines(filePath);

                //// Variables para almacenar los datos

                //// Procesar las líneas
                //for (int i = 0; i < lines.Length; i++)
                //{
                //    switch (lines[i])
                //    {
                //        case "--BASE DE DATOS--":
                //            txServidor.Text = lines[i + 1];
                //            txBasseDatos.Text = lines[i + 2];
                //            txUsuario.Text = lines[i + 3];
                //            txContra.Text = lines[i + 4];
                //            break;

                //        case "--BASE DE DATOS POSTGRES--":
                //            txConexionPG.Text = lines[i + 1];
                //            break;
                //        case "--OTROS--":
                //            if (lines[i + 1] == "1")
                //            {
                //                rbSQL.Checked = true;
                //            }
                //            else
                //            {
                //                rbPG.Checked = true;
                //            }
                //            break;
                //    }
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Copeland", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Environment.Exit(0); // equivalente a End
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btAceptar_Click(object sender, EventArgs e)
        {

            string rutaArchivo = @"C:\CDU\configSecure.dll";

            var config = new ConfigInfo
            {
                Servidor = txServidor.Text,
                BaseDatos = txBasseDatos.Text,
                Usuario = txUsuario.Text,
                Contrasena = txContra.Text,
                pgUrl = txConexionPG.Text,
                ModoConexion = int.Parse((rbSQL.Checked ? "1" : "0"))
            };

            if (!File.Exists(rutaArchivo))
            {
                basConfiguracion.GuardarConfig(config, @"C:\CDU\configSecure.dll");
                MessageBox.Show("Configuración guardada de forma segura.", "Copeland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                basConfiguracion.GuardarConfig(config, @"C:\CDU\configSecure.dll");
                MessageBox.Show("Configuración guardada de forma segura.", "Copeland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
