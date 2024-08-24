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
    public partial class Admin_form : Form
    {
        public Admin_form()
        {
            InitializeComponent();
        }


        /// <summary>
        /// ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>

        string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming Projects\Motors\ABC Car Traders\ABC Car Traders\ABC_Car_Traders.mdf;Integrated Security=True;Connect Timeout=30";

        void bind_car_data(string valueToFind)
        {

            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand comm = new SqlCommand("SELECT * FROM CarDetails WHERE CONCAT(Make,Modele,Product_Year) LIKE '%" + valueToFind + "%'", conn);

            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                dataGridView_admin_car.Rows.Clear();

                while (reader.Read())
                {
                    // Retrieve each column value
                    string make = reader["Make"].ToString();
                    string model = reader["Modele"].ToString();
                    string year = reader["Product_Year"].ToString();
                    string price = reader["Price"].ToString();
                    string Mileage = reader["Mileage"].ToString();
                    string Engine_type = reader["Engine_type"].ToString();
                    string Transmission = reader["Transmission"].ToString();
                    string Color = reader["Color"].ToString();
                    string Condition = reader["Condition"].ToString();
                    string Status = reader["Status"].ToString();
                    string image = reader["Car_Image"].ToString();

                    // Add the row to the DataGridView
                    dataGridView_admin_car.Rows.Add(make, model, year, price, Mileage, Engine_type, Transmission, Color, Condition, Status, image);
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

        }

        void bind_car_part_data(string partvalueToFind)
        {

            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand comm = new SqlCommand("SELECT * FROM CarParts WHERE CONCAT(part_name,part_number,manufacturer) LIKE '%" + partvalueToFind + "%'", conn);

            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                dataGridView_admin_parts.Rows.Clear();

                while (reader.Read())
                {
                    // Retrieve each column value
                    string part_name = reader["part_name"].ToString();
                    string part_number = reader["part_number"].ToString();
                    string manufacturer = reader["manufacturer"].ToString();
                    string price = reader["price"].ToString();
                    string warranty_period = reader["warranty_period"].ToString();
                    string stock_quantity = reader["stock_quantity"].ToString();
                    string condition = reader["condition"].ToString();
                    string compatibility = reader["compatibility"].ToString();
                    string part_status = reader["part_status"].ToString();
                    string part_image = reader["part_image"].ToString();


                    // Add the row to the DataGridView
                    dataGridView_admin_parts.Rows.Add(part_name, part_number, manufacturer, price, warranty_period, stock_quantity, condition, compatibility, part_status, part_image);
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

        }


        void bind_user_data(string valueToFind)
        {

            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand comm = new SqlCommand("SELECT * FROM user_details", conn);

            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                dataGridView1_admin_user.Rows.Clear();

                while (reader.Read())
                {
                    // Retrieve each column value
                    string first_name = reader["first_name"].ToString();
                    string last_name = reader["last_name"].ToString();
                    string mobile_no = reader["mobile_no"].ToString();
                    string email = reader["email"].ToString();
                    string user_state = reader["user_state"].ToString();


                    // Add the row to the DataGridView
                    dataGridView1_admin_user.Rows.Add(first_name, last_name, mobile_no, email, user_state);
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

        }


        void bind_order_data(string valueToFind)
        {

            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand comm = new SqlCommand("SELECT * FROM Orders", conn);

            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                dataGridView1_admin_order.Rows.Clear();

                while (reader.Read())
                {
                    // Retrieve each column value
                    string order_id = reader["order_id"].ToString();
                    string car_model = reader["car_model"].ToString();
                    string customer_name = reader["customer_name"].ToString();
                    string customer_email = reader["customer_email"].ToString();
                    string customer_phone = reader["customer_phone"].ToString();
                    string order_date = reader["order_date"].ToString();
                    string total_amount = reader["total_amount"].ToString();
                    string payment_status = reader["payment_status"].ToString();
                    string order_status = reader["order_status"].ToString();



                    // Add the row to the DataGridView
                    dataGridView1_admin_order.Rows.Add(order_id, car_model, customer_name, customer_email, customer_phone, order_date, total_amount, payment_status, order_status);
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

        }


        private void Admin_form_Load(object sender, EventArgs e)
        {

            bind_car_data("");
        }

        

        private void manage_car_details_btn_Click(object sender, EventArgs e)
        {
            manage_part_details_panel.Visible = false;
            manage_customer_details_panel.Visible = false;
            manage_customer_order_panel.Visible = false;
            report_panel.Visible = false;

            manage_car_details_panel.Visible = true;
            bind_car_data("");


        }

        private void manage_Car_parts_details_btn_Click(object sender, EventArgs e)
        {
            manage_car_details_panel.Visible = false;
            manage_customer_details_panel.Visible = false;
            manage_customer_order_panel.Visible = false;

            manage_part_details_panel.Visible = true;
            
            bind_car_part_data("");
        }

        private void manage_customer_details_btn_Click(object sender, EventArgs e)
        {
            manage_part_details_panel.Visible = false;
            manage_car_details_panel.Visible = false;
            manage_customer_order_panel.Visible = false;
            report_panel.Visible = false; ;

            manage_customer_details_panel.Visible = true;
            bind_user_data("");
        }

        private void manage_customer_order_details_btn_Click(object sender, EventArgs e)
        {
            manage_part_details_panel.Visible = false;
            manage_car_details_panel.Visible = false;
            manage_customer_details_panel.Visible = false;
            report_panel.Visible = false;

            manage_customer_order_panel.Visible = true;
            bind_order_data("");
        }

        private void generate_reports_btn_Click(object sender, EventArgs e)
        {
            manage_part_details_panel.Visible = false;
            manage_car_details_panel.Visible = false;
            manage_customer_details_panel.Visible = false;
            manage_customer_order_panel.Visible = false;

            report_panel.Visible = true;
        }
    }
}
