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
    /// Interação lógica para UCrecette.xam
    /// </summary>
    public partial class UCrecette : UserControl
    {
        public UCrecette()
        {
            InitializeComponent();
        }

        public string ImageName
        {
            set
            {
                ImageR.Source = new BitmapImage(new Uri(value,UriKind.Relative));
            }
        }

        public string NomRecette
        {
            set 
            {
                NomR.Text = value;
            }
        }

        public string LikeLiked
        {
            set
            {
                LikeButton.Source = new BitmapImage(new Uri(value, UriKind.Relative));
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            monButton.Content = "Images/liked.png";
        }
    }
}
