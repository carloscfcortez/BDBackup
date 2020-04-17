using BDBak.Helpers;
using BDBak.Jobs;
using BDBak.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BDBak
{
    public partial class FrmBackup : Form
    {
        public FrmBackup()
        {
            InitializeComponent();
        }





        private void btnExecBackup_Click(object sender, EventArgs e)
        {
            try
            {

                string directory = txtDirectory.Text;
                string fileName = Path.Combine(directory, string.Concat("SPF_BK_", DateTime.Now.ToString("yyyy-MM-dd-HH-mm-ss"), ".bak"));

                if (!Directory.Exists(directory)) Directory.CreateDirectory(directory);


                ConnectionHelper.LoadConnectionString(txtDataSource.Text, "SPF", chkIntegratedSecurity.Checked, txtUserID.Text, txtPassword.Text);

                SqlCommand cmd = new SqlCommand();


                ConnectionHelper.OpenConnection();


                cmd.Connection = ConnectionHelper.Conn;
                cmd.CommandText = $@"BACKUP DATABASE [SPF] TO  DISK = N'{fileName}' WITH NOFORMAT, NOINIT,  NAME = N'{fileName}', SKIP, NOREWIND, NOUNLOAD,  STATS = 10";

                cmd.ExecuteNonQuery();


                MessageBox.Show("Backup realizado com sucesso!");


                ConnectionHelper.CloseConnection();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }





        }

        private void chkIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {
            if (chkIntegratedSecurity.Checked)
            {
                txtUserID.Enabled = false;
                txtUserID.Text = "";

                txtPassword.Enabled = false;
                txtPassword.Text = "";
            }
            else
            {
                txtUserID.Enabled = true;
                txtPassword.Enabled = true;

            }

        }
        public static List<Databases> databases = new List<Databases>();
        private void btnConnect_Click(object sender, EventArgs e)
        {
            ConnectionHelper.LoadConnectionString(txtDataSource.Text, "SPF", chkIntegratedSecurity.Checked, txtUserID.Text, txtPassword.Text);


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = ConnectionHelper.Conn;
            cmd.CommandText = "SELECT name FROM sys.databases";

            SqlDataReader sqlDataReader;

            ConnectionHelper.OpenConnection();

            sqlDataReader = cmd.ExecuteReader();



            while (sqlDataReader.Read())
            {
                var dt = new Databases()
                {
                    name = sqlDataReader.GetString(0)
                };

                databases.Add(dt);
            }


            grdDatabases.DataSource = databases;
            grdDatabases.Update();

            ConnectionHelper.CloseConnection();
        }

        private void chkJob_CheckedChanged(object sender, EventArgs e)
        {
            if (chkJob.Checked)
            {
                foreach (var item in databases.Where(x => x.backup))
                {
                    string[] interval = item.times.Split(',');
                    BackupJob.StartdJobs(item.directory, item.name, interval);
                }
            }
            else
            {
                BackupJob.StopJobs();
            }
            
            
        }
    }
}
