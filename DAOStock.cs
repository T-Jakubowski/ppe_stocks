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
        public void getObject()
        {
            con.Open();
            con.Close();
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
