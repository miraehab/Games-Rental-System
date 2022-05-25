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

        private void Form1_Load(object sender, EventArgs e)
        {

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

        private void btnAnalytics_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnAnalytics.Height;
            pnlNav.Top = btnAnalytics.Top;
            btnAnalytics.BackColor = Color.FromArgb(46, 51, 73);

            lbltitle.Text = "Add";
            this.pnlFormLoader.Controls.Clear();
            frmAnalytics frmAnalytics_vrb = new frmAnalytics() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmAnalytics_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmAnalytics_vrb);
            frmAnalytics_vrb.Show();
            textBox1.Hide();
        }

        private void btnCalender_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnCalender.Height;
            pnlNav.Top = btnCalender.Top;
            btnCalender.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            frmCalender frmCalender_vrb = new frmCalender() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmCalender_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmCalender_vrb);
            frmCalender_vrb.Show();
            textBox1.Hide();
            lbltitle.Text = "Update";
        }

        private void btnContactUs_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnContactUs.Height;
            pnlNav.Top = btnContactUs.Top;
            btnContactUs.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            frmContactUs frmContactUs_vrb = new frmContactUs() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmContactUs_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmContactUs_vrb);
            frmContactUs_vrb.Show();
            textBox1.Hide();
            lbltitle.Text = "Contact Us";
        }

        private void btnsettings_Click(object sender, EventArgs e)
        {
            pnlNav.Height = btnsettings.Height;
            pnlNav.Top = btnsettings.Top;
            btnsettings.BackColor = Color.FromArgb(46, 51, 73);

            this.pnlFormLoader.Controls.Clear();
            frmSettings frmSettings_vrb = new frmSettings() { Dock = DockStyle.Fill, TopLevel = false, TopMost = true };
            frmSettings_vrb.FormBorderStyle = FormBorderStyle.None;
            this.pnlFormLoader.Controls.Add(frmSettings_vrb);
            frmSettings_vrb.Show();
            textBox1.Hide();
            lbltitle.Text = "Settings";
        }

        private void btnDashbord_Leave(object sender, EventArgs e)
        {
            btnBrowse.BackColor = Color.FromArgb(24, 17, 68);
        }

        private void btnAnalytics_Leave(object sender, EventArgs e)
        {
            btnAnalytics.BackColor = Color.FromArgb(24, 17, 68);
        }

        private void btnCalender_Leave(object sender, EventArgs e)
        {
            btnCalender.BackColor = Color.FromArgb(24, 17, 68);
        }

        private void btnContactUs_Leave(object sender, EventArgs e)
        {
            btnContactUs.BackColor = Color.FromArgb(24, 17, 68);
        }

        private void btnsettings_Leave(object sender, EventArgs e)
        {
            btnsettings.BackColor = Color.FromArgb(24, 17, 68);
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
