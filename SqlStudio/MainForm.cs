using System.Collections.Generic;
using System;
using System.Configuration;
using System.Data;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;
using SqlStudio.Models;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace SqlStudio
{
    public partial class MainForm : Form
    {
        public DataTable connectionStrings = new DataTable();

        public MainForm()
        {
            InitializeComponent();

            connectionStrings.Columns.Add("ConnectionString");
            connectionStrings.Columns.Add("DatabaseName");
            connectionStrings.Rows.Add("", "Select DB");

            GetERAConnectionString();

            BindDatabase();
        }

        private async void GetERAConnectionString()
        {
            try
            {
                var superAdminApi = ConfigurationManager.AppSettings["SuperAdmin.Api"];

                if (!string.IsNullOrEmpty(superAdminApi))
                {
                    var verticals = await GetVerticals();

                    if (verticals.Count > 0)
                    {
                        foreach (var vertical in verticals)
                        {
                            var connectionString = $"Data Source={vertical.Server}; Initial Catalog={vertical.Database}; User Id={vertical.Username}; Password={vertical.Password};";

                            connectionStrings.Rows.Add(connectionString, vertical.Database);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public static async Task<List<DatabaseCredential>> GetVerticals()
        {
            using (HttpClient httpClient = new HttpClient())
            {
                httpClient.DefaultRequestHeaders.Add("Authorization", ConfigurationManager.AppSettings["SuperAdmin.API.Key"]);
                HttpResponseMessage response =
                    await httpClient.GetAsync($"{ConfigurationManager.AppSettings["SuperAdmin.API"]}Verticals/Credentials");

                if (response.IsSuccessStatusCode)
                {
                    var contentString = await response.Content.ReadAsStringAsync();
                    var content = JsonConvert.DeserializeObject<ServiceResponse<List<DatabaseCredential>>>(contentString);

                    if (content != null && content.Success)
                        return content.Data;
                    else
                        Console.WriteLine($"Failed to fetch credentials. Message: {content?.Message}");
                }
                else
                    Console.WriteLine($"Failed to fetch credentials. Status code: {response.StatusCode}");

                return new List<DatabaseCredential>();
            }
        }


        public void BindDatabase()
        {
            CboDatabase.DataSource = connectionStrings;
            CboDatabase.DisplayMember = "DatabaseName";
            CboDatabase.ValueMember = "ConnectionString";
        }

        private void BtnConnect_Click(object sender, System.EventArgs e)
        {
            ConnectServer connectServer = new ConnectServer(this);
            connectServer.ShowDialog();
        }

        private void TxtQuery_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.X && e.Alt)
                ExecuteQuery();
        }

        private void ExecuteQuery()
        {
            try
            {
                if (string.IsNullOrEmpty(CboDatabase.SelectedValue.ToString()))
                {
                    MessageBox.Show("Please select a database", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (string.IsNullOrEmpty(TxtQuery.SelectedText))
                    TxtQuery.SelectAll();

                var query = TxtQuery.SelectedText;

                if (!string.IsNullOrEmpty(query))
                {
                    SqlConnection cn = new SqlConnection(CboDatabase.SelectedValue.ToString());
                    SqlCommand sqlCommand = new SqlCommand(query, cn);
                    SqlDataAdapter da = new SqlDataAdapter(sqlCommand);
                    DataTable dt = new DataTable();

                    da.Fill(dt);

                    DgvData.DataSource = null;
                    DgvData.Columns.Clear();

                    DgvData.AutoGenerateColumns = true;
                    DgvData.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
