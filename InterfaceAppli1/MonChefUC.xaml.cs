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
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 5)
                Badge5.Source = new BitmapImage(new Uri("Images/badges/5.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 6)
                Badge6.Source = new BitmapImage(new Uri("Images/badges/6.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 7)
                Badge7.Source = new BitmapImage(new Uri("Images/badges/7.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 8)
                Badge8.Source = new BitmapImage(new Uri("Images/badges/8.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 9)
                Badge9.Source = new BitmapImage(new Uri("Images/badges/9.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 10)
                Badge10.Source = new BitmapImage(new Uri("Images/badges/10.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 11)
                Badge11.Source = new BitmapImage(new Uri("Images/badges/11.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 12)
                Badge12.Source = new BitmapImage(new Uri("Images/badges/12.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 13)
                Badge13.Source = new BitmapImage(new Uri("Images/badges/13.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 14)
                Badge14.Source = new BitmapImage(new Uri("Images/badges/14.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 15)
                Badge15.Source = new BitmapImage(new Uri("Images/badges/15.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 16)
                Badge16.Source = new BitmapImage(new Uri("Images/badges/16.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 17)
                Badge17.Source = new BitmapImage(new Uri("Images/badges/17.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 18)
                Badge18.Source = new BitmapImage(new Uri("Images/badges/18.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 19)
                Badge19.Source = new BitmapImage(new Uri("Images/badges/19.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 20)
                Badge20.Source = new BitmapImage(new Uri("Images/badges/20.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 21)
                Badge21.Source = new BitmapImage(new Uri("Images/badges/21.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 22)
                Badge22.Source = new BitmapImage(new Uri("Images/badges/22.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 23)
                Badge23.Source = new BitmapImage(new Uri("Images/badges/23.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 24)
                Badge24.Source = new BitmapImage(new Uri("Images/badges/24.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 25)
                Badge25.Source = new BitmapImage(new Uri("Images/badges/25.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 26)
                Badge26.Source = new BitmapImage(new Uri("Images/badges/26.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 27)
                Badge27.Source = new BitmapImage(new Uri("Images/badges/27.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 28)
                Badge28.Source = new BitmapImage(new Uri("Images/badges/28.png", UriKind.Relative));
            if (Mgr.CurrentUser.MonChef.Level.Indice >= 29)
                Badge29.Source = new BitmapImage(new Uri("Images/badges/29.png", UriKind.Relative));
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
