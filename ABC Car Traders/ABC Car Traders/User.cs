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

namespace ABC_Car_Traders
{
    public partial class User_form : Form
    {
        public User_form()
        {
            InitializeComponent();
        }

        string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming Projects\Motors\ABC Car Traders\ABC Car Traders\ABC_Car_Traders.mdf;Integrated Security=True;Connect Timeout=30";


        void bind_data()
        {

            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand comm = new SqlCommand("SELECT * FROM CarDetails", conn);

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

        private void car_details_btn_Click(object sender, EventArgs e)
        {

            parts_search_box.Visible = false;
            search_parts.Visible = false;
            dataGridView_parts.Visible = false;


            car_search_box.Visible = true;
            search_car.Visible = true;
            dataGridView_car.Visible = true;

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

            bind_data();

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
        }
    }
}
