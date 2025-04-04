﻿using System;
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
using static CDURechazos.Modulos.basConfiguracion;

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
                ConfigInfo config = basConfiguracion.LeerConfig(@"C:\CDU\configSecure.dll");

                // Variables para almacenar los datos
                string dbLocalHost = config.Servidor;
                string dbLocalName = config.BaseDatos;
                string dbLocalUser = config.Usuario;
                string dbLocalPassword = config.Contrasena;
                string dbUrl = config.pgUrl;
                basConfiguracion.ModoConexion = Convert.ToInt32(config.ModoConexion);

                if (basConfiguracion.ModoConexion == 1)
                {
                    // Se establecen los parámetros de conexión a SQL Server
                    sqlServer.Init(300, dbLocalName, dbLocalHost, dbLocalUser, dbLocalPassword);

                    // Ejecutar consulta de prueba
                    sqlServer.ExecSQL("USE " + dbLocalName);

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

        public void InsertarHistorial(string sAccion)
        {
            string sSQL;
            if (basConfiguracion.ModoConexion == 1)
            {
                sSQL = "INSERT INTO LogFallas (idUsuario, Descripcion) VALUES(" + basConfiguracion.UserID + ",'" + sAccion + "')";
                sqlServer.ExecSQL(sSQL);
            }
            else
            {
                sSQL = "INSERT INTO public.\"LogFallas\" (\"idUsuario\", \"Descripcion\") VALUES(" + basConfiguracion.UserID + ",'" + sAccion + "')";
                PgSQLHelper.ExecSQL(sSQL);
            }
        }

        public interface ICatalogo
        {
            void Nuevo();
            void Guardar();
            void Eliminar();
        }
    }
}
