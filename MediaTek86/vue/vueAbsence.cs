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
        public vueAbsence(int selectedpersonnel)
        {
            InitializeComponent();
            ListAbs.DataSource = dalAbsenceList.GetAbsenceList(selectedpersonnel);
            ListAbs.DisplayMember = "DateDebutDateFinMotif";
        }
    }
}
