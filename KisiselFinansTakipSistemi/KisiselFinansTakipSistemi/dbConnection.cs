using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace KisiselFinansTakipSistemi
{
    internal class dbConnection : IDisposable
    {
        SqlConnection sqlConnection = new SqlConnection("Data Source=UĞUR;Initial Catalog=KisiselFinansTakipSistemi;Integrated Security=True;Trust Server Certificate=True");

        public SqlConnection dbConnect()
        {
            if (sqlConnection.State == System.Data.ConnectionState.Open) 
            {
                return sqlConnection;
            } else
            {
                sqlConnection.Open();
                return sqlConnection;
            }
        }

        public void Dispose()
        {
            sqlConnection.Close();
            sqlConnection.Dispose();
        }
     
    }
}
