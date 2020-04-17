namespace BDBak
{
    partial class FrmBackup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnExecBackup = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDirectory = new System.Windows.Forms.TextBox();
            this.txtDataSource = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.chkIntegratedSecurity = new System.Windows.Forms.CheckBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.chkJob = new System.Windows.Forms.CheckBox();
            this.grdDatabases = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdDatabases)).BeginInit();
            this.SuspendLayout();
            // 
            // btnExecBackup
            // 
            this.btnExecBackup.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnExecBackup.Location = new System.Drawing.Point(15, 190);
            this.btnExecBackup.Name = "btnExecBackup";
            this.btnExecBackup.Size = new System.Drawing.Size(86, 44);
            this.btnExecBackup.TabIndex = 0;
            this.btnExecBackup.Text = "Backup";
            this.btnExecBackup.UseVisualStyleBackColor = true;
            this.btnExecBackup.Click += new System.EventHandler(this.btnExecBackup_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.Location = new System.Drawing.Point(122, 190);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Diretório";
            // 
            // txtDirectory
            // 
            this.txtDirectory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDirectory.Location = new System.Drawing.Point(125, 210);
            this.txtDirectory.Name = "txtDirectory";
            this.txtDirectory.Size = new System.Drawing.Size(353, 23);
            this.txtDirectory.TabIndex = 2;
            this.txtDirectory.Text = "D:\\";
            // 
            // txtDataSource
            // 
            this.txtDataSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtDataSource.Location = new System.Drawing.Point(15, 29);
            this.txtDataSource.Name = "txtDataSource";
            this.txtDataSource.Size = new System.Drawing.Size(353, 23);
            this.txtDataSource.TabIndex = 4;
            this.txtDataSource.Text = "localhost";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Data Source";
            // 
            // txtUserID
            // 
            this.txtUserID.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtUserID.Location = new System.Drawing.Point(15, 84);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.Size = new System.Drawing.Size(353, 23);
            this.txtUserID.TabIndex = 6;
            this.txtUserID.Text = "sa";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.Location = new System.Drawing.Point(12, 64);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "User ID";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtPassword.Location = new System.Drawing.Point(15, 139);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(353, 23);
            this.txtPassword.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.Location = new System.Drawing.Point(12, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(69, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "Password";
            // 
            // chkIntegratedSecurity
            // 
            this.chkIntegratedSecurity.AutoSize = true;
            this.chkIntegratedSecurity.Location = new System.Drawing.Point(383, 29);
            this.chkIntegratedSecurity.Name = "chkIntegratedSecurity";
            this.chkIntegratedSecurity.Size = new System.Drawing.Size(115, 17);
            this.chkIntegratedSecurity.TabIndex = 9;
            this.chkIntegratedSecurity.Text = "Integrated Security";
            this.chkIntegratedSecurity.UseVisualStyleBackColor = true;
            this.chkIntegratedSecurity.CheckedChanged += new System.EventHandler(this.chkIntegratedSecurity_CheckedChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnConnect.Location = new System.Drawing.Point(383, 118);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(169, 44);
            this.btnConnect.TabIndex = 10;
            this.btnConnect.Text = "Connect Database";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // chkJob
            // 
            this.chkJob.AutoSize = true;
            this.chkJob.Location = new System.Drawing.Point(522, 214);
            this.chkJob.Name = "chkJob";
            this.chkJob.Size = new System.Drawing.Size(73, 17);
            this.chkJob.TabIndex = 11;
            this.chkJob.Text = "Ativar Job";
            this.chkJob.UseVisualStyleBackColor = true;
            this.chkJob.CheckedChanged += new System.EventHandler(this.chkJob_CheckedChanged);
            // 
            // grdDatabases
            // 
            this.grdDatabases.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdDatabases.Location = new System.Drawing.Point(15, 256);
            this.grdDatabases.Name = "grdDatabases";
            this.grdDatabases.Size = new System.Drawing.Size(802, 204);
            this.grdDatabases.TabIndex = 12;
            // 
            // FrmBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 472);
            this.Controls.Add(this.grdDatabases);
            this.Controls.Add(this.chkJob);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.chkIntegratedSecurity);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtUserID);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtDataSource);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtDirectory);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnExecBackup);
            this.Name = "FrmBackup";
            this.Text = "BACKUP DATABASE SQL SERVER";
            ((System.ComponentModel.ISupportInitialize)(this.grdDatabases)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnExecBackup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDirectory;
        private System.Windows.Forms.TextBox txtDataSource;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.CheckBox chkIntegratedSecurity;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.CheckBox chkJob;
        private System.Windows.Forms.DataGridView grdDatabases;
    }
}

