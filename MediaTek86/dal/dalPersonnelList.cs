using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.bddmanager;
using MediaTek86.modele;
using MySql.Data.MySqlClient;

namespace MediaTek86.dal
{
    internal class dalPersonnelList
    {
        public static List<mdlPersonnel> GetPersonnelList()
        {
            List<mdlPersonnel> lesPersonnels = new List<mdlPersonnel>();
            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();
                string requetteSql = "SELECT * FROM personnel";
                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mdlPersonnel personnel = new mdlPersonnel(
                            reader.GetInt32("idpersonnel"),
                            reader.GetString("nom"),
                            reader.GetString("prenom"),
                            reader.GetString("tel"),
                            reader.GetString("mail"),
                            reader.GetInt32("idservice")
                        );
                        lesPersonnels.Add(personnel);
                    }
                }
            }
            return lesPersonnels;
        }

        public static void SetPersonnelList(string nom, string prenom, string tel, string mail, int idservice)
        {
            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();
                string requetteSql = "INSERT INTO personnel (nom, prenom, tel, mail, idservice) VALUES (@nom, @prenom, @tel, @mail, @idservice)";
                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@tel", tel);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@idservice", idservice);
                    cmd.ExecuteNonQuery();
                }
            }
        } 
    }
}
