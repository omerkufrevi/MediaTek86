using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MediaTek86.dal;

namespace MediaTek86.vue
{
    public partial class vueModifAbs : Form
    {
        private int selectedpersonnel;
        private DateTime dateDebutAvant;
        private DateTime dateFinAvant;
        private int motifAvant;
        public vueModifAbs(int selectedpersonnel, DateTime datedebut, DateTime datefin, int motif)
        {
            InitializeComponent();
            this.selectedpersonnel = selectedpersonnel;
            dtpDebut.Value = datedebut;
            dtpFin.Value = datefin;
            cmbboxMotif.SelectedIndex = motif;

            this.dateDebutAvant = datedebut;
            this.dateFinAvant = datefin;
            this.motifAvant = motif;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Etes-vous sur d'annuler la modification ?",
                "Confirmer",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                vueAbsence frm = new vueAbsence(selectedpersonnel);
                frm.Show();
            }
            else { }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            DateTime debut = dtpDebut.Value;
            DateTime fin = dtpFin.Value;
            int motif = cmbboxMotif.SelectedIndex;
            if (debut > fin || motif == -1)
            {
                MessageBox.Show("Veuillez remplir tous les champs ou verifier les dates");
                return;
            }
            else
            {
                bool result = dalAbsenceList.ExistAbsenceModif(selectedpersonnel, debut, fin, dateDebutAvant, dateFinAvant);
                if (result == true)
                {
                    MessageBox.Show("Veuillez verifier les dates");
                    return;
                }
                else
                {
                    dalAbsenceList.ModifierAbsence(selectedpersonnel, debut, fin, motif, dateDebutAvant, dateFinAvant, motifAvant);
                    this.Hide();
                    vueAbsence frm = new vueAbsence(selectedpersonnel);
                    frm.Show();
                }
            }
        }
    }
}
