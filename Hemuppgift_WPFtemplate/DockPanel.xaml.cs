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
using System.Windows.Shapes;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for DockPanel.xaml
    /// </summary>
    public partial class DockPanel : Window
    {
        public DockPanel()
        {
            InitializeComponent();
        }

        private void btnCenter_Click(object sender, RoutedEventArgs e)
        {
            BitmapImage bitmap = new BitmapImage();
            bitmap.BeginInit();

            bitmap.UriSource = new Uri("C:\\Users\\benja\\source\\repos\\hemuppgift-wpf-trollemann\\Hemuppgift_WPFtemplate\\TrophyImage.jpg", UriKind.RelativeOrAbsolute);

            bitmap.EndInit();

            imageTrophy.Source = bitmap;
            imageTrophy.Visibility = Visibility.Visible;
        }
    }
}
