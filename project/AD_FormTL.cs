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
            //Data Source=NAMNGUYEN;Initial Catalog=QLThiTracNghiem;User ID=sa;Password=***********

            //init backup and restore 
            btnBU.Enabled = false;
            btnRT.Enabled = false;
            cbDBBU.Text = database;
            cbDBRT.Text = database;
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
                            cbDBBU.Items.Add(dr[0].ToString());
                            cbDBRT.Items.Add(dr[0].ToString()); ;
                        }
                    }
                }
            }
        }

        private void btnKetNoi_Click(object sender, EventArgs e)
        {
            string connectionString;
            if (txtUName.Text != "" && txtPassWord.Text != "")
            {
                connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True;User ID ={2};Password={3}", cbSV.Text, cbDB.Text, txtUName.Text, txtPassWord.Text);
            }
            else
            {
                connectionString = string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", cbSV.Text, cbDB.Text);
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

        private void btnBrowseBU_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == DialogResult.OK)
            {
                txtDDanBU.Text = fbd.SelectedPath;
                btnBU.Enabled = true;
            }
        }

        private void btnBU_Click(object sender, EventArgs e)
        {
            string conString = ConfigurationManager.ConnectionStrings["project"].ToString();
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                String database = cbDBBU.Text;
                if (txtDDanBU.Text == string.Empty)
                {
                    MessageBox.Show("Vui lòng chọn đường dẫn lưu file backup");
                }
                else
                {

                    string q = "BACKUP DATABASE [" + database + "] TO DISK='" + txtDDanBU.Text + "\\" + "Database" + "-" + database + "-" + DateTime.Now.ToString("yyyy-MM-dd--HH-mm-ss") + ".bak'";

                    SqlCommand scmd = new SqlCommand(q, con);
                    scmd.ExecuteNonQuery();
                    MessageBox.Show("Backup Database thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnBU.Enabled = false;

                }
            }
        }

        private void btnBrowseRT_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "SQL SERVER database backup files|*.bak";
            ofd.Title = "Database Restore";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                txtDDanRT.Text = ofd.FileName;
                btnRT.Enabled = true;
            }
        }

        private void btnRT_Click(object sender, EventArgs e)
        {
            string conString =  string.Format("Data Source={0};Initial Catalog={1};Integrated Security=True", cbSV.Text, cbDBRT.Text);
            using (SqlConnection con = new SqlConnection(conString))
            {
                con.Open();
                String database = cbDBRT.Text;
                try
                {

                    string sql1 = string.Format("ALTER DATABASE [" + database + "] SET SINGLE_USER WITH ROLLBACK IMMEDIATE");
                    SqlCommand cmd1 = new SqlCommand(sql1, con);
                    cmd1.ExecuteNonQuery();

                    string sql2 = string.Format("USE MASTER RESTORE DATABASE [" + database + "] FROM DISK='" + txtDDanRT.Text + "' WITH REPLACE;");
                    SqlCommand cmd2 = new SqlCommand(sql2, con);
                    cmd2.ExecuteNonQuery();

                    string sql3 = string.Format("ALTER DATABASE [" + database + "] SET MULTI_USER");
                    SqlCommand cmd3 = new SqlCommand(sql3, con);
                    cmd3.ExecuteNonQuery();
                    // s.Speak("Database Restored successfully");
                    MessageBox.Show("Database Restored successfully", "Restore Database successs", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnRT.Enabled = false;


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        
        }

    }
}
