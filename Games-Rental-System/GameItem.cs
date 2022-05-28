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
            if (User.isAdmin)
            {
                btnRent.Visible = false;
                btnReturn.Visible = false;
            }
            else
            {
                btnRent.Visible = true;
                btnReturn.Visible = true;
            }
        }

        private void btnRent_Click(object sender, EventArgs e)
        {

        }
    }
}
