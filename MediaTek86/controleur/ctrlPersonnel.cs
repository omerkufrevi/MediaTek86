using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaTek86.dal;
using MediaTek86.modele;

namespace MediaTek86.controleur
{
    /// <summary>
    /// Classe gérant les opérations liées au personnel.
    /// </summary>
    internal class ctrlPersonnel
    {
        /// <summary>
        /// Récupérer la liste des personnels.
        /// </summary>
        /// <returns></returns>
        public List<mdlPersonnel> GetPersonnelList()
        {
            return dalPersonnelList.GetPersonnelList();
        }

        /// <summary>
        /// Récupérer les informations d’un personnel.
        /// </summary>
        /// <param name="selectedindex"></param>
        /// <returns></returns>
        public mdlPersonnel GetPersonnelInfo(int selectedindex)
        {
            return dalPersonnelList.GetPersonnelInfo(selectedindex);
        }

        /// <summary>
        /// Ajouter un nouveau personnel.
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idservice"></param>
        public void SetPersonnelList(string nom, string prenom, string tel, string mail, int idservice)
        {
            dalPersonnelList.SetPersonnelList(nom, prenom, tel, mail, idservice);
        }

        /// <summary>
        /// Modifier un personnel existant.
        /// </summary>
        /// <param name="nom"></param>
        /// <param name="prenom"></param>
        /// <param name="tel"></param>
        /// <param name="mail"></param>
        /// <param name="idservice"></param>
        /// <param name="idpersonnel"></param>
        public void ModifierPersonnelList(string nom, string prenom, string tel, string mail, int idservice, int idpersonnel)
        {
            dalPersonnelList.ModifierPersonnelList(nom, prenom, tel, mail, idservice, idpersonnel);
        }

        /// <summary>
        /// Supprimer un personnel.
        /// </summary>
        /// <param name="idpersonnel"></param>
        public void DeletePersonnelList(int idpersonnel)
        {
            dalPersonnelList.DeletePersonnelList(idpersonnel);
        }
    }
}
