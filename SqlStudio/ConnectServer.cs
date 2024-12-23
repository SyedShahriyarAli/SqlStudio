using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SqlStudio
{
    public partial class ConnectServer : Form
    {
        MainForm parent;

        public ConnectServer(MainForm parent)
        {
            InitializeComponent();
            this.parent = parent;
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {
            var connectionString = GetConnectionString();

            using (var connection = new System.Data.SqlClient.SqlConnection(connectionString))
            {
                try
                {
                    connection.Open();
                    MessageBox.Show("Connection successful!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private string GetConnectionString(string dbName = null)
        {
            var connectionString = "Data Source={0}; Initial Catalog={1}; User ID={2}; Password={3};";

            return string.Format(connectionString,
                TxtServer.Text,
                string.IsNullOrEmpty(dbName) ? "master" : dbName,
                TxtUsername.Text, TxtPassword.Text
            );
        }

        private void BtnSubmit_Click(object sender, EventArgs e)
        {
            var connectionString = GetConnectionString();

            SqlCommand cm = new SqlCommand("Select name from sys.databases", new SqlConnection(connectionString));
            SqlDataAdapter da = new SqlDataAdapter(cm);
            DataTable dt = new DataTable();

            da.Fill(dt);

            foreach (DataRow row in dt.Rows)
            {
                connectionString = GetConnectionString(row["name"].ToString());
                parent.connectionStrings.Rows.Add(connectionString, row[0]);
            }

            parent.BindDatabase();

            this.Close();
            this.Dispose();
        }
    }
}
