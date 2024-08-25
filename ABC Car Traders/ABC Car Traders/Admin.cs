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
                dataGridView_admin_user.Rows.Clear();

                while (reader.Read())
                {
                    // Retrieve each column value
                    string first_name = reader["first_name"].ToString();
                    string last_name = reader["last_name"].ToString();
                    string mobile_no = reader["mobile_no"].ToString();
                    string email = reader["email"].ToString();
                    string user_state = reader["user_state"].ToString();


                    // Add the row to the DataGridView
                    dataGridView_admin_user.Rows.Add(first_name, last_name, mobile_no, email, user_state);
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
                dataGridView_admin_order.Rows.Clear();

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
                    string item_image = reader["item_image"].ToString();



                    // Add the row to the DataGridView
                    dataGridView_admin_order.Rows.Add(order_id, car_model, customer_name, customer_email, customer_phone, order_date, total_amount, payment_status, order_status, item_image);
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

        private void dataGridView_admin_car_Click(object sender, EventArgs e)
        {


            


        }

        private void dataGridView_admin_car_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView_admin_car.Rows[e.RowIndex];

                company_textbox.Text = row.Cells[0].Value.ToString();
                modele_textBox.Text = row.Cells[1].Value.ToString();
                product_year_textBox.Text = row.Cells[2].Value.ToString();
                salling_price_textBox.Text = row.Cells[3].Value.ToString();
                mileage_textBox.Text = row.Cells[4].Value.ToString();
                engine_type_textBox.Text = row.Cells[5].Value.ToString();
                transmission_textBox.Text = row.Cells[6].Value.ToString();
                color_textBox.Text = row.Cells[7].Value.ToString();
                condition_textBox.Text = row.Cells[8].Value.ToString();
                status_comboBox.Text = row.Cells[9].Value.ToString();

                car_pictureBox.Image = Image.FromFile(row.Cells[10].Value.ToString());
            }
        }

        private void dataGridView_admin_parts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView_admin_parts.Rows[e.RowIndex];

                part_name_textBox.Text = row.Cells[0].Value.ToString();
                part_number_textBox.Text = row.Cells[1].Value.ToString();
                manufacturer_textBox.Text = row.Cells[2].Value.ToString();
                price_textBox.Text = row.Cells[3].Value.ToString();
                warranty_textBox.Text = row.Cells[4].Value.ToString();
                qty_textBox.Text = row.Cells[5].Value.ToString();
                part_condition_textBox.Text = row.Cells[6].Value.ToString();
                compatibility_textBox.Text = row.Cells[7].Value.ToString();
                stutes_textBox.Text = row.Cells[8].Value.ToString();


                part_pictureBox.Image = Image.FromFile(row.Cells[9].Value.ToString());
            }
        }

        private void dataGridView_admin_user_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView_admin_user.Rows[e.RowIndex];

                fname_textBox.Text = row.Cells[0].Value.ToString();
                lname_textBox.Text = row.Cells[1].Value.ToString();
                mobile_textBox.Text = row.Cells[2].Value.ToString();
                user_state_textBox.Text = row.Cells[4].Value.ToString();
                email_textBox.Text = row.Cells[3].Value.ToString();

            }
        }

        private void dataGridView_admin_order_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            if (e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView_admin_order.Rows[e.RowIndex];

                order_id_textBox.Text = row.Cells[0].Value.ToString();
                car_model_textBox.Text = row.Cells[1].Value.ToString();
                customer_name_textBox.Text = row.Cells[2].Value.ToString();
                customer_email_textBox.Text = row.Cells[3].Value.ToString();
                customer_phone_textBox.Text = row.Cells[4].Value.ToString();
                order_date_textBox.Text = row.Cells[5].Value.ToString();
                total_amount_textBox.Text = row.Cells[6].Value.ToString();
                payment_status_textBox.Text = row.Cells[7].Value.ToString();
                order_status_textBox.Text = row.Cells[8].Value.ToString();


                car_or_part_pictureBox.Image = Image.FromFile(row.Cells[9].Value.ToString());
            }
        }

        public String imagePath;
        private void image_upload_btn_Click(object sender, EventArgs e)
        {

            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    car_pictureBox.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void part_image_upload_btn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    part_pictureBox.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void upload_image_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = dialog.FileName;
                    car_or_part_pictureBox.ImageLocation = imagePath;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void insert_car_btn_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(connection_string);
            try
            {

                conn.Open();

                string query = "INSERT INTO CarDetails (Make, Modele, Product_Year, Price, Mileage, Engine_type, Transmission, Color, Condition,Status,Car_Image) " +
                "VALUES (@Make, @Modele, @Product_Year, @Price, @Mileage, @Engine_type, @Transmission, @Color, @Condition,@Status,@Car_Image)";

                SqlCommand comm_2 = new SqlCommand(query, conn);

                string path = Path.Combine(@"D:\Programming Projects\Motors\ABC Car Traders\ABC Car Traders\Assets\car image\" +
                            company_textbox.Text + modele_textBox.Text.Trim() + ".jpg");

                string directoryPath = Path.GetDirectoryName(path);

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                File.Copy(car_pictureBox.ImageLocation, path, true);

                // Add parameters to prevent SQL injection
                comm_2.Parameters.AddWithValue("@Make", company_textbox.Text);
                comm_2.Parameters.AddWithValue("@Modele", modele_textBox.Text);
                comm_2.Parameters.AddWithValue("@Product_Year", product_year_textBox.Text);
                comm_2.Parameters.AddWithValue("@Price", salling_price_textBox.Text);
                comm_2.Parameters.AddWithValue("@Mileage", mileage_textBox.Text);
                comm_2.Parameters.AddWithValue("@Engine_type", engine_type_textBox.Text);
                comm_2.Parameters.AddWithValue("@Transmission", transmission_textBox.Text);
                comm_2.Parameters.AddWithValue("@Color", color_textBox.Text);
                comm_2.Parameters.AddWithValue("@Condition", condition_textBox.Text);
                comm_2.Parameters.AddWithValue("@Status", status_comboBox.Text);
                comm_2.Parameters.AddWithValue("@Car_Image", path);

                // Execute the command
                comm_2.ExecuteNonQuery();

                MessageBox.Show("Car Details Successfully Added");
                bind_car_data("");
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

        private void update_car_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            try
            {

                conn.Open();

                string query = "UPDATE CarDetails SET Make = @Make, Modele = @Modele, Product_Year = @Product_Year, Price = @Price, Mileage = @Mileage, Engine_type = @Engine_type, Transmission = @Transmission, Color = @Color, Condition = @Condition, Status = @Status, Car_Image = @Car_Image WHERE Modele = @Modele AND Make = @Make";


                SqlCommand comm_2 = new SqlCommand(query, conn);

                string path = Path.Combine(@"D:\Programming Projects\Motors\ABC Car Traders\ABC Car Traders\Assets\car image\" +
                            company_textbox.Text + modele_textBox.Text.Trim() + ".jpg");

                string directoryPath = Path.GetDirectoryName(path);

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                File.Copy(car_pictureBox.ImageLocation, path, true);

                // Add parameters to prevent SQL injection
                comm_2.Parameters.AddWithValue("@Make", company_textbox.Text);
                comm_2.Parameters.AddWithValue("@Modele", modele_textBox.Text);
                comm_2.Parameters.AddWithValue("@Product_Year", product_year_textBox.Text);
                comm_2.Parameters.AddWithValue("@Price", salling_price_textBox.Text);
                comm_2.Parameters.AddWithValue("@Mileage", mileage_textBox.Text);
                comm_2.Parameters.AddWithValue("@Engine_type", engine_type_textBox.Text);
                comm_2.Parameters.AddWithValue("@Transmission", transmission_textBox.Text);
                comm_2.Parameters.AddWithValue("@Color", color_textBox.Text);
                comm_2.Parameters.AddWithValue("@Condition", condition_textBox.Text);
                comm_2.Parameters.AddWithValue("@Status", status_comboBox.Text);
                comm_2.Parameters.AddWithValue("@Car_Image", path);

                // Execute the command
                comm_2.ExecuteNonQuery();

                MessageBox.Show("Car Details Successfully Updated");
                bind_car_data("");
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

        private void delete_car_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            try
            {
                conn.Open();
                string query = "DELETE FROM CarDetails WHERE Modele = @Modele AND Make = @Make";

                SqlCommand comm_2 = new SqlCommand(query, conn);

                comm_2.Parameters.AddWithValue("@Make", company_textbox.Text);
                comm_2.Parameters.AddWithValue("@Modele", modele_textBox.Text);

                int rowsAffected = comm_2.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Car Details Successfully Deleted");
                    bind_car_data("");
                }
                else
                {
                    MessageBox.Show("No matching car details found.");
                }
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

        private void part_inser_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            try
            {

                conn.Open();

                string query = "INSERT INTO CarParts (part_name, part_number, manufacturer, price, warranty_period, stock_quantity, condition, compatibility, part_status,part_image) " +
                "VALUES (@part_name, @part_number, @manufacturer, @price, @warranty_period, @stock_quantity, @condition, @compatibility,@part_status,@part_image)";

                SqlCommand comm_2 = new SqlCommand(query, conn);

                string path = Path.Combine(@"D:\Programming Projects\Motors\ABC Car Traders\ABC Car Traders\Assets\part image\" +
                            part_name_textBox.Text + manufacturer_textBox.Text.Trim() + ".jpg");

                string directoryPath = Path.GetDirectoryName(path);

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                File.Copy(part_pictureBox.ImageLocation, path, true);

                // Add parameters to prevent SQL injection
                comm_2.Parameters.AddWithValue("@part_name", part_name_textBox.Text);
                comm_2.Parameters.AddWithValue("@part_number", part_number_textBox.Text);
                comm_2.Parameters.AddWithValue("@manufacturer", manufacturer_textBox.Text);
                comm_2.Parameters.AddWithValue("@price", price_textBox.Text);
                comm_2.Parameters.AddWithValue("@warranty_period", warranty_textBox.Text);
                comm_2.Parameters.AddWithValue("@stock_quantity", qty_textBox.Text);
                comm_2.Parameters.AddWithValue("@condition", part_condition_textBox.Text);
                comm_2.Parameters.AddWithValue("@compatibility", compatibility_textBox.Text);
                comm_2.Parameters.AddWithValue("@part_status", stutes_textBox.Text);
                comm_2.Parameters.AddWithValue("@part_image", path);

                // Execute the command
                comm_2.ExecuteNonQuery();

                MessageBox.Show("Car Part Details Successfully Added");
                bind_car_part_data("");
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

        private void update_part_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            try
            {
                conn.Open();

                // UPDATE query to update car part details based on part number and manufacturer
                string query = "UPDATE CarParts SET part_name = @part_name, price = @price, warranty_period = @warranty_period, stock_quantity = @stock_quantity, condition = @condition, compatibility = @compatibility, part_status = @part_status, part_image = @part_image WHERE part_number = @part_number AND manufacturer = @manufacturer";

                SqlCommand comm_2 = new SqlCommand(query, conn);

                string path = Path.Combine(@"D:\Programming Projects\Motors\ABC Car Traders\ABC Car Traders\Assets\part image\" +
                            part_name_textBox.Text + manufacturer_textBox.Text.Trim() + ".jpg");

                string directoryPath = Path.GetDirectoryName(path);

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                File.Copy(part_pictureBox.ImageLocation, path, true);

                // Add parameters to prevent SQL injection
                comm_2.Parameters.AddWithValue("@part_name", part_name_textBox.Text);
                comm_2.Parameters.AddWithValue("@part_number", part_number_textBox.Text); // part_number is the identifier
                comm_2.Parameters.AddWithValue("@manufacturer", manufacturer_textBox.Text); // manufacturer is another identifier
                comm_2.Parameters.AddWithValue("@price", price_textBox.Text);
                comm_2.Parameters.AddWithValue("@warranty_period", warranty_textBox.Text);
                comm_2.Parameters.AddWithValue("@stock_quantity", qty_textBox.Text);
                comm_2.Parameters.AddWithValue("@condition", part_condition_textBox.Text);
                comm_2.Parameters.AddWithValue("@compatibility", compatibility_textBox.Text);
                comm_2.Parameters.AddWithValue("@part_status", stutes_textBox.Text);
                comm_2.Parameters.AddWithValue("@part_image", path);

                // Execute the command
                comm_2.ExecuteNonQuery();

                MessageBox.Show("Car Part Details Successfully Updated");
                bind_car_part_data("");
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

        private void delete_part_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            try
            {
                conn.Open();

                // DELETE query to remove car part details based on part number and manufacturer
                string query = "DELETE FROM CarParts WHERE part_number = @part_number AND manufacturer = @manufacturer";

                SqlCommand comm_2 = new SqlCommand(query, conn);

                // Add parameters to prevent SQL injection
                comm_2.Parameters.AddWithValue("@part_number", part_number_textBox.Text); // part_number is the identifier
                comm_2.Parameters.AddWithValue("@manufacturer", manufacturer_textBox.Text); // manufacturer is another identifier

                // Execute the DELETE command
                int rowsAffected = comm_2.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Car Part Details Successfully Deleted");
                    bind_car_part_data(""); // Refresh data after deletion
                }
                else
                {
                    MessageBox.Show("No matching car part details found.");
                }
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

        private void update_user_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            try
            {
                conn.Open();


                string query = "UPDATE user_details SET first_name = @first_name, last_name = @last_name, mobile_no = @mobile_no, email = @email, user_state = @user_state WHERE email = @email";

                SqlCommand comm_2 = new SqlCommand(query, conn);



                comm_2.Parameters.AddWithValue("@first_name", fname_textBox.Text);
                comm_2.Parameters.AddWithValue("@last_name", lname_textBox.Text); 
                comm_2.Parameters.AddWithValue("@mobile_no", mobile_textBox.Text);
                comm_2.Parameters.AddWithValue("@email", email_textBox.Text);
                comm_2.Parameters.AddWithValue("@user_state", user_state_textBox.Text);


                comm_2.ExecuteNonQuery();

                MessageBox.Show("Customer Details Successfully Updated");
                bind_user_data("");
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

        private void delete_user_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            try
            {
                conn.Open();

                string query = "DELETE FROM user_details WHERE email = @email";

                SqlCommand comm_2 = new SqlCommand(query, conn);

                comm_2.Parameters.AddWithValue("@email", email_textBox.Text);

                int rowsAffected = comm_2.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("User Details Successfully Deleted");
                    bind_user_data(""); 
                }
                else
                {
                    MessageBox.Show("No matching user found.");
                }
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

        private void insert_order_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            try
            {

                conn.Open();

                string query = "INSERT INTO Orders (order_id, car_model, customer_name, customer_email, customer_phone, order_date, total_amount, payment_status, order_status,item_image) " +
                "VALUES (@order_id, @car_model, @customer_name, @customer_email, @customer_phone, @order_date, @total_amount, @payment_status,@order_status,@item_image)";

                SqlCommand comm_2 = new SqlCommand(query, conn);

                string path = Path.Combine(@"D:\Programming Projects\Motors\ABC Car Traders\ABC Car Traders\Assets\Customer Order\" +
                            car_model_textBox.Text + customer_name_textBox.Text.Trim() + ".jpg");

                string directoryPath = Path.GetDirectoryName(path);

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                File.Copy(car_or_part_pictureBox.ImageLocation, path, true);

                // Add parameters to prevent SQL injection
                comm_2.Parameters.AddWithValue("@order_id", order_id_textBox.Text);
                comm_2.Parameters.AddWithValue("@car_model", car_model_textBox.Text);
                comm_2.Parameters.AddWithValue("@customer_name", customer_name_textBox.Text);
                comm_2.Parameters.AddWithValue("@customer_email", customer_email_textBox.Text);
                comm_2.Parameters.AddWithValue("@customer_phone", customer_phone_textBox.Text);
                comm_2.Parameters.AddWithValue("@order_date", order_date_textBox.Text);
                comm_2.Parameters.AddWithValue("@total_amount", total_amount_textBox.Text);
                comm_2.Parameters.AddWithValue("@payment_status", payment_status_textBox.Text);
                comm_2.Parameters.AddWithValue("@order_status", order_status_textBox.Text);
                comm_2.Parameters.AddWithValue("@item_image", path);

                // Execute the command
                comm_2.ExecuteNonQuery();

                MessageBox.Show("Car Part Details Successfully Added");
                bind_order_data("");
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

        private void update_order_btn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            try
            {
                conn.Open();


                string query = "UPDATE Orders SET car_model = @car_model, customer_name = @customer_name, customer_email = @customer_email, customer_phone = @customer_phone, order_date = @order_date, total_amount = @total_amount, payment_status = @payment_status, order_status = @order_status, item_image = @item_image WHERE order_id = @order_id";

                SqlCommand comm_2 = new SqlCommand(query, conn);

                string path = Path.Combine(@"D:\Programming Projects\Motors\ABC Car Traders\ABC Car Traders\Assets\Customer Order\" +
                            car_model_textBox.Text + customer_name_textBox.Text.Trim() + ".jpg");

                string directoryPath = Path.GetDirectoryName(path);

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                File.Copy(car_or_part_pictureBox.ImageLocation, path, true);


                comm_2.Parameters.AddWithValue("@order_id", order_id_textBox.Text); 
                comm_2.Parameters.AddWithValue("@car_model", car_model_textBox.Text);
                comm_2.Parameters.AddWithValue("@customer_name", customer_name_textBox.Text);
                comm_2.Parameters.AddWithValue("@customer_email", customer_email_textBox.Text);
                comm_2.Parameters.AddWithValue("@customer_phone", customer_phone_textBox.Text);
                comm_2.Parameters.AddWithValue("@order_date", order_date_textBox.Text);
                comm_2.Parameters.AddWithValue("@total_amount", total_amount_textBox.Text);
                comm_2.Parameters.AddWithValue("@payment_status", payment_status_textBox.Text);
                comm_2.Parameters.AddWithValue("@order_status", order_status_textBox.Text);
                comm_2.Parameters.AddWithValue("@item_image", path);


                comm_2.ExecuteNonQuery();

                MessageBox.Show("Order Details Successfully Updated");
                bind_order_data(""); 
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

        private void delete_order_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            try
            {
                conn.Open();

                string query = "DELETE FROM Orders WHERE order_id = @order_id";

                SqlCommand comm_2 = new SqlCommand(query, conn);

                comm_2.Parameters.AddWithValue("@order_id", order_id_textBox.Text); 


                int rowsAffected = comm_2.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Order Successfully Deleted");
                    bind_order_data(""); 
                }
                else
                {
                    MessageBox.Show("No matching order found.");
                }
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

