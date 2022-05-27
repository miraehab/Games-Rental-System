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
using System.Configuration;

namespace Games_Rental_System
{
    public partial class frmAddGame : Form
    {
        public frmAddGame()
        {
            InitializeComponent();
        }

        private void inpGameName_Click(object sender, EventArgs e)
        {
            inpGameName.SelectAll();
        }

        private void inpVendorName_Click(object sender, EventArgs e)
        {
            inpVendorName.SelectAll();

        }

        private void inpGameAmount_Click(object sender, EventArgs e)
        {
            inpGameAmount.SelectAll();
        }

        private void inpGamePrice_Click(object sender, EventArgs e)
        {
            inpGamePrice.SelectAll();
        }

        private void btnPhoto_Click(object sender, EventArgs e)
        {
            Stream mystream = null;
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files(*.jpg; *.jpeg; *.gif; *.bmp; *.png;)|*.jpg; *.jpeg; *.gif; *.bmp; *.png;";
            if(openFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    if( (mystream=openFileDialog.OpenFile()) != null)
                    {
                        pbPhoto.Image = new Bitmap(openFileDialog.FileName);
                    }
                }catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=MISHOO; Initial Catalog=Game-Over;Integrated Security=True");
            try
            {
                con.Open();
                string _gameName = inpGameName.Text.ToString();
                string _vendorName = inpVendorName.Text.ToString();
                string _gameAmount = inpGameAmount.Text.ToString();
                string _gamePrice = inpGamePrice.Text.ToString();
                DateTime now = DateTime.Now;
                MemoryStream stream = new MemoryStream();
                pbPhoto.Image.Save(stream, System.Drawing.Imaging.ImageFormat.Jpeg);
                byte[] pic = stream.ToArray();
                string _Query = "SELECT * FROM GAME WHERE G_NAME='" + _gameName + "' AND V_NAME = '" + _vendorName + "';";
                string _Query2 = "insert into GAME (G_NAME,V_NAME,AMOUNT,PRICE,G_PHOTO,A_USERNAME,G_DATE) VALUES ('" + _gameName + "','" + _vendorName + "','" + _gameAmount + "','" + _gamePrice + "', @pic, '" + AdminUser.Admin_Name + "','" + now + "');";
                SqlCommand command;
                command = new SqlCommand(_Query, con);
                SqlDataReader data = command.ExecuteReader();
                if (data.Read())
                {
                    MessageBox.Show("Game already exists");
                }
                else
                {
                    data.Close();
                    command = new SqlCommand(_Query2, con);
                    command.Parameters.Add("@pic", SqlDbType.Image).Value = pic;
                    command.ExecuteNonQuery();
                    MessageBox.Show("Game added successfully");
                    inpGameName.Text = "Enter Game Name";
                    inpVendorName.Text = "Enter Vendor Name";
                    inpGameAmount.Text = "Enter Game Amount";
                    inpGamePrice.Text = "Enter Game Price";
                    pbPhoto.Image = Properties.Resources.Logo;
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