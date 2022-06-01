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
    /// Logique d'interaction pour UCbuttons.xaml
    /// </summary>
    public partial class UCbuttons : UserControl
    {
        public Navigator Navigator => (App.Current as App).Navigator;
        public UCbuttons()
        {
            InitializeComponent();
        }

        public string Titre
        {
            set
            {
                TitrePage.Text = value;
            }
        }

        private void Page_accueil(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.PART_ACCUEIL);
        }
    }
}
