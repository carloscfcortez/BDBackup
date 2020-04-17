﻿using BDBak.Helpers;
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

        private void btnConnect_Click(object sender, EventArgs e)
        {
           
        }
    }
}
