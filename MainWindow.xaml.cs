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

namespace kevine_gloria_helena_UA2
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // Liste des utilisateurs pour l'authentification
        private List<User> users;

        public MainWindow()
        {
            InitializeComponent();
            InitializeUserList();
        }
        // Initialiser la liste des utilisateurs
        private void InitializeUserList()
        {
            users = new List<User>
            {
                new User { Username = "user", Password = "password" }, // Utilisateur standard
                new User { Username = "admin", Password = "admin123" } // Administrateur
            };
        }

        // Méthode de connexion
        private void btnLogin_Click(object sender, RoutedEventArgs e)
        {
            string username = txtUser.Text.Trim();
            string password = txtPass.Password.Trim();

            // Vérification des champs vides
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                DisplayError("Veuillez remplir tous les champs.");
                return;
            }

            // Vérification des identifiants
            foreach (var user in users)
            {
                if (user.Username == username && user.Password == password)
                {
                    // Redirection vers la page d'accueil
                    HomePage homePage = new HomePage();
                    this.Close();
                    homePage.Show();
                    return;
                }
            }

            // Si aucun utilisateur ne correspond
            DisplayError("Identifiants incorrects.");
        }

        // Afficher un message d'erreur sur la fenêtre
        private void DisplayError(string message)
        {
            // Créer un TextBlock pour afficher le message d'erreur
            var errorTextBlock = new TextBlock
            {
                Text = message,
                Foreground = Brushes.Red,
                FontSize = 12,
                FontWeight = FontWeights.Bold,
                Margin = new Thickness(0, 10, 0, 0)
            };

            // Ajouter le TextBlock à la StackPanel (ou un autre conteneur) pour afficher le message
            StackPanel stackPanel = (StackPanel)this.Content.FindName("ErrorPanel");
            if (stackPanel != null)
            {
                stackPanel.Children.Clear(); // Effacer les anciens messages d'erreur
                stackPanel.Children.Add(errorTextBlock);
            }
        }

        // Gestion de la minimisation
        private void btnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        // Gestion de la fermeture de la fenêtre
        private void btnClose_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
    }
}