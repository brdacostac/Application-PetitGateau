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
    /// Logique d'interaction pour MonChefUC.xaml
    /// </summary>
    public partial class MonChefUC : UserControl
    {
        public Manager Mgr => (App.Current as App).LeManager;

        public MonChefUC()
        {
            InitializeComponent();
            //mettre a jour le niveau
            Mgr.CurrentUser.MonChef.LevelUp();

            // foto correspondante au sexe de l'utilisateur
            if (Mgr.CurrentUser.Sexe == 'h' || Mgr.CurrentUser.Sexe == 'H')
                Chef.Source = new BitmapImage(new Uri("Images/chef_H.png", UriKind.Relative));
            else
                Chef.Source = new BitmapImage(new Uri("Images/chef_F.png", UriKind.Relative));

            //nom de l'utilisateur
            Titre.Titre = Mgr.CurrentUser.Username;

            // informations sur le niveau de l'utilisateur
            Niveau.Text = " " + Mgr.CurrentUser.MonChef;

            //réalisations débloquées par l'utilisateur
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 1)
                Badge1.Source = new BitmapImage(new Uri("Images/badges/1.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 2)
                Badge2.Source = new BitmapImage(new Uri("Images/badges/2.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 3)
                Badge3.Source = new BitmapImage(new Uri("Images/badges/3.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 4)
                Badge4.Source = new BitmapImage(new Uri("Images/badges/4.png", UriKind.Relative));
        }

        private void UCbuttons_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private async void Page_IsVisibleChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            int valeur = 100;
            while (progressBar.Value <= valeur)
            {

                await Task.Delay(1);

                if (progressBar.Value <= valeur)
                {
                    progressBar.Value = progressBar.Value + 0.50;
                }

            }
        }
    }
}
