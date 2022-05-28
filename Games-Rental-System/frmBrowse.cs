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

        private void inpSearch_Click(object sender, EventArgs e)
        {
            inpSearch.SelectAll();
        }

        private void cbSortby_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MISHOO;Initial Catalog=Game-Over;Integrated Security=True");
            try
            {
                con.Open();
                string _sort="";
                cbValue.Items.Clear();
                cbValue.Text = "";
                SqlCommand command = new SqlCommand("");
                switch (cbSortby.SelectedIndex)
                {
                    case 0:
                        command = new SqlCommand("select DISTINCT year(G_DATE) as G_YEAR from GAME WHERE AMOUNT > 0 ;", con);
                        _sort = "G_YEAR";
                        break;

                    case 1:
                        command = new SqlCommand("select DISTINCT V_NAME from GAME WHERE AMOUNT > 0 ;", con);
                        _sort = "V_NAME";
                        break;

                    case 2:
                        command = new SqlCommand("select DISTINCT G_CATEGORY from GAME WHERE AMOUNT > 0 ;", con);
                        _sort = "G_CATEGORY";
                        break;
                }
                SqlDataReader data = command.ExecuteReader();
                while (data.Read())
                {
                   cbValue.Items.Add(data[_sort].ToString());
      
                }

                con.Close();
            }
            catch
            {
                MessageBox.Show("error connecting to database");
            }

        }

        private void cbValue_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MISHOO;Initial Catalog=Game-Over;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("");
                switch (cbSortby.SelectedIndex)
                {
                    case 0:
                        command = new SqlCommand("select * from GAME WHERE AMOUNT > 0 AND year(G_DATE) = @value;", con);
                        break;

                    case 1:
                        command = new SqlCommand("select * from GAME WHERE AMOUNT > 0 AND V_NAME = @value;", con);
                        break;

                    case 2:
                        command = new SqlCommand("select * from GAME WHERE AMOUNT > 0 AND G_CATEGORY = @value;", con);
                        break;
                }
                command.Parameters.Add(new SqlParameter("@value", cbValue.Text.ToString()));
                SqlDataReader data = command.ExecuteReader();
                flowLayoutPanel1.Controls.Clear();
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

        private void inpSearch_TextChanged(object sender, EventArgs e)
        {
            string _Search = inpSearch.Text.ToString()+ "%";
            SqlConnection con = new SqlConnection(@"Data Source=MISHOO;Initial Catalog=Game-Over;Integrated Security=True");
            try
            {
                con.Open();
                SqlCommand command = new SqlCommand("select * from GAME WHERE AMOUNT > 0 AND G_NAME LIKE @value;", con);
                command.Parameters.Add(new SqlParameter("@value", _Search));
                SqlDataReader data = command.ExecuteReader();
                flowLayoutPanel1.Controls.Clear();
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
    }
}
