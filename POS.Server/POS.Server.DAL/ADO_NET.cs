using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;

namespace POS.Server.DAL
{
    /// <summary>
    /// Sql Data Connectivity provider
    /// </summary>
    public class ADO_NET
    {
        SqlConnection _connection;
        SqlCommand _command;
        SqlTransaction _sqlTransaction;
        private bool _IsTransactionOpen;
        private bool _IsConnectionOpen;
        private readonly string _connectionString = ConfigurationManager.ConnectionStrings["Constr"].ToString();
        private static int OpenConnectionCtr = default(int);
        //Constr
        public ADO_NET()
        {
            this._connectionString = ConfigurationManager.ConnectionStrings["Constr"].ToString();
            this._IsTransactionOpen = default(bool);
            this._IsConnectionOpen = default(bool);
            this._connection = null;
            this._command = null;
        }
        public void Connect()
        {
            this._connection = this._connection ?? new SqlConnection(this._connectionString);
            this._command = this._command ?? new SqlCommand();
            if (this._connection.State == ConnectionState.Open)
            {
                this._connection.Close();
                this._connection.Open();
            }
            else
            {
                this._connection.Open();
                OpenConnectionCtr = OpenConnectionCtr + 1;
            }

            this._IsConnectionOpen = true;

        }
        public void DisConnect()
        {
            if (this._connection.State == ConnectionState.Open)
            {
                this._connection.Close();
                this._connection.Dispose();
                this._command.Dispose();
                OpenConnectionCtr = OpenConnectionCtr - 1;
                this._IsConnectionOpen = false;

            }
        }

        public void BeginTrasaction()
        {
            this.Connect();
            this._sqlTransaction = this._connection.BeginTransaction(IsolationLevel.ReadCommitted);
            this._IsTransactionOpen = true;
        }

        public void CommitTransaction()
        {
            this._sqlTransaction.Commit();
            this._IsTransactionOpen = false;
            this._sqlTransaction = null;
        }
        public void RollBackTransaction()
        {
            this._sqlTransaction.Rollback();
            this._IsTransactionOpen = false;
            this._sqlTransaction = null;
        }

        public int ExecuteQuery(SqlCommand Command)
        {
            int _affectedRecord = default(int);
            try
            {
                this._command = Command;
                this._command.Connection = this._connection;
                _affectedRecord = this._command.ExecuteNonQuery();
                return _affectedRecord;
            }
            catch
            {
                throw;
            }

        }

        public int ExecuteQueryWithTransaction(SqlCommand Command)
        {
            int _affectedRecord = default(int);
            try
            {
                if (!this._IsTransactionOpen)
                {
                    this.BeginTrasaction();
                    this._command = Command;
                    this._command.Connection = this._connection;
                    _affectedRecord = this._command.ExecuteNonQuery();
                }
                this.CommitTransaction();
                return _affectedRecord;
            }
            catch (Exception)
            {
                this.RollBackTransaction();
                throw;
            }
        }

        public SqlDataReader GetRecords(SqlCommand Command)
        {
            SqlDataReader _reader = default(SqlDataReader);
            try
            {
                this._command = Command;
                this._command.Connection = this._connection;
                _reader = this._command.ExecuteReader(CommandBehavior.CloseConnection);
                return _reader;
            }
            catch (Exception)
            {

                throw;
            }
        }

        public bool IsTransactionOpen
        {
            get
            {
                return this._IsTransactionOpen;
            }
        }

        public bool IsConnectionOpen
        {
            get
            {
                return this._IsConnectionOpen;
            }
        }

        public int TotalOpenConnection
        {
            get
            {
                return OpenConnectionCtr;
            }
        }

    }
}
