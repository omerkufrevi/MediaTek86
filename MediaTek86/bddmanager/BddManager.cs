using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace MediaTek86.bddmanager
{
    /// <summary>
    /// Classe permettant d'établir la connexion a la base de données.
    /// </summary>
    internal class BddManager
    {
        // Chaîne de connexion à la base de données
        private static string connectionString = "Server=localhost;Database=MediaTek86;User Id=root;Password=;";
        public static MySqlConnection GetConnection()
        {
            MySqlConnection connection = new MySqlConnection(connectionString);
            return connection;
        }
    }
}
