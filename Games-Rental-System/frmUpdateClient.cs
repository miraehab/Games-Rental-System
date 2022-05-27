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
    public partial class frmUpdateClient : Form
    {
        public frmUpdateClient()
        {
            InitializeComponent();
        }

        private void inpClientPhone_Click(object sender, EventArgs e)
        {
            inpClientPhone.SelectAll();
        }

        private void inpClientFirstName_Click(object sender, EventArgs e)
        {
            inpClientFirstName.SelectAll();
        }

        private void inpClientSecondName_Click(object sender, EventArgs e)
        {
            inpClientSecondName.SelectAll();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MISHOO; Initial Catalog=Game-Over;Integrated Security=True");
            try
            {
                con.Open();
                string _clientOldPhone = inpClientOldPhone.Text.ToString();
                string _clientPhone = inpClientPhone.Text.ToString();
                string _clientFirstName = inpClientFirstName.Text.ToString();
                string _clientSecondName = inpClientSecondName.Text.ToString();
                string _Query = "SELECT C_PHONENUM FROM CLIENT WHERE C_PHONENUM='" + _clientOldPhone + "';";
                string _Query2 = "UPDATE CLIENT SET C_PHONENUM = '" + _clientPhone + "', C_FIRSTNAME = '" + _clientFirstName + "', C_LASTNAME = '" + _clientSecondName + "' WHERE C_PHONENUM='" + _clientOldPhone + "';";
                SqlCommand command;
                command = new SqlCommand(_Query, con);
                SqlDataReader data = command.ExecuteReader();
                if (data.Read())
                {
                    data.Close();
                    command = new SqlCommand(_Query2, con);
                    command.ExecuteNonQuery();
                    MessageBox.Show("Client data updated successfully");
                    inpClientOldPhone.Text = "Enter Client Old Phone Number";
                    inpClientPhone.Text = "Enter Client Phone Number";
                    inpClientFirstName.Text = "Enter Client First Name";
                    inpClientSecondName.Text = "Enter Client Second Name";
                }
                else
                {
                    MessageBox.Show("Client doesn't exist");
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("error connecting to database");
            }
        }

    }
}
