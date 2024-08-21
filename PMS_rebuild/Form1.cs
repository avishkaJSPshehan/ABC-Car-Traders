using PMS_rebuild;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PMS_rebuild
{
    public partial class home : Form
    {
        [DllImport("Gdi32.dll", EntryPoint = "CreateRoundRectRgn")]
        private static extern IntPtr CreateRoundRectRgn(

            int nLeft,
            int nTop,
            int nRight,
            int nBottom,
            int nWidthEllipse,
            int nHeightEllipse

            );
        public home()
        {
            InitializeComponent();
        }

        
        private void userBtn_Click_1(object sender, EventArgs e)
        {
            Login_window login_Window = new Login_window();

            login_Window.Show();
            this.Hide();
        }
        private void adminBtn_Click(object sender, EventArgs e)
        {
            Login_window Login = new Login_window();
            Login.Show();
            this.Hide();
        }

        private void home_Load(object sender, EventArgs e)
        {
            userBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, userBtn.Width, userBtn.Height, 10, 10));
            adminBtn.Region = Region.FromHrgn(CreateRoundRectRgn(0, 0, adminBtn.Width, adminBtn.Height, 10, 10));
        }

        private void home_Load_1(object sender, EventArgs e)
        {

        }

        
    }
}
