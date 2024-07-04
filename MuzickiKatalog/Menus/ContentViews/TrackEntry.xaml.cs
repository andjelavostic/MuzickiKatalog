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
    /// Interaction logic for TrackEntry.xaml
    /// </summary>
    public partial class TrackEntry : Window
    {
        private GlobalID idCounter;
        private ZanrService zanroviService;
        private IzvodjacService izvodjacService;
        private GrupaService grupaService;
        private NumeraService numeraService;
        private AddTrackModelView mv;
        private string id;
        public TrackEntry(string id)
        {
            InitializeComponent();
            idCounter = new GlobalID();
            zanroviService = new ZanrService();
            izvodjacService = new IzvodjacService();
            grupaService = new GrupaService();
            numeraService = new NumeraService();
            mv = new AddTrackModelView(id);
            this.id = id;
            List<Zanr> z=zanroviService.GetAll();
            foreach(Zanr zz in z)
            {
                zanrText.Items.Add(zz.Naziv);
            }
            List<Izvodjac> izv = izvodjacService.GetAll();
            foreach(Izvodjac iz in izv)
            {
                izvodjacText.Items.Add(iz.Id + " " + iz.Ime + " " + iz.Prezime);
            }
            List<Grupa> grupa = grupaService.GetAll();
            foreach (Grupa g in grupa)
            {
                izvodjacText.Items.Add(g.Id + " " + g.Naziv);
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if(opisText.Text!="" && nazivText.Text!="" && slikaText.Text!="" && trajanjeText.Text!="" && zanrText.SelectedItems.Count!=0 && izvodjacText.SelectedItem!=null){
                string opis = opisText.Text;
                string naziv = nazivText.Text;
                string slika = slikaText.Text;
                string izvodjac= izvodjacText.SelectedItem.ToString();
                int idIzvodjaca = int.Parse(izvodjac.Split(" ")[0]);
                List<Zanr> zanrovi = new List<Zanr>();
                foreach (var item in zanrText.SelectedItems)
                {
                    zanrovi.Add(zanroviService.FindZanr(item.ToString()));
                }
                double parsedValue;
                if (!Double.TryParse(trajanjeText.Text,out parsedValue))
                {
                    MessageBox.Show("Unesi trajanje kao decimalni broj!");
                    return;
                }
                bool uspeh=mv.AddTrackAdmin(naziv, opis,slika, parsedValue, idIzvodjaca, zanrovi);
                if (uspeh)
                    MessageBox.Show("Uspesno dodata numera!");
                else
                    MessageBox.Show("Neuspesno!");
            }
            else
            {
                MessageBox.Show("Popuni sva polja i izaberi zanr,album i izvodjaca!");
            }
    }
    }
}
