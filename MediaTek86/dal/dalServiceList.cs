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
    /// Classe permettant d'acceder aux données pour les services.
    /// </summary>
    internal class dalServiceList
    {
        /// <summary>
        /// Récupérer la liste des services.
        /// </summary>
        /// <returns></returns>
        public static List<mdlService> GetService()
        {
            // Liste qui va contenir les services
            List<mdlService> services = new List<mdlService>();

            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();

                // Requête pour récupérer tous les services
                string req = "SELECT * FROM service";

                using (MySqlCommand cmd = new MySqlCommand(req, connection))
                using (MySqlDataReader reader = cmd.ExecuteReader())
                {
                    // Lecture des résultats
                    while (reader.Read())
                    {
                        // Création d’un objet Service avec les données de la BDD
                        mdlService service = new mdlService(
                            reader.GetInt32("idservice"),
                            reader.GetString("nom")
                        );
                        // Ajout dans la liste
                        services.Add(service);
                    }
                }
            }

            return services;
        }

        /// <summary>
        /// Récupérer les informations d’un service.
        /// </summary>
        /// <param name="idservice"></param>
        /// <returns></returns>
        public static mdlService GetServiceName(int idservice)
        {
            // Variable qui contiendra le service trouvé
            mdlService serviceName = null;

            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();

                // Requête pour récupérer un service par son id
                string requetteSql = "SELECT * FROM service WHERE idservice = @idservice";

                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    cmd.Parameters.AddWithValue("@idservice", idservice);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        // Si un résultat est trouvé
                        if (reader.Read())
                        {
                            // Création de l’objet avec les données de la BDD
                            serviceName = new mdlService(
                                reader.GetInt32("idservice"),
                                reader.GetString("nom")
                            );
                        }
                    }
                }
            }
            return serviceName;
        }
    }
}
