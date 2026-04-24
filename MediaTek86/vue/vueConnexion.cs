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
using Mysqlx;

namespace MediaTek86.vue
{
    public partial class vueConnexion : Form
    {
        public vueConnexion()
        {
            InitializeComponent();
        }

        private void vueConnexion_Load(object sender, EventArgs e)
        {

        }

        private void btnConnexion_Click(object sender, EventArgs e)
        {
            string loginText = txtboxLogin.Text;
            string pwdText = txtboxPwd.Text;
            if (loginText == "" || pwdText == "")
            {
                MessageBox.Show("Veuillez remplir tous les champs");
                return;
            }
            else
            {
                bool resultat = dalResponsableAcces.controleConnexion(loginText, pwdText);
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
