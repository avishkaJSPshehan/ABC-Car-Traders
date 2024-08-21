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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void userBtn_Click(object sender, EventArgs e)
        {
            user_login login_Window = new user_login();

            login_Window.Show();
            this.Hide();
        }

        private void adminBtn_Click(object sender, EventArgs e)
        {
            user_login login_Window = new user_login();

            login_Window.Show();
            this.Hide();
        }
    }
}
