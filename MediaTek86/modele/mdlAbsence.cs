using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe représentant une absence de l'application.
    /// </summary>
    internal class mdlAbsence
    {
        public int idPersonnel { get; set; }
        public DateTime datedebut { get; set; }
        public DateTime datefin { get; set; }
        public int idMotif { get; set; }
        public string DateDebutDateFinMotif
        {
            get { return datedebut + " - " + datefin + " | Motif : " + idMotif; }
        }
        public mdlAbsence(int idPersonnel, DateTime datedebut, DateTime datefin, int idMotif)
        {
            this.idPersonnel = idPersonnel;
            this.datedebut = datedebut;
            this.datefin = datefin;
            this.idMotif = idMotif;
        }
    }
}
