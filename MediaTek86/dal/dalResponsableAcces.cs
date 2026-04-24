using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.bddmanager;
using MediaTek86.modele;
using MySql.Data.MySqlClient;
using Org.BouncyCastle.Ocsp;

namespace MediaTek86.dal
{
    /// <summary>
    /// Classe permettant d'acceder aux données pour les responsables
    /// </summary>
    internal class dalResponsableAcces
    {
        public static bool controleConnexion(string loginText, string pwdText)
        {
            bool connexionOK = false;
            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();
                string requetteSql = "SELECT * FROM responsable WHERE login = @login AND pwd = SHA2(@pwd, 256)";
                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    cmd.Parameters.AddWithValue("@login", loginText);
                    cmd.Parameters.AddWithValue("@pwd", pwdText);

                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            connexionOK = true;
                        }
                    }
                }
            }
            return connexionOK;
        }
    }
}
