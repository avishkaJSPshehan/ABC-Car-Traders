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

namespace PMS_rebuild
{
    public partial class day_report : Form
    {
        public day_report()
        {
            InitializeComponent();
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            adminHome fr1 = new adminHome();
            fr1.Show();
            this.Hide();
        }

        private void updatBtn_Click(object sender, EventArgs e)
        {
            string connection_string = "Data Source=DESKTOP-65FAGV7\\SQLEXPRESS;Initial Catalog=PMS_db;Integrated Security=True";
            SqlConnection con = new SqlConnection(connection_string);

            con.Open();


            SqlCommand cmd = new SqlCommand("select * from item_details", con);
            SqlDataAdapter adap = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            adap.Fill(ds, "item_details");
            CrystalReport2 cr1 = new CrystalReport2();
            cr1.SetDataSource(ds);
            crystalReportViewer1.ReportSource = cr1;
            crystalReportViewer1.Refresh();
            con.Close();
            
            
        }

        private void day_report_Load(object sender, EventArgs e)
        {

            ///this.reportViewer1.RefreshReport();
        }
    }
}
