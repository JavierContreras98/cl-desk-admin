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

        int cbxTipo;

        public int CbxTipo { get => cbxTipo; set => cbxTipo = value; }

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
                    if (cbxTipoUsuario.SelectedIndex == 0)
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT NOM_USUARIO, PASS FROM USUARIO WHERE NOM_USUARIO='" + txtUsuario.Text + "' AND PASS='" + txtPassword.Text + "' AND ID_TIPO = 1", conexion))
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
                        CbxTipo = 0;
                    }
                    else if(cbxTipoUsuario.SelectedIndex == 1)
                    {
                        using (SqlCommand cmd = new SqlCommand("SELECT NOM_USUARIO, PASS FROM USUARIO WHERE NOM_USUARIO='" + txtUsuario.Text + "' AND PASS='" + txtPassword.Text + "' AND ID_TIPO = 2", conexion))
                        {
                            SqlDataReader dr = cmd.ExecuteReader();
                            if (dr.Read())
                            {

                                frmMenuAdminNivelUno menuPrincipal = new frmMenuAdminNivelUno();

                                this.Hide();
                                menuPrincipal.ShowDialog();
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("Datos incorrectos.");
                            }
                        }
                        CbxTipo = 1;
                    }
                    else
                    {
                        lblMensaje.Text = "SELECCIONE LA OPCION DEL TIPO DE USUARIO A INICIAR SESION";
                    }
                    //label1.Text = CbxTipo;

                    
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
