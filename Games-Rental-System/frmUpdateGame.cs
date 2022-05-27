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
using System.IO;

namespace Games_Rental_System
{
    public partial class frmUpdateGame : Form
    {
        public frmUpdateGame()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MISHOO; Initial Catalog=Game-Over;Integrated Security=True");

            SqlCommand cmd;

            con.Open();

            cmd = new SqlCommand("select G_PHOTO from GAME where G_ID=10", con);

            SqlDataAdapter da = new SqlDataAdapter(cmd);

            DataSet ds = new DataSet();

            da.Fill(ds);
            

            if (ds.Tables[0].Rows.Count > 0)

            {
                
                MemoryStream ms = new MemoryStream((byte[])ds.Tables[0].Rows[0]["G_PHOTO"]);

                pictureBox1.Image = Image.FromStream(ms);

            }

        }
    }
}
