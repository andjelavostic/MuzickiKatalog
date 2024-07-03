using MuzickiKatalog.Infrastructure.Service;
using MuzickiKatalog.Models.Items;
using MuzickiKatalog.Models.Users;
using MuzickiKatalog.Models;
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
using MuzickiKatalog.Menus.UserMenus.UserViews;

namespace MuzickiKatalog.Menus.ContentViews
{
    /// <summary>
    /// Interaction logic for BandView.xaml
    /// </summary>
    public partial class BandView : Window
    {
        private Grupa grupa;
        private Korisnik korisnik;
        private GlobalID globalId;
        private IzvodjacService izvodjacService;
        private RecenzijaService recenzijaService;
        private string userRole;
        public BandView(Grupa g, Korisnik k, string role)
        {
            InitializeComponent();
            this.grupa = g;
            this.korisnik = k;
            this.userRole = role;
            this.korisnik = k;
            this.globalId = new GlobalID();
            this.izvodjacService = new IzvodjacService();
            this.recenzijaService = new RecenzijaService();

            if (grupa != null)
            {

                string description = $"Naziv: {grupa.Naziv}\nDatum osnivanja: {grupa.DatumOsnivanja}\nOpis: {grupa.Opis}\nZanrovi: ";

                foreach (Zanr zanr in grupa.Zanrovi)
                {
                    description += $"{zanr.Naziv}, ";
                }

                if (grupa.Zanrovi.Count > 0)
                {
                    description = description.Substring(0, description.Length - 2);
                }

                description += "\nClanovi: ";

                foreach (Izvodjac izvodjac in grupa.Clanovi)
                {
                    description += izvodjac.Ime + " " + izvodjac.Prezime + ", ";
                }

                if (grupa.Clanovi.Count > 0)
                {
                    description = description.Substring(0, description.Length - 2);
                }

                DesctiptionTextBlock.Text = description;
            }
        }

        private void reviewButton_Click(object sender, RoutedEventArgs e) { }

        private void ratingButton_Click(object sender, RoutedEventArgs e) { }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (userRole == "korisnik")
            {
                UserMenu user = new UserMenu(korisnik.Email);
                user.Show();
                this.Close();
            }
            else
            {
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
        }
    }
}
