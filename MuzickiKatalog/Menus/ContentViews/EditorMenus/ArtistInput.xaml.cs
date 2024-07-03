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
    /// Interaction logic for ArtistInput.xaml
    /// </summary>
    public partial class ArtistInput : Window
    {
        private string editorId;
        private ZanrService zanroviService;
        private AddArtistModelView mv;
        public ArtistInput(string editorId)
        {
            InitializeComponent();
            this.editorId = editorId;
            zanroviService = new ZanrService();
            mv = new AddArtistModelView(editorId);
            List<Zanr> z = zanroviService.GetAll();
            foreach (Zanr zz in z)
            {
                genreChoice.Items.Add(zz.Naziv);
            }
            List<int> ocene =new List<int> { 1, 2, 3, 4, 5 };
            gradeCombo.ItemsSource = ocene;
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            if (description.Text != "" && nameText.Text != "" && lastNameText.Text != "" && 
                genreChoice.SelectedItems.Count != 0 && imageText.Text != "" && rewiewText.Text!="" && gradeCombo.SelectedItem!=null)
            {
                string desc = description.Text;
                string name = nameText.Text;
                string lastName = lastNameText.Text;
                string img = imageText.Text;
                List<Zanr> zanrovi = new List<Zanr>();
                foreach (var item in genreChoice.SelectedItems)
                {
                    zanrovi.Add(zanroviService.FindZanr(item.ToString()));
                }
                string rewiew = rewiewText.Text;
                int grade = int.Parse(gradeCombo.SelectedItem.ToString());
                bool uspeh = mv.AddArtistEditor(desc, name, lastName, zanrovi, img, rewiew, grade);
                if (uspeh)
                    MessageBox.Show("Uspesno dodat izvodjac!");
                else
                    MessageBox.Show("Neuspesno!");
            }
            else
            {
                MessageBox.Show("Unesi ispravne podatke, izaberi zanr!");
            }
        }

    }
}
