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
    /// Interação lógica para Inscription.xam
    /// </summary>
    public partial class Inscription : Page
    {
        bool isCheckH = false;
        bool isCheckF = false;
        public Inscription()
        {
            InitializeComponent();
        }

        private void CheckBox_Checked_Homme(object sender, RoutedEventArgs e)
        {
            if (!isCheckH)
            {
                Femme.IsChecked = false;
                isCheckH = true;
            }
            else
            {
                Femme.IsChecked = false;
                isCheckH = false;
            }
        }
        private void CheckBox_Checked_Femme(object sender, RoutedEventArgs e)
        {
            if(!isCheckF)
            {
                Homme.IsChecked = false;
                isCheckF = true;
            }
            else
            {
                Homme.IsChecked = false;
                isCheckF = false;
            }
        }
    }
}
