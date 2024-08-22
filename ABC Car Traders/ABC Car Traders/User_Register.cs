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
    public partial class User_Register : Form
    {
        public User_Register()
        {
            InitializeComponent();
        }

        private void cancle_btn_Click(object sender, EventArgs e)
        {
            home home = new home();
            home.Show();
            this.Hide();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            user_login user_login_form = new user_login();
            user_login_form.Show();
            this.Hide();
        }
    }
}
