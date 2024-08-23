using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace ABC_Car_Traders
{
    public partial class user_login : Form

    {
        string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming Projects\Motors\ABC Car Traders\ABC Car Traders\ABC_Car_Traders.mdf;Integrated Security=True;Connect Timeout=30";

        public user_login()
        {
            InitializeComponent();
        }

        private void Login_lb_Click(object sender, EventArgs e)
        {

        }

        private void cancle_btn_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            conn.Open();

            

            string query = "SELECT * from user_details WHERE email = @email and user_password=@password";

            SqlCommand sqlcmd = new SqlCommand(query, conn);
            sqlcmd.Parameters.AddWithValue("@email", email_textbox.Text);
            sqlcmd.Parameters.AddWithValue("@password", password_textbox.Text);
            DataTable dtbl = new DataTable();

            SqlDataAdapter sqlsda = new SqlDataAdapter(sqlcmd);
            sqlsda.Fill(dtbl);

            conn.Close();

            if (dtbl.Rows.Count == 1)
            {
                this.Hide();

                DataRow row = dtbl.Rows[0];

                
                string user_state = row["user_state"].ToString();



                if (user_state == "1")
                {
                    MessageBox.Show("You are logged in as an Admin");
                    Admin_form admin_form = new Admin_form();
                    admin_form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You are logged in as a User");
                    User_form user_form = new User_form();
                    user_form.Show();
                    this.Hide();

                    using (StreamWriter writer = new StreamWriter(@"D:\Programming Projects\Motors\ABC Car Traders\ABC Car Traders\ABC Car Traders\User_login.txt"))
                    {
                        writer.Write(email_textbox.Text);
                    }
                }
            }
            else
            {
                MessageBox.Show("Incorrect username or password");
            }
        }

        private void user_register_btn_Click(object sender, EventArgs e)
        {
            User_Register user_register = new User_Register();
            user_register.Show();
            this.Hide();
        }
    }
}
