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
    /// <summary>
    /// Classe permettant d'acceder aux données pour les personnels.
    /// </summary>
    internal class dalPersonnelList
    {
        /// <summary>
        /// Récupérer la liste des personnels.
        /// </summary>
        /// <returns></returns>
        public static List<mdlPersonnel> GetPersonnelList()
        {
            // Liste qui va contenir les personnels
            List<mdlPersonnel> lesPersonnels = new List<mdlPersonnel>();

            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();

                // Requête pour récupérer tous les personnels
                string requetteSql = "SELECT * FROM personnel";

                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Lecture des résultats
                        while (reader.Read())
                        {
                            // Création d’un objet Personnel avec les données de la BDD
                            mdlPersonnel personnel = new mdlPersonnel(
                                reader.GetInt32("idpersonnel"),
                                reader.GetString("nom"),
                                reader.GetString("prenom"),
                                reader.GetString("tel"),
                                reader.GetString("mail"),
                                reader.GetInt32("idservice")
                            );
                            // Ajout dans la liste
                            lesPersonnels.Add(personnel);
                        }
                    }
                }  
            }
            return lesPersonnels;
        }

        /// <summary>
        /// Récupérer les informations d’un personnel.
        /// </summary>
        /// <param name="selectedindex"></param>
        /// <returns></returns>
        public static mdlPersonnel GetPersonnelInfo(int selectedindex)
        {
            // Variable qui contiendra le personnel trouvé
            mdlPersonnel personnelInfo = null;

            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();

                // Requête pour récupérer un personnel par son id
                string requetteSql = "SELECT * FROM personnel WHERE idpersonnel = @idpersonnel";

                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    cmd.Parameters.AddWithValue("@idpersonnel", selectedindex);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Si un résultat est trouvé
                        if (reader.Read())
                        {
                            // Création de l’objet avec les données de la BDD
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

        /// <summary>
        /// Ajouter un nouveau personnel.
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idservice"></param>
        public static void SetPersonnelList(string nom, string prenom, string tel, string mail, int idservice)
        {
            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();

                // Requête d'insertion d'un nouveau personnel
                string requetteSql = "INSERT INTO personnel (nom, prenom, tel, mail, idservice) VALUES (@nom, @prenom, @tel, @mail, @idservice)";

                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    // Ajout des paramètres
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@tel", tel);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@idservice", idservice);
                    // Exécution de la requête
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Modifier un personnel existant.
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idservice"></param>
        /// <param name="idpersonnel"></param>
        public static void ModifierPersonnelList(string nom, string prenom, string tel, string mail, int idservice, int idpersonnel)
        {
            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();

                // Requête de mise à jour du personnel
                string requetteSql = "UPDATE personnel SET nom = @nom, prenom = @prenom, tel = @tel, mail = @mail, idservice = @idservice WHERE idpersonnel = @idpersonnel;";

                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    // Ajout des paramètres
                    cmd.Parameters.AddWithValue("@nom", nom);
                    cmd.Parameters.AddWithValue("@prenom", prenom);
                    cmd.Parameters.AddWithValue("@tel", tel);
                    cmd.Parameters.AddWithValue("@mail", mail);
                    cmd.Parameters.AddWithValue("@idservice", idservice);
                    cmd.Parameters.AddWithValue("@idpersonnel", idpersonnel);
                    // Exécution de la requête
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Supprimer un personnel.
        /// </summary>
        /// <param name="idpersonnel"></param>
        public static void DeletePersonnelList(int idpersonnel)
        {
            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();

                // Requête de suppression du personnel
                string requetteSql = "DELETE FROM personnel WHERE idpersonnel = @idpersonnel";

                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    // Ajout des paramètres
                    cmd.Parameters.AddWithValue("@idpersonnel", idpersonnel);
                    // Exécution de la requête
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
