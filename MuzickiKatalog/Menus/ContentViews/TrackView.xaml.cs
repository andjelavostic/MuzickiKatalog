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
using System.Windows.Shapes;

namespace MuzickiKatalog.Menus.ContentViews
{
    /// <summary>
    /// Interaction logic for TrackView.xaml
    /// </summary>
    public partial class TrackView : Window
    {
        private Numera numera;
        private Korisnik korisnik;
        private RecenzijaService recenzijaService;
        private NumeraService numeraService;
        private string userRole;
        private GlobalID globalId;
        public TrackView(Numera n, Korisnik k, string userRole)
        {
            InitializeComponent();
            this.numera = n;
            this.korisnik = k;
            this.userRole = userRole;
            this.globalId = new GlobalID();
            this.numeraService = new NumeraService();
            this.recenzijaService = new RecenzijaService();
            // testiranje

            if (numera != null)
            {

                string description = $"Naziv: {numera.Naziv}\nOpis: {numera.Opis}\nZanrovi: ";

                foreach (Zanr zanr in numera.Zanrovi)
                {
                    description += $"{zanr.Naziv}, ";
                }

                if (numera.Zanrovi.Count > 0)
                {
                    description = description.Substring(0, description.Length - 2);
                }

                DesctiptionTextBlock.Text = description;
            }

            // ucitavanje mogucih ocena u comboBox
            for (int i = 0; i < 5; i++)
            {
                ratingComboBox.Items.Add(i + 1);
            }

            // ucitavanje postojece recenzije za ulogovanog korisnika
            if (korisnik != null)
            {
                Recenzija existingReview = recenzijaService.GetRecenzijaById(korisnik.Email, numera.Id);
                if (existingReview != null)
                {
                    FlowDocument document = new FlowDocument();
                    Paragraph paragraph = new Paragraph(new Run(existingReview.Komentar));
                    document.Blocks.Add(paragraph);
                    reviewTextBox.Document = document;
                }
            }

            // ucitavanje urednikove recenzije
            Recenzija editorsReview = recenzijaService.GetEditorsReviewForContent(numera.Id);
            if (editorsReview == null)
            {
                editorsReviewTextBlock.Text = "N/A";
            }
            else
            {
                editorsReviewTextBlock.Text = editorsReview.Komentar;
            }

            // ucitavanje urednikove ocene
            if (numera.OcenaUrednika.Korisnik == null)
                editorsRatingLabel.Content += " N/A";
            else
                editorsRatingLabel.Content += numera.OcenaUrednika.Vrednost.ToString() + "/5";

            // ucitavanje ocena korisnika
            if (numera.OceneKorisnika.Count == 0)
                userRatingLabel.Content += " N/A";
            else
            {
                double sumOfRatings = 0;
                foreach (Ocena ocena in numera.OceneKorisnika)
                {
                    sumOfRatings += ocena.Vrednost;
                }
                userRatingLabel.Content += (sumOfRatings / numera.OceneKorisnika.Count).ToString() + "/5";
            }
        }
        private string GetTextFromRichTextBox(RichTextBox richTextBox)
        {
            TextRange textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            return textRange.Text;
        }
        private void reviewButton_Click(object sender, RoutedEventArgs e)
        {
            Recenzija editorsReview = recenzijaService.GetEditorsReviewForContent(numera.Id);
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
                Recenzija existingReview = recenzijaService.GetRecenzijaById(korisnik.Email, numera.Id);
                if (existingReview != null)
                {
                    MessageBox.Show("Vec ste ostavili recenziju za ovu numeru, kontaktirajte administratora.");
                }
                else
                {
                    string review = GetTextFromRichTextBox(reviewTextBox);
                    Recenzija newReview = new Recenzija(globalId.NextId(), review, numera.Id, korisnik.Email);
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
            else if (userRole.Equals("UREDNIK") && numera.OcenaUrednika.Korisnik != null)
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
                    numeraService.AddEditorsRating(numera.Id, newRating);
                    MessageBox.Show("Uspesno ste ocenili numeru!");
                }
                else
                {
                    bool hasUserRated = false;
                    foreach (Ocena ocena in numera.OceneKorisnika)
                    {
                        if (ocena.Korisnik.Equals(korisnik.Email))
                        {
                            hasUserRated = true;
                            break;
                        }
                    }
                    if (hasUserRated)
                    {
                        MessageBox.Show("Vec ste ocenili numeru!");
                    }
                    else
                    {
                        Ocena newRating = new Ocena();
                        newRating.Id = globalId.NextId();
                        newRating.Vrednost = rating;
                        newRating.Korisnik = korisnik.Email;
                        numeraService.AddUsersRating(numera.Id, newRating);
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