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
using MediaTek86.modele;

namespace MediaTek86.vue
{
    /// <summary>
    /// Form Personnel.
    /// </summary>
    public partial class vuePersonnel : Form
    {
        private ctrlPersonnel controleur = new ctrlPersonnel();

        /// <summary>
        /// Vue permettant de visualiser le panel Personnel.
        /// </summary>
        public vuePersonnel()
        {
            InitializeComponent();
            ListPrsnl.DataSource = controleur.GetPersonnelList();
            ListPrsnl.DisplayMember = "NomPrenomTeletc";
        }

        /// <summary>
        /// Methode permettant d'actualiser la liste du personnel.
        /// </summary>
        public void actualiserPersonnel()
        {
            ListPrsnl.DataSource = null;
            ListPrsnl.DataSource = controleur.GetPersonnelList();
            ListPrsnl.DisplayMember = "NomPrenomTeletc";
        }

        /// <summary>
        /// Bouton ajouter un personnel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            vueAjout frm = new vueAjout();
            frm.Show();
            this.Hide();
        }

        /// <summary>
        /// Bouton modifier un personnel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            // Vérification si aucune personne n'a été choisie
            if (ListPrsnl.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un élément");
                return;
            }
            else
            {
                mdlPersonnel personnel = (mdlPersonnel)ListPrsnl.SelectedItem;
                vueModif frm = new vueModif(personnel.idPersonnel);
                frm.Show();
                this.Hide();
            }
        }

        /// <summary>
        /// Bouton supprimer un personnel.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            // Vérification si aucune personne n'a été choisie
            if (ListPrsnl.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un élément");
                return;
            }
            else
            {
                DialogResult result = MessageBox.Show(
                "Etes-vous sur de supprimer le personnel choisi ?",
                "Confirmer",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    mdlPersonnel personnel = (mdlPersonnel)ListPrsnl.SelectedItem;
                    controleur.DeletePersonnelList(personnel.idPersonnel);
                    actualiserPersonnel();
                }
                else { }
            }
        }

        /// <summary>
        /// Bouton pour gerer les absences.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button4_Click(object sender, EventArgs e)
        {
            // Vérification si aucune personne n'a été choisie
            if (ListPrsnl.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un élément");
                return;
            }
            else
            {
                mdlPersonnel personnel = (mdlPersonnel)ListPrsnl.SelectedItem;
                vueAbsence frm = new vueAbsence(personnel.idPersonnel);
                frm.Show();
                this.Hide();
            }
        }
    }
}
