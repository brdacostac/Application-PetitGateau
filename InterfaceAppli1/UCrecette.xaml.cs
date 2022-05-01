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
        bool like=false;
        public UCrecette()
        {
            InitializeComponent();
        }


        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!like)
            {
                LikeButton.Source = new BitmapImage(new Uri("Images/liked.png", UriKind.Relative));
                like = true;
            }
            else
            {
                LikeButton.Source = new BitmapImage(new Uri("Images/likeButton.png", UriKind.Relative));
                like = false;
            }
            
        }
    }
}
