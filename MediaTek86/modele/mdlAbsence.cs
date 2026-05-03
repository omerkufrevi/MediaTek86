using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using MediaTek86.controleur;
using MediaTek86.dal;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe représentant une absence de l'application.
    /// </summary>
    internal class mdlAbsence
    {
        // Identifiant du personnel
        public int idPersonnel { get; set; }

        // Informations de l'absence
        public DateTime datedebut { get; set; }
        public DateTime datefin { get; set; }
        public int idMotif { get; set; }

        /// <summary>
        /// Chaîne pour affichage dans une ListBox.
        /// </summary>
        public string DateDebutDateFinMotif
        {
            get {
                // Méthode pour obtenir le libelle du motif
                mdlMotif motif = dalMotifList.GetMotifName(idMotif);
                return datedebut + " - " + datefin + " | Motif : " + motif.libelle;
            }
        }

        /// <summary>
        /// Constructeur de l'absence.
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idMotif"></param>
        public mdlAbsence(int idPersonnel, DateTime datedebut, DateTime datefin, int idMotif)
        {
            this.idPersonnel = idPersonnel;
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.idMotif = idMotif;
        }
    }
}
