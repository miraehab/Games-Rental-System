using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace Games_Rental_System
{
    public partial class Main : Form
    {

        public Main()
        {
            InitializeComponent();
            pnlNav.Height = btnBrowse.Height;
            pnlNav.Top = btnBrowse.Top;
            pnlNav.Left = btnBrowse.Left;

            lbltitle.Text = "Browse Games";
            frmBrowse frmBrowse_vrb = new frmBrowse() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmBrowse_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmBrowse_vrb);
            frmBrowse_vrb.Show();
        }

        private void btnBrowse_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnBrowse.Height;
            pnlNav.Top = btnBrowse.Top;
            pnlNav.Left = btnBrowse.Left;
            btnBrowse.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Browse Games";
            this.pnlFormLoader.Controls.Clear();
            frmBrowse frmBrowse_vrb = new frmBrowse() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmBrowse_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmBrowse_vrb);
            frmBrowse_vrb.Show();
            textBox1.Show();

        }

        private void btnAddGame_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAddGame.Height;
            pnlNav.Top = btnAddGame.Top;
            btnAddGame.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Add Game";
            this.pnlFormLoader.Controls.Clear();
            frmAddGame frmAddGame_vrb = new frmAddGame() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAddGame_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAddGame_vrb);
            frmAddGame_vrb.Show();
            textBox1.Hide();
        }

        private void btnUpdateGame_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnUpdateGame.Height;
            pnlNav.Top = btnUpdateGame.Top;
            btnUpdateGame.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            frmUpdateGame frmCalender_vrb = new frmUpdateGame() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCalender_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmCalender_vrb);
            frmCalender_vrb.Show();
            textBox1.Hide();
            lbltitle.Text = "Update Game";
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAddUser.Height;
            pnlNav.Top = btnAddUser.Top;
            btnAddUser.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            frmAddUser frmContactUs_vrb = new frmAddUser() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmContactUs_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmContactUs_vrb);
            frmContactUs_vrb.Show();
            textBox1.Hide();
            lbltitle.Text = "Add User";
        }
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnUpdateUser.Height;
            pnlNav.Top = btnUpdateUser.Top;
            btnUpdateUser.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            frmUpdateUser frmUpdateUser_vrb = new frmUpdateUser() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmUpdateUser_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmUpdateUser_vrb);
            frmUpdateUser_vrb.Show();
            textBox1.Hide();
            lbltitle.Text = "Update User";
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {        
            new Register().Show();
        }

        private void btnBrowse_Leave(object sender, EventArgs e)
        {
            btnBrowse.BackColor = Color.FromArgb(24, 17, 68);
        }

        private void btnAddGame_Leave(object sender, EventArgs e)
        {
            btnAddGame.BackColor = Color.FromArgb(24, 17, 68);
        }

        private void btnUpdateGame_Leave(object sender, EventArgs e)
        {
            btnUpdateGame.BackColor = Color.FromArgb(24, 17, 68);
        }

        private void btnAddUser_Leave(object sender, EventArgs e)
        {
            btnAddUser.BackColor = Color.FromArgb(24, 17, 68);
        }
        private void btnUpdateUser_Leave(object sender, EventArgs e)
        {
            btnUpdateUser.BackColor = Color.FromArgb(24, 17, 68);
        }

        private void btnRegister_Leave(object sender, EventArgs e)
        {
            btnRegister.BackColor = Color.FromArgb(24, 17, 68);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            textBox1.Clear();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void lbltitle_Click(object sender, EventArgs e)
        {

        }
    }
}
