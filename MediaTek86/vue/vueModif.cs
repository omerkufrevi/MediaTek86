using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Design;
using MediaTek86.dal;
using MediaTek86.modele;

namespace MediaTek86.vue
{
    public partial class vueModif : Form
    {
        private int selectedIndex;
        public vueModif(int selectedindex)
        {
            InitializeComponent();
            this.selectedIndex = selectedindex;
            mdlPersonnel personnelInfo = dalPersonnelList.GetPersonnelInfo(selectedindex);
            txtboxNom.Text = personnelInfo.nom;
            txtboxPrenom.Text = personnelInfo.prenom;
            txtboxTel.Text = personnelInfo.tel;
            txtboxMail.Text = personnelInfo.mail;
            cmbboxService.SelectedIndex = personnelInfo.idService;
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
                vuePersonnel frm = new vuePersonnel();
                frm.Show();
            }
            else { }
        }

        private void btnConfirmer_Click(object sender, EventArgs e)
        {
            string nom = txtboxNom.Text;
            string prenom = txtboxPrenom.Text;
            string tel = txtboxTel.Text;
            string mail = txtboxMail.Text;
            int service = cmbboxService.SelectedIndex;
            if (string.IsNullOrWhiteSpace(nom) || string.IsNullOrWhiteSpace(prenom) || string.IsNullOrWhiteSpace(tel) || string.IsNullOrWhiteSpace(mail) || cmbboxService.SelectedIndex == -1)
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }
            else
            {
                dalPersonnelList.ModifierPersonnelList(nom, prenom, tel, mail, service, this.selectedIndex);
                this.Hide();
                vuePersonnel frm = new vuePersonnel();
                frm.Show();
            }
        }
    }

}
