using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cl_desk_admin.CapaVista.ViewCompartidas.AcercaDe
{
    public partial class frmAcercaDe : Form
    {
        public frmAcercaDe()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            CapaVista.ViewAdministradorGeneral.frmMenuAdminGeneral especialidades = new ViewAdministradorGeneral.frmMenuAdminGeneral();
            this.Hide();
            especialidades.ShowDialog();
            this.Close();
        }
    }
}
