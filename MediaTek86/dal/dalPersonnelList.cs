using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
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
                {
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
            }
            return lesPersonnels;
        }

        public static mdlPersonnel GetPersonnelInfo(int selectedindex)
        {
            mdlPersonnel personnelInfo = null;
            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();
                string requetteSql = "SELECT * FROM personnel WHERE idpersonnel = @idpersonnel";
                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    cmd.Parameters.AddWithValue("@idpersonnel", selectedindex);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {

                        if (reader.Read())
                        {
                            personnelInfo = new mdlPersonnel(
                                reader.GetInt32("idpersonnel"),
                                reader.GetString("nom"),
                                reader.GetString("prenom"),
                                reader.GetString("tel"),
                                reader.GetString("mail"),
                                reader.GetInt32("idservice")
                            );
                        }
                    }
                }
            }
            return personnelInfo;
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

        public static void ModifierPersonnelList(string nom, string prenom, string tel, string mail, int idservice, int idpersonne)
        {
            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();
                string requetteSql = "UPDATE personnel SET idpersonnel = @idpersonne, nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice WHERE idpersonnel = @idpersonne;";
                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@tel", tel);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@idservice", idservice);
                    cmd.Parameters.AddWithValue("@idpersonne", idpersonne);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeletePersonnelList(int idpersonnel)
        {
            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();
                string requetteSql = "DELETE FROM personnel WHERE idpersonnel = @idpersonnel";
                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    cmd.Parameters.AddWithValue("@idpersonnel", idpersonnel);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
