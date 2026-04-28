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
using MediaTek86.modele;

namespace MediaTek86.vue
{
    public partial class vueAbsence : Form
    {
        private int selectedpersonnel;
        public vueAbsence(int selectedpersonnel)
        {
            InitializeComponent();
            this.selectedpersonnel = selectedpersonnel;
            ListAbs.DataSource = dalAbsenceList.GetAbsenceList(selectedpersonnel);
            ListAbs.DisplayMember = "DateDebutDateFinMotif";
        }

        public void actualiserAbsence()
        {
            ListAbs.DataSource = null;
            ListAbs.DataSource = dalAbsenceList.GetAbsenceList(selectedpersonnel);
            ListAbs.DisplayMember = "DateDebutDateFinMotif";
        }

        private void btnFermer_Click(object sender, EventArgs e)
        {
            vuePersonnel frm = new vuePersonnel();
            frm.Show();
            this.Hide();
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            vueAjoutAbs frm = new vueAjoutAbs(selectedpersonnel);
            frm.Show();
            this.Hide();
        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            if (ListAbs.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un élément");
                return;
            }
            else
            {
                mdlAbsence absence = (mdlAbsence)ListAbs.SelectedItem;
                vueModifAbs frm = new vueModifAbs(selectedpersonnel, absence.datedebut, absence.datefin, absence.idMotif);
                frm.Show();
                this.Hide();
            }
        }

        private void btnSupp_Click(object sender, EventArgs e)
        {
            if (ListAbs.SelectedItem == null)
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
                    mdlAbsence absence = (mdlAbsence)ListAbs.SelectedItem;
                    dalAbsenceList.DeleteAbsenceList(selectedpersonnel, absence.datedebut, absence.datefin, absence.idMotif);
                    actualiserAbsence();
                }
                else { }
            }
        }
    }
}
