using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gestion_Stock_PPE
{
    internal class DAOUser
    {
        private MySqlConnection con;

        public DAOUser()
        {
            con = new MySqlConnection("server=localhost;userid=root;password=;database=stocks");
        }
        public void get(string identifiant)
        {
            con.Open();
            MySqlCommand command = new MySqlCommand("Select * from user where identifiant = '" + identifiant + "';", con);
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
        public void delete(string identifiant)
        {
            con.Open();
            string query = "delete from user WHERE identifiant = '" + identifiant + "';";
            MySqlCommand delete = new MySqlCommand(query, con);
            delete.ExecuteNonQuery();
            con.Close();
        }
        public void updateById(string identifiant, string nom, string prenom, string password, int idRole, string pharmacieCode)
        {
            con.Open();
            string query = "UPDATE user SET nom = '" + nom + "', prenom = '" + prenom + "', password = '" + password + "', idRole = '" + idRole + "', pharmacieCode = '" + pharmacieCode + "' where identifiant = '" + identifiant + "';";
            MySqlCommand update = new MySqlCommand(query, con);
            update.ExecuteNonQuery();
            con.Close();
        }
        public void insert(string identifiant, string nom, string prenom, string password, int idRole, string pharmacieCode)
        {
            con.Open();
            string query = "INSERT INTO user (identifiant, nom, prenom, password, idRole, pharmacieCode) VALUES('" + identifiant + "', '" + nom + "', '" + prenom + "', '" + password + "', '" + idRole + "', '" + pharmacieCode + "');";
            MySqlCommand insert = new MySqlCommand(query, con);
            insert.ExecuteNonQuery();
            con.Close();
        }
    }
}
