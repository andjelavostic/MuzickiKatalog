using MuzickiKatalog.Infrastructure.Service;
using MuzickiKatalog.Models;
using MuzickiKatalog.Models.Items;
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

namespace MuzickiKatalog.Menus.ContentViews
{
    /// <summary>
    /// Interaction logic for AlbumEntry.xaml
    /// </summary>
    public partial class AlbumEntry : Window
    {
        private ZanrService zanroviService;
        private IzvodjacService izvodjacService;
        private GrupaService grupaService;
        private NumeraService numeraService;
        private AlbumService albumService;
        private AddAlbumModelView mv;
        private string id;
        public AlbumEntry(string id)
        {
            InitializeComponent();
            zanroviService = new ZanrService();
            izvodjacService = new IzvodjacService();
            grupaService = new GrupaService();
            numeraService = new NumeraService();
            albumService = new AlbumService();
            mv = new AddAlbumModelView(id);
            this.id = id;
            List<Zanr> z = zanroviService.GetAll();
            foreach (Zanr zz in z)
            {
                chooseGenreList.Items.Add(zz.Naziv);
            }
            List<Izvodjac> izv = izvodjacService.GetAll();
            foreach (Izvodjac iz in izv)
            {
                artistCombo.Items.Add(iz.Id + " " + iz.Ime + " " + iz.Prezime);
            }
            List<Grupa> grupa=grupaService.GetAll();
            foreach(Grupa g in grupa)
            {
                artistCombo.Items.Add(g.Id + " " + g.Naziv);
            }
            tipCombo.ItemsSource = Enum.GetValues(typeof(TipAlbuma));

        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            //Numere se opciono dodaju na pocetku, mogu kasnije
            if (nazivAlbumaText.Text != "" && opisText.Text != "" && artistCombo.SelectedItem != null && tipCombo.SelectedItem != null
                && imageLinkText.Text != "" && izdavackaText.Text != "" && chooseGenreList.SelectedItems.Count != 0)
            {
                string naziv = nazivAlbumaText.Text;
                string opis = opisText.Text;
                string img = imageLinkText.Text;
                string izdavacka = izdavackaText.Text;
                TipAlbuma tip = (TipAlbuma)Enum.Parse(typeof(TipAlbuma), tipCombo.SelectedItem.ToString());
                List <Zanr> zanrovi = new List<Zanr>();
                foreach (var item in chooseGenreList.SelectedItems)
                {
                    zanrovi.Add(zanroviService.FindZanr(item.ToString()));
                }
                List<Numera> numere = new List<Numera>();
                foreach (var item in trackChoiceList.SelectedItems)
                {
                    numere.Add(numeraService.FindNumera(int.Parse(item.ToString().Split(" ")[0])));
                }
                string izvodjac = artistCombo.SelectedItem.ToString();
                int idIzvodjaca = int.Parse(izvodjac.Split(" ")[0]);
                bool uspeh = mv.AddAlbumAdmin(opis, img, numere, tip, izdavacka, zanrovi, naziv, idIzvodjaca);
                if (uspeh)
                    MessageBox.Show("Uspesno dodat album!");
                else
                    MessageBox.Show("Neuspeh!");
            }
            else
            {
                MessageBox.Show("Unesi sve potrebne podatke i izaberi izvodjaca,tip albuma,zanr!");
            }
        }

        private void artistCombo_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            trackChoiceList.Items.Clear();
            List<Numera> nums = numeraService.GetAll();
            foreach (Numera num in nums)
            {
                string izvodjac = artistCombo.SelectedItem.ToString();
                int idIzvodjaca = int.Parse(izvodjac.Split(" ")[0]);
                if (num.IzvodjacId==idIzvodjaca)
                    trackChoiceList.Items.Add(num.Id + " " + num.Naziv);
            }
        }
    }
}
