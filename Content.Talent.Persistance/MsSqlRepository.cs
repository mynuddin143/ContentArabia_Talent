using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using static Content.Persistance.Encryptor;

namespace SE.CAF.CC.Persistance
{
    public class MsSqlRepository : IRepository
    {
        private string _connectionString = string.Empty;
        private SqlConnection _connection;

        private void OpenConnection()
        {
            if (this._connection.State == ConnectionState.Closed)
            {
                this._connection.Open();
            }
        }

        private void CloseConnection()
        {
            if (this._connection.State != ConnectionState.Closed)
            {
                this._connection.Close();
            }
        }

        public IDataParameter NewParameter() { return new SqlParameter(); }

        public MsSqlRepository(string connectionString)
        {
            try
            {
                if (connectionString != null)
                {
                    this._connectionString = Cryptographer.Decrypt(connectionString);
                }
                //this._connectionString = connectionString;
                this._connection = new SqlConnection(this._connectionString);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public DataSet ExecuteDataSet(string procedureName, IList<IDataParameter> parameters)
        {
            DataSet ds = new DataSet("Data");
            using (SqlCommand command = new SqlCommand(procedureName, this._connection))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;
                    //if (parameters.Count > 0) command.Parameters = new SqlParameterCollection();
                    foreach (IDbDataParameter item in parameters)
                    {
                        SqlParameter param = new SqlParameter(item.ParameterName, item.Value);
                        command.Parameters.Add(param);
                    }
                    this.OpenConnection();
                    SqlDataAdapter da = new SqlDataAdapter();
                    da.SelectCommand = command;
                    da.Fill(ds);
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    this.CloseConnection();
                }
            }
            return ds;
        }

        public IDataReader ExecuteSQLCommand(string query)
        {
            using (SqlCommand command = new SqlCommand(query, this._connection))
            {
                try
                {
                    this.OpenConnection();
                    return command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        public IDataReader ExecuteSQLCommand(string query, IList<IDataParameter> parameters, CommandType cmdType = CommandType.StoredProcedure)
        {
            using (SqlCommand command = new SqlCommand(query, this._connection))
            {
                try
                {
                    command.CommandType = cmdType;
                    //if (parameters.Count > 0) command.Parameters = new SqlParameterCollection();
                    foreach (IDbDataParameter param in parameters)
                    {
                        command.Parameters.Add(param);
                    }
                    this.OpenConnection();
                    return command.ExecuteReader();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        public object ExecuteScalar(string query)
        {
            using (SqlCommand command = new SqlCommand(query, this._connection))
            {
                try
                {
                    this.OpenConnection();
                    return command.ExecuteScalar();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        public int ExecuteNonQuery(string query)
        {
            using (SqlCommand command = new SqlCommand(query, this._connection))
            {
                try
                {
                    command.CommandType = CommandType.Text;
                    this.OpenConnection();
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        public int ExecuteNonQuery(string query, IList<IDataParameter> parameters)
        {
            using (SqlCommand command = new SqlCommand(query, this._connection))
            {
                try
                {
                    command.CommandType = CommandType.Text;
                    foreach (IDbDataParameter param in parameters)
                    {
                        command.Parameters.Add(param);
                    }
                    this.OpenConnection();
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        public IList<TEntity> ExecuteSQLQuery<TEntity>(string query) where TEntity : new()
        {
            IList<TEntity> list = null;
            using (SqlCommand command = new SqlCommand(query, this._connection))
            {
                try
                {
                    this.OpenConnection();
                    SqlDataReader reader = command.ExecuteReader();
                    list = GenericMapper.Map<TEntity>(reader);
                    return list;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        public IList<TEntity> ExecuteSQLQuery<TEntity>(string procedureName, IList<IDataParameter> parameters) where TEntity : new()
        {
            IList<TEntity> list = null;
            using (SqlCommand command = new SqlCommand(procedureName, this._connection))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;
                    //if (parameters.Count > 0) command.Parameters = new SqlParameterCollection();
                    if (parameters != null)
                    {
                        foreach (IDbDataParameter param in parameters)
                        {
                            command.Parameters.Add(param);
                        }
                    }
                    this.OpenConnection();
                    SqlDataReader reader = command.ExecuteReader();
                    list = GenericMapper.Map<TEntity>(reader);
                    return list;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        public int ExecuteStoredProcedure(string procedureName)
        {
            using (SqlCommand command = new SqlCommand(procedureName, this._connection))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;
                    this.OpenConnection();
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        public int ExecuteStoredProcedure(string procedureName, IList<IDataParameter> parameters)
        {
            using (SqlCommand command = new SqlCommand(procedureName, this._connection))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // if (parameters.Count > 0) command.Parameters = new SqlParameterCollection();
                    foreach (IDbDataParameter param in parameters)
                    {
                        command.Parameters.Add(param);
                    }
                    this.OpenConnection();
                    return command.ExecuteNonQuery();
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        public int ExecuteStoredProcedure(string procedureName, IList<IDataParameter> parameters, out long objectId)
        {

            using (SqlCommand command = new SqlCommand(procedureName, this._connection))
            {
                try
                {
                    command.CommandType = CommandType.StoredProcedure;
                    // if (parameters.Count > 0) command.Parameters = new SqlParameterCollection();
                    foreach (IDbDataParameter param in parameters)
                    {
                        command.Parameters.Add(param);
                    }
                    this.OpenConnection();
                    int r = command.ExecuteNonQuery();
                    long retId = 0;
                    string outp = Convert.ToString(command.Parameters["ID"].Value); // Add ID as outparam in proc
                    long.TryParse(outp, out retId);
                    objectId = retId;
                    return r;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        public bool BulkInsert(DataTable dt, string tableName)
        {
            try
            {
                SqlBulkCopy bulkCopy =
                new SqlBulkCopy
                (
                this._connection,
                SqlBulkCopyOptions.TableLock |
                SqlBulkCopyOptions.FireTriggers |
                SqlBulkCopyOptions.UseInternalTransaction,
                null
                );
                foreach (DataColumn col in dt.Columns)
                {
                    bulkCopy.ColumnMappings.Add(col.ColumnName, col.ColumnName);
                }
                bulkCopy.DestinationTableName = tableName;
                this.OpenConnection();
                bulkCopy.WriteToServer(dt);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                this.CloseConnection();
            }
        }

        public IList<TEntity> ExecuteSQLQueryWithParam<TEntity>(string query, IList<IDataParameter> parameters) where TEntity : new()
        {
            IList<TEntity> list = null;
            using (SqlCommand command = new SqlCommand(query, this._connection))
            {
                try
                {
                    command.CommandType = CommandType.Text;
                    //if (parameters.Count > 0) command.Parameters = new SqlParameterCollection();
                    if (parameters != null)
                    {
                        foreach (IDbDataParameter param in parameters)
                        {
                            command.Parameters.Add(param);
                        }
                    }
                    this.OpenConnection();
                    SqlDataReader reader = command.ExecuteReader();
                    list = GenericMapper.Map<TEntity>(reader);
                    return list;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
                finally
                {
                    this.CloseConnection();
                }
            }
        }

        void IDisposable.Dispose()
        {
            this.CloseConnection();
            this._connection.Dispose();
        }

    }
}
