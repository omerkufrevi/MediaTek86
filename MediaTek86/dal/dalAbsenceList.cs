using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using MediaTek86.bddmanager;
using MediaTek86.modele;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant d'acceder aux données pour les absences.
    /// </summary>
    internal class dalAbsenceList
    {
        /// <summary>
        /// Récupérer la liste des absences d’un personnel.
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <returns></returns>
        public static List<mdlAbsence> GetAbsenceList(int idpersonnel)
        {
            // Liste qui va contenir les absences
            List<mdlAbsence> lesAbsences = new List<mdlAbsence>();

            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();

                // Requête pour récupérer tous les absences d'un personnel
                string requetteSql = "SELECT * FROM absence WHERE idpersonnel = @idpersonnel";

                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    // Ajout des paramètres
                    cmd.Parameters.AddWithValue("@idpersonnel", idpersonnel);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Lecture des résultats
                        while (reader.Read())
                        {
                            // Création d’un objet Absence avec les données de la BDD
                            mdlAbsence absence = new mdlAbsence(
                                reader.GetInt32("idpersonnel"),
                                reader.GetDateTime("datedebut"),
                                reader.GetDateTime("datefin"),
                                reader.GetInt32("idmotif")
                            );
                            // Ajout dans la liste
                            lesAbsences.Add(absence);
                        }
                    }
                }
            }
            return lesAbsences;
        }

        /// <summary>
        /// Vérifier s’il existe un chevauchement d’absence.
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <returns></returns>
        public static bool ExistAbsence(int idpersonnel, DateTime datedebut, DateTime datefin)
        {
            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();

                // Requête pour vérifier s'il existe un chevauchement d’absence
                string requetteSql = "SELECT COUNT(*) FROM absence WHERE idpersonnel = @idpersonnel AND @datedebut <= datefin AND @datefin >= datedebut";
                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    // Ajout des paramétres
                    cmd.Parameters.AddWithValue("@idpersonnel", idpersonnel);
                    cmd.Parameters.AddWithValue("@datedebut", datedebut);
                    cmd.Parameters.AddWithValue("@datefin", datefin);
                    
                    // Si il trouve plus de 0 cela valide l'existance d'un chevauchement
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        /// <summary>
        /// Vérifier un chevauchement lors d’une modification.
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="datedebutavant"></param>
        /// <param name="datefinavant"></param>
        /// <returns></returns>
        public static bool ExistAbsenceModif(int idpersonnel, DateTime datedebut, DateTime datefin, DateTime datedebutavant, DateTime datefinavant)
        {
            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();

                // Requête pour vérifier s'il existe un chevauchement d’absence
                string req = @"SELECT COUNT(*) FROM absence WHERE idpersonnel = @idpersonnel AND @datedebut <= datefin AND @datefin >= datedebut AND NOT (datedebut = @datedebutavant AND datefin = @datefinavant)";

                using (MySqlCommand cmd = new MySqlCommand(req, connection))
                {
                    // Ajout des paramétres
                    cmd.Parameters.AddWithValue("@idpersonnel", idpersonnel);
                    cmd.Parameters.AddWithValue("@datedebut", datedebut);
                    cmd.Parameters.AddWithValue("@datefin", datefin);
                    cmd.Parameters.AddWithValue("@datedebutavant", datedebutavant);
                    cmd.Parameters.AddWithValue("@datefinavant", datefinavant);

                    // Si il trouve plus de 0 cela valide l'existance d'un chevauchement sauf celle de l'original
                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        /// <summary>
        /// Ajouter une nouvelle absence.
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idmotif"></param>
        public static void SetAbsence(int idpersonnel, DateTime datedebut, DateTime datefin, int idmotif)
        {
            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();

                // Requête pour insérer une nouvelle absence
                string requetteSql = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES (@idpersonnel, @datedebut, @datefin, @idmotif)";

                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    // Ajout des paramétres
                    cmd.Parameters.AddWithValue("@idpersonnel", idpersonnel);
                    cmd.Parameters.AddWithValue("@datedebut", datedebut);
                    cmd.Parameters.AddWithValue("@datefin", datefin);
                    cmd.Parameters.AddWithValue("@idmotif", idmotif);
                    // Exécution de la requête
                    cmd.ExecuteNonQuery();
                }
            }
        }

        /// <summary>
        /// Modifier une absence existante.
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        /// <param name="datedebutavant"></param>
        /// <param name="datefinavant"></param>
        /// <param name="motifavant"></param>
        public static void ModifierAbsence(int idpersonnel, DateTime datedebut, DateTime datefin, int motif, DateTime datedebutavant, DateTime datefinavant, int motifavant)
        {
            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();

                // Requête pour modifier une absence existante
                string requetteSql = "UPDATE absence SET idpersonnel = @idpersonnel, datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif WHERE idpersonnel = @idpersonnel AND datedebut = @datedebutavant AND datefin = @datefinavant AND idmotif = @motifavant";

                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    // Ajout des paramétres
                    cmd.Parameters.AddWithValue("@datedebut", datedebut);
                    cmd.Parameters.AddWithValue("@datefin", datefin);
                    cmd.Parameters.AddWithValue("@idmotif", motif);
                    cmd.Parameters.AddWithValue("@idpersonnel", idpersonnel);
                    cmd.Parameters.AddWithValue("@datedebutavant", datedebutavant);
                    cmd.Parameters.AddWithValue("@datefinavant", datefinavant);
                    cmd.Parameters.AddWithValue("@motifavant", motifavant);
                    // Exécution de la requête
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void DeleteAbsenceList(int idpersonnel, DateTime datedebut, DateTime datefin, int motif)
        {
            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();

                // Requête pour supprimer une absence
                string requetteSql = "DELETE FROM absence WHERE idpersonnel = @idpersonnel AND datedebut = @datedebut AND datefin = @datefin AND idmotif = @idmotif";

                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    // Ajout des paramétres
                    cmd.Parameters.AddWithValue("@datedebut", datedebut);
                    cmd.Parameters.AddWithValue("@datefin", datefin);
                    cmd.Parameters.AddWithValue("@idmotif", motif);
                    cmd.Parameters.AddWithValue("@idpersonnel", idpersonnel);
                    // Exécution de la requête
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
