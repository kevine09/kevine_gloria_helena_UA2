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
    /// Interaction logic for ChambresControl.xaml
    /// </summary>
    public partial class ChambresControl : UserControl
    {
        public ChambresControl()
        {
            InitializeComponent();
        }
        // Afficher les chambres disponibles
        private void OnViewRoomsClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Affichage des chambres disponibles.");
            // Logique pour afficher les chambres disponibles ici
        }

        // Réserver une chambre
        private void OnReserveRoomClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("validation ou confirmation de reservation de la chambre");
            // Logique pour confirmer    une chambre ici
        }

        // Modifier les informations d'une chambre
        private void OnEditRoomClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Modification des informations de la chambre.");
            // Logique pour modifier une chambre ici
        }
    }
}
