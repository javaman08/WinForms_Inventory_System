using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace INVENTORY_SYSTEM.Login
{
    public partial class Login_Page : Form
    {
        public Login_Page()
        {
            InitializeComponent();
        }

        private void Login_Page_Load(object sender, EventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            textBox2.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var conn = new SqlConnection(AppConnection.ConnectionString))
            {
                if(conn.State == ConnectionState.Closed)
                conn.Open();

                using (var cmd = conn.CreateCommand())
                {
                    cmd.CommandText = @"SELECT COUNT('a') FROM USERS WITH(NOLOCK) WHERE Username = @username AND Password = @password";
                    cmd.Parameters.AddWithValue("@username", textBox1.Text.Trim());
                    cmd.Parameters.AddWithValue("@password", textBox2.Text.Trim());

                    var result = cmd.ExecuteScalar();
                    if((int)result > 0)
                    {
                        MessageBox.Show("Login Pass");
                    }
                    else
                    {
                        MessageBox.Show("Login failed");
                    }
                }
            }

            
                
        }
    }
}
