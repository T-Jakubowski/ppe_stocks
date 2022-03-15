using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gestion_Stock_PPE
{
    internal class DAOPharmacie
    {
        private MySqlConnection con;
        public DAOPharmacie()
        {
            con = new MySqlConnection("server=localhost;userid=root;password=;database=stocks");
        }
        public void get(string nom)
        {
            con.Open();
            MySqlCommand command = new MySqlCommand("Select * from pharmacie where identifiant = '" + nom + "';", con);
            // int result = command.ExecuteNonQuery();
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                if (reader.Read())
                {
                    Console.WriteLine("fake");
                }
                con.Close();
            }
        }
        public void delete(string pharmacieCode)
        {
            con.Open();
            string query = "delete from pharmacie WHERE pharmacieCode = '" + pharmacieCode + "';";
            MySqlCommand delete = new MySqlCommand(query, con);
            delete.ExecuteNonQuery();
            con.Close();
        }
        public void updateByName(string pharmacieCode, string nom, string ville)
        {
            con.Open();
            string query = "UPDATE pharmacie SET nom = '" + nom + "', ville = '" + ville + "' where pharmacieCode = '"+pharmacieCode+"';";
            MySqlCommand update = new MySqlCommand(query, con);
            update.ExecuteNonQuery();
            con.Close();
        }
        public void insert(string pharmacieCode, string nom, string ville)
        {
            con.Open();
            string query = "INSERT INTO pharmacie (pharmacieCode, nom, ville) VALUES('" + pharmacieCode + "', '" + nom + "', '" + ville + "');";
            MySqlCommand insert = new MySqlCommand(query, con);
            insert.ExecuteNonQuery();
            con.Close();
        }
    }
}
