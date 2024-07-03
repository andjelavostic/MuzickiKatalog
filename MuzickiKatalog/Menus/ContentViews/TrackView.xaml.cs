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
    /// Interaction logic for TrackView.xaml
    /// </summary>
    public partial class TrackView : Window
    {
        private Numera numera;
        public TrackView(Numera n)
        {
            InitializeComponent();
            this.numera = n;
            if (numera != null)
            {

                string description = $"Naziv: {numera.Naziv}\nOpis: {numera.Opis}\nZanrovi: ";

                foreach (Zanr zanr in numera.Zanrovi)
                {
                    description += $"{zanr.Naziv}, ";
                }

                if (numera.Zanrovi.Count > 0)
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
