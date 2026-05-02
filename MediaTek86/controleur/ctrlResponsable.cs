using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.bddmanager;
using MediaTek86.dal;
using MySql.Data.MySqlClient;

namespace MediaTek86.controleur
{
    /// <summary>
    /// Gère la connexion des responsables.
    /// </summary>
    internal class ctrlResponsable
    {
        /// <summary>
        /// Vérifie les identifiants saisis.
        /// </summary>
        public bool controleConnexion(string loginText, string pwdText)
        {
            return dalResponsableAcces.controleConnexion(loginText, pwdText);
        }
    }
}