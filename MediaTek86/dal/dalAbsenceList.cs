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

        public static bool ExistAbsence(int idpersonnel, DateTime datedebut, DateTime datefin)
        {
            bool result = false;
            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();
                string requetteSql = "SELECT COUNT(*) FROM absence WHERE idpersonnel = @idpersonnel AND @datedebut <= datefin AND @datefin >= datedebut";
                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    cmd.Parameters.AddWithValue("@idpersonnel", idpersonnel);
                    cmd.Parameters.AddWithValue("@datedebut", datedebut);
                    cmd.Parameters.AddWithValue("@datefin", datefin);
                    
                    int count = Convert.ToInt32(cmd.ExecuteScalar());
                    if (count > 0) 
                    {
                        result = true;
                        return result;
                    }
                    else { return result; }
                }
            }
        }

        public static bool ExistAbsenceModif(int idpersonnel, DateTime datedebut, DateTime datefin, DateTime datedebutavant, DateTime datefinavant)
        {
            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();

                string req = @"SELECT COUNT(*) FROM absence WHERE idpersonnel = @idpersonnel AND @datedebut <= datefin AND @datefin >= datedebut AND NOT (datedebut = @datedebutavant AND datefin = @datefinavant)";

                using (MySqlCommand cmd = new MySqlCommand(req, connection))
                {
                    cmd.Parameters.AddWithValue("@idpersonnel", idpersonnel);
                    cmd.Parameters.AddWithValue("@datedebut", datedebut);
                    cmd.Parameters.AddWithValue("@datefin", datefin);
                    cmd.Parameters.AddWithValue("@datedebutavant", datedebutavant);
                    cmd.Parameters.AddWithValue("@datefinavant", datefinavant);

                    return Convert.ToInt32(cmd.ExecuteScalar()) > 0;
                }
            }
        }

        public static void SetAbsence(int idpersonnel, DateTime datedebut, DateTime datefin, int idmotif)
        {
            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();
                string requetteSql = "INSERT INTO absence (idpersonnel, datedebut, datefin, idmotif) VALUES (@idpersonnel, @datedebut, @datefin, @idmotif)";
                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    cmd.Parameters.AddWithValue("@idpersonnel", idpersonnel);
                    cmd.Parameters.AddWithValue("@datedebut", datedebut);
                    cmd.Parameters.AddWithValue("@datefin", datefin);
                    cmd.Parameters.AddWithValue("@idmotif", idmotif);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void ModifierAbsence(int idpersonnel, DateTime datedebut, DateTime datefin, int motif, DateTime datedebutavant, DateTime datefinavant, int motifavant)
        {
            using (MySqlConnection connection = BddManager.GetConnection())
            {
                connection.Open();
                string requetteSql = "UPDATE absence SET idpersonnel = @idpersonnel, datedebut = @datedebut, datefin = @datefin, idmotif = @idmotif WHERE idpersonnel = @idpersonnel AND datedebut = @datedebutavant AND datefin = @datefinavant AND idmotif = @motifavant";
                using (MySqlCommand cmd = new MySqlCommand(requetteSql, connection))
                {
                    cmd.Parameters.AddWithValue("@datedebut", datedebut);
                    cmd.Parameters.AddWithValue("@datefin", datefin);
                    cmd.Parameters.AddWithValue("@idmotif", motif);
                    cmd.Parameters.AddWithValue("@idpersonnel", idpersonnel);
                    cmd.Parameters.AddWithValue("@datedebutavant", datedebutavant);
                    cmd.Parameters.AddWithValue("@datefinavant", datefinavant);
                    cmd.Parameters.AddWithValue("@motifavant", motifavant);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}
