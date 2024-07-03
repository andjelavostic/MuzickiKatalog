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
    /// Interaction logic for ArtistView.xaml
    /// </summary>
    public partial class ArtistView : Window
    {
        private Izvodjac izvodjac;
        public ArtistView(Izvodjac i)
        {
            InitializeComponent();
            this.izvodjac = i;
            if (izvodjac != null)
            {
             
                string description = $"Ime: {izvodjac.Ime}\nPrezime: {izvodjac.Prezime}\nOpis: {izvodjac.Slika}\nZanrovi: ";

                foreach (Zanr zanr in izvodjac.Zanrovi)
                {
                    description += $"{zanr.Naziv}, ";
                }

                if (izvodjac.Zanrovi.Count > 0)
                {
                    description = description.Substring(0, description.Length - 2);
                }

                DesctiptionTextBlock.Text = description;
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
