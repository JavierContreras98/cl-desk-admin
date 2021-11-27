using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cl_desk_admin.CapaVista.ViewAdministradorGeneral;
using cl_desk_admin.CapaVista.ViewCompartidas;

namespace cl_desk_admin.CapaVista.ViewAdministradorGeneral
{
    public partial class frmMenuAdminGeneral : Form
    {
        public frmMenuAdminGeneral()
        {
            InitializeComponent();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form1 Salir = new Form1();

            this.Hide();
            Salir.ShowDialog();
            this.Close();
        }

        private void btnAdministrarTipoUsuario_Click(object sender, EventArgs e)
        {
            AdminTipoUsuario.frmAdministrarTipoUsuario adminTipoUsuario = new AdminTipoUsuario.frmAdministrarTipoUsuario();

            this.Hide();
            adminTipoUsuario.ShowDialog();
            this.Close();
        }

        private void btnAdministrarUsuario_Click(object sender, EventArgs e)
        {
            AdminUsuario.frmAdministrarUsuario adminUsuario = new AdminUsuario.frmAdministrarUsuario();

            this.Hide();
            adminUsuario.ShowDialog();
            this.Close();
        }

        private void btnAdministrarPaciente_Click(object sender, EventArgs e)
        {
            ViewCompartidas.AdminPacientes.frmAdministrarPacientes adminPacientes = new ViewCompartidas.AdminPacientes.frmAdministrarPacientes();

            this.Hide();
            adminPacientes.ShowDialog();
            this.Close();
        }

        private void btnAdministrarCitas_Click(object sender, EventArgs e)
        {
            ViewCompartidas.AdminCitas.frmAdministrarCitas adminCitass = new ViewCompartidas.AdminCitas.frmAdministrarCitas();

            this.Hide();
            adminCitass.ShowDialog();
            this.Close();
        }

        private void btnAdministrarInforMedico_Click(object sender, EventArgs e)
        {
            ViewCompartidas.AdminInforMedicos.frmAdminInforMedicos adminMedicos = new ViewCompartidas.AdminInforMedicos.frmAdminInforMedicos();

            this.Hide();
            adminMedicos.ShowDialog();
            this.Close();
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
