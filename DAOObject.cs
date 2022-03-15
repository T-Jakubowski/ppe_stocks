using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gestion_Stock_PPE
{
    internal class DAOObject
    {
        private MySqlConnection con;

        public DAOObject()
        {
            con = new MySqlConnection("server=localhost;userid=root;password=;database=stocks");
        }
        public void get(string nom)
        {
            con.Open();
            MySqlCommand command = new MySqlCommand("Select * from objet where nom = '" + nom + "';", con);
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
        public void delete(string objetCode)
        {
            con.Open();
            string query = "delete from objet WHERE objetCode = '" + objetCode + "';";
            MySqlCommand delete = new MySqlCommand(query, con);
            delete.ExecuteNonQuery();
            con.Close();
        }
        public void updateByName(string objetCode, string nom, string composition)
        {
            con.Open();
            string query = "UPDATE objet SET nom = '" + nom + "', composition = '" + composition + "' where objetCode = '" + objetCode + "  ';";
            MySqlCommand update = new MySqlCommand(query, con);
            update.ExecuteNonQuery();
            con.Close();
        }
        public void insert(string objetCode, string nom, string composition)
        {
            con.Open();
            string query = "INSERT INTO objet (objetCode, nom, composition) VALUES('"+ objetCode +"', '"+ nom +"', '"+composition+"');";
            MySqlCommand insert = new MySqlCommand(query, con);
            insert.ExecuteNonQuery();
            con.Close();
        }
    }
}
