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

                string requetteSql = "SELECT idpersonnel, nom, prenom, tel, mail, idservice FROM personnel";

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
    }
}
