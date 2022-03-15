using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Gestion_Stock_PPE
{
    internal class DAORole
    {
        private MySqlConnection con;

        public DAORole()
        {
            con = new MySqlConnection("server=localhost;userid=root;password=;database=stocks");
        }
        public void get()
        {
            con.Open();
            MySqlCommand command = new MySqlCommand("Select * from role;", con);
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
        public void delete(int id)
        {
            con.Open();
            string query = "delete from role WHERE id = " + id;
            MySqlCommand delete = new MySqlCommand(query, con);
            delete.ExecuteNonQuery();
            con.Close();
        }
        public void updateById(int id, string nom, string permission)
        {
            con.Open();
            string query = "UPDATE role SET nom = '" + nom + "', permission = '" + permission + "' where id = " + id;
            MySqlCommand update = new MySqlCommand(query, con);
            update.ExecuteNonQuery();
            con.Close();
        }
        public void insert(string nom, string permission)
        {
            con.Open();
            string query = "INSERT INTO role (nom, permission) VALUES('" + nom + "', '" + permission + "');";
            MySqlCommand insert = new MySqlCommand(query, con);
            insert.ExecuteNonQuery();
            con.Close();
        }
    }
}
