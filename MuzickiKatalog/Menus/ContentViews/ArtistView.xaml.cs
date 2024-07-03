using MuzickiKatalog.Infrastructure.Service;
using MuzickiKatalog.Menus.UserMenus.UserViews;
using MuzickiKatalog.Models;
using MuzickiKatalog.Models.Items;
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
using System.Windows.Media.Media3D;
using System.Windows.Shapes;

namespace MuzickiKatalog.Menus.ContentViews
{
    /// <summary>
    /// Interaction logic for ArtistView.xaml
    /// </summary>
    public partial class ArtistView : Window
    {
        private Izvodjac izvodjac;
        private Korisnik korisnik;
        private GlobalID globalId;
        private IzvodjacService izvodjacService;
        private RecenzijaService recenzijaService;
        private string userRole;
        public ArtistView(Izvodjac i,Korisnik k,string role)
        {
            InitializeComponent();
            this.izvodjac = i;
            this.korisnik = k;
            this.userRole = role;
            this.korisnik = k;
            this.globalId = new GlobalID();
            this.izvodjacService = new IzvodjacService();
            this.recenzijaService = new RecenzijaService();
            
            if (izvodjac != null)
            {
             
                string description = $"Ime: {izvodjac.Ime}\nPrezime: {izvodjac.Prezime}\nOpis: {izvodjac.Opis}\nZanrovi: ";

                foreach (Zanr zanr in izvodjac.Zanrovi)
                {
                    description += $"{zanr.Naziv}, ";
                }

                if (izvodjac.Zanrovi.Count > 0)
                {
                    description = description.Substring(0, description.Length - 2);
                }

                DesctiptionTextBlock.Text = description;
            }

            // ucitavanje mogucih ocena u comboBox
            for (int j = 0; j < 5; j++)
            {
                ratingComboBox.Items.Add(j + 1);
            }

            // ucitavanje postojece recenzije za ulogovanog korisnika
            if (korisnik != null)
            {
                Recenzija existingReview = recenzijaService.GetRecenzijaById(korisnik.Email, izvodjac.Id);
                if (existingReview != null)
                {
                    FlowDocument document = new FlowDocument();
                    Paragraph paragraph = new Paragraph(new Run(existingReview.Komentar));
                    document.Blocks.Add(paragraph);
                    reviewTextBox.Document = document;
                }
            }

            // ucitavanje urednikove recenzije
            Recenzija editorsReview = recenzijaService.GetEditorsReviewForContent(izvodjac.Id);
            if (editorsReview == null)
            {
                editorsReviewTextBlock.Text = "N/A";
            }
            else
            {
                editorsReviewTextBlock.Text = editorsReview.Komentar;
            }

            // ucitavanje postojece ocene korisnika
            if (korisnik != null)
            {
                if (userRole.Equals("UREDNIK") && izvodjac.OcenaUrednika.Korisnik != null)
                {
                    ratingComboBox.SelectedIndex = izvodjac.OcenaUrednika.Vrednost - 1;
                }
                else if (izvodjac.OceneKorisnika.Count > 0)
                {
                    foreach (Ocena ocena in izvodjac.OceneKorisnika)
                    {
                        if (ocena.Korisnik.Equals(korisnik.Email))
                        {
                            ratingComboBox.SelectedIndex = ocena.Vrednost - 1;
                            break;
                        }
                    }
                }
                    
            }

            // ucitavanje urednikove ocene
            if (izvodjac.OcenaUrednika.Korisnik == null)
                editorsRatingLabel.Content += " N/A";
            else
                editorsRatingLabel.Content += izvodjac.OcenaUrednika.Vrednost.ToString() + "/5";

            // ucitavanje ocena korisnika
            if (izvodjac.OceneKorisnika.Count == 0)
                userRatingLabel.Content += " N/A";
            else
            {
                double sumOfRatings = 0;
                foreach (Ocena ocena in izvodjac.OceneKorisnika)
                {
                    sumOfRatings += ocena.Vrednost;
                }
                userRatingLabel.Content += (sumOfRatings / izvodjac.OceneKorisnika.Count).ToString() + "/5";
            }
        }

        private string GetTextFromRichTextBox(RichTextBox richTextBox)
        {
            TextRange textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            return textRange.Text;
        }

        private void reviewButton_Click(object sender, RoutedEventArgs e)
        {
            Recenzija editorsReview = recenzijaService.GetEditorsReviewForContent(izvodjac.Id);
            if (korisnik == null)
            {
                MessageBox.Show("Registrujte se ukoliko zelite da ostavite recenziju.");
            }
            else if (userRole.Equals("UREDNIK") && editorsReview != null)
            {
                MessageBox.Show("Vec postoji ocena urednika");
            }
            else
            {
                Recenzija existingReview = recenzijaService.GetRecenzijaById(korisnik.Email, izvodjac.Id);
                if (existingReview != null)
                {
                    MessageBox.Show("Vec ste ostavili recenziju za ovog izvodjaca, kontaktirajte administratora.");
                }
                else
                {
                    string review = GetTextFromRichTextBox(reviewTextBox);
                    Recenzija newReview = new Recenzija(globalId.NextId(), review, izvodjac.Id, korisnik.Email);
                    recenzijaService.AddRecenzija(newReview);
                    MessageBox.Show("Uspesno ste ostavili recenziju");
                }
            }
        }

        private void ratingButton_Click(object sender, RoutedEventArgs e)
        {
            if (korisnik == null)
            {
                MessageBox.Show("Registrujte se ukoliko zelite da ostavite ocenu.");
            }
            else if (userRole.Equals("UREDNIK") && izvodjac.OcenaUrednika.Korisnik != null)
            {
                MessageBox.Show("Vec postoji ocena urednika");
            }
            else
            {
                int rating = (int)ratingComboBox.SelectedItem;
                if (userRole.Equals("UREDNIK"))
                {
                    Ocena newRating = new Ocena();
                    newRating.Id = globalId.NextId();
                    newRating.Vrednost = rating;
                    newRating.Korisnik = korisnik.Email;
                    izvodjacService.AddEditorsRating(izvodjac.Id, newRating);
                    MessageBox.Show("Uspesno ste ocenili izvodjaca!");
                }
                else
                {
                    bool hasUserRated = false;
                    foreach (Ocena ocena in izvodjac.OceneKorisnika)
                    {
                        if (ocena.Korisnik.Equals(korisnik.Email))
                        {
                            hasUserRated = true;
                            break;
                        }
                    }
                    if (hasUserRated)
                    {
                        MessageBox.Show("Vec ste ocenili izvodjaca!");
                    }
                    else
                    {
                        Ocena newRating = new Ocena();
                        newRating.Id = globalId.NextId();
                        newRating.Vrednost = rating;
                        newRating.Korisnik = korisnik.Email;
                        izvodjacService.AddUsersRating(izvodjac.Id, newRating);
                        MessageBox.Show("Uspesno ste ocenili numeru!");
                    }
                }
            }
        }

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
