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


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public OrderType orderType = new OrderType();

        public MainWindow()
        {
            InitializeComponent();
            HideOptionButtons();
            orderOptionStack.Visibility = Visibility.Hidden;
            orderTypeStack.Visibility = Visibility.Visible;
        }

        private void walkInBttn_Click(object sender, RoutedEventArgs e)
        {
            orderType = OrderType.WalkIn;
            SwitchToOrderingScreen();
        }

        private void pickUpBttn_Click(object sender, RoutedEventArgs e)
        {
            orderType = OrderType.PickUp;
            SwitchToOrderingScreen();
        }

        private void driveThruBttn_Click(object sender, RoutedEventArgs e)
        {
            orderType = OrderType.DriveThru;
            SwitchToOrderingScreen();
        }

        /* Entree Options */

        private void briarheartBurgerBttn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void doubleDraugrBttn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void gardenOrcOmeletteBttn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void phillyPoacherBttn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void smokehouseSkeletonBttn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void thalmorTripleBttn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void thugsTBoneBttn_Click(object sender, RoutedEventArgs e)
        {

        }

        /* Drink Options */
        private void aretinoAppleJuiceBttn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void candlehearthCoffeeBttn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void markarthMilkBttn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void sailorSodaBttn_Click(object sender, RoutedEventArgs e)
        {

        }

        private void warriorWaterBttn_Click(object sender, RoutedEventArgs e)
        {

        }

       /* Menu Option Categories */

        private void entreesBttn_Click(object sender, RoutedEventArgs e)
        {
            HideOptionButtons();
            entreeOptionLeftStack.Visibility = Visibility.Visible;
            entreeOptionRightStack.Visibility = Visibility.Visible;
        }

        private void sidesBttn_Click(object sender, RoutedEventArgs e)
        {
            HideOptionButtons();
            sideOptionLeftStack.Visibility = Visibility.Visible;
            sideOptionRightStack.Visibility = Visibility.Visible;
        }

        private void drinksBttn_Click(object sender, RoutedEventArgs e)
        {
            HideOptionButtons();
            drinkOptionLeftStack.Visibility = Visibility.Visible;
            drinkOptionRightStack.Visibility = Visibility.Visible;
        }

        private void editOrderBttn_Click(object sender, RoutedEventArgs e)
        {
            HideOptionButtons();
        }

        private void HideOptionButtons()
        {
            sideOptionLeftStack.Visibility = Visibility.Hidden;
            sideOptionRightStack.Visibility = Visibility.Hidden;

            drinkOptionLeftStack.Visibility = Visibility.Hidden;
            drinkOptionRightStack.Visibility = Visibility.Hidden;

            entreeOptionLeftStack.Visibility = Visibility.Hidden;
            entreeOptionRightStack.Visibility = Visibility.Hidden;
        }

        private void SwitchToOrderingScreen()
        {
            orderTypeStack.Visibility = Visibility.Visible;
            orderOptionStack.Visibility = Visibility.Visible;

        }
    }
}
