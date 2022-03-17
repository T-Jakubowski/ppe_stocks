using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gestion_Stock_PPE
{
    public class DataGridStock
    {
        public int quantite ;
        public string nom;
        public string composition;
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
                dataStocks.setComposition((string)dataReader["composition"]);
                dataStocks.setNom((string)dataReader["nom"]);
                dataStocks.setQuantite((int)dataReader["quantite"]);
                stocks.Add(dataStocks);

            }
            dataReader.Close();
            return stocks;
        }
        public int getQuantite()
        {
            return quantite;
        }

        public void setQuantite(int quantite) { this.quantite = quantite; }

        public string getNom()
        {
            return nom;
        }

        public void setNom(string nom)
        {
            this.nom = nom;
        }

        public string getComposition()
        {
            return composition;
        }

        public void setComposition(string composition)
        {
            this.composition = composition;
        }
    }
}
