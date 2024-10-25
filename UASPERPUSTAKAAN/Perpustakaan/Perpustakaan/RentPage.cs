using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan
{
    public partial class RentPage : Form
    {
        Dictionary<string, Dictionary<string, Dictionary<string, string>>> multiDict = new Dictionary<string, Dictionary<string, Dictionary<string, string>>>();

        public RentPage()
        {
            InitializeComponent();
            multiDict["Fantasy"] = new Dictionary<string, Dictionary<string, string>>()
            {
                { "1", new Dictionary<string, string>() {
                    { "bookNames", "Dwarf" },
                    { "publisherNames", "Test" },
                    { "writerNames", "Leo" },
                    { "description", "Dwarf man is the bla bla bla" },
                    { "pictureBox", "dwarfTest" }
                } },
                { "2", new Dictionary<string, string>() {
                    { "bookNames", "The Fallen Gates" },
                    { "publisherNames", "Arthur" },
                    { "writerNames", "Jack marston" },
                    { "description", "Fallen Gates is the bla bla bla" },
                    { "pictureBox", "The Fallen Gates" }
                } },
                { "3", new Dictionary<string, string>() {
                    { "bookNames", "Vitran Secrets" },
                    { "publisherNames", "Priscilla" },
                    { "writerNames", "Selvy" },
                    { "description", "the bla bla bla" },
                    { "pictureBox", "Vitran Secrets" }
                } },
                { "4", new Dictionary<string, string>() {
                    { "bookNames", "The Battle For Fae King Troll" },
                    { "publisherNames", "banana" },
                    { "writerNames", "Apple" },
                    { "description", "the bla bla bla" },
                    { "pictureBox", "The Battle For Fae King Troll" }
                } },
                { "5", new Dictionary<string, string>() {
                    { "bookNames", "The Dragon Knights Curse" },
                    { "publisherNames", "banana" },
                    { "writerNames", "Apple" },
                    { "description", "the bla bla bla" },
                    { "pictureBox", "The Dragon Knights Curse" }
                } }
            };

            multiDict["Sci-fi"] = new Dictionary<string, Dictionary<string, string>>()
            {
                { "1", new Dictionary<string, string>() {
                    { "bookNames", "Another World" },
                    { "publisherNames", "Test" },
                    { "writerNames", "Leo" },
                    { "description", "the bla bla bla" },
                    { "pictureBox", "Another World" }
                } },
                { "2", new Dictionary<string, string>() {
                    { "bookNames", "The Calculating Stars" },
                    { "publisherNames", "banana" },
                    { "writerNames", "Apple" },
                    { "description", "the bla bla bla" },
                    { "pictureBox", "The Calculating Stars" }
                } },
                { "3", new Dictionary<string, string>() {
                    { "bookNames", "RELIC" },
                    { "publisherNames", "banana" },
                    { "writerNames", "Apple" },
                    { "description", "the bla bla bla" },
                    { "pictureBox", "RELIC" }
                } }
            };

            multiDict["Mystery"] = new Dictionary<string, Dictionary<string, string>>()
            {
                { "1", new Dictionary<string, string>() {
                    { "bookNames", "MysteryDarkHillSchool" },
                    { "publisherNames", "Test" },
                    { "writerNames", "Jifri" },
                    { "description", "the bla bla bla" },
                    { "pictureBox", "MysteryDarkHillSchool" }
                } },
                { "2", new Dictionary<string, string>() {
                    { "bookNames", "MysteryJanuary" },
                    { "publisherNames", "banana" },
                    { "writerNames", "Apple" },
                    { "description", "the bla bla bla" },
                    { "pictureBox", "MysteryJanuary" }
                } },
                { "3", new Dictionary<string, string>() {
                    { "bookNames", "TheWomanInTheLibrary" },
                    { "publisherNames", "banana" },
                    { "writerNames", "Apple" },
                    { "description", "the bla bla bla" },
                    { "pictureBox", "TheWomanInTheLibrary" }
                } }
            };
        }


        private List<Panel> comicPanels = new List<Panel>();
        int increment = 1;


        public void indexAddComic(string comicTitle, string genreSearch, int index, string listIndex)
        {
            Panel comicPanel = new Panel();
            comicPanel.Size = new Size(150, 300);
            comicPanel.BorderStyle = BorderStyle.None;

            var fantasy = multiDict[genreSearch];
            var bookCode = fantasy[listIndex];

            //Console.WriteLine(bookCode);
            //Console.WriteLine(fantasy);
            
            int panelWidth = comicPanel.Width;
            int panelHeight = comicPanel.Height;

            int x = (((index - 1) % 5) * 180) + 50;
            int y = (int)(Math.Floor((double)(index - 1) / 5) * 310) + 50;
            //int y = 100;

            comicPanel.Location = new Point(x, y);

            var imageDirectory = (Image)Properties.Resources.ResourceManager.GetObject(bookCode["pictureBox"]);

            PictureBox pictureBox = new PictureBox();
            pictureBox.Image = imageDirectory;
            pictureBox.Dock = DockStyle.Top;
            pictureBox.Size = new Size(150, 220);
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            //RoundButton button = new RoundButton();
            //button.Text = comicTitle;
            //button.Dock = DockStyle.Bottom;
            //button.BackColor = Color.FromArgb(7, 190, 185);
            //button.ForeColor = Color.FromArgb(255, 255, 255);
            //button.Font = new Font("Consolas", 8, FontStyle.Bold);
            //button.FlatStyle = FlatStyle.Flat;
            //button.Size = new Size(150, 25);

            Label label = new Label();
            //label.Text = bookCode["bookNames"];
            label.Dock = DockStyle.Bottom;
            label.Font = new Font("Consolas", 12);

            Label label2 = new Label();
            label2.Text = genreSearch;
            label2.Dock = DockStyle.Bottom;
            label2.ForeColor = Color.FromArgb(175, 175, 175);
            label2.Font = new Font("Consolas", 10);

            comicPanel.Controls.Add(pictureBox);
            //comicPanel.Controls.Add(button);
            comicPanel.Controls.Add(label);
            comicPanel.Controls.Add(label2);

            GenreLayout.Controls.Add(comicPanel);
            comicPanels.Add(comicPanel);
        }
        public void AddComic(string text1, string genre, string publicBookCode)
        {
            indexAddComic(text1, genre, increment, publicBookCode);
            Console.WriteLine(text1);
            Console.WriteLine(genre);
            Console.WriteLine(publicBookCode);
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
