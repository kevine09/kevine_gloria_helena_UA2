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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace kevine_gloria_helena_UA2.Views
{
    /// <summary>
    /// Interaction logic for ControlAcceuil.xaml
    /// </summary>
    public partial class ControlAcceuil : UserControl
    {
        public ControlAcceuil()
        {
            InitializeComponent();
        }
        // Bouton "Bienvenue" sur la page d'accueil
        private void OnWelcomeClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Bienvenue sur la page d'accueil de l'hôtel.");
            // Logique d'accueil, ou informations générales ici
        }

        // Bouton "À propos" pour plus d'informations
        private void OnAboutClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("À propos de notre service de réservation d'hôtel.");
            // Logique pour afficher les informations 'À propos'
        }
    }
}
