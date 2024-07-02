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
    /// Interaction logic for TrackEntry.xaml
    /// </summary>
    public partial class TrackEntry : Window
    {
        private GlobalID idCounter;
        private ZanrService zanroviService;
        public TrackEntry()
        {
            InitializeComponent();
            idCounter = new GlobalID();
            zanroviService = new ZanrService();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            List<Zanr> zanrovi = new List<Zanr>();
            foreach (var item in zanrText.SelectedItems)
            {
                zanrovi.Add(zanroviService.FindZanr(item.ToString()));
            }
            if(opisText.Text!="" && nazivText.Text!="" && trajanjeText.Text!="" && zanrText.SelectedItems.Count!=0){
                Numera numera = new Numera(idCounter.NextId(), opisText.Text, slikaText.Text, new Ocena(), new List<Ocena>(), Double.Parse(trajanjeText.Text), DateTime.Now, zanrovi, nazivText.Text);
                MessageBox.Show("Uspesno dodata numera!");
            }
            else
            {
                MessageBox.Show("Popuni sva polja i izaberi zanr,album i izvodjaca!");
            }
    }
    }
}
