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
    /// Interaction logic for BandEntry.xaml
    /// </summary>
    public partial class BandEntry : Window
    {
        private ZanrService zanroviService;
        private IzvodjacService izvodjacService;
        private AddBandModelView mv;
        private string id;
        public BandEntry(string id)
        {
            InitializeComponent();
            zanroviService = new ZanrService();
            izvodjacService = new IzvodjacService();
            mv = new AddBandModelView(id);
            this.id = id;
            List<Zanr> z = zanroviService.GetAll();
            foreach (Zanr zz in z)
            {
                genreChoice.Items.Add(zz.Naziv);
            }
            List<Izvodjac> izv = izvodjacService.GetAll();
            foreach (Izvodjac iz in izv)
            {
                artistsChoice.Items.Add(iz.Id + " " + iz.Ime + " " + iz.Prezime);
            }

        }

        private void addButton_Click(object sender, RoutedEventArgs e) { 
            //Izvodjaci opciono, moze kasnije da se dodaje
            if (description.Text != "" && nameText.Text != "" && genreChoice.SelectedItems.Count != 0 
                && imageText.Text!="" && dateOfFound.SelectedDate.HasValue && dateOfFound.SelectedDate<DateTime.Now)
            {
                string opis = description.Text;
                string naziv = nameText.Text;
                string img = imageText.Text;
                List<Zanr> zanrovi = new List<Zanr>();
                foreach (var item in genreChoice.SelectedItems)
                {
                    zanrovi.Add(zanroviService.FindZanr(item.ToString()));
                }
                List<Izvodjac> izvodjaci = new List<Izvodjac>();
                foreach(var item in artistsChoice.SelectedItems)
                {
                    izvodjaci.Add(izvodjacService.GetByID(int.Parse(item.ToString().Split(" ")[0])));
                }
                DateTime? selectedDate = dateOfFound.SelectedDate;
                DateTime dateTimeWithTime = new DateTime(
                    selectedDate.Value.Year,    // Godina
                    selectedDate.Value.Month,   // Mesec
                    selectedDate.Value.Day,     // Dan
                    0, 0, 0);
                bool uspeh = mv.AddBandAdmin(opis, naziv, img, zanrovi, dateTimeWithTime, izvodjaci);
                if (uspeh)
                    MessageBox.Show("Uspesno dodata grupa!");
                else
                    MessageBox.Show("Neuspesno!");
            }
            else
            {
                MessageBox.Show("Unesi ispravne podatke, datum osnivanja u proslosti, izaberi zanr!");
            }

        }
    }
}
