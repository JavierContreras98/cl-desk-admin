using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cl_desk_admin.CapaVista.ViewAdministradorNivelUno
{
    public partial class frmMenuAdminNivelUno : Form
    {
        public frmMenuAdminNivelUno()
        {
            InitializeComponent();
        }

        private void btnAdministrarEspecialidades_Click(object sender, EventArgs e)
        {
            ViewCompartidas.AdminEspecialidades.AdministrarEspecialidades adminEspecialidades = new ViewCompartidas.AdminEspecialidades.AdministrarEspecialidades();

            this.Hide();
            adminEspecialidades.ShowDialog();
            this.Close();
        }
    }
}
