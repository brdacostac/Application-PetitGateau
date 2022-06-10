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
using Modele;

namespace InterfaceAppli1
{
    /// <summary>
    /// Lógica interna para WCommenter.xaml
    /// </summary>

    public partial class WCommenter : Window
    {
        public Manager Mgr => (App.Current as App).LeManager;

        public WCommenter()
        {
            InitializeComponent();
            DataContext = Mgr;
        }

        private void SendComment(object sender, RoutedEventArgs e)
        {
            string commentaire = Commentaire.Text;

            if (commentaire.Length == 0)
            {
                Message.Text = "Le commentaire est vide !";
            }
            else if (commentaire.Length > 200)
            {
                Message.Text = "Le commentaire est trop long " + commentaire.Length + "/300";
            }

            if(commentaire.Length < 300 && commentaire.Length != 0)
            {
                commentaire = Mgr.CurrentUser.Username + " : \n" + commentaire;
                Mgr.RecetteSelectionne.Commentaires.Add(commentaire);
                Message.Text = "Votre commentaire a été envoyer !";
            }
        }   
    }
}
