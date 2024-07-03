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
    /// Interaction logic for AlbumView.xaml
    /// </summary>
    public partial class AlbumView : Window
    {
        private Album album;
        public AlbumView(Album a)
        {
            InitializeComponent();
            this.album = a;
            if (album != null)
            {

                string description = $"Naziv: {album.Naziv}\nOpis: {album.Opis}\nZanrovi: ";
                foreach (Zanr zanr in album.Zanrovi)
                {
                    description += $"{zanr.Naziv}, ";
                }

                if (album.Zanrovi.Count > 0)
                {
                    description = description.Substring(0, description.Length - 2);
                }
                description += "\n Numere: ";
                foreach(Numera n in album.Numere)
                {
                    description += $"{n.Naziv}, ";
                }
                if(album.Numere.Count > 0)
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
