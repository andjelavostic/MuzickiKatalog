using MuzickiKatalog.Infrastructure.Service;
using MuzickiKatalog.Models;
using MuzickiKatalog.Models.Items;
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
    /// Interaction logic for ArtistEntry.xaml
    /// </summary>
    public partial class ArtistEntry : Window
    {
        private GlobalID idCounter;
        private ZanrService zanroviService;
        private IzvodjacService izvodjacService;
        private string id;
        public ArtistEntry(string id)
        {
            InitializeComponent();
            idCounter = new GlobalID();
            zanroviService = new ZanrService();
            izvodjacService = new IzvodjacService();
            this.id = id;
            List<Zanr> z = zanroviService.GetAll();
            foreach (Zanr zz in z)
            {
                genreChoice.Items.Add(zz.Naziv);
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (description.Text != "" && nameText.Text != "" && lastNameText.Text != "" && genreChoice.SelectedItems.Count != 0 && imageText.Text!="")
            {
                List<Zanr> zanrovi = new List<Zanr>();
                foreach (var item in genreChoice.SelectedItems)
                {
                    zanrovi.Add(zanroviService.FindZanr(item.ToString()));
                }
                Izvodjac izvodjac = new Izvodjac(idCounter.NextId(), description.Text,imageText.Text, new Ocena(), new List<Ocena>(),
                    nameText.Text, lastNameText.Text, zanrovi, id);
                izvodjacService.AddIzvodjac(izvodjac);
                MessageBox.Show("Uspesno dodat izvodjac!");
            }
            else
            {
                MessageBox.Show("Unesi ispravne podatke, izaberi zanr!");
            }
        }
    }
}
