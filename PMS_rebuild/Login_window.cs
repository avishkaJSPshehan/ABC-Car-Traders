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
using System.Data.SqlClient;

namespace PMS_rebuild
{
    public partial class Login_window : Form
    {

        string connection_string = "Data Source=DESKTOP-65FAGV7\\SQLEXPRESS;Initial Catalog=PMS_db;Integrated Security=True;TrustServerCertificate=True";

        public Login_window()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void loginBtn_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(connection_string);
            conn.Open();

            string query = "SELECT * from login_details WHERE username = @username and password=@password";

            SqlCommand sqlcmd = new SqlCommand(query, conn);
            sqlcmd.Parameters.AddWithValue("@username", textBox1.Text);
            sqlcmd.Parameters.AddWithValue("@password", textBox2.Text);
            DataTable dtbl = new DataTable();

            SqlDataAdapter sqlsda = new SqlDataAdapter(sqlcmd);
            sqlsda.Fill(dtbl);

            conn.Close();

            if (dtbl.Rows.Count == 1)
            {
                this.Hide();



                if (textBox1.Text == "admin")
                {
                    MessageBox.Show("You are logged in as an Admin");
                    adminHome fr1 = new adminHome();
                    fr1.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You are logged in as a User");
                    userHome fr2 = new userHome();
                    fr2.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }

        private void Login_window_Load(object sender, EventArgs e)
        {
            textBox2.PasswordChar = '*';
        }
    }
}
