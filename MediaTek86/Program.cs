using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek86.vue;

namespace MediaTek86
{
    /// <summary>
    /// Application de gestion de personnel et d'absence.
    /// </summary>
    internal class NamespaceDoc
    {
    }
    internal static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new vueConnexion());
        }
    }
}
