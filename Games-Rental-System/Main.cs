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
            frmUpdateGame frmUpdateGame_vrb = new frmUpdateGame() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmUpdateGame_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmUpdateGame_vrb);
            frmUpdateGame_vrb.Show();
            textBox1.Hide();
            lbltitle.Text = "Update Game";
        }

        private void btnAddClient_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAddClient.Height;
            pnlNav.Top = btnAddClient.Top;
            btnAddClient.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            frmAddClient frmAddClient_vrb = new frmAddClient() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAddClient_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAddClient_vrb);
            frmAddClient_vrb.Show();
            textBox1.Hide();
            lbltitle.Text = "Add Client";
        }
        private void btnUpdateClient_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnUpdateClient.Height;
            pnlNav.Top = btnUpdateClient.Top;
            btnUpdateClient.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            frmUpdateClient frmUpdateclient_vrb = new frmUpdateClient() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmUpdateclient_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmUpdateclient_vrb);
            frmUpdateclient_vrb.Show();
            textBox1.Hide();
            lbltitle.Text = "Update Client Data";
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

        private void btnAddClient_Leave(object sender, EventArgs e)
        {
            btnAddClient.BackColor = Color.FromArgb(24, 17, 68);
        }
        private void btnUpdateClient_Leave(object sender, EventArgs e)
        {
            btnUpdateClient.BackColor = Color.FromArgb(24, 17, 68);
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
