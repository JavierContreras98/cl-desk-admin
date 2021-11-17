using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cl_desk_admin.CapaModels;

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminHorarioCitas
{
    public partial class AdministrarHorarioCitas : Form
    {
        public AdministrarHorarioCitas()
        {
            InitializeComponent();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            AgregarHorarioCita agregarhorariocita= new AgregarHorarioCita();
            this.Hide();
            agregarhorariocita.Show();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNumero.Text))
            {
                if (rbModificar.Enabled == true)
                {
                    MessageBox.Show("Para modificar un tipo de documento debe ingresar el numero de ID a modificar");
                }
            }
            else
            {
                ModificarHorarioCita modificarhorariocita = new ModificarHorarioCita();
                modificarhorariocita.Id = Convert.ToInt32(txtNumero.Text);
                modificarhorariocita.Show();
                this.Hide();
            }
        }
    }
}
