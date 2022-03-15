using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;


namespace Gestion_Stock_PPE
{
    internal class DAOStock
    {
        private MySqlConnection con;

        public DAOStock()
        {
            con = new MySqlConnection("server=localhost;userid=root;password=;database=stocks");
        }
        public List<Stock> getObject(string pharmacieCode)
        {
            List<Stock> stocks = new List<Stock>();
            con.Open();
            MySqlCommand query = new MySqlCommand();
            query.Connection = con;
            query.CommandText = ("Select * from stocks where pharmacieCode = @pharmacieCode");
            query.Parameters.AddWithValue("pharmacieCode", pharmacieCode);
            query.Prepare();
            MySqlDataReader dataReader = query.ExecuteReader();
            while (dataReader.Read())
            {
                Stock stock = new Stock();
                stock.setPharmacieCode((string)dataReader["pharmacieCode"]);
                stock.setObjetCode((string)dataReader["objetCode"]);
                stock.setQuantite((int)dataReader["quantite"]);
                stocks.Add(stock);
            }
            dataReader.Close();
            return stocks;
        }
        public void deleteObject(string pharmacieCode, string objetCode)
        {
            con.Open();
            string query = "delete from stocks WHERE pharmacieCode = '" + pharmacieCode + "' and objetCode = '" + objetCode + "';";
            MySqlCommand delete = new MySqlCommand(query, con);
            delete.ExecuteNonQuery();
            con.Close();
        }
        public void updateObjectByName(int quantite, string pharmacieCode, string objetCode)
        {
            con.Open();
            string query = "UPDATE stocks SET quantite = " + quantite +" WHERE pharmacieCode = '" + pharmacieCode +  "' and objetCode = '" + objetCode + "';";
            MySqlCommand update = new MySqlCommand(query, con);
            update.ExecuteNonQuery();
            con.Close();
        }
        public void insertObject(int quantite, string pharmacieCode, string objetCode)
        {
            con.Open();
            string query = "INSERT INTO stocks (pharmacieCode, objetCode, quantite) VALUES('" + pharmacieCode + "', '" + objetCode + "', " + quantite + "); ";
            MySqlCommand insert = new MySqlCommand(query, con);
            insert.ExecuteNonQuery();
            con.Close();
        }
    }
}
