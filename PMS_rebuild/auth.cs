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

namespace PMS_rebuild
{
    public partial class auth : Form
    {
        public auth()
        {
            InitializeComponent();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            if (textBox2.Text == textBox3.Text)
            {
                if (textBox1.Text != "")
                {
                    
                    string connection_string = "Data Source=DESKTOP-65FAGV7\\SQLEXPRESS;Initial Catalog=PMS_db;Integrated Security=True";

                    SqlConnection conn = new SqlConnection(connection_string);
                    conn.Open();

                    string query = "insert into login_details values(@username,@password)";

                    SqlCommand sqlcmd = new SqlCommand(query, conn);
                    sqlcmd.Parameters.AddWithValue("@username", textBox1.Text);
                    sqlcmd.Parameters.AddWithValue("@password", textBox2.Text);

                    sqlcmd.ExecuteNonQuery();


                    conn.Close();

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";

                }
                else
                {
                    MessageBox.Show("Username must Required!");
                }
            }
            else
            {
                MessageBox.Show("Password is not Matched!");
            }
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            adminHome auth = new adminHome();
            auth.Show();
            this.Hide();
        }
    }
}
