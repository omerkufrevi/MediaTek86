using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek86.controleur;
using MediaTek86.dal;
using Mysqlx;

namespace MediaTek86.vue
{
    /// <summary>
    /// Form connexion.
    /// </summary>
    public partial class vueConnexion : Form
    {
        private ctrlResponsable controleur = new ctrlResponsable();

        /// <summary>
        /// Vue permettant de visualiser le panel Connexion.
        /// </summary>
        public vueConnexion()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Bouton connexion.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string loginText = txtboxLogin.Text;
            string pwdText = txtboxPwd.Text;
            // Vérification si aucun champ n'a été remplie.
            if (loginText == "" || pwdText == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }
            else
            {
                bool resultat = controleur.controleConnexion(loginText, pwdText);
                if (resultat)
                {
                    MessageBox.Show("Connexion réussie");
                    vuePersonnel frm = new vuePersonnel();
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Erreur");
                }
            }
        }
    }
}
