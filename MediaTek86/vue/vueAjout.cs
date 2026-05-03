using System;
using System.Collections;
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
using MediaTek86.vue;


namespace MediaTek86.vue
{
    public partial class vueAjout : Form
    {
        private ctrlPersonnel controleur = new ctrlPersonnel();
        private ctrlService ctrl = new ctrlService();
        /// <summary>
        /// Vue permettant de visualiser le panel Ajout d'un personnel.
        /// </summary>
        public vueAjout()
        {
            InitializeComponent();
            cmbboxService.DataSource = ctrl.GetService();
            cmbboxService.DisplayMember = "nomS";
            cmbboxService.ValueMember = "idService";
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Etes-vous sur d'annuler l'ajout ?",
                "Confirmer",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Hide();
                vuePersonnel frm = new vuePersonnel();
                frm.Show();
            }
            else{}
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            string nom = txtboxNom.Text;
            string prenom = txtboxPrenom.Text;
            string tel = txtboxTel.Text;
            string mail = txtboxMail.Text;
            int service = (int)cmbboxService.SelectedValue;
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || string.IsNullOrWhiteSpace(tel) || string.IsNullOrWhiteSpace(mail) || cmbboxService.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }
            else
            {
                controleur.SetPersonnelList(nom, prenom, tel, mail, service);
                this.Hide();
                vuePersonnel frm = new vuePersonnel();
                frm.Show();
            }
        }
    }
}
