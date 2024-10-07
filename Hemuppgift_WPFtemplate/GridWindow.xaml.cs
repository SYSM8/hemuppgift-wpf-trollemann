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
    /// Interaction logic for GridWindow.xaml
    /// </summary>
    public partial class GridWindow : Window
    {
        public GridWindow()
        {
            InitializeComponent();
        }

        private void btnApply_Click(object sender, RoutedEventArgs e)
        {
            switch ((Convert.ToInt32(txtBoxRow.Text), Convert.ToInt32(txtBoxColumn.Text)))
            {
                case (0, 0):
                    var btnGrid00 = newButton(0, 0);
                    Grid.SetRow(btnGrid00, 0);
                    Grid.SetColumn(btnGrid00, 0);
                    grid.Children.Add(btnGrid00);
                    break;

                case (0, 1):
                    var btnGrid01 = newButton(0, 1);
                    Grid.SetRow(btnGrid01, 0);
                    Grid.SetColumn(btnGrid01, 1);
                    grid.Children.Add(btnGrid01);
                    break;

                case (0, 2):
                    var btnGrid02 = newButton(0, 2);
                    Grid.SetRow(btnGrid02, 0);
                    Grid.SetColumn(btnGrid02, 2);
                    grid.Children.Add(btnGrid02);
                    break;

                case (0, 3):
                    var btnGrid03 = newButton(0, 3);
                    Grid.SetRow(btnGrid03, 0);
                    Grid.SetColumn(btnGrid03, 3);
                    grid.Children.Add(btnGrid03);
                    break;

                case (1, 0):
                    var btnGrid10 = newButton(1, 0);
                    Grid.SetRow(btnGrid10, 1);
                    Grid.SetColumn(btnGrid10, 0);
                    grid.Children.Add(btnGrid10);
                    break;

                case (1, 1):
                    var btnGrid11 = newButton(1, 1);
                    Grid.SetRow(btnGrid11, 1);
                    Grid.SetColumn(btnGrid11, 1);
                    grid.Children.Add(btnGrid11);
                    break;

                case (1, 2):
                    var btnGrid12 = newButton(1, 2);
                    Grid.SetRow(btnGrid12, 1);
                    Grid.SetColumn(btnGrid12, 2);
                    grid.Children.Add(btnGrid12);
                    break;

                case (1, 3):
                    var btnGrid13 = newButton(1, 3);
                    Grid.SetRow(btnGrid13, 1);
                    Grid.SetColumn(btnGrid13, 3);
                    grid.Children.Add(btnGrid13);
                    break;

                case (2, 0):
                    var btnGrid20 = newButton(2, 0);
                    Grid.SetRow(btnGrid20, 2);
                    Grid.SetColumn(btnGrid20, 0);
                    grid.Children.Add(btnGrid20);
                    break;

                case (2, 1):
                    var btnGrid21 = newButton(2, 1);
                    Grid.SetRow(btnGrid21, 2);
                    Grid.SetColumn(btnGrid21, 1);
                    grid.Children.Add(btnGrid21);
                    break;

                case (2, 2):
                    var btnGrid22 = newButton(2, 2);
                    Grid.SetRow(btnGrid22, 2);
                    Grid.SetColumn(btnGrid22, 2);
                    grid.Children.Add(btnGrid22);
                    break;

                case (2, 3):
                    var btnGrid23 = newButton(2, 3);
                    Grid.SetRow(btnGrid23, 2);
                    Grid.SetColumn(btnGrid23, 3);
                    grid.Children.Add(btnGrid23);
                    break;

                case (3, 0):
                    var btnGrid30 = newButton(3, 0);
                    Grid.SetRow(btnGrid30, 3);
                    Grid.SetColumn(btnGrid30, 0);
                    grid.Children.Add(btnGrid30);
                    break;

                case (3, 1):
                    var btnGrid31 = newButton(3, 1);
                    Grid.SetRow(btnGrid31, 3);
                    Grid.SetColumn(btnGrid31, 1);
                    grid.Children.Add(btnGrid31);
                    break;

                case (3, 2):
                    var btnGrid32 = newButton(3, 2);
                    Grid.SetRow(btnGrid32, 3);
                    Grid.SetColumn(btnGrid32, 2);
                    grid.Children.Add(btnGrid32);
                    break;

                case (3, 3):
                    var btnGrid33 = newButton(3, 3);
                    Grid.SetRow(btnGrid33, 3);
                    Grid.SetColumn(btnGrid33, 3);
                    grid.Children.Add(btnGrid33);
                    break;
            }
        }

        //metod för att skapa en ny knapp
        private Button newButton(int row, int col)
        {
            Button newButton = new Button();
            newButton.Content = $"Row {row}, Column {col}";
            newButton.HorizontalAlignment = HorizontalAlignment.Stretch;
            newButton.VerticalAlignment = VerticalAlignment.Stretch;
            newButton.Background = new SolidColorBrush(Colors.LightGreen);

            return newButton;
        }
    }

}
