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
    /// Logique d'interaction pour InscriptionUC.xaml
    /// </summary>
    public partial class InscriptionUC : UserControl
    {
        public Manager Mgr => (App.Current as App).LeManager;
        public Navigator Navigator => (App.Current as App).Navigator;

        bool isCheckH = false;
        bool isCheckF = false;
        public InscriptionUC()
        {
            InitializeComponent();
            //(App.Current as App).LeManager.LoadComptes();
            DataContext = Mgr.Db.Comptes;
        }
        
        private void CheckBox_Checked_Homme(object sender, RoutedEventArgs e)
        {
            if (!isCheckH)
            {
                Femme.IsChecked = false;
                isCheckH = true;
            }
            else
            {
                Femme.IsChecked = false;
                isCheckH = false;
            }
        }

        private void CheckBox_Checked_Femme(object sender, RoutedEventArgs e)
        {
            if (!isCheckF)
            {
                Homme.IsChecked = false;
                isCheckF = true;
            }
            else
            {
                Homme.IsChecked = false;
                isCheckF = false;
            }
        }

        /// <summary>
        /// Cette foncyion permet a un visiteur de crée un compte 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void CreerCompte(object sender, RoutedEventArgs e)
        {
            string username = NomUtilisateur.Text;
            string motDePasse = MotDePasse.Password;
            string confirmMdp = ConfirmerMdp.Password;
            string cp = CodePostal.Text;
            string ville = Ville.Text;
            string rue = Rue.Text;
            string num = Numero.Text;

            if (username != "" && motDePasse == confirmMdp && (isCheckF == true || isCheckH == true) && cp != "" && ville != "" && rue != "" && num != "")
            {
                if (isCheckF)
                    Mgr.Db.Comptes.Add(new Compte(username, motDePasse, 'f', cp + ", " + ville + " " + rue + " n°" + num));
                else
                    Mgr.Db.Comptes.Add(new Compte(username, motDePasse, 'h', cp + ", " + ville + ", " + " n°" + num + " Rue " + rue));
                Message.Text = "Success ! Votre compte a été créé, vou pouvez vou connecter sur la page Connexion !";
                await Task.Delay(2000);
                Navigator.NavigateTo(Navigator.PART_CONNEXION);
            }
            else
            {
                if (cp == "" || ville == "" || rue == "" || num == "")
                    Message.Text = "Les informations d'adresse ne sont pas complètes";

                if (username == " " || motDePasse == " " || confirmMdp == " ")
                    Message.Text = "Une ou plusieurs cases n'ont pas été complétés";

                if (motDePasse != confirmMdp)
                    Message.Text = "Les mots de passe ne correspondent pas";

                if (isCheckF == false && isCheckH == false)
                    Message.Text = "le sexe n'a pas été indiqué";
            } 
        }
    }
}

