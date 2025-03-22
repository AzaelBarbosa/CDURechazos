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
    }
}
