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
                string filePath = @"C:\CDU\Configuracion.txt";

                if (!File.Exists(filePath))
                {
                 return;
                }

                // Leer todas las líneas del archivo
                string[] lines = File.ReadAllLines(filePath);

                // Variables para almacenar los datos

                // Procesar las líneas
                for (int i = 0; i < lines.Length; i++)
                {
                    switch (lines[i])
                    {
                        case "--BASE DE DATOS--":
                            txServidor.Text = lines[i + 1];
                            txBasseDatos.Text = lines[i + 2];
                            txUsuario.Text = lines[i + 3];
                            txContra.Text = lines[i + 4];
                            break;

                        case "--BASE DE DATOS POSTGRES--":
                            txConexionPG.Text = lines[i + 1];
                            break;
                        case "--OTROS--":
                            if (lines[i + 1] == "1")
                            {
                                rbSQL.Checked = true;
                            }
                            else
                            {
                                rbPG.Checked = true;
                            }
                            break;
                    }
                }
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

            string rutaArchivo = @"C:\CDU\Configuracion.txt";

            if (!File.Exists(rutaArchivo))
            {
                string[] lineas = {
                "--BASE DE DATOS--",
                txServidor.Text,
                txBasseDatos.Text,
                txUsuario.Text,
                txContra.Text,
                "--BASE DE DATOS POSTGRES--",
                txConexionPG.Text,
                "--OTROS--",
                (rbSQL.Checked ? "1" : "0")
                };

                File.WriteAllLines(@"C:\CDU\Configuracion.txt", lineas);
                MessageBox.Show("Archivo creado correctamente.","Copeland",MessageBoxButtons.OK,MessageBoxIcon.Information);
                this.Close();
            }
            else
            {
                // Leer todas las líneas del archivo
                string[] lineas = File.ReadAllLines(rutaArchivo);

                // Actualizar las líneas que correspondan (por ejemplo, las líneas 1 a 4)
                //BASE DATOS
                lineas[1] = txServidor.Text;
                lineas[2] = txBasseDatos.Text;
                lineas[3] = txUsuario.Text;
                lineas[4] = txContra.Text;

                //POSTGRES
                lineas[6] = txConexionPG.Text;

                //OTROS
                lineas[8] = (rbPG.Checked ? "0" : "1");

                // Guardar el archivo sobrescribiéndolo con las líneas actualizadas
                File.WriteAllLines(rutaArchivo, lineas);

                MessageBox.Show("Archivo actualizado correctamente.","Copeland", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }
    }
}
