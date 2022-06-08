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
    /// Logique d'interaction pour InscriptionUC.xaml
    /// </summary>
    public partial class InscriptionUC : UserControl
    {
        bool isCheckH = false;
        bool isCheckF = false;
        public InscriptionUC()
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
            if (!isCheckF)
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

        private void CreerCompte(object sender, RoutedEventArgs e)
        {
            string username = NomUtilisateur.Text;
            string motDePasse = MotDePasse.Text;
            string confirmMdp = ConfirmerMdp.Text;

           
        }
    }
}

