using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Data.SqlClient;

namespace Perpustakaan
{
    public partial class RegisterPage : Form
    {
        public RegisterPage()
        {
            InitializeComponent();
            EmailError.Text = "";
            PasswordError.Text = "";
            UsernameError.Text = "";
            ConfirmPasswordError.Text = "";
        }
        bool a = false;
        bool b = false;
        bool c = false;
        bool d = false;

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {
            TxtPass.PasswordChar = '*';
            string passWord = TxtPass.Text;

            PasswordError.Text = "";

            if (string.IsNullOrEmpty(passWord))
            {
                return;
            }

            if (passWord.Length < 6)
            {
                PasswordError.Text = "Password is too short";
                a = false;
            }
            else if (passWord.Length > 20)
            {
                TxtPass.Text = passWord.Substring(0, 20);
                TxtPass.SelectionStart = TxtPass.Text.Length;
                PasswordError.Text = "Password reached maximum character limit!";
            }
            a = true;
        }

        private void TxtUserName_TextChanged(object sender, EventArgs e)
        {
            string userName = TxtUserName.Text.Trim();

            UsernameError.Text = "";
            b = false;

            if (string.IsNullOrEmpty(userName))
            {
                return;
            }

            if (userName.Length <= 6)
            {
                UsernameError.Text = "Username is too short";
            }
            else if (userName.Length > 20)
            {
                TxtUserName.Text = userName.Substring(0, 20);
                TxtUserName.SelectionStart = 20;
                UsernameError.Text = "Username reached maximum character limit!";
            }
            else
            {
                b = true;
            }
        }

        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            if (TxtEmail.Text.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase) || TxtEmail.Text == "")
            {
                EmailError.Text = "";
                c = true;
            }
            else
            {
                c = false;
                EmailError.Text = "The Email Adress must included @gmail.com";
            }
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void TxtConPass_TextChanged(object sender, EventArgs e)
        {
            TxtConPass.PasswordChar = '*';
            string passWord = TxtConPass.Text;

            if (passWord == "")
            {
                ConfirmPasswordError.Text = "";
                return;
            }

            if (passWord.Length <= 6)
            {
                d = false;
                return;
            }
            d = true;
            ConfirmPasswordError.Text = "";

            if (passWord.Length > 20)
            {
                TxtConPass.Text = passWord.Substring(0, 20);
                TxtConPass.SelectionStart = TxtConPass.Text.Length;
            }

            if (TxtPass.Text != TxtConPass.Text)
            {
                ConfirmPasswordError.Text = "Confirm password isn't the same as password";
            } else
            {
                ConfirmPasswordError.Text = "";
            }
        }



        private void BtnRegister_Click(object sender, EventArgs e)
        {
            //if (a == true && b == true && c == true && d == true)
            //{

            //}
            Home homeForm = Program.FrmUtama;
            homeForm.Show();

            string username = TxtUserName.Text;
            string email = TxtEmail.Text;
            string password = TxtPass.Text;

            DatabaseClass.BukaDB("users");
            Console.WriteLine("A");

            bool userCheck = DatabaseClass.IsUserExists(username, "@username", "SELECT COUNT(*) FROM users WHERE username = @username");
            bool emailCheck = DatabaseClass.IsUserExists(email, "@email", "SELECT COUNT(*) FROM users WHERE email = @email");
            if (userCheck)
            {
                UsernameError.Text = "Username already existed.";
            }

            if (emailCheck)
            {
                EmailError.Text = "Email is already registered. Please choose a different one.";
            }

            Console.WriteLine("B");


            if (!userCheck && !emailCheck)
            {
                //DatabaseClass.RegisterUser(username, email, password);
                Console.WriteLine("ASHDOIAS");
                VerificationEmail verification = Program.FrmVerificationEmail;
                Program.FrmVerificationEmail.changeFunction(username, email);
                verification.Show();
                this.Hide();
            }

            DatabaseClass.TutupDB("users");
        }
    }
}
