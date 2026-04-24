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
    public partial class vuePersonnel : Form
    {
        public vuePersonnel()
        {
            InitializeComponent();
            ListPrsnl.DataSource = dalPersonnelList.GetPersonnelList();
            ListPrsnl.ReadOnly = true;
            ListPrsnl.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ListPrsnl.Columns["idPersonnel"].Visible = false;
            ListPrsnl.Columns["idService"].Visible = false;
            ListPrsnl.Columns["nom"].HeaderText = "Nom";
            ListPrsnl.Columns["prenom"].HeaderText = "Prénom";
            ListPrsnl.Columns["tel"].HeaderText = "Téléphone";
            ListPrsnl.Columns["mail"].HeaderText = "Email";
        }

    }
}
