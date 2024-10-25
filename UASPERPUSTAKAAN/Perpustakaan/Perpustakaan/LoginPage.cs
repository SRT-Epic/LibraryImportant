﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Perpustakaan
{
    public partial class LoginPage : Form
    {
        public LoginPage()
        {
            InitializeComponent();
            EmailError.Text = "";
            PasswordError.Text = "";
        }

        bool a = false;
        bool b = false;

        private void TxtPass_TextChanged(object sender, EventArgs e)
        {
            TxtPass.PasswordChar = '*';
            string passWord = TxtPass.Text;
            PasswordError.Text = "";
            if (passWord.Length <= 6)
            {
                PasswordError.Text = "Password is too short";
                a = false;
                return;
            }

            a = true;
            if (passWord.Length > 20)
            {
                TxtPass.Text = passWord.Substring(0, 20);

                TxtPass.SelectionStart = TxtPass.Text.Length;
                PasswordError.Text = "Password reach maximum character!!";
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }


        private void TxtEmail_TextChanged(object sender, EventArgs e)
        {
            if (TxtEmail.Text.EndsWith("@gmail.com", StringComparison.OrdinalIgnoreCase))
            {
                EmailError.Text = "";
                b = true;
            }
            else
            {
                b = false;
                EmailError.Text = "The Email Adress must included @gmail.com";
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void LblEmail_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void roundButton1_Click(object sender, EventArgs e)
        {
            if (a == true && b == true)
            {
                string email = TxtEmail.Text;
                string password = TxtPass.Text;

                DatabaseClass.BukaDB("users");

                bool emailCheck = DatabaseClass.IsUserExists(email, "@email", "SELECT COUNT(*) FROM users WHERE email = @email");

                if (!emailCheck)
                {
                    EmailError.Text = "Email not found. Please register or check your input.";
                    return;
                }

                bool isLoginSuccessful = DatabaseClass.CheckLoginCredentials(email, password, "SELECT password FROM users WHERE email = @email");

                if (!isLoginSuccessful)
                {
                    PasswordError.Text = "Incorrect password. Please try again.";
                    return;
                }

                DatabaseClass.TutupDB("users");

                Home homeForm = Program.FrmUtama;
                homeForm.Show();

                Program.FrmUtama.userChange();
                this.Hide();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {
            RegisterPage Register = Program.FrmRegister;
            Register.Show();
            this.Hide();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}