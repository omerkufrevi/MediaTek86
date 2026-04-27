using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe représentant un personnel de l'application.
    /// </summary>
    internal class mdlPersonnel
    {
        public int idPersonnel { get; set; }
        public string nom { get; set; }
        public string prenom { get; set; }
        public string tel { get; set; }
        public string mail { get; set; }
        public int idService { get; set; }
        public string NomPrenomTeletc
        {
            get { return nom + " " + prenom + " " + tel + " " + mail + " " + idService; }
        }
        public mdlPersonnel(int idPersonnel, string nom, string prenom, string tel, string mail, int idService)
        {
            this.idPersonnel = idPersonnel;
            this.nom = nom;
            this.prenom = prenom;
            this.tel = tel;
            this.mail = mail;
            this.idService = idService;
        }
    }
}
