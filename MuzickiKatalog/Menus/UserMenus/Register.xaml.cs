using MuzickiKatalog.Infrastructure.Service;
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

namespace MuzickiKatalog
{
    /// <summary>
    /// Interaction logic for Register.xaml
    /// </summary>
    public partial class Register : Window
    {
        private RegistrovanKorisnikService rkS;
        private RegisterModelView rMV;
        public Register(RegistrovanKorisnikService rkS)
        {
            InitializeComponent();
            this.rkS = rkS;
            this.rMV = new RegisterModelView();
        }

        private void Back_Click(object sender, RoutedEventArgs e)
        {
            MainWindow main = new MainWindow();
            main.Show();
            this.Close();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            string firstName = FirstNameTextBox.Text;
            string lastName = LastNameTextBox.Text;
            string email = EmailTextBox.Text;
            string password = PasswordTextBox.Text;

            if(rMV.Register(firstName, lastName, email, password, this.rkS)){
                MessageBox.Show("Profile succesfully created", "Success", MessageBoxButton.OK);

            }
            else
            {
                MessageBox.Show("Can not create account", "Warning", MessageBoxButton.OK, MessageBoxImage.Warning);
                MainWindow main = new MainWindow();
                main.Show();
                this.Close();
            }
        }
    }
}
