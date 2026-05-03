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
    /// Classe gérant les opérations liées au motif.
    /// </summary>
    internal class ctrlMotif
    {
        /// <summary>
        /// Récuperer la liste des motifs.
        /// </summary>
        /// <returns></returns>
        public List<mdlMotif> GetMotif()
        {
            return dalMotifList.GetMotif();
        }

        /// <summary>
        /// Récupérer les informations d’un motif.
        /// </summary>
        /// <param name="idmotif"></param>
        /// <returns></returns>
        public mdlMotif GetMotifName(int idmotif)
        {
            return dalMotifList.GetMotifName(idmotif);
        }
    }
}
