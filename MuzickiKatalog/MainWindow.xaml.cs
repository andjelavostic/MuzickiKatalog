using MuzickiKatalog.Infrastructure.Service;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace MuzickiKatalog
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private RegistrovanKorisnikService rkS;
        public MainWindow()
        {
            InitializeComponent();
            this.rkS = new RegistrovanKorisnikService();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            Register register = new Register(rkS);
            register.Show();
            this.Close();
        }
    }
}