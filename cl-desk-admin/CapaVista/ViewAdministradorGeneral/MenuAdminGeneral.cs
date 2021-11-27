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

        private void btnAdministrarProfesion_Click(object sender, EventArgs e)
        {
            ViewCompartidas.AdminProfesion.AdministrarProfesion adminProfesiones = new ViewCompartidas.AdminProfesion.AdministrarProfesion();

            this.Hide();
            adminProfesiones.ShowDialog();
            this.Close();
        }

        private void btnAdministrarEmpleado_Click(object sender, EventArgs e)
        {
            ViewCompartidas.AdminEmpleados.frmAdministrarEmpleados adminEmpleados = new ViewCompartidas.AdminEmpleados.frmAdministrarEmpleados();

            this.Hide();
            adminEmpleados.ShowDialog();
            this.Close();
        }

        private void btnAdministrarPais_Click(object sender, EventArgs e)
        {
            ViewCompartidas.AdminPais.frmAdministrarPais adminPais = new ViewCompartidas.AdminPais.frmAdministrarPais();

            this.Hide();
            adminPais.ShowDialog();
            this.Close();
        }

        private void btnAdministrarDepartamentos_Click(object sender, EventArgs e)
        {
            ViewCompartidas.AdminDepartamentos.frmAdministrarDepartamentos adminDepartamentos = new ViewCompartidas.AdminDepartamentos.frmAdministrarDepartamentos();

            this.Hide();
            adminDepartamentos.ShowDialog();
            this.Close();
        }

        private void btnAdministrarMunicipio_Click(object sender, EventArgs e)
        {
            ViewCompartidas.AdminMunicipios.frmAdministrarMunicipios adminMunicipios = new ViewCompartidas.AdminMunicipios.frmAdministrarMunicipios();

            this.Hide();
            adminMunicipios.ShowDialog();
            this.Close();
        }

        private void btnAdministrarTipoDoc_Click(object sender, EventArgs e)
        {
            ViewCompartidas.AdminTipoDocumento.AdministrarTipoDocumento adminTipoDoc = new ViewCompartidas.AdminTipoDocumento.AdministrarTipoDocumento();

            this.Hide();
            adminTipoDoc.ShowDialog();
            this.Close();
        }

        private void btnAdministrarTipoSangre_Click(object sender, EventArgs e)
        {
            ViewCompartidas.AdminTipoSangre.frmAdministrarTipoSangre administrarTipoSangre = new ViewCompartidas.AdminTipoSangre.frmAdministrarTipoSangre();

            this.Hide();
            administrarTipoSangre.ShowDialog();
            this.Close();
        }

        private void btnAdministrarHorarioCita_Click(object sender, EventArgs e)
        {
            ViewCompartidas.AdminHorarioCitas.AdministrarHorarioCitas adminHorario = new ViewCompartidas.AdminHorarioCitas.AdministrarHorarioCitas();

            this.Hide();
            adminHorario.ShowDialog();
            this.Close();
        }
    }
}
