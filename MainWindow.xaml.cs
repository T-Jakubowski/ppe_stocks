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

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            //string cs = "sever=localhost;userid=root;password=;database=stocks";
            DAORole dao = new DAORole();
            
            try
            {
                dao.delete(4);
                dao.updateById(3, "compta", "0111001");
                dao.insert("Barde", "01121111");
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
