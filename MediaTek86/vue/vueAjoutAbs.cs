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
    /// Form ajout absence.
    /// </summary>
    public partial class vueAjoutAbs : Form
    {
        private int selectedpersonnel;
        private ctrlAbsence controleur = new ctrlAbsence();
        private ctrlMotif ctrl = new ctrlMotif();

        /// <summary>
        /// Vue permettant de visualiser le panel Ajout d'absence.
        /// </summary>
        /// <param name="selectedpersonnel"></param>
        public vueAjoutAbs(int selectedpersonnel)
        {
            InitializeComponent();
            this.selectedpersonnel = selectedpersonnel;
            cmbboxMotif.DataSource = ctrl.GetMotif();
            cmbboxMotif.DisplayMember = "libelle";
            cmbboxMotif.ValueMember = "idMotif";
        }

        /// <summary>
        /// Bouton annuler l'ajout d'une absence.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Etes-vous sur d'annuler ?",
                "Confirmer",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                vueAbsence frm = new vueAbsence(selectedpersonnel);
                frm.Show();
                this.Close();
            }
            else { }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            DateTime datedebut = dtpDebut.Value;
            DateTime datefin = dtpFin.Value;
            int motif = (int)cmbboxMotif.SelectedValue;
            // Vérification si aucun champ n'a été remplie.
            if (datedebut > datefin || motif == -1)
            {
                MessageBox.Show("Veuillez remplir tous les champs ou verifier les dates");
                return;
            }
            else
            {
                bool result = controleur.ExistAbsence(selectedpersonnel, datedebut, datefin);
                if (result == true)
                {
                    MessageBox.Show("Veuillez verifier les dates");
                    return;
                }
                else
                {
                    controleur.SetAbsence(selectedpersonnel, datedebut, datefin, motif);
                    this.Hide();
                    vueAbsence frm = new vueAbsence(selectedpersonnel);
                    frm.Show();
                }
            }
        }
    }
}
