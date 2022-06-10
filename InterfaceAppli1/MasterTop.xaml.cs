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
    /// Interação lógica para MasterTop.xam
    /// </summary>
    public partial class MasterTop : UserControl
    {
        public Manager Mgr => (App.Current as App).LeManager;
        public Navigator Navigator => (App.Current as App).Navigator;

        public MasterTop()
        {
            InitializeComponent();
            
        }

        private void entree_Click(object sender, RoutedEventArgs e)
        {
            
            recet.DataContext = Mgr.recette_top_type_choisi(Modele.Type.Entree);
        }

        private void plat_Click(object sender, RoutedEventArgs e)
        {
            recet.DataContext = Mgr.recette_top_type_choisi(Modele.Type.Plat);
        }

        private void dessert_Click(object sender, RoutedEventArgs e)
        {
            recet.DataContext = Mgr.recette_top_type_choisi(Modele.Type.Dessert);
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mgr.RecetteSelectionne = e.AddedItems[0] as Recette;
            Navigator.NavigateTo(Navigator.PART_RECDETAILEE);
        }

    }
}

