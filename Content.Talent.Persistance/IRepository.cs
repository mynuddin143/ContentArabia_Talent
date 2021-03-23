using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SE.CAF.CC.Persistance
{
    public interface IRepository : IDisposable
    {
        IDataParameter NewParameter();
        IDataReader ExecuteSQLCommand(string query);
        IDataReader ExecuteSQLCommand(string query, IList<IDataParameter> parameters, CommandType cmdType= CommandType.StoredProcedure);
        DataSet ExecuteDataSet(string procedureName, IList<IDataParameter> parameters);
        object ExecuteScalar(string query);
        int ExecuteNonQuery(string query);
        int ExecuteNonQuery(string query, IList<IDataParameter> parameters);
        IList<TEntity> ExecuteSQLQuery<TEntity>(string query) where TEntity : new();
        IList<TEntity> ExecuteSQLQuery<TEntity>(string procedureName, IList<IDataParameter> parameters) where TEntity : new();
        int ExecuteStoredProcedure(string procedureName);
        int ExecuteStoredProcedure(string procedureName, IList<IDataParameter> parameters);
        int ExecuteStoredProcedure(string procedureName, IList<IDataParameter> parameters, out long objectId);
        bool BulkInsert(DataTable dt, string tableName);
        IList<TEntity> ExecuteSQLQueryWithParam<TEntity>(string query, IList<IDataParameter> parameters) where TEntity : new();

    }
}
