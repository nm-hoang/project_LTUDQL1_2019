using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace project
{
    class CheckConnect
    {
         SqlConnection _connection;
        public CheckConnect (string connectionString)
        {
            _connection = new SqlConnection(connectionString);
        }
        public bool IsConnection
        {

            get
            {
                if (_connection.State == ConnectionState.Closed)
                {
                    _connection.Open();
                }
                return true;
            }
        }
    }
}
