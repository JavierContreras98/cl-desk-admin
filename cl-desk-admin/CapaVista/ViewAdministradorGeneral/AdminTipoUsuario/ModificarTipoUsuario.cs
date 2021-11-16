using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using cl_desk_admin.CapaModelo;

namespace cl_desk_admin.CapaVista.ViewAdministradorGeneral.AdminTipoUsuario
{
    public partial class frmModificarTipoUsuario : Form
    {
        Tipo_UsuarioModels resultado;
        int id;
        string nombre, descripcion;

        public frmModificarTipoUsuario()
        {
            InitializeComponent();
        }

        public int Id { get => id; set => id = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Descripcion { get => descripcion; set => descripcion = value; }

        private void frmModificarTipoUsuario_Load(object sender, EventArgs e)
        {
            //lblIdUsuario.Text = Convert.ToString(Id1);
            lblId.Text = Convert.ToString(Id);
        }
    }
}
