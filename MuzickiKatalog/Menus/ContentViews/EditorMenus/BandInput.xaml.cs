using MuzickiKatalog.Infrastructure.Service;
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

namespace MuzickiKatalog.Menus.ContentViews.EditorMenus
{
    /// <summary>
    /// Interaction logic for BandInput.xaml
    /// </summary>
    public partial class BandInput : Window
    {
        private string editorId;
        private ZanrService zanroviService;
        private IzvodjacService izvodjacService;
        private AddBandModelView mv;
        public BandInput(string editorId)
        {
            InitializeComponent();
            this.editorId = editorId;
            zanroviService = new ZanrService();
            izvodjacService = new IzvodjacService();
            mv = new AddBandModelView(editorId);
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
            List<int> ocene = new List<int> { 1, 2, 3, 4, 5 };
            gradeCombo.ItemsSource = ocene;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            //Izvodjaci opciono, moze kasnije da se dodaje
            if (description.Text != "" && nameText.Text != "" && genreChoice.SelectedItems.Count != 0
                && imageText.Text != "" && dateOfFound.SelectedDate.HasValue && 
                dateOfFound.SelectedDate < DateTime.Now && reviewText.Text!="" && gradeCombo.SelectedItem!=null)
            {
                string opis = description.Text;
                string naziv = nameText.Text;
                string img = imageText.Text;
                string review = reviewText.Text;
                int grade = int.Parse(gradeCombo.SelectedItem.ToString());
                List<Zanr> zanrovi = new List<Zanr>();
                foreach (var item in genreChoice.SelectedItems)
                {
                    zanrovi.Add(zanroviService.FindZanr(item.ToString()));
                }
                List<Izvodjac> izvodjaci = new List<Izvodjac>();
                foreach (var item in artistsChoice.SelectedItems)
                {
                    izvodjaci.Add(izvodjacService.GetByID(int.Parse(item.ToString().Split(" ")[0])));
                }
                DateTime? selectedDate = dateOfFound.SelectedDate;
                DateTime dateTimeWithTime = new DateTime(
                    selectedDate.Value.Year,    // Godina
                    selectedDate.Value.Month,   // Mesec
                    selectedDate.Value.Day,     // Dan
                    0, 0, 0);
                bool uspeh = mv.AddBandEditor(opis, naziv, img, zanrovi, dateTimeWithTime, izvodjaci,review,grade);
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
