using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe représentant les motifs.
    /// </summary>
    internal class mdlMotif
    {
        // Identifiant du motif
        public int idMotif { get; set; }
        // Le libelle
        public string libelle { get; set; }

        public mdlMotif(int idMotif, string libelle)
        {
            this.idMotif = idMotif;
            this.libelle = libelle;
        }
    }
}
