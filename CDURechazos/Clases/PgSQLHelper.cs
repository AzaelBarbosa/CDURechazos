using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using Npgsql;

namespace CDURechazos.Clases
{
   public class PgSQLHelper
    {
        private static string mstrConnection;
        private string mstrConnection_2;
        private static NpgsqlConnection mobjConnection;
        private NpgsqlConnection mobjConnection_2;
        private static NpgsqlTransaction mobjTransaction;
        private NpgsqlTransaction mobjTransaction_2;
        private static string mstrModuleName;
        private string mstrModuleName_2;
        private static bool mblnDisposed = false;
        private bool mblnDisposed_2 = false;
        private static int mintTimeOut = 300;
        private int mintTimeOut_2 = 300;

        private const string EXCEPTION_MSG = "There was an error in the method. Please see the Application Log for details.";


        public PgSQLHelper()
        {
            Init();
            mstrModuleName = this.GetType().ToString();
        }

        public static void Init(int intTimeOut = 300, string strUrl = "")
        {

            mstrConnection = strUrl;

            mintTimeOut = intTimeOut;

            try
            {
                mobjConnection = new NpgsqlConnection(mstrConnection);
                mobjConnection.Open();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al inicializar la conexión: " + ex.Message);
            }
        }

        private static void AttachParameters(NpgsqlCommand command, NpgsqlParameter[] commandParameters)
        {
            foreach (var p in commandParameters)
            {
                if (p.Direction == ParameterDirection.InputOutput && p.Value == null)
                    p.Value = DBNull.Value;
                command.Parameters.Add(p);
            }
        }

        #region ExecSP
        public static void ExecSP(string SPName, NpgsqlParameter[] ParamValues = null)
        {
            try
            {
                if (mblnDisposed)
                    throw new ObjectDisposedException(mstrModuleName, "This object has already been disposed.");

                if (mobjConnection.State != ConnectionState.Open)
                    mobjConnection.Open();

                var objCommand = new NpgsqlCommand(SPName, mobjConnection)
                {
                    CommandType = CommandType.StoredProcedure,
                    CommandTimeout = mintTimeOut
                };

                if (ParamValues != null)
                    AttachParameters(objCommand, ParamValues);

                if (mobjTransaction != null)
                    objCommand.Transaction = mobjTransaction;

                objCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ExecSPNoQuery
        public static ArrayList ExecSPNoQuery(string strSPName, NpgsqlParameter[] ParamValues = null)
        {
            var arrReturn = new ArrayList();
            var objCommand = new NpgsqlCommand(strSPName, mobjConnection)
            {
                CommandType = CommandType.StoredProcedure,
                CommandTimeout = mintTimeOut
            };

            try
            {
                if (mobjConnection.State != ConnectionState.Open)
                    mobjConnection.Open();

                if (ParamValues != null)
                    AttachParameters(objCommand, ParamValues);

                if (mobjTransaction != null)
                    objCommand.Transaction = mobjTransaction;

                objCommand.ExecuteNonQuery();

                foreach (NpgsqlParameter objParameter in objCommand.Parameters)
                {
                    if (objParameter.Direction == ParameterDirection.Output)
                        arrReturn.Add(objParameter.Value);
                }

                return arrReturn;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ExecSPReturnDT
        public static DataTable ExecSPReturnDT(string SPName, NpgsqlParameter[] ParamValues = null, string TableName = "Table")
        {
            var objDT = new DataTable();

            try
            {
                if (mblnDisposed)
                    throw new ObjectDisposedException(mstrModuleName, "This object has already been disposed.");

                if (mobjConnection.State != ConnectionState.Open)
                    mobjConnection.Open();

                var objCommand = new NpgsqlCommand(SPName, mobjConnection)
                {
                    CommandTimeout = mintTimeOut,
                    CommandType = CommandType.StoredProcedure
                };

                if (ParamValues != null)
                    AttachParameters(objCommand, ParamValues);

                if (mobjTransaction != null)
                    objCommand.Transaction = mobjTransaction;

                var objDA = new NpgsqlDataAdapter(objCommand);
                objDA.Fill(objDT);
                objDT.TableName = TableName;

                return objDT;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        #region ExecSQLReturnDT

        public static DataTable ExecSQLReturnDT(string strSQL, string tableName = "NewTable")
        {
            NpgsqlCommand objCommand;
            NpgsqlDataAdapter objDA;
            DataTable objDT = new DataTable();

            try
            {
                if (mblnDisposed)
                {
                    throw new ObjectDisposedException(mstrModuleName, "This object has already been disposed.");
                }

                if (mobjConnection.State != ConnectionState.Open)
                {
                    mobjConnection.Open();
                }

                objCommand = new NpgsqlCommand(strSQL, mobjConnection)
                {
                    CommandTimeout = mintTimeOut,
                    CommandType = CommandType.Text
                };

                if (mobjTransaction != null)
                {
                    objCommand.Transaction = mobjTransaction;
                }

                objDA = new NpgsqlDataAdapter(objCommand);
                objDA.Fill(objDT);
                objDT.TableName = tableName;

                return objDT;
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        #endregion

        #region ExecSQL

        public static void ExecSQL(string strSQL)
        {
            NpgsqlCommand objCommand;

            try
            {
                if (mblnDisposed)
                {
                    throw new ObjectDisposedException(mstrModuleName, "This object has already been disposed.");
                }

                if (mobjConnection.State != ConnectionState.Open)
                {
                    mobjConnection.Open();
                }

                objCommand = new NpgsqlCommand(strSQL, mobjConnection)
                {
                    CommandTimeout = mintTimeOut,
                    CommandType = CommandType.Text
                };

                if (mobjTransaction != null)
                {
                    objCommand.Transaction = mobjTransaction;
                }

                objCommand.ExecuteNonQuery();
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        #endregion

        #region ExecSQLReturnDS

        public static DataSet ExecSQLReturnDS(string strSQL, string strTableName = "Table")
        {
            NpgsqlCommand objCommand;
            NpgsqlDataAdapter objDA;
            DataSet objDS = new DataSet();

            try
            {
                // Verificar que el objeto no ha sido eliminado
                if (mblnDisposed)
                {
                    throw new ObjectDisposedException(mstrModuleName, "This object has already been disposed.");
                }

                // Verificar si la conexión está abierta
                if (mobjConnection.State != ConnectionState.Open)
                {
                    mobjConnection.Open();
                }

                // Inicializar el comando SQL
                objCommand = new NpgsqlCommand(strSQL, mobjConnection)
                {
                    CommandTimeout = mintTimeOut,
                    CommandType = CommandType.Text
                };

                // Si hay una transacción activa, asociarla
                if (mobjTransaction != null)
                {
                    objCommand.Transaction = mobjTransaction;
                }

                // Inicializar el adaptador con el comando SQL
                objDA = new NpgsqlDataAdapter(objCommand);

                // Llenar el DataSet
                objDA.Fill(objDS, strTableName);

                // Devolver el resultado
                return objDS;
            }
            catch (Exception objException)
            {
                throw objException;
            }
        }

        #endregion

        #region Update Command

        public static void UpdateDataset(ref DataSet ds, string strTable)
        {
            NpgsqlDataAdapter da;
            NpgsqlCommandBuilder cb;
            NpgsqlTransaction tr = null;

            try
            {
                if (mobjConnection.State != ConnectionState.Open)
                {
                    mobjConnection.Open();
                }

                da = new NpgsqlDataAdapter("SELECT * FROM " + strTable + " WHERE 1=0", mobjConnection);
                cb = new NpgsqlCommandBuilder(da);

                // Iniciar una transacción local
                tr = mobjConnection.BeginTransaction();
                da.SelectCommand.Transaction = tr;
                cb.RefreshSchema();

                // Agregar manejador de evento para capturar IDs generados
                da.RowUpdated += new NpgsqlRowUpdatedEventHandler(OnRowUpdated);

                // Aplicar la actualización
                da.Update(ds, strTable);

                // Remover el manejador
                da.RowUpdated -= new NpgsqlRowUpdatedEventHandler(OnRowUpdated);

                tr.Commit();
            }
            catch (Exception ex)
            {
                try
                {
                    tr?.Rollback();
                }
                catch { }

                throw ex;
            }
        }

        private static void OnRowUpdated(object sender, NpgsqlRowUpdatedEventArgs args)
        {
            int newID = 0;
            object newObj;
            var idCMD = new NpgsqlCommand("SELECT LASTVAL()", mobjConnection);

            if (args.StatementType == System.Data.StatementType.Insert)
            {
                var adapter = sender as NpgsqlDataAdapter;
                if (adapter?.SelectCommand.Transaction != null)
                {
                    idCMD.Transaction = adapter.SelectCommand.Transaction;
                }

                newObj = idCMD.ExecuteScalar();
                if (newObj != DBNull.Value)
                {
                    newID = Convert.ToInt32(newObj);
                    if (newID > 0)
                    {
                        args.Row[0] = newID;
                    }
                }
            }
        }

        public static void UpdateByDataTable(ref DataTable dt)
        {
            if (dt == null) return;

            NpgsqlDataAdapter da;
            NpgsqlCommandBuilder cb;
            NpgsqlTransaction tr = null;

            try
            {
                if (mobjConnection.State != ConnectionState.Open)
                {
                    mobjConnection.Open();
                }

                da = new NpgsqlDataAdapter("SELECT * FROM " + dt.TableName + " WHERE 1=0", mobjConnection);
                cb = new NpgsqlCommandBuilder(da);

                // Iniciar una transacción local
                tr = mobjConnection.BeginTransaction();
                da.SelectCommand.Transaction = tr;
                cb.RefreshSchema();

                // Agregar manejador de evento para capturar IDs generados
                da.RowUpdated += new NpgsqlRowUpdatedEventHandler(OnRowUpdated);

                // Aplicar la actualización
                da.Update(dt);

                // Remover el manejador
                da.RowUpdated -= new NpgsqlRowUpdatedEventHandler(OnRowUpdated);

                tr.Commit();
            }
            catch (Exception ex)
            {
                try
                {
                    tr?.Rollback();
                }
                catch { }

                throw ex;
            }
        }

        #endregion

        #region Insert Command

        public static DataSet InsertByDataset(DataSet ds, string strTable)
        {
            var da = new NpgsqlDataAdapter("SELECT * FROM " + strTable + " WHERE 1=0", mobjConnection);
            var cb = new NpgsqlCommandBuilder(da);

            try
            {
                if (mobjConnection.State != ConnectionState.Open)
                {
                    mobjConnection.Open();
                }

                cb.RefreshSchema();
                da.Fill(ds, strTable);

                // Sin el NpgsqlCommandBuilder, esta línea fallaría.
                da.Update(ds, strTable);
            }
            catch (Exception ex)
            {
                // Manejo de excepciones
                Console.WriteLine("Error en InsertByDataset: " + ex.Message);
            }

            return ds;
        }

        #endregion

        #region Dispose

        public static void Dispose()
        {
            if (!mblnDisposed)
            {
                try
                {
                    // Liberar la conexión a la base de datos llamando a su método Dispose
                    if (mobjConnection != null)
                    {
                        mobjConnection.Dispose();
                        mobjConnection = null;
                    }
                }
                finally
                {
                    // Indicar que Dispose() ha sido llamado
                    mblnDisposed = true;
                }
            }
        }

        #endregion

    }
}
