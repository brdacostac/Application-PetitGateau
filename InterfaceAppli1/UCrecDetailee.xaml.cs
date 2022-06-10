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
using Modele;

namespace InterfaceAppli1
{
    /// <summary>
    /// Interação lógica para UCrecDetailee.xam
    /// </summary>
    public partial class UCrecDetailee : UserControl
    {
        public Manager Mgr => (App.Current as App).LeManager;
        public Navigator Navigator => (App.Current as App).Navigator;
        public UCrecDetailee()
        {
            InitializeComponent();

            if(!Mgr.CurrentUser.MesRecettes.Contains(Mgr.RecetteSelectionne))
            {
                LikeButton.Source = new BitmapImage(new Uri("Images/likeButton.png", UriKind.Relative));
            }
            else
            {
                LikeButton.Source = new BitmapImage(new Uri("Images/liked.png", UriKind.Relative));
            }

            //(App.Current as App).LeManager.LoadRecettes();
            DataContext = Mgr;
            LesIngredients.Text = Mgr.RecetteSelectionne.DisplayIngredients();
            LesEtapes.Text = Mgr.RecetteSelectionne.DisplayEtapes();
            LesCommentaires.Text = Mgr.RecetteSelectionne.DisplayCommentaires();
        }

        private void Retour(object sender, RoutedEventArgs e)
        {
            RecetteVegan r = Mgr.RecetteSelectionne as RecetteVegan;
            if (r != null)
                Navigator.NavigateTo(Navigator.PART_VEGAN);
            else
            {
                if (Mgr.RecetteSelectionne.Origine == Region.Nord)
                    Navigator.NavigateTo(Navigator.PART_NORTE);
                if (Mgr.RecetteSelectionne.Origine == Region.Nordest)
                    Navigator.NavigateTo(Navigator.PART_NORDESTE);
                if (Mgr.RecetteSelectionne.Origine == Region.Sud)
                    Navigator.NavigateTo(Navigator.PART_SUL);
                if (Mgr.RecetteSelectionne.Origine == Region.Sudest)
                    Navigator.NavigateTo(Navigator.PART_SUDESTE);
                if (Mgr.RecetteSelectionne.Origine == Region.CentreOuest)
                    Navigator.NavigateTo(Navigator.PART_CENTRO_OESTE);
            }
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(!Mgr.CurrentUser.connected)
                Navigator.NavigateTo(Navigator.PART_CONNEXION);

            if (!Mgr.CurrentUser.MesRecettes.Contains(Mgr.RecetteSelectionne))
            {
                LikeButton.Source = new BitmapImage(new Uri("Images/liked.png", UriKind.Relative));
                Mgr.CurrentUser.MesRecettes.Add(Mgr.RecetteSelectionne);
                Mgr.RecetteSelectionne.Liked += 1;
            }
            else
            {
                LikeButton.Source = new BitmapImage(new Uri("Images/likeButton.png", UriKind.Relative));
                Mgr.CurrentUser.MesRecettes.Remove(Mgr.RecetteSelectionne);
            }
        }

        private void Commenter(object sender, RoutedEventArgs e)
        {
            if(Mgr.CurrentUser.connected)
            {
                WCommenter pageCommentaire = new WCommenter();
                pageCommentaire.Show();
            }
            else
                Navigator.NavigateTo(Navigator.PART_CONNEXION);
        }
    }
}
