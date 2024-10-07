using System.Windows;
using System.Windows.Controls;

namespace Hemuppgift_WPFtemplate
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //HEJ
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnGrid_Click(object sender, RoutedEventArgs e)
        {
            GridWindow grid = new GridWindow();
            grid.Show();
        }

        private void btnStackPanel_Click(object sender, RoutedEventArgs e)
        {
            StackPanel stackPanel = new StackPanel();
            stackPanel.Show();
        }

        private void btnWrapPanel_Click(object sender, RoutedEventArgs e)
        {
            WrapPanel wrapPanel = new WrapPanel();
            wrapPanel.Show();
        }

        private void btnDockPanel_Click(object sender, RoutedEventArgs e)
        {
            DockPanel dockPanel = new DockPanel();
            dockPanel.Show();
        }
    }
}