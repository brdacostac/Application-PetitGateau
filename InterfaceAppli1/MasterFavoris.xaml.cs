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
    /// Master des recettes aimées par l'utilisateur
    /// </summary>

    public partial class MasterFavoris : UserControl
    {
        public Manager Mgr => (App.Current as App).LeManager;
        public Navigator Navigator => (App.Current as App).Navigator;

        public MasterFavoris()
        {
            InitializeComponent();
            DataContext = Mgr.CurrentUser.MesRecettes;

            foreach (Recette rec in Mgr.CurrentUser.MesRecettes)
            {
                List<Recette> plat = new List<Recette>();
                if (rec.Filtre == Modele.Type.Plat)
                    plat.Add(rec);
            }

            foreach (Recette rec in Mgr.CurrentUser.MesRecettes)
            {
                List<Recette> entree = new List<Recette>();
                if (rec.Filtre == Modele.Type.Entree)
                    entree.Add(rec);
            }

            foreach (Recette rec in Mgr.CurrentUser.MesRecettes)
            {
                List<Recette> dessert = new List<Recette>();
                if (rec.Filtre == Modele.Type.Dessert)
                    dessert.Add(rec);
            }
        }

        private void entree_Click(object sender, RoutedEventArgs e)
        {    
            recet.DataContext = entree;
        }

        private void plat_Click(object sender, RoutedEventArgs e)
        {  
            recet.DataContext = plat;
        }

        private void dessert_Click(object sender, RoutedEventArgs e)
        {  
            recet.DataContext = dessert;
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Mgr.RecetteSelectionne = e.AddedItems[0] as Recette;
            Navigator.NavigateTo(Navigator.PART_RECDETAILEE);
        }
    }
}
