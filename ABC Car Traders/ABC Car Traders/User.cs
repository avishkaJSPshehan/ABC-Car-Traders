using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABC_Car_Traders
{
    public partial class User_form : Form
    {
        public User_form()
        {
            InitializeComponent();
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
