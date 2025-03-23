using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CDURechazos.Modulos
{
    public class basConfiguracion
    {
        // Variables para almacenar la información del usuario
        public static int UserID;
        public static string NumEmpleado;
        public static string Nombre;

        // Variables para almacenar la configuración de la aplicación
        public static string RutaArchivos;
        public static bool EnvioNominas;
        public static bool SincronizarEmpleados;
        public static string HostCorreo;
        public static int Puerto;
        public static string CorreoEnvio;
        public static string ContrasenaCorreo;
        public static int Linea;
        public static int TipoActividad;
        public static int TipoPermiso;
        public static int ModoConexion = 0;

        public void SetUserSession(int userID, string numEmpleado, string nombre)
        {
            basConfiguracion.UserID = userID;
            basConfiguracion.NumEmpleado = numEmpleado;
            basConfiguracion.Nombre = nombre;
        }

        public void SetConfig(string rutaArchivos, bool envioNominas, bool sincroEmpleados, string hostCorreo, int puerto, string correo, string contrasena)
        {
            basConfiguracion.RutaArchivos = rutaArchivos;
            basConfiguracion.EnvioNominas = envioNominas;
            basConfiguracion.SincronizarEmpleados = sincroEmpleados;
            basConfiguracion.HostCorreo = hostCorreo;
            basConfiguracion.Puerto = puerto;
            basConfiguracion.CorreoEnvio = correo;
            basConfiguracion.ContrasenaCorreo = contrasena;
        }

        // Método opcional para limpiar la información del usuario
        public void ClearUserSession()
        {
            basConfiguracion.UserID = 0;
            basConfiguracion.NumEmpleado = string.Empty;
            basConfiguracion.Nombre = string.Empty;
        }

    }
}
