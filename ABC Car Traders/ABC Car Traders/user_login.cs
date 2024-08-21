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
    public partial class user_login : Form
    {
        public user_login()
        {
            InitializeComponent();
        }

        private void Login_lb_Click(object sender, EventArgs e)
        {

        }

        private void cancle_btn_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }
    }
}
