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
    public partial class User_Register : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming Projects\Motors\ABC Car Traders\ABC Car Traders\ABC_Car_Traders.mdf;Integrated Security=True;Connect Timeout=30");

        public User_Register()
        {
            InitializeComponent();
        }

        private void cancle_btn_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            if (fname_textbox.Text == ""
                || lname_textbox.Text == ""
                || mobile_textbox.Text == ""
                || email_textbox.Text == ""
                || password_textbox.Text == ""
                )
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        DateTime today = DateTime.Today;
                        connect.Open();
                        string insertData = "INSERT INTO user_details " +
                            "(first_name,last_name, mobile_no, email, user_password, user_state) " +
                            "VALUES(@f_name,@l_name, @mobile, @email, @password, @state)";



                        using (SqlCommand cmd = new SqlCommand(insertData, connect))
                        {
                            cmd.Parameters.AddWithValue("@f_name", fname_textbox.Text.Trim());
                            cmd.Parameters.AddWithValue("@l_name", lname_textbox.Text.Trim());
                            cmd.Parameters.AddWithValue("@mobile", mobile_textbox.Text.Trim());
                            cmd.Parameters.AddWithValue("@email", email_textbox.Text.Trim());
                            cmd.Parameters.AddWithValue("@password", password_textbox.Text.Trim());
                            cmd.Parameters.AddWithValue("@state", "0");

                            cmd.ExecuteNonQuery();

                            

                            MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }



            user_login user_login_form = new user_login();
            user_login_form.Show();
            this.Hide();
        }
    }
}
