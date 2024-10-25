using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Perpustakaan
{
    internal static class Program
    {
        public static Home FrmUtama;
        public static Menu FrmMenu;
        public static Page FrmPage;
        public static Discover FrmDiscover;
        public static LoginPage FrmLogin;
        public static RentPage FrmRent;
        public static RegisterPage FrmRegister;
        public static VerificationEmail FrmVerificationEmail;

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            FrmUtama = new Home();
            FrmMenu = new Menu();
            FrmPage = new Page();
            FrmDiscover = new Discover();
            FrmLogin = new LoginPage();
            FrmRent = new RentPage();
            FrmRegister = new RegisterPage();
            FrmVerificationEmail = new VerificationEmail();

            FrmMenu.MdiParent = FrmUtama;
            FrmPage.MdiParent = FrmUtama;
            FrmDiscover.MdiParent = FrmUtama;
            FrmRent.MdiParent = FrmUtama;

            Application.Run(FrmUtama);
        }
    }
}
