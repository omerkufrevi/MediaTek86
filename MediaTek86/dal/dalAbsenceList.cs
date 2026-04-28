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
    internal class dalAbsenceList
    {
        public static List<mdlAbsence> GetAbsenceList(int idpersonnel)
        {
            List<mdlAbsence> lesAbsences = new List<mdlAbsence>();
            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();
                string requetteSql = "SELECT * FROM absence WHERE idpersonnel = @idpersonnel";
                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    cmd.Parameters.AddWithValue("@idpersonnel", idpersonnel);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            mdlAbsence absence = new mdlAbsence(
                                reader.GetInt32("idpersonnel"),
                                reader.GetDateTime("datedebut"),
                                reader.GetDateTime("datefin"),
                                reader.GetInt32("idmotif")
                            );
                            lesAbsences.Add(absence);
                        }
                    }
                }
            }
            return lesAbsences;
        }
    }
}
