using MuzickiKatalog.Menus.ContentViews;
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

namespace MuzickiKatalog
{
    /// <summary>
    /// Interaction logic for AdminMenu.xaml
    /// </summary>
    public partial class AdminMenu : Window
    {
        private string adminId;
        public AdminMenu(string adminId)
        {
            InitializeComponent();
            this.adminId = adminId;
        }

        private void addTrackButton_Click(object sender, RoutedEventArgs e)
        {
            TrackEntry track = new TrackEntry(adminId);
            track.Show();
        }

        private void addAlbumButton_Click(object sender, RoutedEventArgs e)
        {
            AlbumEntry album = new AlbumEntry(adminId);
            album.Show();
        }

        private void addArtistButton_Click(object sender, RoutedEventArgs e)
        {
            ArtistEntry artist = new ArtistEntry(adminId);
            artist.Show();

        }

        private void addBandButton_Click(object sender, RoutedEventArgs e)
        {
            BandEntry band = new BandEntry(adminId);
            band.Show();
        }

        private void addGenre_Click(object sender, RoutedEventArgs e)
        {
            GenreEntry genre = new GenreEntry();
            genre.Show();
        }
    }
}
