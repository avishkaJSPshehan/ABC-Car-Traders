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
    public partial class userHome : Form
    {

        string connection_string = "Data Source=DESKTOP-65FAGV7\\SQLEXPRESS;Initial Catalog=PMS_db;Integrated Security=True";

        public userHome()
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
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        private void userHome_Load(object sender, EventArgs e)
        {
            bind_data();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dataGridView1.CurrentRow.Selected = true;
            textBox18.Text = dataGridView1.CurrentRow.Cells["item_code"].Value.ToString();
            textBox17.Text = dataGridView1.CurrentRow.Cells["description"].Value.ToString();
            textBox10.Text = dataGridView1.CurrentRow.Cells["retail_price"].Value.ToString();
        }

        private void nextBtn_Click(object sender, EventArgs e)
        {
            string data = "";
            try
            {
                SqlConnection conn = new SqlConnection(connection_string);
                SqlCommand comm = new SqlCommand(@"SELECT * FROM item_details WHERE description = @description", conn);
                comm.Parameters.AddWithValue("@description", textBox17.Text);

                conn.Open();

                SqlDataReader reader = comm.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {


                        data = reader.GetString(4);
                        //Console.WriteLine(data);
                      


                        //age = reader.GetString(3);


                    }
                }

                conn.Close();


                if (Convert.ToDouble(textBox14.Text) <= Convert.ToDouble(data))
                {
                    //ouble amount = Convert.ToDouble(dataGridView1.CurrentRow.Cells["retail_price"].Value.ToString()) * Convert.ToDouble(textBox14.Text);

                    int n = dataGridView2.Rows.Add();
                    dataGridView2.Rows[n].Cells[0].Value = textBox18.Text;
                    dataGridView2.Rows[n].Cells[1].Value = textBox17.Text;
                    dataGridView2.Rows[n].Cells[2].Value = textBox14.Text;
                    dataGridView2.Rows[n].Cells[3].Value = textBox10.Text;

                    //label7.Text = Convert.ToString(Convert.ToDouble(label7.Text) + amount);
                    textBox18.Text = "";
                    textBox17.Text = "";
                    textBox14.Text = "";
                    textBox10.Text = "";
                }
                else
                {
                    MessageBox.Show("Quentity not Available");
                }
            }
            catch (Exception ex){
                Console.WriteLine(ex);
                MessageBox.Show("Unknown Error!");
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {



            SqlConnection conn = new SqlConnection(connection_string);


            //comm1.Parameters.Add("@new_qty", SqlDbType.VarChar);

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {

                try
                {

                    SqlConnection connection = new SqlConnection(connection_string);
                    connection.Open();
                    SqlCommand command = new SqlCommand("select qty from item_details where item_code=@item_code", connection);
                    string cmd = "UPDATE item_details SET qty=@new_qty where item_code=@item_code";
                    SqlCommand comm1 = new SqlCommand(cmd, conn);
                    comm1.Parameters.Add("@item_code", SqlDbType.VarChar);

                    command.Parameters.AddWithValue("@item_code", dataGridView2.Rows[i].Cells[0].Value.ToString());


                    SqlDataReader reader = command.ExecuteReader();
                    // Call Read before accessing data. 

                    reader.Read();
                    string db_qty = reader.GetString(0);
                    // Call Close when done reading.
                    reader.Close();
                    connection.Close();

                    double new_qty = Convert.ToDouble(db_qty) - Convert.ToDouble(dataGridView2.Rows[i].Cells[2].Value.ToString());
                    //Console.WriteLine(new_qty);
                    comm1.Parameters["@item_code"].Value = dataGridView2.Rows[i].Cells[0].Value.ToString();
                    comm1.Parameters.AddWithValue("@new_qty", Convert.ToString(new_qty));

                    conn.Open();
                    comm1.ExecuteNonQuery();
                    conn.Close();


                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                    Console.WriteLine(ex);
                }

            }
            conn.Close();
            bind_data();
            dataGridView2.Rows.Clear();

            
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            SqlConnection conn = new SqlConnection(connection_string);
            SqlCommand comm = new SqlCommand(@"SELECT * FROM item_details WHERE description = @description", conn);
            comm.Parameters.AddWithValue("@description", textBox1.Text);

            conn.Open();

            SqlDataReader reader = comm.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {


                    textBox18.Text = reader.GetString(0);
                    textBox17.Text = reader.GetString(1); 
                    textBox10.Text = reader.GetString(9);
                    

                    //age = reader.GetString(3);


                }
            }

            conn.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }
    }
}
