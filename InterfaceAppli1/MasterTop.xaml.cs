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
            Recette max = Mgr.Db.Recettes[0];
            foreach (Recette r in Mgr.Db.Recettes)
            {
                if (r.Liked > max.Liked && r.Filtre == Modele.Type.Entree)
                {
                    max = r;
                }
            }
            recet.DataContext = max;
        }

        private void plat_Click(object sender, RoutedEventArgs e)
        {
            Recette max = Mgr.Db.Recettes[0];
            foreach (Recette r in Mgr.Db.Recettes)
            {
                if (r.Liked > max.Liked && r.Filtre == Modele.Type.Plat)
                {
                    max = r;
                }
            }
            recet.DataContext = max;
        }

        private void dessert_Click(object sender, RoutedEventArgs e)
        {
            Recette max = Mgr.Db.Recettes[0];
            foreach (Recette r in Mgr.Db.Recettes)
            {
                if (r.Liked > max.Liked && r.Filtre == Modele.Type.Dessert)
                {
                    max = r;
                }
            }
            recet.DataContext = max;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mgr.RecetteSelectionne = e.AddedItems[0] as Recette;
            Navigator.NavigateTo(Navigator.PART_RECDETAILEE);
        }

    }
}

