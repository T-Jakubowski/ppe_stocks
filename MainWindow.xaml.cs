using MySql.Data.MySqlClient;
using System;
using System.Windows;

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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //string cs = "sever=localhost;userid=root;password=;database=stocks";
            DAOStock dAOStock = new DAOStock();
            try
            {
                dAOStock.updateObjectByName(4, "AR719", "AX938");
                //dAOStock.insertObject(5, "DF066", "VP349");
                dAOStock.deleteObject("DF066", "VP349");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
