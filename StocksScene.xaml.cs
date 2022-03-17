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
using MySql.Data.MySqlClient;

namespace Gestion_Stock_PPE
{
    /// <summary>
    /// Logique d'interaction pour StocksScene.xaml
    /// </summary>
    public partial class StocksScene : Page
    {
        public StocksScene()
        {
            InitializeComponent();
            List<DataGridStock> dataStock = new List<DataGridStock>(); 
            DataGridStock dataGridStock = new DataGridStock();
            dataStock = dataGridStock.getDataStocks("AR719");
            foreach(DataGridStock stock in dataStock)
            {
                dataGridStocks.Items.Add(stock);
            }
        }
        public class DataGridStock
        {
            public int quantite { get; set; }
            public string nom { get; set; }
            public string composition { get; set; }
            private MySqlConnection con;

            public DataGridStock()
            {
                con = new MySqlConnection("server=localhost;userid=root;password=;database=stocks");
            }

            public DataGridStock(int quantite, string nom, string composition)
            {
                con = new MySqlConnection("server=localhost;userid=root;password=;database=stocks");
                this.quantite = quantite;
                this.nom = nom;
                this.composition = composition;
            }


            public List<DataGridStock> getDataStocks(string pharmacieCode)
            {
                List<DataGridStock> stocks = new List<DataGridStock>();
                con.Open();
                MySqlCommand query = new MySqlCommand();
                query.Connection = con;
                query.CommandText = ("Select quantite, nom, composition from stocks, objet where stocks.pharmacieCode = @pharmacieCode and objet.objetCode = stocks.objetCode;");
                query.Parameters.AddWithValue("pharmacieCode", pharmacieCode);
                query.Prepare();
                MySqlDataReader dataReader = query.ExecuteReader();
                while (dataReader.Read())
                {
                    DataGridStock dataStocks = new DataGridStock();
                    dataStocks.composition = (string)dataReader["composition"];
                    dataStocks.nom = (string)dataReader["nom"];
                    dataStocks.quantite = (int)dataReader["quantite"];
                    stocks.Add(dataStocks);
                }
                dataReader.Close();
                return stocks;
            }
        }
    }
}
