using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaTek86.modele
{
    /// <summary>
    /// Classe représentant les services.
    /// </summary>
    internal class mdlService
    {
        // Identifiant du service
        public int idService { get; set; }
        // Le nom
        public string nomS { get; set; }

        /// <summary>
        /// Constructeur du service.
        /// </summary>
        /// <param name="idService"></param>
        /// <param name="nomS"></param>
        public mdlService(int idService, string nomS)
        {
            this.idService = idService;
            this.nomS = nomS;
        }
    }
}
