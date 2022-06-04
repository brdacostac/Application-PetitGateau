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
    /// Logique d'interaction pour ConnexionUC.xaml
    /// </summary>
    public partial class ConnexionUC : UserControl
    {
        public Navigator Navigator => (App.Current as App).Navigator;
        public ConnexionUC()
        {
            InitializeComponent();
        }

        private void Page_Inscription(object sender, RoutedEventArgs e)
        {
            Navigator.NavigateTo(Navigator.PART_INSCRIPTION);
        }
    }
}
