using Modele;
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


namespace InterfaceAppli1
{
    /// <summary>
    /// Logique d'interaction pour ConnexionUC.xaml
    /// </summary>
    public partial class ConnexionUC : UserControl
    {
        public Navigator Navigator => (App.Current as App).Navigator;
        public Manager Mgr => (App.Current as App).LeManager;
        public ConnexionUC()
        {
            InitializeComponent();
            (App.Current as App).LeManager.LoadComptes();
            DataContext = Mgr.Db.Comptes;
        }

        private void Page_Inscription(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.PART_INSCRIPTION);
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            string username = Username.Text;
            string motDePasse = MotDePasse.Password;
               
            if(Mgr.CurrentUser.Connected == true)
            {
                Message.Text = "Vous êtes déjà connecter!";
                return;
            }

            if (Mgr.Login(username, motDePasse))
                Message.Text = "Success ! Vous êtes connecter!";
            else
                Message.Text = "L'authentification a échoué";
        }
    }
}
