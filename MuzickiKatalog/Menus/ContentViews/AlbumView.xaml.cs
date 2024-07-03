using MuzickiKatalog.Infrastructure.Service;
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
    /// Interaction logic for AlbumView.xaml
    /// </summary>
    public partial class AlbumView : Window
    {
        private Album album;
        private Korisnik korisnik;
        private RecenzijaService recenzijaService;
        // za testiranje
        private UrednikService urednikService;
        public AlbumView(Album a, Korisnik k)
        {
            InitializeComponent();
            this.album = a;
            this.korisnik = k;
            this.recenzijaService = new RecenzijaService();
            // za testiranje
            /*this.urednikService = new UrednikService();
            foreach(Urednik urednik in urednikService.GetAll())
            {
                if (urednik.Email.Equals("ana.anic@gmail.com"))
                {
                    korisnik = urednik;
                    //MessageBox.Show("nasli smo " + k.Ime, "evo");
                    break;
                }
            }*/
            if (album != null)
            {

                string description = $"Naziv: {album.Naziv}\nOpis: {album.Opis}\nZanrovi: ";
                foreach (Zanr zanr in album.Zanrovi)
                {
                    description += $"{zanr.Naziv}, ";
                }

                if (album.Zanrovi.Count > 0)
                {
                    description = description.Substring(0, description.Length - 2);
                }
                description += "\n Numere: ";
                foreach(Numera n in album.Numere)
                {
                    description += $"{n.Naziv}, ";
                }
                if(album.Numere.Count > 0)
                {
                    description = description.Substring(0, description.Length - 2);
                }

                DesctiptionTextBlock.Text = description;
            }

            // ucitavanje numera sa albuma u dataGrid
            foreach (Numera n in album.Numere)
            {
                tracksDataGrid.Items.Add(new TableData(n));
            }

            // ucitavanje mogucih ocena u comboBox
            for (int i = 0; i < 5; i++)
            {
                ratingComboBox.Items.Add(i+1);
            }

            // ucitavanje postojece recenzije za ulogovanog korisnika
            if (korisnik != null)
            {
                Recenzija existingReview = recenzijaService.GetRecenzijaById(korisnik.Email, album.Id);
                if (existingReview != null)
                {
                    FlowDocument document = new FlowDocument();
                    Paragraph paragraph = new Paragraph(new Run(existingReview.Komentar));
                    document.Blocks.Add(paragraph);
                    reviewTextBox.Document = document;
                }
            }

            // ucitavanje urednikove recenzije
            Recenzija editorsReview = recenzijaService.GetEditorsReviewForContent(album.Id);
            if (editorsReview == null)
            {
                editorsReviewTextBlock.Text = "N/A";
            }
            else
            {
                editorsReviewTextBlock.Text = editorsReview.Komentar;
            }
        }

        public class TableData
        {
            public int Id { get; set; }
            public string naziv { get; set; }
            public List<Zanr> zanrovi { get; set; }

            public TableData(Izvodjac i)
            {
                Id = i.Id;
                naziv = i.Ime + " " + i.Prezime;
                zanrovi = i.Zanrovi;
            }
            public TableData(Album a)
            {
                Id = a.Id;
                naziv = a.Naziv;
                zanrovi = a.Zanrovi;
            }
            public TableData(Numera n)
            {
                Id = n.Id;
                naziv = n.Naziv;
                zanrovi = n.Zanrovi;
            }
            public TableData(Grupa g)
            {
                Id = g.Id;
                naziv = g.Naziv;
                zanrovi = g.Zanrovi;
            }
        }

        private string GetTextFromRichTextBox(RichTextBox richTextBox)
        {
            TextRange textRange = new TextRange(richTextBox.Document.ContentStart, richTextBox.Document.ContentEnd);
            return textRange.Text;
        }

        private void reviewButton_Click(object sender, RoutedEventArgs e)
        {
            if (korisnik == null)
            {
                MessageBox.Show("Registrujte se ukoliko zelite da ostavite recenziju.");
            }
            else
            {
                Recenzija existingReview = recenzijaService.GetRecenzijaById(korisnik.Email, album.Id);
                if (existingReview!=null)
                {
                    MessageBox.Show("Vec ste ostavili recenziju za ovaj album, kontaktirajte administratora.");
                }
                else
                {
                    string review = GetTextFromRichTextBox(reviewTextBox);
                    recenzijaService.AddRecenzija(review, album.Id, korisnik.Email);
                    MessageBox.Show("Uspesno ste ostavili recenziju");
                }
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }
    }
}
