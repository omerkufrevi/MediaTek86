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
    /// <summary>
    /// Classe permettant d'acceder aux données pour les motifs.
    /// </summary>
    internal class dalMotifList
    {
        /// <summary>
        /// Récupérer la liste des motifs.
        /// </summary>
        /// <returns></returns>
        public static List<mdlMotif> GetMotif()
        {
            List<mdlMotif> motifs = new List<mdlMotif>();

            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();

                string req = "SELECT * FROM motif";

                using (MySqlCommand cmd = new MySqlCommand(req, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        mdlMotif motif = new mdlMotif(
                            reader.GetInt32("idmotif"),
                            reader.GetString("libelle")
                        );

                        motifs.Add(motif);
                    }
                }
            }

            return motifs;
        }

        /// <summary>
        /// Récupérer les informations d’un motif.
        /// </summary>
        /// <param name="idmotif"></param>
        /// <returns></returns>
        public static mdlMotif GetMotifName(int idmotif)
        {
            // Variable qui contiendra le motif trouvé
            mdlMotif motifName = null;

            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();

                // Requête pour récupérer un motif par son id
                string requetteSql = "SELECT * FROM motif WHERE idmotif = @idmotif";

                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    cmd.Parameters.AddWithValue("@idmotif", idmotif);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Si un résultat est trouvé
                        if (reader.Read())
                        {
                            // Création de l’objet avec les données de la BDD
                            motifName = new mdlMotif(
                                reader.GetInt32("idmotif"),
                                reader.GetString("libelle")
                            );
                        }
                    }
                }
            }
            return motifName;
        }
    }
}
