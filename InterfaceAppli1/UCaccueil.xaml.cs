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
    /// Interação lógica para UCaccueil.xam
    /// </summary>
    public partial class UCaccueil : UserControl
    {
        public Navigator Navigator => (App.Current as App).Navigator;
        public UCaccueil()
        {
            InitializeComponent();
        }
        private void Page_vegan(object sender, RoutedEventArgs e)
        {
            Vegan pg = new Vegan();
        }

        private void Page_regions(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.PART_REGIONS);
        }
    }
}
