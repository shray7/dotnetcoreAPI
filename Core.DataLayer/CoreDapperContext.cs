using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Core.DataLayer
{
    public class CoreDapperContext
    {
        private IDbConnection DbConnection;
        public CoreDapperContext()
        {
            DbConnection = new SqlConnection();
        }
    }
}
