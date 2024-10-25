using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Perpustakaan
{
    public partial class Page : Form
    {
        public Page()
        {
            InitializeComponent();
        }

        string publicGenre;
        string publicBookCode;
        public void UpdateTitleBook(string text1, string text2, string text3, string text4, string text5, string genre, string publicCode)
        {
            var imageDirectory = (Image)Properties.Resources.ResourceManager.GetObject(text5);
            PageNameBook.Text = text1;
            PublishNameBook.Text = text2;
            PenulisNameBook.Text = text3;
            DescriptionNameBook.Text = text4;
            pictureCover.Image = imageDirectory;
            pictureCover.SizeMode = PictureBoxSizeMode.StretchImage;
            publicGenre = genre;
            GenreLabel.Text = genre;
            TitleLabel.Text = text1;
            publicBookCode = publicCode;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {
            Discover discover = Program.FrmDiscover;
            discover.Show();
            discover.WindowState = FormWindowState.Maximized;
            discover.BringToFront();
        }

        private void label6_Click(object sender, EventArgs e)
        {
            Discover discover = Program.FrmDiscover;
            discover.Show();
            discover.WindowState = FormWindowState.Maximized;
            discover.BringToFront();
        }

        private void roundButton2_Click(object sender, EventArgs e)
        {
            //Panel panel = new Panel();
            //panel.Dock = DockStyle.Top;
            //panel.BackColor = Color.Orange;
            //panel.Size = new Size(150, 40);
            //panel1.Controls.Add(panel);

            //Panel panel2 = new Panel();
            //panel2.Dock = DockStyle.Top;
            //panel2.BackColor = Color.Orange;
            //panel2.Size = new Size(150, 40);
            //panel1.Controls.Add(panel2);

            //Label label = new Label();
            //label.Dock = DockStyle.Fill;
            //label.Font = new Font("Consolas", 12, FontStyle.Bold);
            //panel.Controls.Add(label);


            RentPage rent = Program.FrmRent;
            rent.AddComic(PageNameBook.Text, publicGenre, publicBookCode);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        int index = 1;
        private void button1_Click_1(object sender, EventArgs e)
        {
            Panel comentarPanel = new Panel();
            comentarPanel.Size = new Size(150, 100);
            comentarPanel.BorderStyle = BorderStyle.None;
            comentarPanel.Dock = DockStyle.Top;

            int x = (((index - 1) % 5) * 180) + 50;
            int y = (int)(Math.Floor((double)(index - 1) / 5) * 310) + 50;

            comentarPanel.Location = new Point(x, y);
            Label stuff = new Label();
            stuff.Dock = DockStyle.Fill;
            stuff.Text = textBox1.Text;

            comentarPanel.Controls.Add(stuff);
            CommentPanel.Controls.Add(comentarPanel);
            index++;

        }
    }
}
