using System;
using System.Windows.Forms;
using System.Drawing;
using System.Runtime.InteropServices;

namespace Games_Rental_System
{
    public partial class Login : Form
    {
     
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Main().Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}