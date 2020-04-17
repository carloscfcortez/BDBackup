using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BDBak.Helpers
{
    public class DatabaseHelper
    {
        public static async Task GerarBak(string _directory, string database)
        {
            try
            {

                string directory = _directory;
                string fileName = Path.Combine(directory, string.Concat($"{database}_BK_", DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"), ".bak"));

                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);

                //ConnectionHelper.LoadConnectionString(txtDataSource.Text, "SPF", chkIntegratedSecurity.Checked, txtUserID.Text, txtPassword.Text);

                SqlCommand cmd = new SqlCommand();


                ConnectionHelper.OpenConnection();


                cmd.Connection = ConnectionHelper.Conn;
                cmd.CommandText = $@"BACKUP DATABASE [{database}] TO  DISK = N'{fileName}' WITH NOFORMAT, NOINIT,  NAME = N'{fileName}', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

                await cmd.ExecuteNonQueryAsync();


                //MessageBox.Show("Backup realizado com sucesso!");


                ConnectionHelper.CloseConnection();


            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
    }
}
