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
    /// Interaction logic for ClientsControl.xaml
    /// </summary>
    public partial class ClientsControl : UserControl
    {
        public ClientsControl()
        {
            InitializeComponent();
        }
    
    // afficher les informations du client c'est a dire son profil
    private void OnViewProfilClick(object sender, RoutedEventArgs e)
    {
        // logique pour afficher les informations du profil
    }

    // Afficher la liste des clients ( vu par l'administrateur)
    private void OnViewClientsClick(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Affichage de la liste des clients.");
        // Logique pour afficher les clients ici
    }

    // Ajouter un nouveau client
    private void OnAddClientClick(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Ajout d'un nouveau client.");
        // Logique pour ajouter un client ici
    }

    // Modifier un client existant
    private void OnEditClientClick(object sender, RoutedEventArgs e)
    {
        MessageBox.Show("Modification des informations du client.");
        // Logique pour modifier un client ici
    }
}
}
