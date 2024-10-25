using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private Form originalForm = null;

        public void SwitchForm(Form targetForm, int transitionSpeed = 100, double increment = 0.05)
        {
            if (targetForm != originalForm)
            {
                originalForm.Hide();
                targetForm.WindowState = FormWindowState.Maximized;
                targetForm.BringToFront();
                targetForm.Show();

                originalForm = targetForm;
            }
        }


        public void userChange()
        {

        }
        private void Form1_Load(object sender, EventArgs e)
        {

            //TitleHome.Parent = GradientBoxTop;
            //TitleHome.BackColor = Color.Transparent;

            //LoginButton.Parent = pictureBox2;


            Menu menu = Program.FrmMenu;
            menu.Show();
            menu.WindowState = FormWindowState.Maximized;
            menu.BringToFront();
            originalForm = menu;
        }

        Color colorDefault = Color.FromArgb(88, 101, 251);
        private void button1_Click(object sender, EventArgs e)
        {
            SwitchForm(Program.FrmMenu);

            button1.BackColor = Color.FromArgb(7, 190, 185);
            Collection.BackColor = colorDefault;
            button3.BackColor = colorDefault;
            button4.BackColor = colorDefault;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SwitchForm(Program.FrmRent);

            button1.BackColor = colorDefault;
            Collection.BackColor = colorDefault;
            button3.BackColor = colorDefault;
            button4.BackColor = Color.FromArgb(29, 132, 192);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.BackColor = colorDefault;
            Collection.BackColor = colorDefault;
            button3.BackColor = Color.FromArgb(29, 132, 192);
            button4.BackColor = colorDefault;
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void TitleHome_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void GradientBoxTop_Click(object sender, EventArgs e)
        {

        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }

        private void LoginButton_Click(object sender, EventArgs e)
        {
            LoginPage loginForm = Program.FrmLogin;
            loginForm.Show();
            //this.Hide();
        }

        private void Collection_Click(object sender, EventArgs e)
        {
            button1.BackColor = colorDefault;
            Collection.BackColor = Color.FromArgb(29, 132, 192);
            button3.BackColor = colorDefault;
            button4.BackColor = colorDefault;

            SwitchForm(Program.FrmDiscover);
        }

        private void pictureBox6_Click_1(object sender, EventArgs e)
        {
          
        }
        
        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {
            string searchTerm = textBox1.Text;
            Discover discover = Program.FrmDiscover;
            discover.SearchBarFunc(searchTerm);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int originalSize = 186;
            for (int i = 1; i < originalSize; i+=2)
            {
                PanelThreeDot.Size = new Size(i, 771);
                AccountButton.Location = new Point(-152 + i, 48);
                Thread.Sleep(1);
            }
        }

        private void pictureBox2_Click_1(object sender, EventArgs e)
        {

        }
    }
}
