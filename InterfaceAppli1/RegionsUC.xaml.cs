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
    /// Logique d'interaction pour RegionsUC.xaml
    /// </summary>
    public partial class RegionsUC : UserControl
    {
        public Navigator Navigator => (App.Current as App).Navigator;

        public Manager Mgr => (App.Current as App).LeManager;
        public RegionsUC()
        {
            InitializeComponent();
        }
        private void Page_Norte(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.PART_NORTE);
            Mgr.CurrentUser.MonChef.ExperienceActuel += 20;
        }
        private void Page_Nordeste(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.PART_NORDESTE);
            Mgr.CurrentUser.MonChef.ExperienceActuel += 20;
        }
        private void Page_Centro_Oeste(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.PART_CENTRO_OESTE);
            Mgr.CurrentUser.MonChef.ExperienceActuel += 20;
        }
        private void Page_Sudeste(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.PART_SUDESTE);
            Mgr.CurrentUser.MonChef.ExperienceActuel += 20;
        }
        private void Page_Sul(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.PART_SUL);
            Mgr.CurrentUser.MonChef.ExperienceActuel += 20;
        }
    }
}
