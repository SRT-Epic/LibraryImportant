using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Perpustakaan.DatabaseClass;

namespace Perpustakaan
{
    public partial class RentPage : Form
    {
        Dictionary<string, Dictionary<string, Dictionary<string, string>>> multiDict = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();

        public RentPage()
        {
            InitializeComponent();
        }


        private List<Panel> comicPanels = new List<Panel>();
        int increment = 1;


        public void AddComicDatabase(string bookTitle, string bookCodeParam, int indexPosition, string genreNovel, byte[] pictureBook, string Publisher, string author, string bookDescription)
        {
            Panel comicPanel = new Panel();
            comicPanel.Size = new Size(150, 300);
            comicPanel.BorderStyle = BorderStyle.None;

            int x = (((indexPosition - 1) % 5) * 180) + 50;
            int y = (int)(Math.Floor((double)(indexPosition - 1) / 5) * 310) + 50;

            comicPanel.Location = new Point(x, y);

            PictureBox pictureBox = new PictureBox();
            if (pictureBook != null && pictureBook.Length > 0)
            {
                using (MemoryStream ms = new MemoryStream(pictureBook))
                {
                    pictureBox.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pictureBox.Image = null; // Clear the PictureBox if no image is found
            }

            pictureBox.Dock = DockStyle.Top;
            pictureBox.Size = new Size(150, 220);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            RoundButton button = new RoundButton();
            button.Text = "Read Book";
            button.Dock = DockStyle.Bottom;
            button.BackColor = Color.FromArgb(7, 190, 185);
            button.ForeColor = Color.White;
            button.Font = new Font("Consolas", 8, FontStyle.Bold);
            button.FlatStyle = FlatStyle.Flat;
            button.Size = new Size(150, 25);

            Label label = new Label();
            label.Text = bookTitle;
            label.Dock = DockStyle.Bottom;
            label.Font = new Font("Consolas", 12);

            Label label2 = new Label();
            label2.Text = genreNovel;
            label2.Dock = DockStyle.Bottom;
            label2.ForeColor = Color.FromArgb(175, 175, 175);
            label2.Font = new Font("Consolas", 10);

            button.Click += (s, e) =>
            {
                InboxForm inboxFrm = Program.FrmInbox;
                inboxFrm.Show();
                inboxFrm.WindowState = FormWindowState.Maximized;
                inboxFrm.BringToFront();
            };



            comicPanel.Controls.Add(pictureBox);
            comicPanel.Controls.Add(button);
            comicPanel.Controls.Add(label);
            comicPanel.Controls.Add(label2);

            GenreLayout.Controls.Add(comicPanel);
            comicPanels.Add(comicPanel);
        }

        public void AddComic(string text1, string genre, string publicBookCode)
        {
            //indexAddComic(text1, genre, increment, publicBookCode);

            DatabaseClass.BukaDB("book");
            List<Book> bookList = DatabaseClass.BacaDataBuku(
                $"SELECT * FROM book WHERE book_id = '{publicBookCode}'"
            );

            foreach (var book in bookList)
            {
                AddComicDatabase(
                    book.BookTitle,
                    book.BookId,
                    increment,
                    book.BookGenre,
                    book.BookImageCover,
                    book.BookPublisher,
                    book.BookAuthor,
                    book.BookDescription
                );
            }

            DatabaseClass.TutupDB("book");

            increment++;


        }

        private void RentPage_Load(object sender, EventArgs e)
        {

        }

        private void GenreLayout_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
