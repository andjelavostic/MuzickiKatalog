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
    /// Interaction logic for GenreEntry.xaml
    /// </summary>
    public partial class GenreEntry : Window
    {
        private ZanrService zanrService;
        private GlobalID idCounter;
        public GenreEntry()
        {
            InitializeComponent();
            zanrService=new ZanrService();
            idCounter = new GlobalID();
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (nameText.Text != "")
            {
                List<Zanr> zanrovi = zanrService.GetAll();
                bool postoji = zanrovi.Any(z => z.Naziv == nameText.Text);
                if (!postoji)
                {
                    Zanr zanr = new Zanr(idCounter.NextId(), nameText.Text);
                    zanrService.AddZanr(zanr);
                    MessageBox.Show("Uspesno dodat zanr!");
                }
                else
                {
                    MessageBox.Show("Vec postoji taj zanr");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Popuni naziv zanra!");
            }
        }
    }
}
