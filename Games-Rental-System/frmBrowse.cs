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

namespace Games_Rental_System
{
    public partial class frmBrowse : Form
    {
        public frmBrowse()
        {
            InitializeComponent();
            SqlConnection con = new SqlConnection(@"Data Source=MISHOO;Initial Catalog=Game-Over;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("select * from GAME WHERE AMOUNT > 0;", con);
                SqlDataReader data = command.ExecuteReader();
                while (data.Read())
                {
                    GameItem item = new GameItem(data);
                    flowLayoutPanel1.Controls.Add(item);
                }

                con.Close();
            }
            catch
            {
                MessageBox.Show("error connecting to database");
            }

        }

        private void frmBrowse_Load(object sender, EventArgs e)
        {

        }
    }
}
