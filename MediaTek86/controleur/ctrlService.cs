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
    /// Classe gérant les opérations liées au service.
    /// </summary>
    internal class ctrlService
    {
        /// <summary>
        /// Récuperer la liste des services.
        /// </summary>
        /// <returns></returns>
        public List<mdlService> GetService()
        {
            return dalServiceList.GetService();
        }

        /// <summary>
        /// Récupérer les informations d’un service.
        /// </summary>
        /// <param name="idservice"></param>
        /// <returns></returns>
        public mdlService GetServiceName(int idservice)
        {
            return dalServiceList.GetServiceName(idservice);
        }
    }
}
