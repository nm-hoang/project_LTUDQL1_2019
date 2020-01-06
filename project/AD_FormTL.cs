using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace project
{
    public partial class AD_FormTL : Form
    {
        public AD_FormTL()
        {
            InitializeComponent();
            txtPassWord.PasswordChar = '*';
            // get connectionstring
            string connectionStringNow = ConfigurationManager.ConnectionStrings["project"].ToString();
            SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(connectionStringNow);
            string server = builder.DataSource;
            string database = builder.InitialCatalog;
            txtUName.Text = builder.UserID;
            txtPassWord.Text = builder.Password;
            // init cbb
            cbSV.Items.Add(server);
            cbSV.Items.Add(string.Format(@"{0}\SQLEXPRESS", Environment.MachineName));
            cbSV.SelectedIndex = 0;
            GetDatabaseList();
            cbDB.Text = database;
        }
        public void GetDatabaseList()
        {
            // Open connection to the database
            string conString = ConfigurationManager.ConnectionStrings["project"].ToString();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                // Set up a command with the given query and associate
                // this with the current connection.
                using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                {
                    using (IDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            cbDB.Items.Add(dr[0].ToString());
                        }
                    }
                }
            }
        }

        private void AD_FormTL_Load(object sender, EventArgs e)
        {

        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            string connectionString;
            if (txtUName.Text != "" && txtPassWord.Text != "")
            {
                connectionString = string.Format("Data Source={0};Initial Catalog={1};User ID ={2};Password={3}", cbSV.Text, cbDB.Text, txtUName.Text, txtPassWord.Text);
            }
            else
            {
                connectionString = string.Format("Data Source={0};Initial Catalog={1}", cbSV.Text, cbDB.Text);
            }
            try
            {
                CheckConnect cn = new CheckConnect(connectionString);
                if (cn.IsConnection)
                {
                    Configuration config;
                    config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
                    config.ConnectionStrings.ConnectionStrings["project"].ConnectionString = connectionString;
                    config.Save(ConfigurationSaveMode.Modified, true);
                    ConfigurationManager.RefreshSection("connectionStrings");
                    MessageBox.Show("Kết nối thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
