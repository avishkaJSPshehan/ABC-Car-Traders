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
    public partial class Single_part : Form
    {
        string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming Projects\Motors\ABC Car Traders\ABC Car Traders\ABC_Car_Traders.mdf;Integrated Security=True;Connect Timeout=30";

        public Single_part()
        {
            InitializeComponent();
        }

        private void cancle_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            string user_email = "";
            string first_name = "";
            string last_name = "";
            string mobile_no = "";

            using (StreamReader reader = new StreamReader(@"D:\Programming Projects\Motors\ABC Car Traders\ABC Car Traders\ABC Car Traders\User_login.txt"))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    user_email = line;
                }
            }

            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand comm = new SqlCommand("SELECT * FROM user_details WHERE email = '" + user_email + "'", conn);

            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();


                while (reader.Read())
                {
                    // Retrieve each column value
                    first_name = reader["first_name"].ToString();
                    last_name = reader["last_name"].ToString();
                    mobile_no = reader["mobile_no"].ToString();
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }


            Single_part singale_part_view = new Single_part();

            string part_name = part_name_lb.Text.ToString().Trim();


            try
            {

                string partimagePath = "";


                SqlCommand comm_3 = new SqlCommand("SELECT * FROM CarParts WHERE part_name = '" + part_name + "'", conn);

                try
                {
                    conn.Open();
                    SqlDataReader reader = comm_3.ExecuteReader();


                    while (reader.Read())
                    {
                        partimagePath = reader["part_image"].ToString();

                    }

                    reader.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
                finally
                {
                    conn.Close();
                }

                conn.Open();

                string query = "INSERT INTO Orders (order_id, car_model, customer_name, customer_email, customer_phone, order_date, total_amount, payment_status, order_status,item_image) " +
                "VALUES (@order_id, @car_model, @customer_name, @customer_email, @customer_phone, @order_date, @total_amount, @payment_status, @order_status,@image)";

                SqlCommand comm_2 = new SqlCommand(query, conn);

                Random random = new Random();
                int order_number = random.Next(100000, 1000000);

                DateTime onlyDate = DateTime.Today;  




                // Add parameters to prevent SQL injection
                comm_2.Parameters.AddWithValue("@order_id", order_number);
                comm_2.Parameters.AddWithValue("@car_model", part_name);
                comm_2.Parameters.AddWithValue("@customer_name", first_name);
                comm_2.Parameters.AddWithValue("@customer_email", user_email);
                comm_2.Parameters.AddWithValue("@customer_phone", mobile_no);
                comm_2.Parameters.AddWithValue("@order_date", onlyDate);  
                comm_2.Parameters.AddWithValue("@total_amount", price_lb.Text);
                comm_2.Parameters.AddWithValue("@payment_status", "cash");
                comm_2.Parameters.AddWithValue("@order_status", "Processing"); 
                comm_2.Parameters.AddWithValue("@image", partimagePath);

                // Execute the command
                comm_2.ExecuteNonQuery();

                MessageBox.Show( "Order Successfully Added");
                this.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
            finally
            {
                conn.Close();
            }
        }
    }
}
