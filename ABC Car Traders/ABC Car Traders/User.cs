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
    public partial class User_form : Form
    {
        public User_form()
        {
            InitializeComponent();
        }

        string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming Projects\Motors\ABC Car Traders\ABC Car Traders\ABC_Car_Traders.mdf;Integrated Security=True;Connect Timeout=30";


        void bind_car_data(string valueToFind)
        {

            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand comm = new SqlCommand("SELECT * FROM CarDetails WHERE CONCAT(Make,Modele,Product_Year) LIKE '%"+valueToFind+"%'", conn);

            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                dataGridView_car.Rows.Clear();

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

                    // Add the row to the DataGridView
                    dataGridView_car.Rows.Add(make, model, year, price, Mileage, Engine_type, Transmission, Color, Condition, Status);
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
                dataGridView_parts.Rows.Clear();

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


                    // Add the row to the DataGridView
                    dataGridView_parts.Rows.Add(part_name, part_number, manufacturer, price, warranty_period, stock_quantity, condition, compatibility, part_status);
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


        void bind_order_data(string user_email)
        {

            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand comm = new SqlCommand("SELECT * FROM Orders WHERE customer_email = '"+user_email+"'", conn);

            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();
                dataGridView_order.Rows.Clear();

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
                    dataGridView_order.Rows.Add(order_id, car_model, customer_name, customer_email, customer_phone, order_date, total_amount, payment_status, order_status);
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


        private void car_details_btn_Click(object sender, EventArgs e)
        {

            parts_search_box.Visible = false;
            search_parts.Visible = false;
            dataGridView_parts.Visible = false;


            car_search_box.Visible = true;
            search_car.Visible = true;
            dataGridView_car.Visible = true;
            dataGridView_order.Visible = false;

            bind_car_data("");

        }

        private void parts_details_btn_Click(object sender, EventArgs e)
        {
            parts_search_box.Visible = true;
            search_parts.Visible = true;
            dataGridView_parts.Visible = true;


            car_search_box.Visible = false;
            search_car.Visible = false;
            dataGridView_car.Visible = false;
            dataGridView_order.Visible = false;

            bind_car_part_data("");

        }

        private void User_form_Load(object sender, EventArgs e)
        {
            parts_search_box.Visible = false;
            search_parts.Visible = false;
            dataGridView_parts.Visible = false;
            dataGridView_order.Visible = false;


            car_search_box.Visible = true;
            search_car.Visible = true;
            dataGridView_car.Visible = true;

            bind_car_part_data("");
            bind_car_data("");

        }

        private void order_status_btn_Click(object sender, EventArgs e)
        {
            parts_search_box.Visible = false;
            search_parts.Visible = false;
            dataGridView_parts.Visible = false;
            car_search_box.Visible = false;
            search_car.Visible = false;
            dataGridView_car.Visible = false;

            dataGridView_order.Visible = true;


            string user_email = "";
            using (StreamReader reader = new StreamReader(@"D:\Programming Projects\Motors\ABC Car Traders\ABC Car Traders\ABC Car Traders\User_login.txt"))
            {
                string line;
                // Read line by line
                while ((line = reader.ReadLine()) != null)
                {
                    user_email = line;
                }
            }

            bind_order_data(user_email);
        }

        private void car_search_box_TextChanged(object sender, EventArgs e)
        {
            bind_car_data(car_search_box.Text);
        }

        private void parts_search_box_TextChanged(object sender, EventArgs e)
        {
            bind_car_part_data(parts_search_box.Text);
        }

        private void dataGridView_car_Click(object sender, EventArgs e)
        {
            string imagePath = "";

            Single_Product singale_product_view = new Single_Product();

            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand comm = new SqlCommand("SELECT * FROM CarDetails WHERE Modele = '"+ dataGridView_car.CurrentRow.Cells[1].Value.ToString() +"'", conn);

            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();


                while (reader.Read())
                {
                    imagePath = reader["Car_Image"].ToString();

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

            singale_product_view.car_image.Image = Image.FromFile(imagePath);

            singale_product_view.company_lb.Text = dataGridView_car.CurrentRow.Cells[0].Value.ToString();
            singale_product_view.modele_lb.Text = dataGridView_car.CurrentRow.Cells[1].Value.ToString();
            singale_product_view.product_year_lb.Text = dataGridView_car.CurrentRow.Cells[2].Value.ToString();
            singale_product_view.price_lb.Text = dataGridView_car.CurrentRow.Cells[3].Value.ToString();
            singale_product_view.mileage_lb.Text = dataGridView_car.CurrentRow.Cells[4].Value.ToString();
            singale_product_view.engine_type_lb.Text = dataGridView_car.CurrentRow.Cells[5].Value.ToString();
            singale_product_view.transmission_lb.Text = dataGridView_car.CurrentRow.Cells[6].Value.ToString();
            singale_product_view.color_lb.Text = dataGridView_car.CurrentRow.Cells[7].Value.ToString();
            singale_product_view.condition_lb.Text = dataGridView_car.CurrentRow.Cells[8].Value.ToString();
            singale_product_view.status_lb.Text = dataGridView_car.CurrentRow.Cells[9].Value.ToString();

            singale_product_view.ShowDialog();
        }

        private void dataGridView_parts_Click(object sender, EventArgs e)
        {
            string partimagePath = "";

            Single_part singale_part_view = new Single_part();

            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand comm = new SqlCommand("SELECT * FROM CarParts WHERE part_number = '" + dataGridView_parts.CurrentRow.Cells[1].Value.ToString() + "'", conn);

            try
            {
                conn.Open();
                SqlDataReader reader = comm.ExecuteReader();


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

            singale_part_view.part_image.Image = Image.FromFile(partimagePath);

            singale_part_view.part_name_lb.Text = dataGridView_parts.CurrentRow.Cells[0].Value.ToString();
            singale_part_view.part_number_lb.Text = dataGridView_parts.CurrentRow.Cells[1].Value.ToString();
            singale_part_view.manufacturer_lb.Text = dataGridView_parts.CurrentRow.Cells[2].Value.ToString();
            singale_part_view.price_lb.Text = dataGridView_parts.CurrentRow.Cells[3].Value.ToString();
            singale_part_view.warranty_period_lb.Text = dataGridView_parts.CurrentRow.Cells[4].Value.ToString();
            singale_part_view.stock_quantity_lb.Text = dataGridView_parts.CurrentRow.Cells[5].Value.ToString();
            singale_part_view.condition_lb.Text = dataGridView_parts.CurrentRow.Cells[6].Value.ToString();
            singale_part_view.compatibility_lb.Text = dataGridView_parts.CurrentRow.Cells[7].Value.ToString();
            singale_part_view.part_status_lb.Text = dataGridView_parts.CurrentRow.Cells[8].Value.ToString();


            singale_part_view.ShowDialog();
        }
    }
    }

