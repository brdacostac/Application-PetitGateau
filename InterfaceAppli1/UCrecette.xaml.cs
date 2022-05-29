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
            if (!Like)
            {
                LikeButton.Source = new BitmapImage(new Uri("Images/liked.png", UriKind.Relative));
            }
            else
            {
                LikeButton.Source = new BitmapImage(new Uri("Images/likeButton.png", UriKind.Relative));
            }
        }

        public string Img
        {
            get { return (string)GetValue(ImgProperty); }
            set { SetValue(ImgProperty, value); }
        }

        public static readonly DependencyProperty ImgProperty =
        DependencyProperty.Register("Img", typeof(string), typeof(UCrecette));

        public string Nom
        {
            get { return (string)GetValue(NomProperty); }
            set { SetValue(NomProperty, value); }
        }

        public static readonly DependencyProperty NomProperty =
        DependencyProperty.Register("Nom", typeof(string), typeof(UCrecette));


        public bool Like = false;
        /*{
            get { return (bool)GetValue(LikeProperty); }
            set { SetValue(LikeProperty, value); }
        }

        public static readonly DependencyProperty LikeProperty =
        DependencyProperty.Register("Like", typeof(string), typeof(UCrecette), new PropertyMetadata(false));*/

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (!Like)
            {
                LikeButton.Source = new BitmapImage(new Uri("Images/liked.png", UriKind.Relative));
                Like = true;
            }
            else
            {
                LikeButton.Source = new BitmapImage(new Uri("Images/likeButton.png", UriKind.Relative));
                Like = false;
            }
            
        }
    }
}
