using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for ReservationsControl.xaml
    /// </summary>
    public partial class ReservationsControl : UserControl
    {
      //  private ReservationsViewModel _viewModel;
        // public ObservableCollection<Reservation> Reservations { get; set; }

        public ReservationsControl()
        {
            InitializeComponent();
           // Reservations = new ObservableCollection<Reservation>();
            // this.DataContext = this;
        }
        // Créer une nouvelle réservation
        private void OnCreateReservationClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Création d'une nouvelle réservation.");
            // Logique de création d'une nouvelle réservation ici
         //   Reservations.Add(new Reservation { Nom = "Nouveau Client", NumeroChambre = 101, DateArrivee = DateTime.Now, DateDepart = DateTime.Now.AddDays(3) });

        }

        // Afficher la liste des réservations
        private void OnViewReservationsClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Affichage de toutes les réservations.");
            // Logique pour afficher toutes les réservations ici
        }

        // Modifier une réservation existante
        private void OnEditReservationClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Modification d'une réservation.");
            // Logique pour modifier une réservation ici
        }

       /* private void OnDeleteReservationClick(object sender, RoutedEventArgs e)
        {
            if (Reservations.Any())
            {
                Reservations.Remove(Reservations[0]); // Supprime la première réservation comme exemple
            }
        }
        private void OnAddReservationClick(object sender, RoutedEventArgs e)
        {
            var reservation = new Reservation
            {
                Nom = ClientNameTextBox.Text,
                NumeroChambre = int.Parse(RoomNumberTextBox.Text),
                DateArrivee = StartDatePicker.SelectedDate ?? DateTime.Now,
                DateDepart = EndDatePicker.SelectedDate ?? DateTime.Now.AddDays(1)
            };
            Reservations.Add(reservation);
        }*/

    }
}
