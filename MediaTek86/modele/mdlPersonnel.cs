using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Design;
using MediaTek86.dal;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe représentant un personnel de l'application.
    /// </summary>
    internal class mdlPersonnel
    {
        // Identifiant du personnel
        public int idPersonnel { get; set; }

        // Informations personnelles
        public string nom { get; set; }
        public string prenom { get; set; }
        public string tel { get; set; }
        public string mail { get; set; }

        // Service associé
        public int idService { get; set; }

        /// <summary>
        /// Chaîne pour affichage dans une ListBox.
        /// </summary>
        public string NomPrenomTeletc
        {
            get 
            {
                mdlService service = dalServiceList.GetServiceName(idService);
                return nom + " " + prenom + " - " + tel + " - " + mail + " - " + service.nomS;
            }
        }

        /// <summary>
        /// Constructeur du personnel.
        /// </summary>
        /// <param name="idPersonnel"></param>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idService"></param>
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
