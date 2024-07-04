using MuzickiKatalog.Menus.ContentViews;
using MuzickiKatalog.Menus.ContentViews.EditorMenus;
using MuzickiKatalog.Menus.UserMenus.UserViews;
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
    /// Interaction logic for EditorMenu.xaml
    /// </summary>
    public partial class EditorMenu : Window
    {
        private string idEditor;
        public EditorMenu(string idEditor)
        {
            InitializeComponent();
            this.idEditor = idEditor;
        }

        private void addTrack_Click(object sender, RoutedEventArgs e)
        {
            TrackInput track = new TrackInput(idEditor);
            track.Show();
        }

        private void addAlbum_Click(object sender, RoutedEventArgs e)
        {
            AlbumInput album = new AlbumInput(idEditor);
            album.Show();
        }

        private void addBand_Click(object sender, RoutedEventArgs e)
        {
            BandInput band = new BandInput(idEditor);
            band.Show();
        }

        private void addArtist_Click(object sender, RoutedEventArgs e)
        {
            ArtistInput artist = new ArtistInput(idEditor);
            artist.Show();
        }

        private void backButton_Click(object sender, RoutedEventArgs e)
        {
            UserMenu userMenu = new UserMenu(idEditor,"UREDNIK");
            userMenu.Show();
            this.Close();
        }
    }
}
