using MySql.Data.MySqlClient;
using System;
using System.Windows;
using System.Collections.Generic;

namespace Gestion_Stock_PPE
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

        private void SignIn(object sender, RoutedEventArgs e)
        {


            DAOUser DAOUser = new DAOUser();
            if (DAOUser.searchIfUserExist(login.Text, password.Text))
            {
                navBarreGrid.Visibility = Visibility.Visible;
                loginGrid.Visibility = Visibility.Hidden;
                Main.Content = new Accueil();
            }
            else
            {
                MessageBox.Show("Mauvais Identifiant/mdp");
            }
        }

        private void GoToAccueil(object sender, RoutedEventArgs e)
        {
            Main.Content = new Accueil();
        }

        private void GoToPharmacie(object sender, RoutedEventArgs e)
        {
            Main.Content = new Pharmacie();
        }

        private void GoToStock(object sender, RoutedEventArgs e)
        {
            Main.Content = new StocksScene();
        }
    }
}
