using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using cl_desk_admin.CapaVista.ViewAdministradorGeneral;
using cl_desk_admin.CapaVista.ViewAdministradorNivelUno;
using cl_desk_admin.CapaVista.ViewCompartidas;

namespace cl_desk_admin
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            logins();
        }

        public void logins()
        {
            try
            {
                string cnn = ConfigurationManager.ConnectionStrings["cnn"].ConnectionString;
                using (SqlConnection conexion = new SqlConnection(cnn))
                {
                    conexion.Open();
                        using (SqlCommand cmd = new SqlCommand("SELECT NOM_USUARIO, PASS FROM USUARIO WHERE NOM_USUARIO='" + txtUsuario.Text + "' AND PASS='" + txtPassword.Text + "'", conexion))
                        {
                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {

                                frmMenuAdminGeneral menuPrincipal = new frmMenuAdminGeneral();

                                this.Hide();
                                menuPrincipal.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Datos incorrectos.");
                            }
                        }
                    }
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
    }
}
