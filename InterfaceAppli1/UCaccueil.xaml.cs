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
    /// Interação lógica para UCaccueil.xam
    /// </summary>
    public partial class UCaccueil : UserControl
    {
        public Navigator Navigator => (App.Current as App).Navigator;

        public Manager Mgr => (App.Current as App).LeManager;

        public UCaccueil()
        {
            InitializeComponent();
        }
        private void Page_vegan(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.PART_VEGAN);
            Mgr.CurrentUser.MonChef.ExperienceActuel += 50;
        }

        private void Page_regions(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.PART_REGIONS);
            Mgr.CurrentUser.MonChef.ExperienceActuel += 50;
        }
        private void Page_top(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.PART_TOP);
            Mgr.CurrentUser.MonChef.ExperienceActuel += 50;
        }
        private void Page_favoris(object sender, RoutedEventArgs e)
        {
            if (Mgr.CurrentUser.Connected)
                Navigator.NavigateTo(Navigator.PART_FAVORIS);
            else
                Navigator.NavigateTo(Navigator.PART_CONNEXION);
            Mgr.CurrentUser.MonChef.ExperienceActuel += 50;
        }
        private void Page_monchef(object sender, RoutedEventArgs e)
        {
            if (Mgr.CurrentUser.Connected)
                Navigator.NavigateTo(Navigator.PART_MONCHEF);
            else
                Navigator.NavigateTo(Navigator.PART_CONNEXION);
            Mgr.CurrentUser.MonChef.ExperienceActuel += 50;
        }
    }
}
