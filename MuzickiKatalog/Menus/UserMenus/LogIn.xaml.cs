using MuzickiKatalog.Infrastructure.Service;
using MuzickiKatalog.Menus.UserMenus.UserViews;
using MuzickiKatalog.Models.Users;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MuzickiKatalog
{
    /// <summary>
    /// Interaction logic for LogIn.xaml
    /// </summary>
    public partial class LogIn : Window
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            KorisnikService korisnikService = new KorisnikService();
            Korisnik korisnik = korisnikService.Prijava(emailText.Text, lozinkaText.Text);
            if (korisnik == null)
            {
                MessageBox.Show("Ne postoji korisnik!");
            }
            else
            {
                if (korisnik.Uloga == "admin")
                {
                    AdminMenu adminMenu = new AdminMenu(korisnik.Email);
                    adminMenu.Show();
                    this.Close();
                }
                else if (korisnik.Uloga == "urednik")
                {
                    EditorMenu editorMenu=new EditorMenu(korisnik.Email);
                    editorMenu.Show();
                    this.Close();
                }
                else
                {
                    UserMenu userMenu = new UserMenu(korisnik.Email);
                    userMenu.Show();
                    this.Close();
                }
            }
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
