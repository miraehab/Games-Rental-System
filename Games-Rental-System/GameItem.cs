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
    public partial class GameItem : UserControl
    {
        private SqlDataReader _game;
        public GameItem()
        {
            InitializeComponent();
        }
        public GameItem(SqlDataReader game) :this()
        {
            _game = game;
            TName.Text = _game["G_NAME"].ToString();
            TPrice.Text = _game["PRICE"].ToString()+"$";
            TAmount.Text = _game["AMOUNT"].ToString()+" CDs";
            MemoryStream ms = new MemoryStream((byte[])_game["G_PHOTO"]);
            Image img = new Bitmap(ms);
            pbPhoto.Image = img;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void GameItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Rent");
        }
    }
}
