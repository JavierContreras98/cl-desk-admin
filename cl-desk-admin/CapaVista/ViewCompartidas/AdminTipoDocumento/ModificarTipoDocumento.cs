using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cl_desk_admin.CapaVista.ViewCompartidas.AdminTipoDocumento
{
    public partial class ModificarTipoDocumento : Form
    {
        string id;

        public string Id { get => id; set => id = value; }

        public ModificarTipoDocumento()
        {
            InitializeComponent();
        }

        private void ModificarTipoDocumento_Load(object sender, EventArgs e)
        {
            AdministrarTipoDocumento tipodocumento = new AdministrarTipoDocumento();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
