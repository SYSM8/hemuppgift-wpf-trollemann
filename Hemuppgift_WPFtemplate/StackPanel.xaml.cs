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
    /// Interaction logic for StackPanel.xaml
    /// </summary>
    public partial class StackPanel : Window
    {
        public StackPanel()
        {
            InitializeComponent();
        }

        private void radioBtnHorizontal_Checked(object sender, RoutedEventArgs e)
        {
            stackPanel.Orientation = Orientation.Horizontal;
        }

        private void radioBtnVertical_Checked(object sender, RoutedEventArgs e)
        {
            stackPanel.Orientation = Orientation.Vertical;
        }
    }
}
