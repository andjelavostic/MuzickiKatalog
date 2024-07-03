using MuzickiKatalog.Infrastructure.Service;
using MuzickiKatalog.Menus.ContentViews;
using MuzickiKatalog.Models.Items;
using MuzickiKatalog.Models.Users;
using MuzickiKatalog.ModelViews;
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

namespace MuzickiKatalog.Menus.UserMenus.UserViews
{
    /// <summary>
    /// Interaction logic for UserMenu.xaml
    /// </summary>
    public partial class UserMenu : Window
    {
        private RegistrovanKorisnikService rkS;
        private AlbumService aS;
        private NumeraService nS;
        private GrupaService gS;
        private IzvodjacService iS;
        private SearchModelView sMV;
        private string userId;
        private List<TableData> data = new List<TableData>();
        public UserMenu(string userId)
        {
            InitializeComponent();
            this.rkS = new RegistrovanKorisnikService();
            this.aS = new AlbumService();
            this.nS = new NumeraService();
            this.gS = new GrupaService();
            this.iS = new IzvodjacService();
            this.sMV = new SearchModelView();
            this.userId= userId;
            emailText.Content = userId;
        }

        private void logoutButon_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
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

        private void searchButton_Click(object sender, RoutedEventArgs e)
        {
            data.Clear();
            string input = SearchBox.Text;
            List<Izvodjac> izvodjaci = sMV.SearchIzvodjaci(input, iS);
            List<Numera> numere = sMV.SearchNumere(input, nS);
            List<Album> albumi = sMV.SearchAlbumi(input, aS);
            List<Grupa> grupe = sMV.SearchGrupe(input, gS);
            foreach (Izvodjac i in izvodjaci)
            {
                data.Add(new TableData(i));
            }
            foreach (Numera n in numere)
            {
                data.Add(new TableData(n));
            }
            foreach (Album a in albumi)
            {
                data.Add(new TableData(a));
            }
            foreach (Grupa g in grupe)
            {
                data.Add(new TableData(g));
            }
            tableDataGrid.ItemsSource = null;
            tableDataGrid.ItemsSource = data;
            tableDataGrid.Visibility = Visibility.Visible;

        }
        private void tableDataGrid_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            int i = 0;
            Korisnik k = rkS.GetById(userId);
            if (tableDataGrid.SelectedItem != null)
            {
                TableData selectedRow = (TableData)tableDataGrid.SelectedItem;
                int id = selectedRow.Id;
                var objekat = sMV.SearchObject(id, aS, gS, iS, nS);
                if (sMV.SearchIzvodjac(id, iS))
                {
                    ArtistView artistView = new ArtistView(iS.GetByID(id),k,"korisnik");
                    artistView.Show();
                    this.Close();
                }
                else if (sMV.SearchNumera(id, nS))
                {
                    TrackView trackView = new TrackView(nS.GetByID(id), k, "korisnik");
                    trackView.Show();
                    this.Close();
                }
                else if (sMV.SearchAlbum(id, aS))
                {
                    AlbumView albumView = new AlbumView(aS.GetByID(id), k, "korisnik");
                    albumView.Show();
                    this.Close();
                }
            }
        }
    }
}
