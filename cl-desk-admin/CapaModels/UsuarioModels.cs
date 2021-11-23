using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cl_desk_admin.CapaModels
{
    class UsuarioModels
    {
        int id, id_Tipo;
        string nom_Usuario, pass;

        public int Id { get => id; set => id = value; }
        public string Nom_Usuario { get => nom_Usuario; set => nom_Usuario = value; }
        public string Pass { get => pass; set => pass = value; }
        public int Id_Tipo { get => id_Tipo; set => id_Tipo = value; }
    }
}
