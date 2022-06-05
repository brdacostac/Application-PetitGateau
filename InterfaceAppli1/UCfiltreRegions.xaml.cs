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
    /// Interação lógica para UCfiltreRegions.xam
    /// </summary>
    public partial class UCfiltreRegions : UserControl
    {
        
        public Manager Mgr => (App.Current as App).LeManager;

        public UCfiltreRegions()
        {
            InitializeComponent();
        }

        public System.Windows.Media.ImageSource Limage
        {
            set
            {
                ImageRegion.Source = value;
            }
        }

        public string Description
        {
            set => description.Text = value;
        }

        private void Button_Click_entree(object sender, RoutedEventArgs e)
        {
            UCmasterRegions page = new UCmasterRegions();
            page.Origine = Reg;
            page.typ = Modele.Type.Entree;
            Recettes.Content = page;
            
        }
        private void Button_Click_plat(object sender, RoutedEventArgs e)
        {
            UCmasterRegions page = new UCmasterRegions();
            page.Origine = Reg;
            page.typ = Modele.Type.Plat;
            Recettes.Content = page;

        }
        private void Button_Click_dessert(object sender, RoutedEventArgs e)
        {
            UCmasterRegions page = new UCmasterRegions();
            page.Origine = Reg;
            page.typ = Modele.Type.Dessert;
            Recettes.Content = page;

        }
        public Region Reg
        {
            get { return (Region)GetValue(RegionProperty); }
            set { SetValue(RegionProperty, value); }
        }

        public static readonly DependencyProperty RegionProperty =
        DependencyProperty.Register("Reg", typeof(Region), typeof(UCfiltreRegions));
    }
}
