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
using System.Collections.ObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;
using System.Net.Http;
using System.Reflection;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using static Perpustakaan.DatabaseClass;


//multiDict["Fantasy"] = new Dictionary<string, Dictionary<string, string>>()
//            {
//                { "1", new Dictionary<string, string>() {
//                    { "bookNames", "Dwarf" },
//                    { "publisherNames", "Test" },
//                    { "writerNames", "Leo" },
//                    { "description", "Dwarf man is the bla bla bla" },
//                    { "pictureBox", "dwarfTest" }
//                } },
//                { "2", new Dictionary<string, string>() {
//                    { "bookNames", "The Fallen Gates" },
//                    { "publisherNames", "Arthur" },
//                    { "writerNames", "Jack marston" },
//                    { "description", "Fallen Gates is the bla bla bla" },
//                    { "pictureBox", "The Fallen Gates" }
//                } },
//                { "3", new Dictionary<string, string>() {
//                    { "bookNames", "Vitran Secrets" },
//                    { "publisherNames", "Priscilla" },
//                    { "writerNames", "Selvy" },
//                    { "description", "the bla bla bla" },
//                    { "pictureBox", "Vitran Secrets" }
//                } },
//                { "4", new Dictionary<string, string>() {
//                    { "bookNames", "The Battle For Fae King Troll" },
//                    { "publisherNames", "banana" },
//                    { "writerNames", "Apple" },
//                    { "description", "the bla bla bla" },
//                    { "pictureBox", "The Battle For Fae King Troll" }
//                } },
//                { "5", new Dictionary<string, string>() {
//                    { "bookNames", "The Dragon Knights Curse" },
//                    { "publisherNames", "banana" },
//                    { "writerNames", "Apple" },
//                    { "description", "the bla bla bla" },
//                    { "pictureBox", "The Dragon Knights Curse" }
//                } }
//            };

//multiDict["Sci-fi"] = new Dictionary<string, Dictionary<string, string>>()
//            {
//                { "1", new Dictionary<string, string>() {
//                    { "bookNames", "Another World" },
//                    { "publisherNames", "Test" },
//                    { "writerNames", "Leo" },
//                    { "description", "the bla bla bla" },
//                    { "pictureBox", "Another World" }
//                } },
//                { "2", new Dictionary<string, string>() {
//                    { "bookNames", "The Calculating Stars" },
//                    { "publisherNames", "banana" },
//                    { "writerNames", "Apple" },
//                    { "description", "the bla bla bla" },
//                    { "pictureBox", "The Calculating Stars" }
//                } },
//                { "3", new Dictionary<string, string>() {
//                    { "bookNames", "RELIC" },
//                    { "publisherNames", "banana" },
//                    { "writerNames", "Apple" },
//                    { "description", "the bla bla bla" },
//                    { "pictureBox", "RELIC" }
//                } }
//            };

//multiDict["Mystery"] = new Dictionary<string, Dictionary<string, string>>()
//            {
//                { "1", new Dictionary<string, string>() {
//                    { "bookNames", "MysteryDarkHillSchool" },
//                    { "publisherNames", "Test" },
//                    { "writerNames", "Jifri" },
//                    { "description", "the bla bla bla" },
//                    { "pictureBox", "MysteryDarkHillSchool" }
//                } },
//                { "2", new Dictionary<string, string>() {
//                    { "bookNames", "MysteryJanuary" },
//                    { "publisherNames", "banana" },
//                    { "writerNames", "Apple" },
//                    { "description", "the bla bla bla" },
//                    { "pictureBox", "MysteryJanuary" }
//                } },
//                { "3", new Dictionary<string, string>() {
//                    { "bookNames", "TheWomanInTheLibrary" },
//                    { "publisherNames", "banana" },
//                    { "writerNames", "Apple" },
//                    { "description", "the bla bla bla" },
//                    { "pictureBox", "TheWomanInTheLibrary" }
//                } },
//                { "4", new Dictionary<string, string>() {
//                    { "bookNames", "MysteryDarkHillSchool" },
//                    { "publisherNames", "Test" },
//                    { "writerNames", "Jifri" },
//                    { "description", "the bla bla bla" },
//                    { "pictureBox", "MysteryDarkHillSchool" }
//                } },
//                { "5", new Dictionary<string, string>() {
//                    { "bookNames", "MysteryJanuary" },
//                    { "publisherNames", "banana" },
//                    { "writerNames", "Apple" },
//                    { "description", "the bla bla bla" },
//                    { "pictureBox", "MysteryJanuary" }
//                } },
//                { "6", new Dictionary<string, string>() {
//                    { "bookNames", "TheWomanInTheLibrary" },
//                    { "publisherNames", "banana" },
//                    { "writerNames", "Apple" },
//                    { "description", "the bla bla bla" },
//                    { "pictureBox", "TheWomanInTheLibrary" }
//                } },
//                { "7", new Dictionary<string, string>() {
//                    { "bookNames", "MysteryDarkHillSchool" },
//                    { "publisherNames", "Test" },
//                    { "writerNames", "Jifri" },
//                    { "description", "the bla bla bla" },
//                    { "pictureBox", "MysteryDarkHillSchool" }
//                } },
//                { "8", new Dictionary<string, string>() {
//                    { "bookNames", "MysteryJanuary" },
//                    { "publisherNames", "banana" },
//                    { "writerNames", "Apple" },
//                    { "description", "the bla bla bla" },
//                    { "pictureBox", "MysteryJanuary" }
//                } },
//                { "9", new Dictionary<string, string>() {
//                    { "bookNames", "TheWomanInTheLibrary" },
//                    { "publisherNames", "banana" },
//                    { "writerNames", "Apple" },
//                    { "description", "the bla bla bla" },
//                    { "pictureBox", "TheWomanInTheLibrary" }
//                } },
//                { "10", new Dictionary<string, string>() {
//                    { "bookNames", "MysteryJanuary" },
//                    { "publisherNames", "banana" },
//                    { "writerNames", "Apple" },
//                    { "description", "the bla bla bla" },
//                    { "pictureBox", "MysteryJanuary" }
//                } },
//                { "11", new Dictionary<string, string>() {
//                    { "bookNames", "TheWomanInTheLibrary" },
//                    { "publisherNames", "banana" },
//                    { "writerNames", "Apple" },
//                    { "description", "the bla bla bla" },
//                    { "pictureBox", "TheWomanInTheLibrary" }
//                } },
//                { "12", new Dictionary<string, string>() {
//                    { "bookNames", "TheWomanInTheLibrary" },
//                    { "publisherNames", "banana" },
//                    { "writerNames", "Apple" },
//                    { "description", "the bla bla bla" },
//                    { "pictureBox", "TheWomanInTheLibrary" }
//                } },
//                { "13", new Dictionary<string, string>() {
//                    { "bookNames", "TheWomanInTheLibrary" },
//                    { "publisherNames", "banana" },
//                    { "writerNames", "Apple" },
//                    { "description", "the bla bla bla" },
//                    { "pictureBox", "TheWomanInTheLibrary" }
//                } }
//            };

namespace Perpustakaan
{
    public partial class Discover : Form
    {
        RoundButton originalButton = null;

        Dictionary<string, Dictionary<string, Dictionary<string, string>>> multiDict = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();


        private List<Panel> comicPanels = new List<Panel>();
        string genre = "Fantasy";
        string oldGenre;
        int allIndex;

        public class SearchResult
        {
            public string Genre { get; set; }
            public string Id { get; set; }
            public string BookName { get; set; }
        }

        private List<SearchResult> SearchBooks(Dictionary<string, Dictionary<string, Dictionary<string, string>>> multiDict, string searchTerm)
        {
            List<SearchResult> matchedBooks = new List<SearchResult>();
            string normalizedSearchTerm = searchTerm.ToLower();

            foreach (var genre in multiDict)
            {
                foreach (var bookEntry in genre.Value)
                {
                    string bookName = bookEntry.Value["bookNames"];
                    if (bookName.IndexOf(normalizedSearchTerm, StringComparison.OrdinalIgnoreCase) >= 0)
                    {
                        // Create a new SearchResult object
                        matchedBooks.Add(new SearchResult
                        {
                            Genre = genre.Key,
                            Id = bookEntry.Key,
                            BookName = bookName
                        });
                    }
                }
            }

            return matchedBooks;
        }

        public void indexAddComic(string comicTitle, string genreSearch, int index, string listIndex)
        {
            Panel comicPanel = new Panel();
            comicPanel.Size = new Size(150, 300);
            comicPanel.BorderStyle = BorderStyle.None;
            comicPanel.BackColor = Color.Gray;

            var fantasy = multiDict[genreSearch];
            var bookCode = fantasy[listIndex];

            int panelWidth = comicPanel.Width;
            int panelHeight = comicPanel.Height;

            int x = (((index - 1) % 5) * 180) + 50;
            int y = (int)(Math.Floor((double)(index - 1) / 5) * 310) + 50;
            //int y = 100;

            comicPanel.Location = new Point(x, y);

            var imageDirectory = (Image)Properties.Resources.ResourceManager.GetObject("PfpEmail");

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = imageDirectory;
            pictureBox.Dock = DockStyle.Top;
            pictureBox.Size = new Size(150, 220);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            RoundButton button = new RoundButton();
            button.Text = comicTitle;
            button.Dock = DockStyle.Bottom;
            button.BackColor = Color.FromArgb(7, 190, 185);
            button.ForeColor = Color.FromArgb(255, 255, 255);
            button.Font = new Font("Consolas", 8, FontStyle.Bold);
            button.FlatStyle = FlatStyle.Flat;
            button.Size = new Size(150, 25);

            Label label = new Label();
            label.Text = bookCode["bookNames"];
            label.Dock = DockStyle.Bottom;
            label.Font = new Font("Consolas", 12);

            Label label2 = new Label();
            label2.Text = genreSearch;
            label2.Dock = DockStyle.Bottom;
            label2.ForeColor = Color.FromArgb(175, 175, 175);
            label2.Font = new Font("Consolas", 10);

            button.Click += (s, e) =>
            {
                Menu collt = Program.FrmMenu;
                collt.Hide();

                Page page = Program.FrmPage;
                page.UpdateTitleBook(
                    bookCode["bookNames"],
                    bookCode["publisherNames"],
                    bookCode["writerNames"],
                    bookCode["description"],
                    bookCode["pictureBox"],
                    genreSearch,
                    listIndex.ToString()
                );
                page.Show();
                page.WindowState = FormWindowState.Maximized;
                page.BringToFront();
            };

            comicPanel.Controls.Add(pictureBox);
            comicPanel.Controls.Add(button);
            comicPanel.Controls.Add(label);
            comicPanel.Controls.Add(label2);

            GenreLayout.Controls.Add(comicPanel);
            comicPanels.Add(comicPanel);
        }
        int indexItterate = 1;

        private void DisplayResults(List<SearchResult> results)
        {
            GenreLayout.Controls.Clear();
            foreach (var result in results)
            {
                indexAddComic("check comic", result.Genre, indexItterate, result.Id);
                Console.WriteLine(result.BookName);
                indexItterate++;
            }
            indexItterate = 1;
            Console.WriteLine("Previous");
        }

        public void SearchBarFunc(string searchText)
        {
            var results = SearchBooks(multiDict, searchText);

            if (results != null)
            {
                DisplayResults(results);
            }
        }

        public void RefreshComic(string genreParam, RoundButton buttonParam)
        {
            GenreLayout.Controls.Clear();
            originalButton = buttonParam;

            int itemsPerPage = 10;
            int currentPage = 1;

            int totalBooks = DatabaseClass.GetTotalBooks("book_genre", "book", genreParam);
            int totalPages = (int)Math.Ceiling(totalBooks / (double)itemsPerPage);

            void DisplayBooksForCurrentPage(int pageNumber)
            {
                GenreLayout.Controls.Clear();

                DatabaseClass.BukaDB("DatabaseBook");

                string query = "SELECT * FROM book";
                if (!string.IsNullOrEmpty(genreParam))
                {
                    query += $" WHERE CAST(book_genre AS VARCHAR(MAX)) = '{genreParam}'"; 
                }
                query += $" ORDER BY book_id OFFSET {(pageNumber - 1) * itemsPerPage} ROWS FETCH NEXT {itemsPerPage} ROWS ONLY";

                List<DatabaseClass.Book> bookList = DatabaseClass.BacaDataBuku(query);

                int allIndex = 1;
                foreach (var book in bookList)
                {
                    AddComicDatabase(
                        book.BookTitle, 
                        book.BookId, 
                        allIndex, 
                        book.BookGenre, 
                        book.BookImageCover, 
                        book.BookPublisher,
                        book.BookAuthor,
                        book.BookDescription
                    );
                    allIndex++;
                }

                DatabaseClass.TutupDB("book");
                PageNumber();
            }

            void PageNumber()
            {
                for (int i = 1; i <= totalPages; i++)
                {
                    RoundButton nextPageButton = new RoundButton();
                    nextPageButton.Text = i.ToString();
                    nextPageButton.Size = new Size(30, 30);
                    nextPageButton.Location = new Point(50 + (i - 1) * 40, 670);
                    nextPageButton.Click += (s, e) =>
                    {
                        currentPage = i;
                        DisplayBooksForCurrentPage(currentPage);
                    };

                    GenreLayout.Controls.Add(nextPageButton);
                }
            }

            DisplayBooksForCurrentPage(currentPage);
        }


        public void AddComicDatabase(string bookTitle, string bookCodeParam, int indexPosition, string genreNovel, string pictureBook, string Publisher, string author, string bookDescription)
        {
            Panel comicPanel = new Panel();
            comicPanel.Size = new Size(150, 300);
            comicPanel.BorderStyle = BorderStyle.None;

            int x = (((indexPosition - 1) % 5) * 180) + 50;
            int y = (int)(Math.Floor((double)(indexPosition - 1) / 5) * 310) + 50;

            comicPanel.Location = new Point(x, y);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = (Image)Properties.Resources.ResourceManager.GetObject(pictureBook);
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
                Menu collt = Program.FrmMenu;
                collt.Hide();

                Page page = Program.FrmPage;
                page.UpdateTitleBook(
                    bookTitle,
                    Publisher,
                    author,
                    bookDescription,
                    pictureBook,
                    genreNovel,
                    bookCodeParam
                );
                page.Show();
                page.WindowState = FormWindowState.Maximized;
                page.BringToFront();
            };



            comicPanel.Controls.Add(pictureBox);
            comicPanel.Controls.Add(button);
            comicPanel.Controls.Add(label);
            comicPanel.Controls.Add(label2);

            GenreLayout.Controls.Add(comicPanel);
            comicPanels.Add(comicPanel);
        }

        SqlDataReader TabelBuku;
        SqlCommand CmdCari;

        public void allFunction()
        {
            int itemsPerPage = 10;
            int currentPage = 1;

            int totalBooks = DatabaseClass.GetTotalBooks("book_genre", "book");
            int totalPages = (int)Math.Ceiling(totalBooks / (double)itemsPerPage);

            void PageNumber()
            {
                for (int i = 1; i <= totalPages; i++)
                {
                    RoundButton nextPageButton = new RoundButton();
                    nextPageButton.Text = i.ToString();
                    nextPageButton.Size = new Size(30, 30);
                    nextPageButton.Location = new Point(50 + (i - 1) * 40, 670);
                    int pageNumber = i;
                    nextPageButton.Click += (s, e) =>
                    {
                        currentPage = pageNumber;
                        DisplayBooksForCurrentPage(currentPage);
                    };

                    GenreLayout.Controls.Add(nextPageButton);
                }
            }


            void DisplayBooksForCurrentPage(int pageNumber)
            {
                GenreLayout.Controls.Clear();

                DatabaseClass.BukaDB("book");
                List<Book> bookList = DatabaseClass.BacaDataBuku(
                    $"SELECT * FROM book ORDER BY book_id OFFSET {(pageNumber - 1) * itemsPerPage} ROWS FETCH NEXT {itemsPerPage} ROWS ONLY"
                );
                int allIndex = 1;

                foreach (var book in bookList)
                {
                    AddComicDatabase(
                        book.BookTitle,
                        book.BookId,
                        allIndex,
                        book.BookGenre,
                        book.BookImageCover,
                        book.BookPublisher,
                        book.BookAuthor,
                        book.BookDescription
                    );
                    allIndex++;
                }

                DatabaseClass.TutupDB("book");
                PageNumber();
            }

            DisplayBooksForCurrentPage(currentPage);
            PageNumber();

        }

        public Discover()
        {
            InitializeComponent();

            originalButton = roundButton7;

            allFunction();
        }

        private void Discover_Load(object sender, EventArgs e)
        {
            
        }

        private void roundButton1_MouseHover(object sender, EventArgs e)
        {

        }

        
        Color turqoiseBackColor = Color.FromArgb(7, 190, 185);
        Color grayBackColor = Color.FromArgb(224, 224, 224);
        Color whiteForeColor = Color.FromArgb(255, 255, 255);
        Color brownForeColor = Color.FromArgb(124, 112, 106);
        private void roundButton2_Click(object sender, EventArgs e)
        {
            originalButton.BackColor = grayBackColor;
            originalButton.ForeColor = brownForeColor;
            roundButton2.BackColor = turqoiseBackColor;
            roundButton2.ForeColor = whiteForeColor;
            RefreshComic("Sci-fi", roundButton2);
        }

        private void roundButton3_Click(object sender, EventArgs e)
        {
            originalButton.BackColor = grayBackColor;
            originalButton.ForeColor = brownForeColor;
            roundButton3.BackColor = turqoiseBackColor;
            roundButton3.ForeColor = whiteForeColor;
            RefreshComic("Mystery", roundButton3);
        }

        private void roundButton4_Click(object sender, EventArgs e)
        {
            originalButton.BackColor = grayBackColor;
            originalButton.ForeColor = brownForeColor;
            roundButton4.BackColor = turqoiseBackColor;
            roundButton4.ForeColor = whiteForeColor;
            RefreshComic("Romance", roundButton4);
        }

        private void roundButton5_Click(object sender, EventArgs e)
        {
            originalButton.BackColor = grayBackColor;
            originalButton.ForeColor = brownForeColor;
            roundButton5.BackColor = turqoiseBackColor;
            roundButton5.ForeColor = whiteForeColor;
            RefreshComic("Horror", roundButton5);
        }

        private void roundButton6_Click(object sender, EventArgs e)
        {
            originalButton.BackColor = grayBackColor;
            originalButton.ForeColor = brownForeColor;
            roundButton6.BackColor = turqoiseBackColor;
            roundButton6.ForeColor = whiteForeColor;
            RefreshComic("Biography", roundButton6);
        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            originalButton.BackColor = grayBackColor;
            originalButton.ForeColor = brownForeColor;
            roundButton1.BackColor = turqoiseBackColor;
            roundButton1.ForeColor = whiteForeColor;
            RefreshComic("Fantasy", roundButton1);
        }

        private void roundButton7_Click(object sender, EventArgs e)
        {
            originalButton.BackColor = grayBackColor;
            originalButton.ForeColor = brownForeColor;
            roundButton7.BackColor = turqoiseBackColor;
            roundButton7.ForeColor = whiteForeColor;
            originalButton = roundButton7;

            allFunction();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void GenreLayout_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
