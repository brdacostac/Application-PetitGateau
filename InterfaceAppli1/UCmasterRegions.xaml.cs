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

        /// <summary>
        /// attribut origine qui va être changé en fonction de la page region
        /// </summary>
        public Region Origine
        {
            get { return origine; }
            set { origine = value; }
        }
        private Region origine;


        /// <summary>
        /// attribut typ va changer le dataContext en fonction du type choisi et de la region
        /// </summary>
        public Modele.Type typ
        {
            get { return typ; }
            set { DataContext = Mgr.Dd.recettes_region_type_choisi(Origine,value); }
        }
        
    }
}
