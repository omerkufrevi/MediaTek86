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
    /// Classe gérant les opérations liées aux absences.
    /// </summary>
    internal class ctrlAbsence
    {
        /// <summary>
        /// Récupérer la liste des absences d’un personnel.
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <returns></returns>
        public List<mdlAbsence> GetAbsenceList(int idpersonnel)
        {
            return dalAbsenceList.GetAbsenceList(idpersonnel);
        }

        /// <summary>
        /// Vérifier s’il existe un chevauchement d’absence.
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <returns></returns>
        public bool ExistAbsence(int idpersonnel, DateTime datedebut, DateTime datefin)
        {
            return dalAbsenceList.ExistAbsence(idpersonnel, datedebut, datefin);
        }

        /// <summary>
        /// Vérifier un chevauchement lors d’une modification.
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="datedebutavant"></param>
        /// <param name="datefinavant"></param>
        /// <returns></returns>
        public bool ExistAbsenceModif(int idpersonnel, DateTime datedebut, DateTime datefin, DateTime datedebutavant, DateTime datefinavant)
        {
            return dalAbsenceList.ExistAbsenceModif(idpersonnel, datedebut, datefin, datedebutavant, datefinavant);
        }

        /// <summary>
        /// Ajouter une nouvelle absence.
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="idmotif"></param>
        public void SetAbsence(int idpersonnel, DateTime datedebut, DateTime datefin, int idmotif)
        {
            dalAbsenceList.SetAbsence(idpersonnel, datedebut, datefin, idmotif);
        }

        /// <summary>
        /// Modifier une absence existante.
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        /// <param name="datedebutavant"></param>
        /// <param name="datefinavant"></param>
        /// <param name="motifavant"></param>
        public void ModifierAbsence(int idpersonnel, DateTime datedebut, DateTime datefin, int motif, DateTime datedebutavant, DateTime datefinavant, int motifavant)
        {
            dalAbsenceList.ModifierAbsence(idpersonnel, datedebut, datefin, motif, datedebutavant, datefinavant, motifavant);
        }

        /// <summary>
        /// Supprimer une absence.
        /// </summary>
        /// <param name="idpersonnel"></param>
        /// <param name="datedebut"></param>
        /// <param name="datefin"></param>
        /// <param name="motif"></param>
        public void DeleteAbsenceList(int idpersonnel, DateTime datedebut, DateTime datefin, int motif)
        {
            dalAbsenceList.DeleteAbsenceList(idpersonnel, datedebut, datefin, motif);
        }
    }
}
