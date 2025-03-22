using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CDURechazos.Clases;
using System.IO;
using System.Data.SqlClient;

namespace CDURechazos.Modulos
{
    public class basFunctions
    {
        public void ConectaBD()
        {
            string sSQL = "";
            DataTable dtPaso = new DataTable();

            try
            {
                string filePath = @"C:\CheckList\CheckList.txt";

                // Leer todas las líneas del archivo
                string[] lines = File.ReadAllLines(filePath);

                // Variables para almacenar los datos
                string dbLocalHost = "";
                string dbLocalName = "";
                string dbLocalUser = "";
                string dbLocalPassword = "";

                string dbRemoteHost = "";
                string dbRemoteName = "";
                string dbRemoteUser = "";
                string dbRemotePassword = "";
                string dbPort = "";

                // Procesar las líneas
                for (int i = 0; i < lines.Length; i++)
                {
                    switch (lines[i])
                    {
                        case "--BASE DE DATOS--":
                            dbLocalHost = lines[i + 1];
                            dbLocalName = lines[i + 2];
                            dbLocalUser = lines[i + 3];
                            dbLocalPassword = lines[i + 4];
                            break;

                        case "--BASE DE DATOS POSTGRES--":
                            dbRemoteHost = lines[i + 1];
                            dbRemoteName = lines[i + 2];
                            dbRemoteUser = lines[i + 3];
                            dbRemotePassword = lines[i + 4];
                            dbPort = lines[i + 5];
                            break;
                    }
                }

                if (basConfiguracion.ModoConexion == 1)
                {
                    // Se establecen los parámetros de conexión a SQL Server
                    //sqlServer.Init(null, dbLocalName, dbLocalHost, dbLocalUser, dbLocalPassword);

                    // Ejecutar consulta de prueba
                    //sqlServer.ExecSQL("USE Salvage");

                    // Obtener número de sucursal
                    sSQL = "SELECT TOP 1 * FROM Usuarios";
                    //dtPaso = sqlServer.ExecSQLReturnDT(sSQL);
                    if (dtPaso != null && dtPaso.Rows.Count > 0)
                    {
                        // Procesamiento adicional si es necesario
                    }
                }
                else
                {
                    // Se establecen los parámetros de conexión a PostgreSQL
                    PgSQLHelper.Init(300, dbRemoteHost, dbRemoteName, dbRemoteUser, dbRemotePassword, dbPort);

                    dtPaso = PgSQLHelper.ExecSQLReturnDT(@"SELECT * FROM public.""Tablas"" LIMIT 300 OFFSET 0;", "Tablas");
                    if (dtPaso != null && dtPaso.Rows.Count > 0)
                    {
                        // Procesamiento adicional si es necesario
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Copeland", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Environment.Exit(0); // equivalente a End
            }
        }
    }
}
