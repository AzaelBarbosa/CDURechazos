using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDURechazos.Modulos;

namespace CDURechazos
{
    public partial class frmSplashScreen: Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
        }

        private async void frmSplashScreen_Load(object sender, EventArgs e)
        {
            lblStatus.Text = "Inicializando componentes...";
            await Task.Delay(500);

            lblStatus.Text = "Cargando configuración...";
            await Task.Delay(500);

            lblStatus.Text = "Verificando conexión a la base de datos...";
            await Task.Delay(500);

            lblStatus.Text = "Sincronizando datos del sistema...";
            await Task.Delay(500);

            lblStatus.Text = "Cargando módulos de usuario....";
            await Task.Delay(500);

            lblStatus.Text = "Verificando permisos de acceso...";
            await Task.Delay(500);

            lblStatus.Text = "Preparando interfaz gráfica...";
            await Task.Delay(500);

            lblStatus.Text = "Cargando catálogos del sistema...";
            await Task.Delay(500);

            lblStatus.Text = "Iniciando aplicación...";
            await Task.Delay(1000);

            // Luego abres el formulario principal
            this.Hide();
            frmLogin frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
