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
    public partial class vuePersonnel : Form
    {
        public vuePersonnel()
        {
            InitializeComponent();
            ListPrsnl.DataSource = dalPersonnelList.GetPersonnelList();
            ListPrsnl.DisplayMember = "NomPrenomTeletc";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vueAjout frm = new vueAjout();
            frm.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
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
    }
}
