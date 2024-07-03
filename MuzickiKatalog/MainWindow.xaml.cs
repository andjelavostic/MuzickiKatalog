using MuzickiKatalog.Infrastructure.Service;
using MuzickiKatalog.Menus.ContentViews;
using MuzickiKatalog.Models.Items;
using MuzickiKatalog.ModelViews;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MuzickiKatalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RegistrovanKorisnikService rkS;
        private AlbumService aS;
        private NumeraService nS;
        private GrupaService gS;
        private IzvodjacService iS;
        private SearchModelView sMV;
        private List<TableData> data = new List<TableData>();
        public MainWindow()
        {
            InitializeComponent();
            this.rkS = new RegistrovanKorisnikService();
            this.aS = new AlbumService();
            this.nS = new NumeraService();
            this.gS = new GrupaService();
            this.iS = new IzvodjacService();
            this.sMV = new SearchModelView();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register(rkS);
            register.Show();
            this.Close();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Close();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            data.Clear();
            string input = SearchBox.Text;
            List<Izvodjac> izvodjaci = sMV.SearchIzvodjaci(input, iS);
            List<Numera> numere = sMV.SearchNumere(input, nS);
            List<Album> albumi = sMV.SearchAlbumi(input, aS);
            List<Grupa> grupe = sMV.SearchGrupe(input, gS);
            foreach(Izvodjac i in izvodjaci)
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

        private void tableDataGrid_MouseDoubleClick_1(object sender, MouseButtonEventArgs e)
        {
            int i = 0;
            if (tableDataGrid.SelectedItem != null)
            {
                TableData selectedRow = (TableData)tableDataGrid.SelectedItem;
                int id = selectedRow.Id;
                var objekat = sMV.SearchObject(id, aS, gS, iS, nS);
                if (sMV.SearchIzvodjac(id, iS))
                {
                    ArtistView artistView = new ArtistView(iS.GetByID(id), null, "");
                    artistView.Show();
                    this.Close();
                }
                else if (sMV.SearchNumera(id, nS))
                {
                    TrackView trackView = new TrackView(nS.GetByID(id), null, "");
                    trackView.Show();
                    this.Close();
                }
                else if (sMV.SearchAlbum(id, aS))
                {
                    AlbumView albumView = new AlbumView(aS.GetByID(id), null, "");
                    albumView.Show();
                    this.Close();
                }
                else if (sMV.SearchGrupa(id, gS))
                {
                    BandView bandView = new BandView(gS.GetByID(id), null, "");
                    bandView.Show();
                    this.Close();
                }



            }
        }
    }
}