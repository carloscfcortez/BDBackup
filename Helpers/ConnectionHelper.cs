using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDBak.Helpers
{

    public class ConnectionHelper
    {
        public static SqlConnection Conn { get; set; }

       
        public static void LoadConnectionString(string dataSource, string initialCatalog, bool integratedSecureity, string userId = null
            , string password = null)
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = null;

            if (integratedSecureity)
            {
                
                sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
                {
                    InitialCatalog = initialCatalog,
                    DataSource = dataSource,
                    IntegratedSecurity = integratedSecureity
                };
            }
            else
            {
                sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
                {
                    InitialCatalog = initialCatalog,
                    DataSource = dataSource,
                    IntegratedSecurity = integratedSecureity,
                    UserID = userId,
                    Password = password
                };
            }

            LoadConnectionString(sqlConnectionStringBuilder);

        }

        public static void LoadConnectionString(SqlConnectionStringBuilder sqlConnectionStringBuilder)
        {
            if (Conn == null)
                Conn = (new SqlConnection() { ConnectionString = sqlConnectionStringBuilder.ConnectionString });
        }

        public static void OpenConnection()
        {
            if (Conn != null)
                if (Conn.State != System.Data.ConnectionState.Open)
                    Conn.Open();

        }

        public static void CloseConnection()
        {
            if (Conn != null)
                if (Conn.State != System.Data.ConnectionState.Closed)
                    Conn.Close();
        }
    }
}
