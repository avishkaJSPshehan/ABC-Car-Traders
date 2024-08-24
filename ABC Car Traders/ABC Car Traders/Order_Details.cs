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
    public partial class Order_Details : Form
    {

        string connection_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Programming Projects\Motors\ABC Car Traders\ABC Car Traders\ABC_Car_Traders.mdf;Integrated Security=True;Connect Timeout=30";

        public Order_Details()
        {
            InitializeComponent();
        }

        private void order_status_lb_Click(object sender, EventArgs e)
        {

        }

        private void cancle_btn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void remover_order_Click(object sender, EventArgs e)
        {
            string query = "DELETE FROM Orders WHERE order_id = @order_id";

            using (SqlConnection conn = new SqlConnection(connection_string))
            {
                SqlCommand comm = new SqlCommand(query, conn);

                // Add parameters to prevent SQL injection
                comm.Parameters.AddWithValue("@order_id", order_id_lb.Text);  // Assuming `orderId` is a variable storing the ID of the order to delete

                try
                {
                    conn.Open();
                    int rowsAffected = comm.ExecuteNonQuery();  // Execute the query
                    if (rowsAffected > 0)
                    {
                        
                        MessageBox.Show("Order deleted successfully." );
                    }
                    else
                    {
                        MessageBox.Show("No order found with the specified ID.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred: " + ex.Message);
                }
            }

            this.Close();

        }
    }
}
