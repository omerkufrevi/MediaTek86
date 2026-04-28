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
    }
}
