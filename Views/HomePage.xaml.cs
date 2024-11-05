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

namespace kevine_gloria_helena_UA2.Views
{
    /// <summary>
    /// Interaction logic for HomePage.xaml
    /// </summary>
    public partial class HomePage : Window
    {
        public HomePage()
        {
            InitializeComponent();
        }
        // Afficher les options d'accueil dans l'espace de travail
        private void Accueil_Click(object sender, RoutedEventArgs e)
        {
            EspaceDeTravail.Content = new ControlAcceuil();  // À créer si besoin
        }

        // Afficher les options de réservations dans l'espace de travail
        private void Reservations_Click(object sender, RoutedEventArgs e)
        {
            EspaceDeTravail.Content = new ReservationsControl();
        }

        // Afficher les options de chambres dans l'espace de travail
        private void Chambres_Click(object sender, RoutedEventArgs e)
        {
            EspaceDeTravail.Content = new ChambresControl();
        }

        // Afficher les options de clients dans l'espace de travail
        private void Clients_Click(object sender, RoutedEventArgs e)
        {
            EspaceDeTravail.Content = new ClientsControl();
        }
    }
}
