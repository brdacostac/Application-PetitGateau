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
    /// Interação lógica para UCmasterRegions.xam
    /// </summary>
    public partial class UCmasterRegions : UserControl
    {
        public Manager Mgr => (App.Current as App).LeManager;
        public UCmasterRegions()
        {
            InitializeComponent();

            (App.Current as App).LeManager.LoadRecettes();
            DataContext = Mgr.Dd.Recettes;
            
        }

        public Region Origine
        {
            get { return Origine; }
            set { DataContext = Mgr.Dd.recettes_region_choisi(value); }
        }
        
    }
}
