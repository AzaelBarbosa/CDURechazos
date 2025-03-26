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
using System.Security.Cryptography;
using ClosedXML.Excel;

namespace CDURechazos.Modulos
{
    public class basFunctions
    {
        private static readonly string clave = "TuClaveSecreta123"; // debe ser de 16, 24 o 32 caracteres
        private static readonly string iv = "VectorInicial1234";    // debe ser de 16 caracteres
        public static DataTable dtExportar;
        public void ConectaBD()
        {
            string sSQL = "";
            DataTable dtPaso = new DataTable();

            try
            {
                string filePath = @"C:\CDU\Configuracion.txt";

                // Leer todas las líneas del archivo
                string[] lines = File.ReadAllLines(filePath);

                // Variables para almacenar los datos
                string dbLocalHost = "";
                string dbLocalName = "";
                string dbLocalUser = "";
                string dbLocalPassword = "";

                string dbUrl = "";

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
                            dbUrl = lines[i + 1];
                            break;
                        case "--OTROS--":
                            basConfiguracion.ModoConexion = Convert.ToInt32( lines[i + 1]);
                            break;
                    }
                }

                if (basConfiguracion.ModoConexion == 1)
                {
                    // Se establecen los parámetros de conexión a SQL Server
                    sqlServer.Init(300, dbLocalName, dbLocalHost, dbLocalUser, dbLocalPassword);

                    // Ejecutar consulta de prueba
                    sqlServer.ExecSQL("USE Salvage");

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
                    PgSQLHelper.Init(300, dbUrl);

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

        public static string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] entrada = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(entrada);
                return Convert.ToBase64String(hash);
            }
        }

        public void ExportarDataGridViewAExcel(DataGridView dgv, string rutaArchivo)
        {
            using (var wb = new XLWorkbook())
            {
                var ws = wb.Worksheets.Add("Datos");

                // Escribir encabezados
                for (int i = 0; i < dgv.Columns.Count; i++)
                {
                    ws.Cell(1, i + 1).Value = dgv.Columns[i].HeaderText;
                }

                // Escribir filas
                for (int i = 0; i < dgv.Rows.Count; i++)
                {
                    for (int j = 0; j < dgv.Columns.Count; j++)
                    {
                        ws.Cell(i + 2, j + 1).Value = dgv.Rows[i].Cells[j].Value?.ToString();
                    }
                }

                wb.SaveAs(rutaArchivo);
            }
        }

        public void ExportarDataTableAExcel(DataTable dt, string rutaArchivo)
        {
            using (var wb = new XLWorkbook())
            {
                wb.Worksheets.Add(dt, "Hoja1");
                wb.SaveAs(rutaArchivo);
            }
        }

    }
}
