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
    public partial class adminHome : Form
    {
        string connection_string = "Data Source=DESKTOP-65FAGV7\\SQLEXPRESS;Initial Catalog=PMS_db;Integrated Security=True;TrustServerCertificate=True";

        public adminHome()
        {
            InitializeComponent();
        }

        void bind_data()
        {
            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand comm = new SqlCommand("SELECT * FROM item_details", conn);
            conn.Open();
            SqlDataAdapter adpt = new SqlDataAdapter(comm);
            DataTable dt = new DataTable();
            dt.Clear();
            adpt.Fill(dt);
            dataGridView2.DataSource = dt;
            conn.Close();

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            panel2.Visible = true;
            panel3.Visible = false;
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            panel3.Visible = true;
            panel2.Visible = false;
            bind_data();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("Item Number is Empty");
            }
            else if (textBox4.Text == "")
            {
                MessageBox.Show("Item Description is Empty");
            }
            else
            {
                int n = dataGridView1.Rows.Add();
                dataGridView1.Rows[n].Cells[0].Value = textBox1.Text;
                dataGridView1.Rows[n].Cells[1].Value = textBox2.Text;
                dataGridView1.Rows[n].Cells[2].Value = dateTimePicker1.Text;
                dataGridView1.Rows[n].Cells[3].Value = textBox3.Text;
                dataGridView1.Rows[n].Cells[4].Value = textBox4.Text;
                dataGridView1.Rows[n].Cells[5].Value = textBox7.Text;
                dataGridView1.Rows[n].Cells[6].Value = textBox6.Text;
                dataGridView1.Rows[n].Cells[7].Value = textBox8.Text;
                dataGridView1.Rows[n].Cells[8].Value = textBox9.Text;
                dataGridView1.Rows[n].Cells[9].Value = textBox5.Text;
            }

            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            textBox6.Text = "";
            textBox7.Text = "";
            textBox9.Text = "";
            textBox10.Text = "";
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {


            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand comm = new SqlCommand(@"SELECT * FROM item_details WHERE description = @description", conn);
            comm.Parameters.AddWithValue("@description", textBox2.Text);

            conn.Open();

            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {


                    textBox1.Text = reader.GetString(0);
                    textBox2.Text = reader.GetString(1);
                    textBox3.Text = reader.GetString(3);
                    textBox4.Text = reader.GetString(4);
                    textBox7.Text = reader.GetString(5);
                    textBox6.Text = reader.GetString(6);
                    textBox8.Text = reader.GetString(7);
                    textBox9.Text = reader.GetString(8);
                    textBox5.Text = reader.GetString(9);

                    //age = reader.GetString(3);


                }
            }

            conn.Close();
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {

            //string query = "insert into item_details values(@item_code,@description,@exp_date,@pack_size,@aty,@free,@rate,@discount,@amount,@retail_price)";
            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand comm = new SqlCommand(@"INSERT INTO item_details VALUES(@item_code,@description,@exp_date,@pack_size,@qty,@free,@rate,@discount,@amount,@retail_price)", conn);
            comm.Parameters.Add("@item_code", SqlDbType.VarChar);
            comm.Parameters.Add("@description", SqlDbType.VarChar);
            comm.Parameters.Add("@exp_date", SqlDbType.VarChar);
            comm.Parameters.Add("@pack_size", SqlDbType.VarChar);
            comm.Parameters.Add("@qty", SqlDbType.VarChar);
            comm.Parameters.Add("@free", SqlDbType.VarChar);
            comm.Parameters.Add("@rate", SqlDbType.VarChar);
            comm.Parameters.Add("@discount", SqlDbType.VarChar);
            comm.Parameters.Add("@amount", SqlDbType.VarChar);
            comm.Parameters.Add("@retail_price", SqlDbType.VarChar);

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {

                try
                {


                    comm.Parameters["@item_code"].Value = dataGridView1.Rows[i].Cells[0].Value.ToString();
                    comm.Parameters["@description"].Value = dataGridView1.Rows[i].Cells[1].Value.ToString();
                    comm.Parameters["@exp_date"].Value = dataGridView1.Rows[i].Cells[2].Value.ToString();
                    comm.Parameters["@pack_size"].Value = dataGridView1.Rows[i].Cells[3].Value.ToString();
                    comm.Parameters["@qty"].Value = dataGridView1.Rows[i].Cells[4].Value.ToString();
                    comm.Parameters["@free"].Value = dataGridView1.Rows[i].Cells[5].Value.ToString();
                    comm.Parameters["@rate"].Value = dataGridView1.Rows[i].Cells[6].Value.ToString();
                    comm.Parameters["@discount"].Value = dataGridView1.Rows[i].Cells[7].Value.ToString();
                    comm.Parameters["@amount"].Value = dataGridView1.Rows[i].Cells[8].Value.ToString();
                    comm.Parameters["@retail_price"].Value = dataGridView1.Rows[i].Cells[9].Value.ToString();

                    conn.Open();
                    comm.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                    //Console.WriteLine(ex);
                }


                conn.Close();


            }
            dataGridView1.Rows.Clear();
            MessageBox.Show("Invoice inserted successful");


        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            //AdminHome log = new AdminHome();
            this.Close();
        }

        private void dataGridView2_Click(object sender, EventArgs e)
        {

            dataGridView2.CurrentRow.Selected = true;
            textBox18.Text = dataGridView2.CurrentRow.Cells["item_code"].Value.ToString();
            textBox17.Text = dataGridView2.CurrentRow.Cells["description"].Value.ToString();
            textBox19.Text = dataGridView2.CurrentRow.Cells["exp_date"].Value.ToString();
            textBox16.Text = dataGridView2.CurrentRow.Cells["pack_size"].Value.ToString();
            textBox14.Text = dataGridView2.CurrentRow.Cells["qty"].Value.ToString();
            textBox13.Text = dataGridView2.CurrentRow.Cells["free"].Value.ToString();
            textBox15.Text = dataGridView2.CurrentRow.Cells["rate"].Value.ToString();
            textBox12.Text = dataGridView2.CurrentRow.Cells["discount"].Value.ToString();
            textBox11.Text = dataGridView2.CurrentRow.Cells["amount"].Value.ToString();
            textBox10.Text = dataGridView2.CurrentRow.Cells["retail_price"].Value.ToString();
        }

        private void updatBtn_Click(object sender, EventArgs e)
        {

            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand comm = new SqlCommand(@"UPDATE item_details SET item_code=@item_code, description=@description, exp_date=@exp_date, pack_size=@pack_size, qty=@qty, free=@free, rate=@rate, discount=@discount, amount=@amount, retail_price=@retail_price where item_code=@item_code", conn);
            comm.Parameters.AddWithValue("@item_code", textBox18.Text);
            comm.Parameters.AddWithValue("@description", textBox17.Text);
            comm.Parameters.AddWithValue("@exp_date", textBox19.Text);
            comm.Parameters.AddWithValue("@pack_size", textBox16.Text);
            comm.Parameters.AddWithValue("@qty", textBox14.Text);
            comm.Parameters.AddWithValue("@free", textBox13.Text);
            comm.Parameters.AddWithValue("@rate", textBox15.Text);
            comm.Parameters.AddWithValue("@discount", textBox12.Text);
            comm.Parameters.AddWithValue("@amount", textBox11.Text);
            comm.Parameters.AddWithValue("@retail_price", textBox10.Text);

            conn.Open();

            comm.ExecuteNonQuery();
            bind_data();

            conn.Close();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            day_report repo = new day_report();
            repo.Show();
            this.Hide();
        }

        private void authBtn_Click(object sender, EventArgs e)
        {
            auth auth = new auth();
            auth.Show();
            this.Hide();
        }
    }
}
