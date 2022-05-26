using System;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Data;
using System.Data.SqlClient;

namespace Games_Rental_System
{
    public partial class Login : Form
    {
     
        public Login()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MISHOO;Initial Catalog=Game-Over;Integrated Security=True");
            try
            {
                con.Open();
                string _userName = inpUserName.Text.ToString();
                string _password = inpPassword.Text.ToString();
                string _Query = "SELECT * FROM ADMIN WHERE A_USERNAME='" + _userName + "'";
                SqlCommand command = new SqlCommand(_Query,con);
                SqlDataReader data = command.ExecuteReader();
                if (data.Read())
                {
                    if (_userName == data["A_USERNAME"].ToString() && _password == data["A_PASSWORD"].ToString())
                    {
                        AdminUser.Admin_Name = _userName;
                        new Main().Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("Wrong Password");
                    }
                }
                else {
                    MessageBox.Show("User doesn't Exist");
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