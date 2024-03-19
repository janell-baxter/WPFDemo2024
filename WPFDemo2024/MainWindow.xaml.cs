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

namespace WPFDemo2024
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void SetUp()
        {
            ContentFrame.Navigate(new Main());
            //PlayerName.Text = game.Player.PersonName;
            //Currency.Text = game.Player.PersonCurrency.ToString("C");
        }

        #region EventHandlers
        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            SetUp();
        }
        private void AreaOne_Click(object sender, RoutedEventArgs e)
        {

            ContentFrame.Navigate(new Uri("AreaOne.xaml", UriKind.Relative));
        }

        private void AreaTwo_Click(object sender, RoutedEventArgs e)
        {

            ContentFrame.Navigate(new Uri("AreaTwo.xaml", UriKind.Relative));
        }

        private void Inventory_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Uri("Inventory.xaml", UriKind.Relative));
        }
        #endregion
    }
}
